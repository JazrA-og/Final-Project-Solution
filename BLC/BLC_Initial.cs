using Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Timers;
using System.Xml.Linq;

namespace BLC
{
    #region BLC
    public partial class BLC : IDisposable
    {
        #region Enumeration
        public enum Enum_Language
        {
            English = 0,
            French = 1,
            Arabic = 2
        }
        public enum Enum_BR_Codes
        {
            BR_9999,  // Invalid Credentials
            BR_0000,  // Uniqueness Violation                      
            BR_0001,  // Password should be at least 4 characters
            BR_0002,  // Wrong Username and/or Password
            BR_0003,  // Username already taken
            BR_0004,  //User not found 
            BR_0005,  //Email already taken
            BR_0006,  //User is not active
        }
        public enum Enum_EditMode
        {
            Add,
            Update
        }
        public enum Enum_Environment
        {
            BHS = 0,
            MS = 1
        }
        public enum Enum_GradeMode
        {
            Over_One_Hundred = 0,
            Assignment = 1
        }
        #endregion
        #region Members
        private string _ConnectionString = string.Empty;
        DALC.IDALC _AppContext = null;
        #endregion
        #region Properties
        public Tools.Tools oTools { get; set; }
        public string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            set
            {
                _ConnectionString = value;
            }
        }
        public long? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public Enum_Language Language { get; set; }
        public string Messages_FilePath { get; set; }
        public List<Message> Messages { get; set; }
        public Enum_Environment Environment { get; set; }

