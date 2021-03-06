using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using BLC;
namespace BLC
{
public partial class BLC
{

#region Enum_API_Method
public enum Enum_API_Method
{
Authenticate,
Edit_Admin,
Delete_Admin,
Get_Admin_By_OWNER_ID,
Get_Admin_By_Where,
Get_Admin_By_Where_Adv,
Get_Admin_By_Criteria,
Get_Admin_By_ADMIN_ID,
Get_Admin_By_USERNAME,
Edit_Booking,
Delete_Booking,
Get_Booking_By_OWNER_ID,
Get_Booking_By_OWNER_ID_Adv,
Get_Booking_By_BOOKING_ID,
Get_Booking_By_BOOKING_ID_Adv,
Get_Booking_By_Where,
Get_Booking_By_Where_Adv,
Get_Booking_By_CLIENT_ID,
Get_Booking_By_CLIENT_ID_Adv,
Get_Booking_By_BUSINESS_ID,
Get_Booking_By_BUSINESS_ID_Adv,
Get_Booking_By_SERVICE_PROD_ID_Adv,
Edit_Boost_listing,
Delete_Boost_listing,
Get_Boost_listing_By_OWNER_ID,
Get_Boost_listing_By_OWNER_ID_Adv,
Get_Boost_listing_By_BOOST_LISTING_ID,
Get_Boost_listing_By_BOOST_LISTING_ID_Adv,
Get_Boost_listing_By_Where,
Get_Boost_listing_By_Where_Adv,
Edit_Boost_pricing,
Delete_Boost_pricing,
Get_Boost_pricing_By_OWNER_ID,
Get_Boost_pricing_By_OWNER_ID_Adv,
Get_Boost_pricing_By_BOOST_PRICING_ID,
Get_Boost_pricing_By_BOOST_PRICING_ID_Adv,
Get_Boost_pricing_By_Where,
Get_Boost_pricing_By_Where_Adv,
Edit_Business,
Delete_Business,
Get_Business_By_OWNER_ID,
Get_Business_By_OWNER_ID_Adv,
Get_Business_By_Where,
Get_Business_By_Where_Adv,
Get_Business_By_BUSINESS_ID,
Get_Business_By_BUSINESS_ID_Adv,
Get_Business_By_USERNAME,
Get_Business_By_USERNAME_Adv,
Edit_Category,
Delete_Category,
Get_Category_By_CATEGORY_ID,
Get_Category_By_Where,
Get_Category_By_Where_Adv,
Get_Category_By_OWNER_ID,
Get_Category_By_OWNER_ID_Adv,
Edit_Client,
Delete_Client,
Get_Client_By_Criteria,
Get_Client_By_Where,
Get_Client_By_Where_Adv,
Get_Client_By_OWNER_ID,
Get_Client_By_CLIENT_ID,
Get_Client_By_CLIENT_ID_Adv,
Get_Client_By_USERNAME,
Get_Client_By_USERNAME_Adv,
Edit_Coordinates,
Delete_Coordinates,
Get_Coordinates_By_OWNER_ID,
Get_Coordinates_By_Where,
Get_Coordinates_By_Where_Adv,
Edit_Currency,
Delete_Currency,
Get_Currency_By_Where,
Get_Currency_By_OWNER_ID,
Get_Currency_By_CURRENCY_ID,
Edit_Feedback,
Delete_Feedback,
Get_Feedback_By_Where,
Get_Feedback_By_Where_Adv,
Get_Feedback_By_OWNER_ID,
Get_Feedback_By_FEEDBACK_ID,
Get_Feedback_By_BOOKING_ID,
Edit_Service_prod,
Delete_Service_prod,
Get_Service_prod_By_Where,
Get_Service_prod_By_Where_Adv,
Get_Service_prod_By_OWNER_ID,
Get_Service_prod_By_SERVICE_PROD_ID,
Get_Service_prod_By_OWNER_ID_Adv,
Get_Service_prod_By_SERVICE_PROD_ID_Adv,
Get_Service_prod_By_BUSINESS_ID,
Get_Service_prod_By_BUSINESS_ID_Adv,
Get_Service_prod_By_SUB_CATEGORY_ID,
Get_Service_prod_By_SUB_CATEGORY_ID_Adv,
Edit_Status,
Delete_Status,
Get_Status_By_OWNER_ID,
Get_Status_By_STATUS_ID,
Edit_Sub_category,
Delete_Sub_category,
Get_Sub_category_By_Where,
Get_Sub_category_By_Where_Adv,
Get_Sub_category_By_OWNER_ID,
Get_Sub_category_By_OWNER_ID_Adv,
Get_Sub_category_By_CATEGORY_ID,
Edit_Work_area,
Delete_Work_area,
Get_Work_area_By_OWNER_ID,
Get_Work_area_By_Where,
Get_Work_area_By_Where_Adv,
Edit_Work_list,
Delete_Work_list,
Delete_Work_list_By_BUSINESS_ID,
Get_Work_list_By_WORK_LIST_ID,
Get_Work_list_By_BUSINESS_ID,
Get_Work_list_By_WORK_AREA_ID,
Get_Work_list_By_BUSINESS_ID_Adv,
Get_Work_list_By_WORK_AREA_ID_Adv,
Get_Work_list_By_WORK_LIST_ID_Adv,
Get_Work_list_By_OWNER_ID,
Edit_User,
Delete_User,
Get_User_By_Criteria,
Get_User_By_Where,
Get_User_By_OWNER_ID,
Get_User_By_USER_ID,
Get_SetupEntries_Per_Table,
Get_User_By_Criteria_Adv,
Delete_User_By_USERNAME
}
#endregion

#region Prepare_BLCInitializer
public BLCInitializer Prepare_BLCInitializer(string i_Ticket, Enum_API_Method i_Enum_API_Method)
{
#region Declaration And Initialization Section.
BLCInitializer oBLCInitializer = new BLCInitializer();
BLC oBLC_Default = new BLC();
string str_CUSTOM_BLC_INIT = string.Empty;
#endregion
#region Body Section.
if (this.OnPreEvent_BLC_Init != null)
{
oBLCInitializer = this.OnPreEvent_BLC_Init(i_Ticket, i_Enum_API_Method);
return oBLCInitializer;
}
else
{
oBLCInitializer.UserID = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
}
#endregion
#region Return Section.
return oBLCInitializer;
#endregion
}
#endregion

#region General Pre/Post events
public delegate void PreEvent_Handler_General(string i_MethodName);
public delegate void PostEvent_Handler_General(string i_MethodName);
public event PreEvent_Handler_General OnPreEvent_General;
public event PostEvent_Handler_General OnPostEvent_General;
#endregion
#region General Pre/Post BLC_Init
public delegate BLCInitializer PreEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public delegate BLCInitializer PostEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public event PreEvent_Handler_BLC_Init OnPreEvent_BLC_Init;
public event PostEvent_Handler_BLC_Init OnPostEvent_BLC_Init;
#endregion
public  delegate void PreEvent_Handler_Delete_Status(Params_Delete_Status i_Params_Delete_Status);
public  delegate void  PostEvent_Handler_Delete_Status(Params_Delete_Status i_Params_Delete_Status);
public event PreEvent_Handler_Delete_Status OnPreEvent_Delete_Status;
public event PostEvent_Handler_Delete_Status OnPostEvent_Delete_Status;
public  delegate void PreEvent_Handler_Delete_Booking(Params_Delete_Booking i_Params_Delete_Booking);
public  delegate void  PostEvent_Handler_Delete_Booking(Params_Delete_Booking i_Params_Delete_Booking);
public event PreEvent_Handler_Delete_Booking OnPreEvent_Delete_Booking;
public event PostEvent_Handler_Delete_Booking OnPostEvent_Delete_Booking;
public  delegate void PreEvent_Handler_Delete_Business(Params_Delete_Business i_Params_Delete_Business);
public  delegate void  PostEvent_Handler_Delete_Business(Params_Delete_Business i_Params_Delete_Business);
public event PreEvent_Handler_Delete_Business OnPreEvent_Delete_Business;
public event PostEvent_Handler_Delete_Business OnPostEvent_Delete_Business;
public  delegate void PreEvent_Handler_Delete_Work_area(Params_Delete_Work_area i_Params_Delete_Work_area);
public  delegate void  PostEvent_Handler_Delete_Work_area(Params_Delete_Work_area i_Params_Delete_Work_area);
public event PreEvent_Handler_Delete_Work_area OnPreEvent_Delete_Work_area;
public event PostEvent_Handler_Delete_Work_area OnPostEvent_Delete_Work_area;
public  delegate void PreEvent_Handler_Delete_Boost_listing(Params_Delete_Boost_listing i_Params_Delete_Boost_listing);
public  delegate void  PostEvent_Handler_Delete_Boost_listing(Params_Delete_Boost_listing i_Params_Delete_Boost_listing);
public event PreEvent_Handler_Delete_Boost_listing OnPreEvent_Delete_Boost_listing;
public event PostEvent_Handler_Delete_Boost_listing OnPostEvent_Delete_Boost_listing;
public  delegate void PreEvent_Handler_Edit_Boost_pricing(Boost_pricing i_Boost_pricing,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Boost_pricing(Boost_pricing i_Boost_pricing,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Boost_pricing OnPreEvent_Edit_Boost_pricing;
public event PostEvent_Handler_Edit_Boost_pricing OnPostEvent_Edit_Boost_pricing;
public  delegate void PreEvent_Handler_Edit_Client(Client i_Client,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Client(Client i_Client,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Client OnPreEvent_Edit_Client;
public event PostEvent_Handler_Edit_Client OnPostEvent_Edit_Client;
public  delegate void PreEvent_Handler_Edit_Service_prod(Service_prod i_Service_prod,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Service_prod(Service_prod i_Service_prod,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Service_prod OnPreEvent_Edit_Service_prod;
public event PostEvent_Handler_Edit_Service_prod OnPostEvent_Edit_Service_prod;
public  delegate void PreEvent_Handler_Edit_Admin(Admin i_Admin,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Admin(Admin i_Admin,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Admin OnPreEvent_Edit_Admin;
public event PostEvent_Handler_Edit_Admin OnPostEvent_Edit_Admin;
public  delegate void PreEvent_Handler_Edit_Category(Category i_Category,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Category(Category i_Category,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Category OnPreEvent_Edit_Category;
public event PostEvent_Handler_Edit_Category OnPostEvent_Edit_Category;
public  delegate void PreEvent_Handler_Edit_Status(Status i_Status,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Status(Status i_Status,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Status OnPreEvent_Edit_Status;
public event PostEvent_Handler_Edit_Status OnPostEvent_Edit_Status;
public  delegate void PreEvent_Handler_Edit_Feedback(Feedback i_Feedback,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Feedback(Feedback i_Feedback,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Feedback OnPreEvent_Edit_Feedback;
public event PostEvent_Handler_Edit_Feedback OnPostEvent_Edit_Feedback;
public  delegate void PreEvent_Handler_Edit_Booking(Booking i_Booking,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Booking(Booking i_Booking,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Booking OnPreEvent_Edit_Booking;
public event PostEvent_Handler_Edit_Booking OnPostEvent_Edit_Booking;
public  delegate void PreEvent_Handler_Edit_Business(Business i_Business,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Business(Business i_Business,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Business OnPreEvent_Edit_Business;
public event PostEvent_Handler_Edit_Business OnPostEvent_Edit_Business;
public  delegate void PreEvent_Handler_Edit_Work_list(Work_list i_Work_list,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Work_list(Work_list i_Work_list,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Work_list OnPreEvent_Edit_Work_list;
public event PostEvent_Handler_Edit_Work_list OnPostEvent_Edit_Work_list;
public  delegate void PreEvent_Handler_Edit_Work_area(Work_area i_Work_area,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Work_area(Work_area i_Work_area,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Work_area OnPreEvent_Edit_Work_area;
public event PostEvent_Handler_Edit_Work_area OnPostEvent_Edit_Work_area;
public  delegate void PreEvent_Handler_Edit_Boost_listing(Boost_listing i_Boost_listing,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Boost_listing(Boost_listing i_Boost_listing,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Boost_listing OnPreEvent_Edit_Boost_listing;
public event PostEvent_Handler_Edit_Boost_listing OnPostEvent_Edit_Boost_listing;
public  delegate void PreEvent_Handler_Delete_Boost_pricing(Params_Delete_Boost_pricing i_Params_Delete_Boost_pricing);
public  delegate void  PostEvent_Handler_Delete_Boost_pricing(Params_Delete_Boost_pricing i_Params_Delete_Boost_pricing);
public event PreEvent_Handler_Delete_Boost_pricing OnPreEvent_Delete_Boost_pricing;
public event PostEvent_Handler_Delete_Boost_pricing OnPostEvent_Delete_Boost_pricing;
public  delegate void PreEvent_Handler_Delete_Client(Params_Delete_Client i_Params_Delete_Client);
public  delegate void  PostEvent_Handler_Delete_Client(Params_Delete_Client i_Params_Delete_Client);
public event PreEvent_Handler_Delete_Client OnPreEvent_Delete_Client;
public event PostEvent_Handler_Delete_Client OnPostEvent_Delete_Client;
public  delegate void PreEvent_Handler_Delete_Service_prod(Params_Delete_Service_prod i_Params_Delete_Service_prod);
public  delegate void  PostEvent_Handler_Delete_Service_prod(Params_Delete_Service_prod i_Params_Delete_Service_prod);
public event PreEvent_Handler_Delete_Service_prod OnPreEvent_Delete_Service_prod;
public event PostEvent_Handler_Delete_Service_prod OnPostEvent_Delete_Service_prod;
public  delegate void PreEvent_Handler_Delete_Admin(Params_Delete_Admin i_Params_Delete_Admin);
public  delegate void  PostEvent_Handler_Delete_Admin(Params_Delete_Admin i_Params_Delete_Admin);
public event PreEvent_Handler_Delete_Admin OnPreEvent_Delete_Admin;
public event PostEvent_Handler_Delete_Admin OnPostEvent_Delete_Admin;
public  delegate void PreEvent_Handler_Delete_Category(Params_Delete_Category i_Params_Delete_Category);
public  delegate void  PostEvent_Handler_Delete_Category(Params_Delete_Category i_Params_Delete_Category);
public event PreEvent_Handler_Delete_Category OnPreEvent_Delete_Category;
public event PostEvent_Handler_Delete_Category OnPostEvent_Delete_Category;
#region Cach Dropper
public void Initialize_Cash_Dropper()
{
}
#endregion
}
}
