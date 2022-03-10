using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BLC
{
    #region Enumeration
    public enum Enum_EntityNameFormat
    {
        FML,
        FLM,
        MFL,
        MLF,
        LFM,
        LMF
    }
    #endregion
    public partial class BLC
    {
        #region Members
        #endregion        
        #region Setup
        #region EditSetup
        #region EditSetup
        public void EditSetup(SetupEntry i_SetupEntry)
        {
            #region Declaration And Initialization Section.
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "EditSetup";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                oMethodInfo.Invoke(this, new object[] { i_SetupEntry });
                return;
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("EditSetup");
            }
            #endregion
            #region Body Section.
            i_SetupEntry.ENTRY_USER_ID = this.UserID;
            i_SetupEntry.OWNER_ID = this.OwnerID;
            i_SetupEntry.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
            oTools.InvokeMethod(_AppContext, "UP_EDIT_SETUP", i_SetupEntry);
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("EditSetup");
            }
            #endregion
        }
        #endregion
        #endregion
        #endregion
        #region Ticket
        #region ResolveTicket
        public Dictionary<string, string> ResolveTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            Dictionary<string, string> oList = new Dictionary<string, string>();
            string str_Ticket_PlainText = string.Empty;
            Crypto.Crypto oCrypto = new Crypto.Crypto();
            string[] oMainTempList = null;
            string[] oSubTempList = null;
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("ResolveTicket");
            }
            #endregion
            #region Body Section.
            if (!string.IsNullOrEmpty(i_Input))
            {
                //str_Ticket_PlainText = oCrypto.Decrypt(i_Input, _KeySet);
                str_Ticket_PlainText = i_Input;

                if (!string.IsNullOrEmpty(str_Ticket_PlainText))
                {
                    oMainTempList = str_Ticket_PlainText.Split(new string[] { "[~!@]" }, StringSplitOptions.RemoveEmptyEntries);

                    var oQuery = from oItem in oMainTempList
                                 select oItem;

                    foreach (var oRow in oQuery)
                    {
                        oSubTempList = oRow.Split(new string[] { ":" }, StringSplitOptions.None);
                        oList.Add(oSubTempList[0], oSubTempList[1]);
                    }
                }
            }
            else
            {
                oList.Add("USER_ID", "1");
                oList.Add("OWNER_ID", "1");
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("ResolveTicket");
            }
            #endregion
            #region Return Section.
            return oList;
            #endregion
        }
        #endregion
        #region IsValidTicket
        public bool IsValidTicket(string i_Input)
        {
            #region Declaration And Initialization Section.
            bool Is_ValidTicket = false;
            long? i_MinutesElapsedSinceMidnight = 0;
            string str_CurrentDate = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            Dictionary<string, string> oTicketParts = new Dictionary<string, string>();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "IsValidTicket";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                return Convert.ToBoolean(oMethodInfo.Invoke(this, new object[] { i_Input }));
                // Intentially Left Empty.
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("IsValidTicket");
            }
            #endregion
            #region Body Section.
            try
            {
                oTicketParts = ResolveTicket(i_Input);
                str_CurrentDate = oTools.GetDateString(DateTime.Today);

                if (oTicketParts["START_DATE"] == str_CurrentDate) // Session Started In Different Day.
                {
                    i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;

                    if (i_MinutesElapsedSinceMidnight <= Convert.ToInt32(oTicketParts["START_MINUTE"]) + Convert.ToInt32(oTicketParts["SESSION_PERIOD"]))
                    {
                        Is_ValidTicket = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Is_ValidTicket = false;
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("IsValidTicket");
            }
            #endregion
            #region Return Section.
            return Is_ValidTicket;
            #endregion
        }
        #endregion
        #endregion        
        #region Authentication
        public User Authenticate(Params_Authenticate i_Params_Authenticate)
        {
            #region Declaration and Initialization

            UserInfo oUserInfo = new UserInfo();
            User oUser = new User();
            Crypto.MiniCryptoHelper oCrypto = new Crypto.MiniCryptoHelper();
            Crypto.Crypto iCrypto = new Crypto.Crypto();

            #endregion
            #region Body Section
            List<dynamic> oList = _AppContext.UP_GET_USER_BY_USERNAME(i_Params_Authenticate.Username);
            if ((oList != null) && (oList.Count > 0))
            {
                var Pass = oCrypto.Encrypt(i_Params_Authenticate.Password);
                if (oList[0].IS_ACTIVE == false)
                {

                    //i_Params_Authenticate.IsAuthenticated = false;
                    throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0006));
                }
                else  if (Pass == oList[0].PASSWORD)
                {
                    oUser.USERNAME = oList[0].USERNAME;
                    oUser.PASSWORD = oList[0].PASSWORD;
                    oUser.USER_ID = oList[0].USER_ID;
                    oUser.OWNER_ID = oList[0].OWNER_ID;
                    oUser.IS_ACTIVE = oList[0].IS_ACTIVE;
                    oUser.USER_TYPE_CODE = oList[0].USER_TYPE_CODE;
                    i_Params_Authenticate.IsAuthenticated = true;



                    //var i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
                    //var str_ticket_PlainText = string.Format(
                    //    "USER_ID:{0}[!@]OWNER_ID:{1}[!@]START_DATE:{2}[!@]START_MINUTE:{3}[!@]SESSION_PERIOD:{4}",
                    //    oUser.USER_ID,
                    //    oUser.OWNER_ID,
                    //    oTools.GetDateString(DateTime.Today),
                    //    i_MinutesElapsedSinceMidnight.ToString(),
                    //    60
                    //    );
                    ////oUserInfo.Ticket = iCrypto.Encrypt(str_ticket_PlainText, _KeyPublic);
                    //oUserInfo.Ticket = str_ticket_PlainText;


                }
                //else if (oList[0].IS_ACTIVE == false)
                //{

                //    //i_Params_Authenticate.IsAuthenticated = false;
                //    throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0006));
                //}
                else
                {

                    //i_Params_Authenticate.IsAuthenticated = false;
                    throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0002));
                }
            }
            else
            {

                i_Params_Authenticate.IsAuthenticated = false;
                throw new BLCException(GetMessageContent(Enum_BR_Codes.BR_0002));
            }
            #endregion
            #region Return Section
            return oUser;
            #endregion
        }
        #endregion
        #region Get_Business_By_USERNAME
        //public Business_Obj Get_Business_By_USERNAME(Params_Get_Business_By_USERNAME i_Params_Get_Business_By_USERNAME)
        //{

        //    #region Declaration and Initialization
        //    Business_Obj oBusiness = new Business_Obj();
        //    //oTools.SetPropertiesDefaultValue(oBusiness);
        //    Params_Get_Business_By_BUSINESS_ID i_Params_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
        //    #endregion
        //    #region Body Section
        //    List<dynamic> oList = _AppContext.UP_GET_BUSINESS_ID_BY_USERNAME(i_Params_Get_Business_By_USERNAME.Username);
        //    if ((oList != null) && (oList.Count > 0))
        //    {

        //        oBusiness.BUSINESS_ID = oList[0].BUSINESS.ID;
        //        oBusiness.USERNAME = oList[0].USERNAME;
        //        oBusiness.EMAIL = oList[0].EMAIL;
        //    }
        //    #endregion
        //    #region Return Section
        //    return oBusiness;
        //    #endregion

        //}
        #endregion
        #region Get_Business_By_UNAME
        //public List<dynamic> Get_Business_By_UNAME(Params_Get_Business_By_UNAME i_Params_Get_Business_By_UNAME)
        //{

        //    #region Declaration and Initialization
        //    Business oBusiness = new Business();
        //    //oTools.SetPropertiesDefaultValue(oBusiness);
           
        //    #endregion
        //    #region Body Section
        //    List<dynamic> oList = _AppContext.UP_GET_BUSINESS_ID_BY_USERNAME(i_Params_Get_Business_By_UNAME.Username);
        //    if ((oList != null) && (oList.Count > 0))
        //    {

        //        //oBusiness.BUSINESS_ID = oList[0].BUSINESS.ID;
        //        //oBusiness.USERNAME = oList[0].USERNAME;
        //        //oBusiness.EMAIL = oList[0].EMAIL;
        //        return oList;
        //    }
        //    #endregion
        //    #region Return Section
        //    //return oBusiness;
        //    return null;
        //    #endregion

        //}
        #endregion
        #region Get_SetupEntries_Per_Table
        public List<SetupEntry> Get_SetupEntries_Per_Table(Params_Get_SetupEntries_Per_Table i_Params_Get_SetupEntries_Per_Table)
        {
            #region Declaration And Initilization Section.
            Tools.Tools oTools = new Tools.Tools();
            SetupEntry oSetupEntry = new SetupEntry();
            List<SetupEntry> oList = new List<SetupEntry>();
            #endregion
            #region Body Section.
            List<dynamic> oList1 = _AppContext.UP_GET_SETUP_ENTRIES_PER_TABLE(i_Params_Get_SetupEntries_Per_Table.TBL_NAME);

            if ((oList1 != null) && (oList1.Count > 0))
            {
                foreach (var oRow in oList1)
                {
                    //oSetupEntry = new SetupEntry();
                    oTools.CopyPropValues(oRow, oSetupEntry);
                    oList.Add(oSetupEntry);
                }
            }
            #endregion
            #region Return Section
            return oList;
            #endregion
        }
        #endregion
        #region Clear_User_By_Username
        public void Clear_User_By_Username(Params_Clear_User_By_Username i_Params_Clear_User_By_Username)
        {
            #region Declaration and Initialization
            List<dynamic> oList = new List<dynamic>();
            Params_Delete_User i_Params_Delete_User = new Params_Delete_User();
            #endregion
            #region Body Section
            oList = _AppContext.UP_GET_USER_BY_USERNAME(i_Params_Clear_User_By_Username.Username);
            if (oList != null && oList.Count > 0)
            {
                _AppContext.Delete_User_By_USERNAME(i_Params_Clear_User_By_Username.Username);
            }
            #endregion
            #region Return Section
            #endregion
        }
        #endregion
        #region takeNDigits

        private static int takeNDigits(int number, int N)
        {
            // this is for handling negative numbers, we are only insterested in postitve number
            number = Math.Abs(number);
            // special case for 0 as Log of 0 would be infinity
            if (number == 0)
                return number;
            // getting number of digits on this input number
            int numberOfDigits = (int)Math.Floor(Math.Log10(number) + 1);
            // check if input number has more digits than the required get first N digits
            if (numberOfDigits >= N)
                return (int)Math.Truncate((number / Math.Pow(10, numberOfDigits - N)));
            else
                return number;
        }
        #endregion
        


    }
    #region Business Entities
    #region Setup
    #region SetupEntry
    public class SetupEntry
    {
        #region Properties
        public Int32? OWNER_ID { get; set; }
        public string TBL_NAME { get; set; }
        public string CODE_NAME { get; set; }
        public bool? ISSYSTEM { get; set; }
        public bool? ISDELETEABLE { get; set; }
        public bool? ISUPDATEABLE { get; set; }
        public bool? ISVISIBLE { get; set; }
        public bool? ISDELETED { get; set; }
        public Int32? DISPLAY_ORDER { get; set; }
        public string CODE_VALUE_EN { get; set; }
        public string CODE_VALUE_FR { get; set; }
        public string CODE_VALUE_AR { get; set; }
        public string ENTRY_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string NOTES { get; set; }

        public string INVARIANT_VALUE { get; set; }
        #endregion
    }
    #endregion    
    #endregion
    #region Uploaded_file
    public partial class Uploaded_file
    {
        public string My_URL { get; set; }
    }
    #endregion
    #region Params_Authenticate
    public partial class Params_Authenticate
    {
        #region Properties.
        //public UserInfo My_UserInfo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAuthenticated { get; set; }
    }
    #endregion
    #region UserInfo
    public class UserInfo
    {
        #region Properties
        public long? UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAuthenticated { get; set; }
        public Int32? OwnerID { get; set; }
        public string Ticket { get; set; }
        #endregion
    }
    #endregion

    #endregion
    #region Params_Get_Business_By_UNAME
    //public partial class Params_Get_Business_By_UNAME
    //{
    //    public string Username { get; set; }
    //}
    #endregion
    #region Params_Get_SetupEntries_Per_Table
    public partial class Params_Get_SetupEntries_Per_Table
    {
        #region Properties.
        public string TBL_NAME { get; set; }
        #endregion
    }
    #endregion
    #region User
    public partial class User
    {
        public string My_Ticket { get; set; }
    }
    #endregion
    #region Category
    public partial class Category
    {
        public List<Sub_category> My_Sub_categories { get; set; }
    }
    #endregion
    #region Business_Obj
    //public class Business_Obj
    //{
    //       public string USERNAME { get; set; }
    //       public int BUSINESS_ID { get; set; }
    //       public string EMAIL { get; set; }
    //}
    #endregion
    #region Business
    public partial class Business
    {
        public List<Work_area> My_Work_areas { get; set; }
        public List<Work_list> My_Work_lists { get; set; }
    }
    #endregion
    #region Booking
    public partial class Booking
    {
        public List<Feedback> My_Feedbacks { get; set; }
    }
    #endregion
    #region Params_Clear_User_By_Username
    public class Params_Clear_User_By_Username
    {
        public string Username { get; set; }
    }
    #endregion
    #endregion
}