        #endregion
        #region Constructor
        public BLC()
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.
            #endregion
        }
        public BLC(BLCInitializer i_BLCInitializer)
        {
            #region Declaration And Initialization Section.    
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Body Section.
            // ---------------------
            ConnectionString = i_BLCInitializer.ConnectionString;
            UserID = i_BLCInitializer.UserID;
            OwnerID = i_BLCInitializer.OwnerID;
            Language = i_BLCInitializer.Language;
            Messages_FilePath = i_BLCInitializer.Messages_FilePath;
            _AppContext = new DALC.MSSQL_DALC(_ConnectionString);
            this.oTools = new Tools.Tools();
            // ---------------------

            // ---------------------
            LoadMessages();
            SubscribeToEvents();
            //Initialize_Audit_Mechanism();
            // ---------------------


            #endregion
        }
        #endregion
        #region Subscribe To Events
        public void SubscribeToEvents()
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.

            Initialize_Cascade_Mechanism();
            //Register_Uploaded_Events_Handlers();
            this.OnPreEvent_Edit_Admin += new PreEvent_Handler_Edit_Admin(BLC_OnPreEvent_Edit_Admin);
            this.OnPreEvent_Delete_Admin += new PreEvent_Handler_Delete_Admin(BLC_OnPreEvent_Delete_Admin);
            this.OnPreEvent_Edit_Client += new PreEvent_Handler_Edit_Client(BLC_OnPreEvent_Edit_Client);
            this.OnPreEvent_Edit_Client += new PreEvent_Handler_Edit_Client(BLC_OnPreEvent_Edit_Client_02);
            this.OnPreEvent_Edit_Client += new PreEvent_Handler_Edit_Client(BLC_OnPreEvent_Edit_Client_03);
            this.OnPreEvent_Edit_Business += new PreEvent_Handler_Edit_Business(BLC_OnPreEvent_Edit_Business);
            this.OnPreEvent_Edit_Business += new PreEvent_Handler_Edit_Business(BLC_OnPreEvent_Edit_Business_02);
            this.OnPreEvent_Edit_Business += new PreEvent_Handler_Edit_Business(BLC_OnPreEvent_Edit_Business_03);
            //this.OnPreEvent_Edit_Business += new PreEvent_Handler_Edit_Business(BLC_OnPreEvent_Edit_Business_04);
            this.OnPreEvent_Edit_Service_prod += new PreEvent_Handler_Edit_Service_prod(BLC_OnPreEvent_Edit_Service_prod);
            this.OnPreEvent_Edit_Feedback += new PreEvent_Handler_Edit_Feedback(BLC_OnPreEvent_Edit_Feedback);
            this.OnPreEvent_Edit_Booking += new PreEvent_Handler_Edit_Booking(BLC_OnPreEvent_Edit_Booking);
            this.OnPreEvent_Edit_Boost_listing += new PreEvent_Handler_Edit_Boost_listing(BLC_OnPreEvent_Edit_Boost_listing);
            this.OnPreEvent_Edit_Boost_listing += new PreEvent_Handler_Edit_Boost_listing(BLC_OnPreEvent_Edit_Boost_listing_02);
            //this.OnPreEvent_Delete_Boost_listing += new PreEvent_Handler_Delete_Boost_listing(BLC_OnPreEvent_Delete_Boost_listing);
            this.OnPreEvent_Edit_Boost_pricing += new PreEvent_Handler_Edit_Boost_pricing(BLC_OnPreEvent_Edit_Boost_pricing);
            this.OnPreEvent_Edit_Boost_pricing += new PreEvent_Handler_Edit_Boost_pricing(BLC_OnPreEvent_Edit_Boost_pricing_02);
            //this.OnPreEvent_Edit_Work_area += new PreEvent_Handler_Edit_Work_area(BLC_OnPreEvent_Edit_Work_area);
            this.OnPreEvent_Edit_Work_list += new PreEvent_Handler_Edit_Work_list(BLC_OnPreEvent_Edit_Work_list);

            #endregion
        }
        #endregion
        #region IDisposable Members
        public void Dispose()
        {
            #region Body Section.
            #endregion
        }
        #endregion
        #region LoadMessages
        public void LoadMessages()
        {
            #region Declaration And Initialization Section.
            XElement oRoot = null;
            XElement oLanguage = null;
            #endregion
            #region Body Section.
            this.Messages = new List<Message>();

            if (!string.IsNullOrEmpty(this.Messages_FilePath))
            {
                oRoot = XElement.Load(this.Messages_FilePath);
                if (oRoot != null)
                {
                    switch (Language)
                    {
                        case Enum_Language.English:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                        case Enum_Language.Arabic:
                            oLanguage = oRoot.Element("ARABIC");
                            break;
                        default:
                            oLanguage = oRoot.Element("ENGLISH");
                            break;
                    }

                    foreach (var oItem in oLanguage.Elements("MESSAGE"))
                    {
                        this.Messages.Add(new Message() { Code = oItem.Attribute("CODE").Value, Content = oItem.Attribute("CONTENT").Value });
                    }
                }
            }
            #endregion
        }
        #endregion
        #region GetMessageContent
        public string GetMessageContent(Enum_BR_Codes i_BR_Code)
        {
            #region Declaration And Initialization Section.
            string str_ReturnValue = string.Empty;
            #endregion
            #region Body Section.
            var oResult = this.Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region GetMessageContent
        public string GetMessageContent(Enum_BR_Codes i_BR_Code, Dictionary<string, string> i_PlaceHolders)
        {
            #region Declaration And Initialization Section.
            string str_ReturnValue = string.Empty;
            #endregion
            #region Body Section.
            var oResult = this.Messages.First(x => x.Code == i_BR_Code.ToString());
            str_ReturnValue = oResult.Content;

            foreach (var oItem in i_PlaceHolders)
            {
                str_ReturnValue = str_ReturnValue.Replace(oItem.Key, oItem.Value);
            }
            #endregion
            #region Return Section.
            return str_ReturnValue;
            #endregion
        }
        #endregion
        #region Events Implementation


        #region Admin

        #region BLC_OnPreEvent_Edit_Admin
        void BLC_OnPreEvent_Edit_Admin(Admin i_Admin, BLC.Enum_EditMode i_Enum_EditMode)
        {
            User oUser = new User();
            MiniCryptoHelper oCrypto = new MiniCryptoHelper();
            //i_Admin.PASSWORD = oCrypto.Encrypt(i_Admin.PASSWORD);


            switch (i_Enum_EditMode)
            {
                case Enum_EditMode.Add:
                    List<dynamic> oList = _AppContext.UP_GET_USER_BY_USERNAME(i_Admin.USERNAME);
                    List<dynamic> oList2 = _AppContext.UP_GET_USER_BY_EMAIL(i_Admin.USERNAME);
                    if (oList != null && oList.Count != 0)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0003));
                    }
                    else if (oList2 != null && oList2.Count != 0)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0005));
                    }
                    else
                    {
                        oUser.USER_ID = -1;
                        oUser.OWNER_ID = 1;
                        oUser.USERNAME = i_Admin.USERNAME;
                        i_Admin.PASSWORD = oCrypto.Encrypt(i_Admin.PASSWORD);
                        oUser.PASSWORD = i_Admin.PASSWORD;
                        oUser.USER_TYPE_CODE = "004";
                        oUser.IS_ACTIVE = false;
                        Edit_User(oUser);
                    }
                    break;

                case Enum_EditMode.Update:
                    List<dynamic> oAdmin = _AppContext.UP_GET_ADMIN_BY_ADMIN_ID(i_Admin.ADMIN_ID);
                    List<dynamic> oList1 = _AppContext.UP_GET_USER_BY_USERNAME(oAdmin[0].USERNAME);
                    if (oList1 == null && oList1.Count == 0)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0004));
                    }
                    else
                    {
                        oUser.USER_ID = oList1[0].USER_ID;
                        oUser.OWNER_ID = 1;
                        oUser.USERNAME = i_Admin.USERNAME;
                        if (oList1[0].PASSWORD != i_Admin.PASSWORD)
                        {
                            i_Admin.PASSWORD = oCrypto.Encrypt(i_Admin.PASSWORD);
                            oUser.PASSWORD = i_Admin.PASSWORD;
                        }
                        else
                        {
                            oUser.PASSWORD = i_Admin.PASSWORD;
                        }
                        oUser.USER_TYPE_CODE = "004";
                        oUser.IS_ACTIVE = i_Admin.IS_ACTIVE;
                        Edit_User(oUser);
                        break;
                    }
            }
        }

        #endregion
        #region BLC_OnPreEvent_Delete_Admin
        void BLC_OnPreEvent_Delete_Admin(Params_Delete_Admin i_Params_Delete_Admin)
        {

        }
        #endregion

        #endregion
        #region Client

        #region BLC_OnPreEvent_Edit_Client
        void BLC_OnPreEvent_Edit_Client(Client i_Client, BLC.Enum_EditMode i_Enum_EditMode)
        {
            User oUser = new User();
            MiniCryptoHelper oCrypto = new MiniCryptoHelper();
            //i_Client.PASSWORD = oCrypto.Encrypt(i_Client.PASSWORD);


            switch (i_Enum_EditMode)
            {
                case Enum_EditMode.Add:

                    List<dynamic> oList = _AppContext.UP_GET_USER_BY_USERNAME(i_Client.USERNAME);
                    //List<dynamic> oList2 = _AppContext.UP_GET_USER_BY_EMAIL(i_Client.EMAIL);
                    if (oList != null && oList.Count != 0)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0003));
                    }
                    //else if (oList2 != null && oList2.Count != 0)
                    //{
                    //    throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0005));
                    //}
                    else
                    {
                        oUser.USER_ID = -1;
                        oUser.OWNER_ID = 1;
                        oUser.USERNAME = i_Client.USERNAME;
                        i_Client.PASSWORD = oCrypto.Encrypt(i_Client.PASSWORD);
                        oUser.PASSWORD = i_Client.PASSWORD;
                        oUser.USER_TYPE_CODE = "002";
                        oUser.IS_ACTIVE = false;
                        Edit_User(oUser);
                    }
                    break;

                case Enum_EditMode.Update:
                    List<dynamic> oClient = _AppContext.UP_GET_CLIENT_BY_CLIENT_ID(i_Client.CLIENT_ID);
                    List<dynamic> oList1 = _AppContext.UP_GET_USER_BY_USERNAME(oClient[0].USERNAME);
                    if (oList1 == null && oList1.Count == 0)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0004));
                    }
                    else
                    {
                        oUser.USER_ID = oList1[0].USER_ID;
                        oUser.OWNER_ID = 1;
                        oUser.USERNAME = i_Client.USERNAME;
                        if (oList1[0].PASSWORD != i_Client.PASSWORD)
                        {
                            i_Client.PASSWORD = oCrypto.Encrypt(i_Client.PASSWORD);
                            oUser.PASSWORD = i_Client.PASSWORD;
                        }
                        else
                        {
                            oUser.PASSWORD = i_Client.PASSWORD;
                        }
                        oUser.USER_TYPE_CODE = "002";
                        oUser.IS_ACTIVE = i_Client.IS_ACTIVE;
                        Edit_User(oUser);
                        break;
                    }
            }
        }

        #endregion
        #region BLC_OnPreEvent_Edit_Client_02
        void BLC_OnPreEvent_Edit_Client_02(Client i_Client, BLC.Enum_EditMode i_Enum_EditMode)
        {
            if (i_Client.IS_VERIFIED == false && i_Client.IS_ACTIVE == true)
            {
                throw new BLCException("Cannot activate account unless it is verified");
            }


        }

        #endregion
        #region BLC_OnPreEvent_Edit_Client_03
        void BLC_OnPreEvent_Edit_Client_03(Client i_Client, BLC.Enum_EditMode i_Enum_EditMode)
        {
            string oNumberList = i_Client.PHONE_NUMBER.ToString();
            int oNumber = takeNDigits(i_Client.PHONE_NUMBER.Value, 2);
            if (oNumberList.Length != 8)
            {
                throw new BLCException("Number must be composed of 8 digits");
            }
            else
            {
                switch (oNumber)
                {
                    case 01:
                        break;
                    case 04:
                        break;
                    case 05:
                        break;
                    case 06:
                        break;
                    case 07:
                        break;
                    case 08:
                        break;
                    case 09:
                        break;
                    case 03:
                        break;
                    case 70:
                        break;
                    case 71:
                        break;
                    case 76:
                        break;
                    case 78:
                        break;
                    case 79:
                        break;
                    case 81:
                        break;
                    default:
                        throw new BLCException("Please provide a valid phone number");

                }
            }

        }
        #endregion


        #endregion
        #region Business

        #region BLC_OnPreEvent_Edit_Business
        void BLC_OnPreEvent_Edit_Business(Business i_Business, BLC.Enum_EditMode i_Enum_EditMode)
        {
            User oUser = new User();
            MiniCryptoHelper oCrypto = new MiniCryptoHelper();
            //i_Businessman.PASSWORD = oCrypto.Encrypt(i_Businessman.PASSWORD);


            switch (i_Enum_EditMode)
            {
                case Enum_EditMode.Add:

                    List<dynamic> oList = _AppContext.UP_GET_USER_BY_USERNAME(i_Business.USERNAME);
                    List<dynamic> oList2 = _AppContext.UP_GET_USER_BY_EMAIL(i_Business.EMAIL);
                    if (oList != null && oList.Count != 0)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0003));
                    }
                    else if (oList2 != null && oList2.Count != 0)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0005));

                    }
                    else
                    {
                        oUser.USER_ID = -1;
                        oUser.OWNER_ID = 1;
                        oUser.USERNAME = i_Business.USERNAME;
                        i_Business.PASSWORD = oCrypto.Encrypt(i_Business.PASSWORD);
                        oUser.PASSWORD = i_Business.PASSWORD;
                        oUser.USER_TYPE_CODE = "003";
                        oUser.IS_ACTIVE = false;
                        Edit_User(oUser);
                    }
                    break;

                case Enum_EditMode.Update:
                    List<dynamic> oBusiness = _AppContext.UP_GET_BUSINESS_BY_BUSINESS_ID(i_Business.BUSINESS_ID);
                    List<dynamic> oList1 = _AppContext.UP_GET_USER_BY_USERNAME(oBusiness[0].USERNAME);
                    if (oList1 == null && oList1.Count == 0)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0004));
                    }
                    else
                    {
                        oUser.USER_ID = oList1[0].USER_ID;
                        oUser.OWNER_ID = 1;
                        oUser.USERNAME = i_Business.USERNAME;
                        if (oList1[0].PASSWORD != i_Business.PASSWORD)
                        {
                            i_Business.PASSWORD = oCrypto.Encrypt(i_Business.PASSWORD);
                            oUser.PASSWORD = i_Business.PASSWORD;
                        }
                        else
                        {
                            oUser.PASSWORD = i_Business.PASSWORD;
                        }
                        oUser.USER_TYPE_CODE = "003";
                        oUser.IS_ACTIVE = i_Business.IS_ACTIVE;
                        Edit_User(oUser);
                        break;
                    }
            }
        }

        #endregion
        #region BLC_OnPreEvent_Edit_Business_02
        void BLC_OnPreEvent_Edit_Business_02(Business i_Business, BLC.Enum_EditMode i_Enum_EditMode)
        {
            User oUser = new User();
            MiniCryptoHelper oCrypto = new MiniCryptoHelper();
            //i_Businessman.PASSWORD = oCrypto.Encrypt(i_Businessman.PASSWORD);


            switch (i_Enum_EditMode)
            {
                case Enum_EditMode.Add:
                    break;

                case Enum_EditMode.Update:
                    List<dynamic> oList1 = _AppContext.UP_GET_USER_BY_USERNAME(i_Business.USERNAME);
                    if (oList1 == null && oList1.Count == 0)
                    {
                        throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0004));
                    }
                    else
                    {
                        if (i_Business.IS_VALIDATED == false && i_Business.IS_ACTIVE == true)
                        {
                            throw new BLCException("Cannot activate account unless it is validated");
                        }
                        break;
                    }
            }
        }

        #endregion
        #region BLC_OnPreEvent_Edit_Business_03
        void BLC_OnPreEvent_Edit_Business_03(Business i_Business, BLC.Enum_EditMode i_Enum_EditMode)
        {
            string oNumberList = i_Business.PHONE_NUMBER.ToString();
            int oNumber = takeNDigits(i_Business.PHONE_NUMBER.Value, 2);
            if (oNumberList.Length != 8)
            {
                throw new BLCException("Number must be composed of 8 digits");
            }
            else
            {
                switch (oNumber)
                {
                    case 01:
                        break;
                    case 04:
                        break;
                    case 05:
                        break;
                    case 06:
                        break;
                    case 07:
                        break;
                    case 08:
                        break;
                    case 09:
                        break;
                    case 03:
                        break;
                    case 70:
                        break;
                    case 71:
                        break;
                    case 76:
                        break;
                    case 78:
                        break;
                    case 79:
                        break;
                    case 81:
                        break;
                    default:
                        throw new BLCException("Please provide a valid phone number");

                }
            }

        }

        #endregion
        #region BLC_OnPreEvent_Edit_Business_04
        void BLC_OnPreEvent_Edit_Business_04(Business i_Business, BLC.Enum_EditMode i_Enum_EditMode)
        {
            Work_list oWork = new Work_list();
            List<dynamic> oWorkArea = new List<dynamic>();
            List<dynamic> oWorkList = new List<dynamic>();
            oWorkArea = _AppContext.UP_GET_WORK_AREA_BY_OWNER_ID(1);
            oWorkList = _AppContext.UP_GET_WORK_LIST_BY_BUSINESS_ID(13);

            switch (i_Enum_EditMode)
            {
                case Enum_EditMode.Add:
                    oWorkArea.ForEach((item) => {
                        oWork.BUSINESS_ID = i_Business.BUSINESS_ID;
                        oWork.OWNER_ID = 1;
                        oWork.WORK_AREA_ID = item.WORK_AREA_ID;
                        oWork.WORK_LIST_ID = -1;
                        oWork.IS_TRUE = false;
                        oWorkList.Add(oWork);
                    });
                    oWorkList.ForEach((element) =>
                    {
                        Edit_Work_list(element);
                    });
                    break;

                case Enum_EditMode.Update:
                    break;
            }
        }
        #endregion

        #endregion

        #region Service_Prod

        #region BLC_OnPreEvent_Edit_Service_prod

        void BLC_OnPreEvent_Edit_Service_prod(Service_prod i_Service_prod, BLC.Enum_EditMode i_Enum_EditMode)
        {
            if (i_Service_prod.PRICE < 0)
            {
                throw new BLCException("The Price cannot be a negative value!");
            }
        }

        #endregion

        #endregion
        #region Feedback

        #region BLC_OnPreEvent_Edit_Feedback

        void BLC_OnPreEvent_Edit_Feedback(Feedback i_Feedback, BLC.Enum_EditMode i_Enum_EditMode)
        {
            if (i_Feedback.RATING < 1)
            {
                throw new BLCException("The Rating value cannot be lower than 1!");
            }
            else if (i_Feedback.RATING > 5)
            {
                throw new BLCException("The Rating value cannot be higher than 5!");
            }
        }

        #endregion

        #endregion
        #region Booking

        #region BLC_OnPreEvent_Edit_Booking

        void BLC_OnPreEvent_Edit_Booking(Booking i_Booking, BLC.Enum_EditMode i_Enum_EditMode)
        {
            #region Declaration and Initialization
            List<dynamic> oBusiness = new List<dynamic>();
            List<dynamic> oService = new List<dynamic>();
            #endregion
            #region Body
            oBusiness = _AppContext.UP_GET_BUSINESS_BY_BUSINESS_ID(i_Booking.BUSINESS_ID);
            oService = _AppContext.UP_GET_SERVICE_PROD_BY_SERVICE_PROD_ID(i_Booking.SERVICE_PROD_ID);
            i_Booking.TOTAL_PRICE = oBusiness[0].MINIMUM_COST + oService[0].PRICE;
            #endregion
        }

        #endregion

        #endregion
        #region Boost_listing

        #region BLC_OnPreEvent_Edit_Boost_listing

        void BLC_OnPreEvent_Edit_Boost_listing(Boost_listing i_Boost_listing, BLC.Enum_EditMode i_Enum_EditMode)
        {
            switch (i_Enum_EditMode)
            {
                case Enum_EditMode.Add:
                    i_Boost_listing.IS_COMPLETED = false;
                    i_Boost_listing.IS_ACTIVE = false;
                    break;
                case Enum_EditMode.Update:
                    if (i_Boost_listing.IS_ACTIVE == false)
                    {
                        ChangeBoostStatus(i_Boost_listing.SERVICE_PROD_ID, false);
                        //i_Boost_listing.IS_ACTIVE = false;
                    }
                    else if (i_Boost_listing.IS_ACTIVE == true)
                    {
                        ChangeBoostStatus(i_Boost_listing.SERVICE_PROD_ID, true);
                        //i_Boost_listing.IS_ACTIVE = true;

                    }
                    break;
            }
        }

        #endregion
        #region BLC_OnPreEvent_Edit_Boost_listing_02
        void BLC_OnPreEvent_Edit_Boost_listing_02(Boost_listing i_Boost_listing, BLC.Enum_EditMode i_Enum_EditMode)
        {
            
            Params_Get_Boost_pricing_By_BOOST_PRICING_ID i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID = new Params_Get_Boost_pricing_By_BOOST_PRICING_ID();
            i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID.BOOST_PRICING_ID = i_Boost_listing.BOOST_PRICING_ID;
            Boost_pricing oBoost_pricing = Get_Boost_pricing_By_BOOST_PRICING_ID(i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID);
            double minutes = Convert.ToDouble(oBoost_pricing.MINUTE);

            //Console.WriteLine(DateTime.Now.ToString("Start:"+"HH:mm:ss"));

            if (i_Boost_listing.IS_ACTIVE == true && i_Boost_listing.IS_COMPLETED != true)
            {
                Timer timer = new System.Timers.Timer();
                timer.Interval = 60000 * minutes;
                //timer.Elapsed += OnTimedEvent;
                timer.Elapsed += (sender, e) => OnTimedEvent(sender, e, i_Boost_listing);
                timer.AutoReset = false;
                timer.Enabled = true;
                i_Boost_listing.IS_COMPLETED = true;
            }else if(i_Boost_listing.IS_COMPLETED == true)
            {
                throw new BLCException("Cannot edit a completed Boost Listing!");
            }
        }
        #endregion
        #region ChangeBoostStatus
        public void ChangeBoostStatus(int? serviceID, bool status)
        {
            Params_Get_Service_prod_By_SERVICE_PROD_ID i_Params_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
            i_Params_Get_Service_prod_By_SERVICE_PROD_ID.SERVICE_PROD_ID = serviceID;
          Service_prod oService =  Get_Service_prod_By_SERVICE_PROD_ID(i_Params_Get_Service_prod_By_SERVICE_PROD_ID);
            oService.IS_BOOSTED = status;
            Edit_Service_prod(oService);
        }
        #endregion
        #region OnTimedEvent
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e, Boost_listing i_Boost_listing)
        {
            ChangeBoostStatus(i_Boost_listing.SERVICE_PROD_ID, false);
            i_Boost_listing.IS_ACTIVE = false;
        }
        #endregion
        #region BLC_OnPreEvent_Delete_Boost_listing
        void BLC_OnPreEvent_Delete_Boost_listing(Params_Delete_Boost_listing i_Params_Delete_Boost_listing)
        {
            #region Init
            List<dynamic> oBoostListing = _AppContext.UP_GET_BOOST_LISTING_BY_BOOST_LISTING_ID(i_Params_Delete_Boost_listing.BOOST_LISTING_ID);
            List<dynamic> oService = _AppContext.UP_GET_SERVICE_PROD_BY_SERVICE_PROD_ID(oBoostListing[0].SERVICE_PROD_ID);
            List<dynamic> oBusiness = _AppContext.UP_GET_BUSINESS_BY_BUSINESS_ID(oService[0].BUSINESS_ID);
            List<dynamic> oUser = _AppContext.UP_GET_USER_BY_USERNAME(oBusiness[0].USERNAME);
            #endregion
            #region Body
            if(oUser[0].USER_TYPE_CODE == "003")
            {
                if (oBoostListing[0].IS_ACTIVE == true)
                {
                    throw new BLCException("Cannot delete an active boost listing!");
                }
                else if (oBoostListing[0].IS_COMPLETED == true)
                {
                    throw new BLCException("Cannot delete a completed boost listing!");
                }
            }else
            {

            }
            #endregion
        }
        #endregion

        #endregion
        #region Boost_pricing

        #region BLC_OnPreEvent_Edit_Boost_pricing
        void BLC_OnPreEvent_Edit_Boost_pricing(Boost_pricing i_Boost_pricing, BLC.Enum_EditMode i_Enum_EditMode)
        {
            if (i_Boost_pricing.MINUTE <= 0)
            {
                throw new BLCException("Minute field cannot be negative or null!");
            }
            else if (i_Boost_pricing.PRICE_PER_MINUTE <= 0)
            {
                throw new BLCException("Price per minute field cannot be negative or null!");
            }

        }
        #endregion
        #region BLC_OnPreEvent_Edit_Boost_pricing_02
        void BLC_OnPreEvent_Edit_Boost_pricing_02(Boost_pricing i_Boost_pricing, BLC.Enum_EditMode i_Enum_EditMode)
        {
            decimal? price = i_Boost_pricing.PRICE_PER_MINUTE * i_Boost_pricing.MINUTE;
            if (i_Boost_pricing.TOTAL_PRICE != price)
            {
                i_Boost_pricing.TOTAL_PRICE = price;
            }
        }
        #endregion

        #endregion

        #region Work_area

        #region BLC_OnPreEvent_Edit_Work_area
        void BLC_OnPreEvent_Edit_Work_area(Work_area i_Work_area, BLC.Enum_EditMode i_Enum_EditMode)
        {
            //Work_list oWork = new Work_list();
            //List<dynamic> oBusiness = new List<dynamic>();
            //List<Work_list> oWorkList = new List<Work_list>();
            //oBusiness = _AppContext.UP_GET_BUSINESS_BY_OWNER_ID(1);
            ////oWorkList = _AppContext.UP_GET_WORK_LIST_BY_BUSINESS_ID(13);
            

            //switch (i_Enum_EditMode)
            //{
            //    case Enum_EditMode.Add:
            //        if ((oBusiness != null) && (oBusiness.Count !=0) && (oWorkList != null) && (oWorkList.Count != 0))
            //        {
            //            oBusiness.ForEach((item) => {
            //                oWork.BUSINESS_ID = item.BUSINESS_ID;
            //                oWork.OWNER_ID = 1;
            //                oWork.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
            //                oWork.WORK_LIST_ID = -1;
            //                oWork.IS_TRUE = false;
            //                oWorkList.Add(oWork);
            //            });
            //            oWorkList.ForEach((element) =>
            //            {
            //                Edit_Work_list(element);
            //            });
            //        }
            //        break;

            //    case Enum_EditMode.Update:
            //        break;
            //}
            }
        #endregion

        #endregion
        #region Work_list

        #region BLC_OnPreEvent_Edit_Work_list
        void BLC_OnPreEvent_Edit_Work_list(Work_list i_Work_list, BLC.Enum_EditMode i_Enum_EditMode)
        {
            //switch (i_Enum_EditMode)
            //{
            //    case Enum_EditMode.Add:
            //        List<dynamic> oWorkList = new List<dynamic>();
            //        oWorkList = _AppContext.UP_GET_WORK_LIST_BY_BUSINESS_ID(i_Work_list.BUSINESS_ID);
            //        if (oWorkList != null && oWorkList.Count > 0)
            //        {
            //            oWorkList.ForEach((item) =>
            //            {
            //                if (item.WORK_AREA_ID == i_Work_list.WORK_AREA_ID)
            //                {
            //                    return;
            //                }
            //            });
            //        }
            //        break;
            //    case Enum_EditMode.Update:
            //    break;
             
            //}
        }
        #endregion

        #endregion

    }

    #endregion
    #region BLCInitializer
    public class BLCInitializer
    {
        #region Properties
        public string ConnectionString { get; set; }
        public long? UserID { get; set; }
        public Int32? OwnerID { get; set; }
        public BLC.Enum_Language Language { get; set; }
        public string Messages_FilePath { get; set; }
        #endregion
    }
    #endregion
    #region Message
    public class Message
    {
        #region Properties
        public string Code { get; set; }
        public string Content { get; set; }
        #endregion
    }
    #endregion
    #region EnvCode Attribute
    #region EnvCode
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Constructor, AllowMultiple = true)]
    public class EnvCode : System.Attribute
    {
        #region Properties
        public BLC.Enum_Environment Environment { get; set; }
        public string MethodName { get; set; }
        #endregion
        #region Constructor
        public EnvCode(BLC.Enum_Environment i_Environment, string i_MethodName)
        {
            #region Body Section.
            Environment = i_Environment;
            MethodName = i_MethodName;
            #endregion
        }
        #endregion
        #region Behavior
        #region GetEnvCode
        public static MethodInfo GetEnvCode(Params_GetEnvCode i_Params_GetEnvCode)
        {
            #region Declaration And Initialization Section.
            MethodInfo[] oMethods = null;
            MethodInfo oMethodInfo = null;
            object[] oAttributes = null;
            EnvCode oEnvCode = null;

            bool Is_AlreadyFound = false;
            MethodInfo oMethodInfo_ReturnValue = null;
            #endregion
            #region Body Section.

            // ----------------------
            oMethods = i_Params_GetEnvCode.My_Type.GetMethods();
            // ----------------------

            // ----------------------
            for (int i = 0; i < oMethods.GetLength(0); i++)
            {
                // ----------------------
                if (Is_AlreadyFound == true)
                {
                    break;
                }
                // ----------------------

                // ----------------------
                oMethodInfo = oMethods[i];
                oAttributes = oMethodInfo.GetCustomAttributes(true);
                // ----------------------

                // ----------------------
                foreach (Attribute oAttribute in oAttributes)
                {
                    if (oAttribute is EnvCode)
                    {
                        oEnvCode = oAttribute as EnvCode;
                        if (oEnvCode != null)
                        {
                            if ((oEnvCode.Environment == i_Params_GetEnvCode.My_Environment) && (oEnvCode.MethodName == i_Params_GetEnvCode.My_MethodName))
                            {
                                oMethodInfo_ReturnValue = oMethodInfo;
                                Is_AlreadyFound = true;
                                break;
                            }
                        }
                    }
                }
                // ----------------------
            }
            // ----------------------
            #endregion
            #region Return Section.
            return oMethodInfo_ReturnValue;
            #endregion
        }
        #endregion
        #endregion
    }
    #endregion
    #region Params_GetEnvCode
    public class Params_GetEnvCode
    {
        #region Properties.
        public System.Type My_Type { get; set; }
        public BLC.Enum_Environment My_Environment { get; set; }
        public string My_MethodName { get; set; }
        #endregion
    }
    #endregion
    #endregion
}

#endregion
