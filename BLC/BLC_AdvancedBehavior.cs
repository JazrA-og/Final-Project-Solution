using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
public Boost_pricing Get_Boost_pricing_By_BOOST_PRICING_ID_Adv(Params_Get_Boost_pricing_By_BOOST_PRICING_ID i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID)
{
Boost_pricing oBoost_pricing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_BOOST_PRICING_ID_Adv");}
#region Body Section.
DALC.Boost_pricing oDBEntry = _AppContext.Get_Boost_pricing_By_BOOST_PRICING_ID_Adv(i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID.BOOST_PRICING_ID);
oBoost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry, oBoost_pricing);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_BOOST_PRICING_ID_Adv");}
return oBoost_pricing;
}
public Client Get_Client_By_CLIENT_ID_Adv(Params_Get_Client_By_CLIENT_ID i_Params_Get_Client_By_CLIENT_ID)
{
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_CLIENT_ID_Adv");}
#region Body Section.
DALC.Client oDBEntry = _AppContext.Get_Client_By_CLIENT_ID_Adv(i_Params_Get_Client_By_CLIENT_ID.CLIENT_ID);
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_CLIENT_ID_Adv");}
return oClient;
}
public Service_prod Get_Service_prod_By_SERVICE_PROD_ID_Adv(Params_Get_Service_prod_By_SERVICE_PROD_ID i_Params_Get_Service_prod_By_SERVICE_PROD_ID)
{
Service_prod oService_prod = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_SERVICE_PROD_ID_Adv");}
#region Body Section.
DALC.Service_prod oDBEntry = _AppContext.Get_Service_prod_By_SERVICE_PROD_ID_Adv(i_Params_Get_Service_prod_By_SERVICE_PROD_ID.SERVICE_PROD_ID);
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_SERVICE_PROD_ID_Adv");}
return oService_prod;
}
public Admin Get_Admin_By_ADMIN_ID_Adv(Params_Get_Admin_By_ADMIN_ID i_Params_Get_Admin_By_ADMIN_ID)
{
Admin oAdmin = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_ADMIN_ID_Adv");}
#region Body Section.
DALC.Admin oDBEntry = _AppContext.Get_Admin_By_ADMIN_ID_Adv(i_Params_Get_Admin_By_ADMIN_ID.ADMIN_ID);
oAdmin = new Admin();
oTools.CopyPropValues(oDBEntry, oAdmin);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_ADMIN_ID_Adv");}
return oAdmin;
}
public Category Get_Category_By_CATEGORY_ID_Adv(Params_Get_Category_By_CATEGORY_ID i_Params_Get_Category_By_CATEGORY_ID)
{
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID_Adv");}
#region Body Section.
DALC.Category oDBEntry = _AppContext.Get_Category_By_CATEGORY_ID_Adv(i_Params_Get_Category_By_CATEGORY_ID.CATEGORY_ID);
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID_Adv");}
return oCategory;
}
public Sub_category Get_Sub_category_By_SUB_CATEGORY_ID_Adv(Params_Get_Sub_category_By_SUB_CATEGORY_ID i_Params_Get_Sub_category_By_SUB_CATEGORY_ID)
{
Sub_category oSub_category = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_SUB_CATEGORY_ID_Adv");}
#region Body Section.
DALC.Sub_category oDBEntry = _AppContext.Get_Sub_category_By_SUB_CATEGORY_ID_Adv(i_Params_Get_Sub_category_By_SUB_CATEGORY_ID.SUB_CATEGORY_ID);
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oSub_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oSub_category.My_Category);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_SUB_CATEGORY_ID_Adv");}
return oSub_category;
}
public Coordinates Get_Coordinates_By_COORDINATES_ID_Adv(Params_Get_Coordinates_By_COORDINATES_ID i_Params_Get_Coordinates_By_COORDINATES_ID)
{
Coordinates oCoordinates = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_COORDINATES_ID_Adv");}
#region Body Section.
DALC.Coordinates oDBEntry = _AppContext.Get_Coordinates_By_COORDINATES_ID_Adv(i_Params_Get_Coordinates_By_COORDINATES_ID.COORDINATES_ID);
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oCoordinates.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oCoordinates.My_Booking);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_COORDINATES_ID_Adv");}
return oCoordinates;
}
public Currency Get_Currency_By_CURRENCY_ID_Adv(Params_Get_Currency_By_CURRENCY_ID i_Params_Get_Currency_By_CURRENCY_ID)
{
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID_Adv");}
#region Body Section.
DALC.Currency oDBEntry = _AppContext.Get_Currency_By_CURRENCY_ID_Adv(i_Params_Get_Currency_By_CURRENCY_ID.CURRENCY_ID);
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID_Adv");}
return oCurrency;
}
public Status Get_Status_By_STATUS_ID_Adv(Params_Get_Status_By_STATUS_ID i_Params_Get_Status_By_STATUS_ID)
{
Status oStatus = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_STATUS_ID_Adv");}
#region Body Section.
DALC.Status oDBEntry = _AppContext.Get_Status_By_STATUS_ID_Adv(i_Params_Get_Status_By_STATUS_ID.STATUS_ID);
oStatus = new Status();
oTools.CopyPropValues(oDBEntry, oStatus);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_STATUS_ID_Adv");}
return oStatus;
}
public Feedback Get_Feedback_By_FEEDBACK_ID_Adv(Params_Get_Feedback_By_FEEDBACK_ID i_Params_Get_Feedback_By_FEEDBACK_ID)
{
Feedback oFeedback = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_FEEDBACK_ID_Adv");}
#region Body Section.
DALC.Feedback oDBEntry = _AppContext.Get_Feedback_By_FEEDBACK_ID_Adv(i_Params_Get_Feedback_By_FEEDBACK_ID.FEEDBACK_ID);
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_FEEDBACK_ID_Adv");}
return oFeedback;
}
public Booking Get_Booking_By_BOOKING_ID_Adv(Params_Get_Booking_By_BOOKING_ID i_Params_Get_Booking_By_BOOKING_ID)
{
Booking oBooking = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_BOOKING_ID_Adv");}
#region Body Section.
DALC.Booking oDBEntry = _AppContext.Get_Booking_By_BOOKING_ID_Adv(i_Params_Get_Booking_By_BOOKING_ID.BOOKING_ID);
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_BOOKING_ID_Adv");}
return oBooking;
}
public Business Get_Business_By_BUSINESS_ID_Adv(Params_Get_Business_By_BUSINESS_ID i_Params_Get_Business_By_BUSINESS_ID)
{
Business oBusiness = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_BUSINESS_ID_Adv");}
#region Body Section.
DALC.Business oDBEntry = _AppContext.Get_Business_By_BUSINESS_ID_Adv(i_Params_Get_Business_By_BUSINESS_ID.BUSINESS_ID);
oBusiness = new Business();
oTools.CopyPropValues(oDBEntry, oBusiness);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_BUSINESS_ID_Adv");}
return oBusiness;
}
public Work_list Get_Work_list_By_WORK_LIST_ID_Adv(Params_Get_Work_list_By_WORK_LIST_ID i_Params_Get_Work_list_By_WORK_LIST_ID)
{
Work_list oWork_list = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_WORK_LIST_ID_Adv");}
#region Body Section.
DALC.Work_list oDBEntry = _AppContext.Get_Work_list_By_WORK_LIST_ID_Adv(i_Params_Get_Work_list_By_WORK_LIST_ID.WORK_LIST_ID);
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_WORK_LIST_ID_Adv");}
return oWork_list;
}
public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_Adv");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_Adv");}
return oUser;
}
public Work_area Get_Work_area_By_WORK_AREA_ID_Adv(Params_Get_Work_area_By_WORK_AREA_ID i_Params_Get_Work_area_By_WORK_AREA_ID)
{
Work_area oWork_area = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_WORK_AREA_ID_Adv");}
#region Body Section.
DALC.Work_area oDBEntry = _AppContext.Get_Work_area_By_WORK_AREA_ID_Adv(i_Params_Get_Work_area_By_WORK_AREA_ID.WORK_AREA_ID);
oWork_area = new Work_area();
oTools.CopyPropValues(oDBEntry, oWork_area);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_WORK_AREA_ID_Adv");}
return oWork_area;
}
public Boost_listing Get_Boost_listing_By_BOOST_LISTING_ID_Adv(Params_Get_Boost_listing_By_BOOST_LISTING_ID i_Params_Get_Boost_listing_By_BOOST_LISTING_ID)
{
Boost_listing oBoost_listing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_BOOST_LISTING_ID_Adv");}
#region Body Section.
DALC.Boost_listing oDBEntry = _AppContext.Get_Boost_listing_By_BOOST_LISTING_ID_Adv(i_Params_Get_Boost_listing_By_BOOST_LISTING_ID.BOOST_LISTING_ID);
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_BOOST_LISTING_ID_Adv");}
return oBoost_listing;
}
public List<Boost_pricing> Get_Boost_pricing_By_BOOST_PRICING_ID_List_Adv(Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List)
{
Boost_pricing oBoost_pricing = null;
List<Boost_pricing> oList = new List<Boost_pricing>();
Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List_SP oParams_Get_Boost_pricing_By_BOOST_PRICING_ID_List_SP = new Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_BOOST_PRICING_ID_List_Adv");}
#region Body Section.
List<DALC.Boost_pricing> oList_DBEntries = _AppContext.Get_Boost_pricing_By_BOOST_PRICING_ID_List_Adv(i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List.BOOST_PRICING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry, oBoost_pricing);
oList.Add(oBoost_pricing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_BOOST_PRICING_ID_List_Adv");}
return oList;
}
public List<Client> Get_Client_By_CLIENT_ID_List_Adv(Params_Get_Client_By_CLIENT_ID_List i_Params_Get_Client_By_CLIENT_ID_List)
{
Client oClient = null;
List<Client> oList = new List<Client>();
Params_Get_Client_By_CLIENT_ID_List_SP oParams_Get_Client_By_CLIENT_ID_List_SP = new Params_Get_Client_By_CLIENT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_CLIENT_ID_List_Adv");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_CLIENT_ID_List_Adv(i_Params_Get_Client_By_CLIENT_ID_List.CLIENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_CLIENT_ID_List_Adv");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SERVICE_PROD_ID_List_Adv(Params_Get_Service_prod_By_SERVICE_PROD_ID_List i_Params_Get_Service_prod_By_SERVICE_PROD_ID_List)
{
Service_prod oService_prod = null;
List<Service_prod> oList = new List<Service_prod>();
Params_Get_Service_prod_By_SERVICE_PROD_ID_List_SP oParams_Get_Service_prod_By_SERVICE_PROD_ID_List_SP = new Params_Get_Service_prod_By_SERVICE_PROD_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_SERVICE_PROD_ID_List_Adv");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_SERVICE_PROD_ID_List_Adv(i_Params_Get_Service_prod_By_SERVICE_PROD_ID_List.SERVICE_PROD_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_SERVICE_PROD_ID_List_Adv");}
return oList;
}
public List<Admin> Get_Admin_By_ADMIN_ID_List_Adv(Params_Get_Admin_By_ADMIN_ID_List i_Params_Get_Admin_By_ADMIN_ID_List)
{
Admin oAdmin = null;
List<Admin> oList = new List<Admin>();
Params_Get_Admin_By_ADMIN_ID_List_SP oParams_Get_Admin_By_ADMIN_ID_List_SP = new Params_Get_Admin_By_ADMIN_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_ADMIN_ID_List_Adv");}
#region Body Section.
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_ADMIN_ID_List_Adv(i_Params_Get_Admin_By_ADMIN_ID_List.ADMIN_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAdmin = new Admin();
oTools.CopyPropValues(oDBEntry, oAdmin);
oList.Add(oAdmin);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_ADMIN_ID_List_Adv");}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List_Adv(Params_Get_Category_By_CATEGORY_ID_List i_Params_Get_Category_By_CATEGORY_ID_List)
{
Category oCategory = null;
List<Category> oList = new List<Category>();
Params_Get_Category_By_CATEGORY_ID_List_SP oParams_Get_Category_By_CATEGORY_ID_List_SP = new Params_Get_Category_By_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_CATEGORY_ID_List_Adv(i_Params_Get_Category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_SUB_CATEGORY_ID_List_Adv(Params_Get_Sub_category_By_SUB_CATEGORY_ID_List i_Params_Get_Sub_category_By_SUB_CATEGORY_ID_List)
{
Sub_category oSub_category = null;
List<Sub_category> oList = new List<Sub_category>();
Params_Get_Sub_category_By_SUB_CATEGORY_ID_List_SP oParams_Get_Sub_category_By_SUB_CATEGORY_ID_List_SP = new Params_Get_Sub_category_By_SUB_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_SUB_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_SUB_CATEGORY_ID_List_Adv(i_Params_Get_Sub_category_By_SUB_CATEGORY_ID_List.SUB_CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oSub_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oSub_category.My_Category);
oList.Add(oSub_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_SUB_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_COORDINATES_ID_List_Adv(Params_Get_Coordinates_By_COORDINATES_ID_List i_Params_Get_Coordinates_By_COORDINATES_ID_List)
{
Coordinates oCoordinates = null;
List<Coordinates> oList = new List<Coordinates>();
Params_Get_Coordinates_By_COORDINATES_ID_List_SP oParams_Get_Coordinates_By_COORDINATES_ID_List_SP = new Params_Get_Coordinates_By_COORDINATES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_COORDINATES_ID_List_Adv");}
#region Body Section.
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_COORDINATES_ID_List_Adv(i_Params_Get_Coordinates_By_COORDINATES_ID_List.COORDINATES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oCoordinates.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oCoordinates.My_Booking);
oList.Add(oCoordinates);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_COORDINATES_ID_List_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List_Adv(Params_Get_Currency_By_CURRENCY_ID_List i_Params_Get_Currency_By_CURRENCY_ID_List)
{
Currency oCurrency = null;
List<Currency> oList = new List<Currency>();
Params_Get_Currency_By_CURRENCY_ID_List_SP oParams_Get_Currency_By_CURRENCY_ID_List_SP = new Params_Get_Currency_By_CURRENCY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID_List_Adv");}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_CURRENCY_ID_List_Adv(i_Params_Get_Currency_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Status> Get_Status_By_STATUS_ID_List_Adv(Params_Get_Status_By_STATUS_ID_List i_Params_Get_Status_By_STATUS_ID_List)
{
Status oStatus = null;
List<Status> oList = new List<Status>();
Params_Get_Status_By_STATUS_ID_List_SP oParams_Get_Status_By_STATUS_ID_List_SP = new Params_Get_Status_By_STATUS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_STATUS_ID_List_Adv");}
#region Body Section.
List<DALC.Status> oList_DBEntries = _AppContext.Get_Status_By_STATUS_ID_List_Adv(i_Params_Get_Status_By_STATUS_ID_List.STATUS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStatus = new Status();
oTools.CopyPropValues(oDBEntry, oStatus);
oList.Add(oStatus);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_STATUS_ID_List_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_FEEDBACK_ID_List_Adv(Params_Get_Feedback_By_FEEDBACK_ID_List i_Params_Get_Feedback_By_FEEDBACK_ID_List)
{
Feedback oFeedback = null;
List<Feedback> oList = new List<Feedback>();
Params_Get_Feedback_By_FEEDBACK_ID_List_SP oParams_Get_Feedback_By_FEEDBACK_ID_List_SP = new Params_Get_Feedback_By_FEEDBACK_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_FEEDBACK_ID_List_Adv");}
#region Body Section.
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_FEEDBACK_ID_List_Adv(i_Params_Get_Feedback_By_FEEDBACK_ID_List.FEEDBACK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_FEEDBACK_ID_List_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_BOOKING_ID_List_Adv(Params_Get_Booking_By_BOOKING_ID_List i_Params_Get_Booking_By_BOOKING_ID_List)
{
Booking oBooking = null;
List<Booking> oList = new List<Booking>();
Params_Get_Booking_By_BOOKING_ID_List_SP oParams_Get_Booking_By_BOOKING_ID_List_SP = new Params_Get_Booking_By_BOOKING_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_BOOKING_ID_List_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_BOOKING_ID_List_Adv(i_Params_Get_Booking_By_BOOKING_ID_List.BOOKING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_BOOKING_ID_List_Adv");}
return oList;
}
public List<Business> Get_Business_By_BUSINESS_ID_List_Adv(Params_Get_Business_By_BUSINESS_ID_List i_Params_Get_Business_By_BUSINESS_ID_List)
{
Business oBusiness = null;
List<Business> oList = new List<Business>();
Params_Get_Business_By_BUSINESS_ID_List_SP oParams_Get_Business_By_BUSINESS_ID_List_SP = new Params_Get_Business_By_BUSINESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_BUSINESS_ID_List_Adv");}
#region Body Section.
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_BUSINESS_ID_List_Adv(i_Params_Get_Business_By_BUSINESS_ID_List.BUSINESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBusiness = new Business();
oTools.CopyPropValues(oDBEntry, oBusiness);
oList.Add(oBusiness);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_BUSINESS_ID_List_Adv");}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_LIST_ID_List_Adv(Params_Get_Work_list_By_WORK_LIST_ID_List i_Params_Get_Work_list_By_WORK_LIST_ID_List)
{
Work_list oWork_list = null;
List<Work_list> oList = new List<Work_list>();
Params_Get_Work_list_By_WORK_LIST_ID_List_SP oParams_Get_Work_list_By_WORK_LIST_ID_List_SP = new Params_Get_Work_list_By_WORK_LIST_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_WORK_LIST_ID_List_Adv");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_WORK_LIST_ID_List_Adv(i_Params_Get_Work_list_By_WORK_LIST_ID_List.WORK_LIST_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_WORK_LIST_ID_List_Adv");}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List_Adv");}
return oList;
}
public List<Work_area> Get_Work_area_By_WORK_AREA_ID_List_Adv(Params_Get_Work_area_By_WORK_AREA_ID_List i_Params_Get_Work_area_By_WORK_AREA_ID_List)
{
Work_area oWork_area = null;
List<Work_area> oList = new List<Work_area>();
Params_Get_Work_area_By_WORK_AREA_ID_List_SP oParams_Get_Work_area_By_WORK_AREA_ID_List_SP = new Params_Get_Work_area_By_WORK_AREA_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_WORK_AREA_ID_List_Adv");}
#region Body Section.
List<DALC.Work_area> oList_DBEntries = _AppContext.Get_Work_area_By_WORK_AREA_ID_List_Adv(i_Params_Get_Work_area_By_WORK_AREA_ID_List.WORK_AREA_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_area = new Work_area();
oTools.CopyPropValues(oDBEntry, oWork_area);
oList.Add(oWork_area);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_WORK_AREA_ID_List_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_LISTING_ID_List_Adv(Params_Get_Boost_listing_By_BOOST_LISTING_ID_List i_Params_Get_Boost_listing_By_BOOST_LISTING_ID_List)
{
Boost_listing oBoost_listing = null;
List<Boost_listing> oList = new List<Boost_listing>();
Params_Get_Boost_listing_By_BOOST_LISTING_ID_List_SP oParams_Get_Boost_listing_By_BOOST_LISTING_ID_List_SP = new Params_Get_Boost_listing_By_BOOST_LISTING_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_BOOST_LISTING_ID_List_Adv");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_BOOST_LISTING_ID_List_Adv(i_Params_Get_Boost_listing_By_BOOST_LISTING_ID_List.BOOST_LISTING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_BOOST_LISTING_ID_List_Adv");}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_OWNER_ID_Adv(Params_Get_Boost_pricing_By_OWNER_ID i_Params_Get_Boost_pricing_By_OWNER_ID)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
Boost_pricing oBoost_pricing = new Boost_pricing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Boost_pricing> oList_DBEntries = _AppContext.Get_Boost_pricing_By_OWNER_ID_Adv(i_Params_Get_Boost_pricing_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry, oBoost_pricing);
oList.Add(oBoost_pricing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_OWNER_ID_Adv");}
return oList;
}
public List<Client> Get_Client_By_PHONE_NUMBER_Adv(Params_Get_Client_By_PHONE_NUMBER i_Params_Get_Client_By_PHONE_NUMBER)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_PHONE_NUMBER_Adv");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_PHONE_NUMBER_Adv(i_Params_Get_Client_By_PHONE_NUMBER.PHONE_NUMBER);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_PHONE_NUMBER_Adv");}
return oList;
}
public List<Client> Get_Client_By_OWNER_ID_Adv(Params_Get_Client_By_OWNER_ID i_Params_Get_Client_By_OWNER_ID)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_OWNER_ID_Adv(i_Params_Get_Client_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_OWNER_ID_Adv");}
return oList;
}
public List<Client> Get_Client_By_USERNAME_Adv(Params_Get_Client_By_USERNAME i_Params_Get_Client_By_USERNAME)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_USERNAME_Adv");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_USERNAME_Adv(i_Params_Get_Client_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_USERNAME_Adv");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_OWNER_ID_Adv(Params_Get_Service_prod_By_OWNER_ID i_Params_Get_Service_prod_By_OWNER_ID)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_OWNER_ID_Adv(i_Params_Get_Service_prod_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_OWNER_ID_Adv");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_BUSINESS_ID_Adv(Params_Get_Service_prod_By_BUSINESS_ID i_Params_Get_Service_prod_By_BUSINESS_ID)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_BUSINESS_ID_Adv");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_BUSINESS_ID_Adv(i_Params_Get_Service_prod_By_BUSINESS_ID.BUSINESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_BUSINESS_ID_Adv");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID_Adv(Params_Get_Service_prod_By_SUB_CATEGORY_ID i_Params_Get_Service_prod_By_SUB_CATEGORY_ID)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_SUB_CATEGORY_ID_Adv");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_SUB_CATEGORY_ID_Adv(i_Params_Get_Service_prod_By_SUB_CATEGORY_ID.SUB_CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_SUB_CATEGORY_ID_Adv");}
return oList;
}
public List<Admin> Get_Admin_By_OWNER_ID_Adv(Params_Get_Admin_By_OWNER_ID i_Params_Get_Admin_By_OWNER_ID)
{
List<Admin> oList = new List<Admin>();
Admin oAdmin = new Admin();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_OWNER_ID_Adv(i_Params_Get_Admin_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAdmin = new Admin();
oTools.CopyPropValues(oDBEntry, oAdmin);
oList.Add(oAdmin);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_OWNER_ID_Adv");}
return oList;
}
public List<Admin> Get_Admin_By_USERNAME_Adv(Params_Get_Admin_By_USERNAME i_Params_Get_Admin_By_USERNAME)
{
List<Admin> oList = new List<Admin>();
Admin oAdmin = new Admin();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_USERNAME_Adv");}
#region Body Section.
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_USERNAME_Adv(i_Params_Get_Admin_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAdmin = new Admin();
oTools.CopyPropValues(oDBEntry, oAdmin);
oList.Add(oAdmin);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_USERNAME_Adv");}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID_Adv(Params_Get_Category_By_OWNER_ID i_Params_Get_Category_By_OWNER_ID)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_OWNER_ID_Adv(i_Params_Get_Category_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_OWNER_ID_Adv");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_OWNER_ID_Adv(Params_Get_Sub_category_By_OWNER_ID i_Params_Get_Sub_category_By_OWNER_ID)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_OWNER_ID_Adv(i_Params_Get_Sub_category_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oSub_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oSub_category.My_Category);
oList.Add(oSub_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_OWNER_ID_Adv");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_CATEGORY_ID_Adv(Params_Get_Sub_category_By_CATEGORY_ID i_Params_Get_Sub_category_By_CATEGORY_ID)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_CATEGORY_ID_Adv");}
#region Body Section.
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_CATEGORY_ID_Adv(i_Params_Get_Sub_category_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oSub_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oSub_category.My_Category);
oList.Add(oSub_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_CATEGORY_ID_Adv");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_OWNER_ID_Adv(Params_Get_Coordinates_By_OWNER_ID i_Params_Get_Coordinates_By_OWNER_ID)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_OWNER_ID_Adv(i_Params_Get_Coordinates_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oCoordinates.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oCoordinates.My_Booking);
oList.Add(oCoordinates);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_OWNER_ID_Adv");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_BOOKING_ID_Adv(Params_Get_Coordinates_By_BOOKING_ID i_Params_Get_Coordinates_By_BOOKING_ID)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_BOOKING_ID_Adv");}
#region Body Section.
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_BOOKING_ID_Adv(i_Params_Get_Coordinates_By_BOOKING_ID.BOOKING_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oCoordinates.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oCoordinates.My_Booking);
oList.Add(oCoordinates);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_BOOKING_ID_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID_Adv(Params_Get_Currency_By_OWNER_ID i_Params_Get_Currency_By_OWNER_ID)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_OWNER_ID_Adv(i_Params_Get_Currency_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_OWNER_ID_Adv");}
return oList;
}
public List<Status> Get_Status_By_OWNER_ID_Adv(Params_Get_Status_By_OWNER_ID i_Params_Get_Status_By_OWNER_ID)
{
List<Status> oList = new List<Status>();
Status oStatus = new Status();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Status> oList_DBEntries = _AppContext.Get_Status_By_OWNER_ID_Adv(i_Params_Get_Status_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStatus = new Status();
oTools.CopyPropValues(oDBEntry, oStatus);
oList.Add(oStatus);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_OWNER_ID_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_OWNER_ID_Adv(Params_Get_Feedback_By_OWNER_ID i_Params_Get_Feedback_By_OWNER_ID)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_OWNER_ID_Adv(i_Params_Get_Feedback_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_OWNER_ID_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_BOOKING_ID_Adv(Params_Get_Feedback_By_BOOKING_ID i_Params_Get_Feedback_By_BOOKING_ID)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_BOOKING_ID_Adv");}
#region Body Section.
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_BOOKING_ID_Adv(i_Params_Get_Feedback_By_BOOKING_ID.BOOKING_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_BOOKING_ID_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_OWNER_ID_Adv(Params_Get_Booking_By_OWNER_ID i_Params_Get_Booking_By_OWNER_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_OWNER_ID_Adv(i_Params_Get_Booking_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_OWNER_ID_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_SERVICE_PROD_ID_Adv(Params_Get_Booking_By_SERVICE_PROD_ID i_Params_Get_Booking_By_SERVICE_PROD_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_SERVICE_PROD_ID_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_SERVICE_PROD_ID_Adv(i_Params_Get_Booking_By_SERVICE_PROD_ID.SERVICE_PROD_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_SERVICE_PROD_ID_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_CLIENT_ID_Adv(Params_Get_Booking_By_CLIENT_ID i_Params_Get_Booking_By_CLIENT_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_CLIENT_ID_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_CLIENT_ID_Adv(i_Params_Get_Booking_By_CLIENT_ID.CLIENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_CLIENT_ID_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_WORK_AREA_ID_Adv(Params_Get_Booking_By_WORK_AREA_ID i_Params_Get_Booking_By_WORK_AREA_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_WORK_AREA_ID_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_WORK_AREA_ID_Adv(i_Params_Get_Booking_By_WORK_AREA_ID.WORK_AREA_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_WORK_AREA_ID_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_STATUS_ID_Adv(Params_Get_Booking_By_STATUS_ID i_Params_Get_Booking_By_STATUS_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_STATUS_ID_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_STATUS_ID_Adv(i_Params_Get_Booking_By_STATUS_ID.STATUS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_STATUS_ID_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_BUSINESS_ID_Adv(Params_Get_Booking_By_BUSINESS_ID i_Params_Get_Booking_By_BUSINESS_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_BUSINESS_ID_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_BUSINESS_ID_Adv(i_Params_Get_Booking_By_BUSINESS_ID.BUSINESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_BUSINESS_ID_Adv");}
return oList;
}
public List<Business> Get_Business_By_USERNAME_Adv(Params_Get_Business_By_USERNAME i_Params_Get_Business_By_USERNAME)
{
List<Business> oList = new List<Business>();
Business oBusiness = new Business();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_USERNAME_Adv");}
#region Body Section.
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_USERNAME_Adv(i_Params_Get_Business_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBusiness = new Business();
oTools.CopyPropValues(oDBEntry, oBusiness);
oList.Add(oBusiness);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_USERNAME_Adv");}
return oList;
}
public List<Business> Get_Business_By_OWNER_ID_Adv(Params_Get_Business_By_OWNER_ID i_Params_Get_Business_By_OWNER_ID)
{
List<Business> oList = new List<Business>();
Business oBusiness = new Business();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_OWNER_ID_Adv(i_Params_Get_Business_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBusiness = new Business();
oTools.CopyPropValues(oDBEntry, oBusiness);
oList.Add(oBusiness);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_OWNER_ID_Adv");}
return oList;
}
public List<Work_list> Get_Work_list_By_OWNER_ID_Adv(Params_Get_Work_list_By_OWNER_ID i_Params_Get_Work_list_By_OWNER_ID)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_OWNER_ID_Adv(i_Params_Get_Work_list_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_OWNER_ID_Adv");}
return oList;
}
public List<Work_list> Get_Work_list_By_BUSINESS_ID_Adv(Params_Get_Work_list_By_BUSINESS_ID i_Params_Get_Work_list_By_BUSINESS_ID)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_BUSINESS_ID_Adv");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_BUSINESS_ID_Adv(i_Params_Get_Work_list_By_BUSINESS_ID.BUSINESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_BUSINESS_ID_Adv");}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_AREA_ID_Adv(Params_Get_Work_list_By_WORK_AREA_ID i_Params_Get_Work_list_By_WORK_AREA_ID)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_WORK_AREA_ID_Adv");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_WORK_AREA_ID_Adv(i_Params_Get_Work_list_By_WORK_AREA_ID.WORK_AREA_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_WORK_AREA_ID_Adv");}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID_Adv(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME_Adv");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME_Adv(i_Params_Get_User_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME_Adv");}
return oList;
}
public List<Work_area> Get_Work_area_By_OWNER_ID_Adv(Params_Get_Work_area_By_OWNER_ID i_Params_Get_Work_area_By_OWNER_ID)
{
List<Work_area> oList = new List<Work_area>();
Work_area oWork_area = new Work_area();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Work_area> oList_DBEntries = _AppContext.Get_Work_area_By_OWNER_ID_Adv(i_Params_Get_Work_area_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_area = new Work_area();
oTools.CopyPropValues(oDBEntry, oWork_area);
oList.Add(oWork_area);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_OWNER_ID_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_OWNER_ID_Adv(Params_Get_Boost_listing_By_OWNER_ID i_Params_Get_Boost_listing_By_OWNER_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_OWNER_ID_Adv");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_OWNER_ID_Adv(i_Params_Get_Boost_listing_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_OWNER_ID_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID_Adv(Params_Get_Boost_listing_By_SERVICE_PROD_ID i_Params_Get_Boost_listing_By_SERVICE_PROD_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_SERVICE_PROD_ID_Adv");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_SERVICE_PROD_ID_Adv(i_Params_Get_Boost_listing_By_SERVICE_PROD_ID.SERVICE_PROD_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_SERVICE_PROD_ID_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID_Adv(Params_Get_Boost_listing_By_BOOST_PRICING_ID i_Params_Get_Boost_listing_By_BOOST_PRICING_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_BOOST_PRICING_ID_Adv");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_BOOST_PRICING_ID_Adv(i_Params_Get_Boost_listing_By_BOOST_PRICING_ID.BOOST_PRICING_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_BOOST_PRICING_ID_Adv");}
return oList;
}
public List<Client> Get_Client_By_PHONE_NUMBER_List_Adv(Params_Get_Client_By_PHONE_NUMBER_List i_Params_Get_Client_By_PHONE_NUMBER_List)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_PHONE_NUMBER_List_Adv");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_PHONE_NUMBER_List_Adv(i_Params_Get_Client_By_PHONE_NUMBER_List.PHONE_NUMBER_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_PHONE_NUMBER_List_Adv");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_BUSINESS_ID_List_Adv(Params_Get_Service_prod_By_BUSINESS_ID_List i_Params_Get_Service_prod_By_BUSINESS_ID_List)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_BUSINESS_ID_List_Adv");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_BUSINESS_ID_List_Adv(i_Params_Get_Service_prod_By_BUSINESS_ID_List.BUSINESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_BUSINESS_ID_List_Adv");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID_List_Adv(Params_Get_Service_prod_By_SUB_CATEGORY_ID_List i_Params_Get_Service_prod_By_SUB_CATEGORY_ID_List)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_SUB_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_SUB_CATEGORY_ID_List_Adv(i_Params_Get_Service_prod_By_SUB_CATEGORY_ID_List.SUB_CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_SUB_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_CATEGORY_ID_List_Adv(Params_Get_Sub_category_By_CATEGORY_ID_List i_Params_Get_Sub_category_By_CATEGORY_ID_List)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_CATEGORY_ID_List_Adv");}
#region Body Section.
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_CATEGORY_ID_List_Adv(i_Params_Get_Sub_category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oSub_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oSub_category.My_Category);
oList.Add(oSub_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_CATEGORY_ID_List_Adv");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_BOOKING_ID_List_Adv(Params_Get_Coordinates_By_BOOKING_ID_List i_Params_Get_Coordinates_By_BOOKING_ID_List)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_BOOKING_ID_List_Adv");}
#region Body Section.
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_BOOKING_ID_List_Adv(i_Params_Get_Coordinates_By_BOOKING_ID_List.BOOKING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oCoordinates.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oCoordinates.My_Booking);
oList.Add(oCoordinates);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_BOOKING_ID_List_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_BOOKING_ID_List_Adv(Params_Get_Feedback_By_BOOKING_ID_List i_Params_Get_Feedback_By_BOOKING_ID_List)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_BOOKING_ID_List_Adv");}
#region Body Section.
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_BOOKING_ID_List_Adv(i_Params_Get_Feedback_By_BOOKING_ID_List.BOOKING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_BOOKING_ID_List_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_SERVICE_PROD_ID_List_Adv(Params_Get_Booking_By_SERVICE_PROD_ID_List i_Params_Get_Booking_By_SERVICE_PROD_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_SERVICE_PROD_ID_List_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_SERVICE_PROD_ID_List_Adv(i_Params_Get_Booking_By_SERVICE_PROD_ID_List.SERVICE_PROD_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_SERVICE_PROD_ID_List_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_CLIENT_ID_List_Adv(Params_Get_Booking_By_CLIENT_ID_List i_Params_Get_Booking_By_CLIENT_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_CLIENT_ID_List_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_CLIENT_ID_List_Adv(i_Params_Get_Booking_By_CLIENT_ID_List.CLIENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_CLIENT_ID_List_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_WORK_AREA_ID_List_Adv(Params_Get_Booking_By_WORK_AREA_ID_List i_Params_Get_Booking_By_WORK_AREA_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_WORK_AREA_ID_List_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_WORK_AREA_ID_List_Adv(i_Params_Get_Booking_By_WORK_AREA_ID_List.WORK_AREA_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_WORK_AREA_ID_List_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_STATUS_ID_List_Adv(Params_Get_Booking_By_STATUS_ID_List i_Params_Get_Booking_By_STATUS_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_STATUS_ID_List_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_STATUS_ID_List_Adv(i_Params_Get_Booking_By_STATUS_ID_List.STATUS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_STATUS_ID_List_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_BUSINESS_ID_List_Adv(Params_Get_Booking_By_BUSINESS_ID_List i_Params_Get_Booking_By_BUSINESS_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_BUSINESS_ID_List_Adv");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_BUSINESS_ID_List_Adv(i_Params_Get_Booking_By_BUSINESS_ID_List.BUSINESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_BUSINESS_ID_List_Adv");}
return oList;
}
public List<Work_list> Get_Work_list_By_BUSINESS_ID_List_Adv(Params_Get_Work_list_By_BUSINESS_ID_List i_Params_Get_Work_list_By_BUSINESS_ID_List)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_BUSINESS_ID_List_Adv");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_BUSINESS_ID_List_Adv(i_Params_Get_Work_list_By_BUSINESS_ID_List.BUSINESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_BUSINESS_ID_List_Adv");}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_AREA_ID_List_Adv(Params_Get_Work_list_By_WORK_AREA_ID_List i_Params_Get_Work_list_By_WORK_AREA_ID_List)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_WORK_AREA_ID_List_Adv");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_WORK_AREA_ID_List_Adv(i_Params_Get_Work_list_By_WORK_AREA_ID_List.WORK_AREA_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_WORK_AREA_ID_List_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID_List_Adv(Params_Get_Boost_listing_By_SERVICE_PROD_ID_List i_Params_Get_Boost_listing_By_SERVICE_PROD_ID_List)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_SERVICE_PROD_ID_List_Adv");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_SERVICE_PROD_ID_List_Adv(i_Params_Get_Boost_listing_By_SERVICE_PROD_ID_List.SERVICE_PROD_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_SERVICE_PROD_ID_List_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID_List_Adv(Params_Get_Boost_listing_By_BOOST_PRICING_ID_List i_Params_Get_Boost_listing_By_BOOST_PRICING_ID_List)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_BOOST_PRICING_ID_List_Adv");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_BOOST_PRICING_ID_List_Adv(i_Params_Get_Boost_listing_By_BOOST_PRICING_ID_List.BOOST_PRICING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_BOOST_PRICING_ID_List_Adv");}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_Criteria_Adv(Params_Get_Boost_pricing_By_Criteria i_Params_Get_Boost_pricing_By_Criteria)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
long? tmp_TOTAL_COUNT = 0;
Boost_pricing oBoost_pricing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Boost_pricing_By_Criteria.OWNER_ID == null) || (i_Params_Get_Boost_pricing_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Boost_pricing_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_pricing_By_Criteria.START_ROW == null) { i_Params_Get_Boost_pricing_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Boost_pricing_By_Criteria.END_ROW == null) || (i_Params_Get_Boost_pricing_By_Criteria.END_ROW == 0)) { i_Params_Get_Boost_pricing_By_Criteria.END_ROW = 1000000; }
List<DALC.Boost_pricing> oList_DBEntries = _AppContext.Get_Boost_pricing_By_Criteria_Adv(i_Params_Get_Boost_pricing_By_Criteria.NAME,i_Params_Get_Boost_pricing_By_Criteria.DESCRIPTION,i_Params_Get_Boost_pricing_By_Criteria.OWNER_ID,i_Params_Get_Boost_pricing_By_Criteria.START_ROW,i_Params_Get_Boost_pricing_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry, oBoost_pricing);
oList.Add(oBoost_pricing);
}
}
i_Params_Get_Boost_pricing_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_Criteria_Adv");}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_Where_Adv(Params_Get_Boost_pricing_By_Where i_Params_Get_Boost_pricing_By_Where)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
long? tmp_TOTAL_COUNT = 0;
Boost_pricing oBoost_pricing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Boost_pricing_By_Where.OWNER_ID == null) || (i_Params_Get_Boost_pricing_By_Where.OWNER_ID == 0)) { i_Params_Get_Boost_pricing_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_pricing_By_Where.START_ROW == null) { i_Params_Get_Boost_pricing_By_Where.START_ROW = 0; }
if ((i_Params_Get_Boost_pricing_By_Where.END_ROW == null) || (i_Params_Get_Boost_pricing_By_Where.END_ROW == 0)) { i_Params_Get_Boost_pricing_By_Where.END_ROW = 1000000; }
List<DALC.Boost_pricing> oList_DBEntries = _AppContext.Get_Boost_pricing_By_Where_Adv(i_Params_Get_Boost_pricing_By_Where.NAME,i_Params_Get_Boost_pricing_By_Where.DESCRIPTION,i_Params_Get_Boost_pricing_By_Where.OWNER_ID,i_Params_Get_Boost_pricing_By_Where.START_ROW,i_Params_Get_Boost_pricing_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry, oBoost_pricing);
oList.Add(oBoost_pricing);
}
}
i_Params_Get_Boost_pricing_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_Where_Adv");}
return oList;
}
public List<Client> Get_Client_By_Criteria_Adv(Params_Get_Client_By_Criteria i_Params_Get_Client_By_Criteria)
{
List<Client> oList = new List<Client>();
long? tmp_TOTAL_COUNT = 0;
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria.START_ROW == null) { i_Params_Get_Client_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria.END_ROW == null) || (i_Params_Get_Client_By_Criteria.END_ROW == 0)) { i_Params_Get_Client_By_Criteria.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria_Adv(i_Params_Get_Client_By_Criteria.FIRST_NAME,i_Params_Get_Client_By_Criteria.LAST_NAME,i_Params_Get_Client_By_Criteria.USERNAME,i_Params_Get_Client_By_Criteria.PASSWORD,i_Params_Get_Client_By_Criteria.EMAIL,i_Params_Get_Client_By_Criteria.OWNER_ID,i_Params_Get_Client_By_Criteria.START_ROW,i_Params_Get_Client_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria_Adv");}
return oList;
}
public List<Client> Get_Client_By_Where_Adv(Params_Get_Client_By_Where i_Params_Get_Client_By_Where)
{
List<Client> oList = new List<Client>();
long? tmp_TOTAL_COUNT = 0;
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Client_By_Where.OWNER_ID == null) || (i_Params_Get_Client_By_Where.OWNER_ID == 0)) { i_Params_Get_Client_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where.START_ROW == null) { i_Params_Get_Client_By_Where.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where.END_ROW == null) || (i_Params_Get_Client_By_Where.END_ROW == 0)) { i_Params_Get_Client_By_Where.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where_Adv(i_Params_Get_Client_By_Where.FIRST_NAME,i_Params_Get_Client_By_Where.LAST_NAME,i_Params_Get_Client_By_Where.USERNAME,i_Params_Get_Client_By_Where.PASSWORD,i_Params_Get_Client_By_Where.EMAIL,i_Params_Get_Client_By_Where.OWNER_ID,i_Params_Get_Client_By_Where.START_ROW,i_Params_Get_Client_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where_Adv");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_Criteria_Adv(Params_Get_Service_prod_By_Criteria i_Params_Get_Service_prod_By_Criteria)
{
List<Service_prod> oList = new List<Service_prod>();
long? tmp_TOTAL_COUNT = 0;
Service_prod oService_prod = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Service_prod_By_Criteria.OWNER_ID == null) || (i_Params_Get_Service_prod_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Service_prod_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Service_prod_By_Criteria.START_ROW == null) { i_Params_Get_Service_prod_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Service_prod_By_Criteria.END_ROW == null) || (i_Params_Get_Service_prod_By_Criteria.END_ROW == 0)) { i_Params_Get_Service_prod_By_Criteria.END_ROW = 1000000; }
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_Criteria_Adv(i_Params_Get_Service_prod_By_Criteria.NAME,i_Params_Get_Service_prod_By_Criteria.DESCRIPTION,i_Params_Get_Service_prod_By_Criteria.OWNER_ID,i_Params_Get_Service_prod_By_Criteria.START_ROW,i_Params_Get_Service_prod_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
i_Params_Get_Service_prod_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_Criteria_Adv");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_Where_Adv(Params_Get_Service_prod_By_Where i_Params_Get_Service_prod_By_Where)
{
List<Service_prod> oList = new List<Service_prod>();
long? tmp_TOTAL_COUNT = 0;
Service_prod oService_prod = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Service_prod_By_Where.OWNER_ID == null) || (i_Params_Get_Service_prod_By_Where.OWNER_ID == 0)) { i_Params_Get_Service_prod_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Service_prod_By_Where.START_ROW == null) { i_Params_Get_Service_prod_By_Where.START_ROW = 0; }
if ((i_Params_Get_Service_prod_By_Where.END_ROW == null) || (i_Params_Get_Service_prod_By_Where.END_ROW == 0)) { i_Params_Get_Service_prod_By_Where.END_ROW = 1000000; }
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_Where_Adv(i_Params_Get_Service_prod_By_Where.NAME,i_Params_Get_Service_prod_By_Where.DESCRIPTION,i_Params_Get_Service_prod_By_Where.OWNER_ID,i_Params_Get_Service_prod_By_Where.START_ROW,i_Params_Get_Service_prod_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
i_Params_Get_Service_prod_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_Where_Adv");}
return oList;
}
public List<Admin> Get_Admin_By_Criteria_Adv(Params_Get_Admin_By_Criteria i_Params_Get_Admin_By_Criteria)
{
List<Admin> oList = new List<Admin>();
long? tmp_TOTAL_COUNT = 0;
Admin oAdmin = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Admin_By_Criteria.OWNER_ID == null) || (i_Params_Get_Admin_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Admin_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Admin_By_Criteria.START_ROW == null) { i_Params_Get_Admin_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Admin_By_Criteria.END_ROW == null) || (i_Params_Get_Admin_By_Criteria.END_ROW == 0)) { i_Params_Get_Admin_By_Criteria.END_ROW = 1000000; }
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_Criteria_Adv(i_Params_Get_Admin_By_Criteria.FIRST_NAME,i_Params_Get_Admin_By_Criteria.LAST_NAME,i_Params_Get_Admin_By_Criteria.USERNAME,i_Params_Get_Admin_By_Criteria.PASSWORD,i_Params_Get_Admin_By_Criteria.EMAIL,i_Params_Get_Admin_By_Criteria.OWNER_ID,i_Params_Get_Admin_By_Criteria.START_ROW,i_Params_Get_Admin_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAdmin = new Admin();
oTools.CopyPropValues(oDBEntry, oAdmin);
oList.Add(oAdmin);
}
}
i_Params_Get_Admin_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_Criteria_Adv");}
return oList;
}
public List<Admin> Get_Admin_By_Where_Adv(Params_Get_Admin_By_Where i_Params_Get_Admin_By_Where)
{
List<Admin> oList = new List<Admin>();
long? tmp_TOTAL_COUNT = 0;
Admin oAdmin = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Admin_By_Where.OWNER_ID == null) || (i_Params_Get_Admin_By_Where.OWNER_ID == 0)) { i_Params_Get_Admin_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Admin_By_Where.START_ROW == null) { i_Params_Get_Admin_By_Where.START_ROW = 0; }
if ((i_Params_Get_Admin_By_Where.END_ROW == null) || (i_Params_Get_Admin_By_Where.END_ROW == 0)) { i_Params_Get_Admin_By_Where.END_ROW = 1000000; }
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_Where_Adv(i_Params_Get_Admin_By_Where.FIRST_NAME,i_Params_Get_Admin_By_Where.LAST_NAME,i_Params_Get_Admin_By_Where.USERNAME,i_Params_Get_Admin_By_Where.PASSWORD,i_Params_Get_Admin_By_Where.EMAIL,i_Params_Get_Admin_By_Where.OWNER_ID,i_Params_Get_Admin_By_Where.START_ROW,i_Params_Get_Admin_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAdmin = new Admin();
oTools.CopyPropValues(oDBEntry, oAdmin);
oList.Add(oAdmin);
}
}
i_Params_Get_Admin_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_Where_Adv");}
return oList;
}
public List<Category> Get_Category_By_Criteria_Adv(Params_Get_Category_By_Criteria i_Params_Get_Category_By_Criteria)
{
List<Category> oList = new List<Category>();
long? tmp_TOTAL_COUNT = 0;
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Criteria.START_ROW == null) { i_Params_Get_Category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Category_By_Criteria.END_ROW == null) || (i_Params_Get_Category_By_Criteria.END_ROW == 0)) { i_Params_Get_Category_By_Criteria.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Criteria_Adv(i_Params_Get_Category_By_Criteria.NAME,i_Params_Get_Category_By_Criteria.DESCRIPTION,i_Params_Get_Category_By_Criteria.OWNER_ID,i_Params_Get_Category_By_Criteria.START_ROW,i_Params_Get_Category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
i_Params_Get_Category_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Criteria_Adv");}
return oList;
}
public List<Category> Get_Category_By_Where_Adv(Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
List<Category> oList = new List<Category>();
long? tmp_TOTAL_COUNT = 0;
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Category_By_Where.OWNER_ID == null) || (i_Params_Get_Category_By_Where.OWNER_ID == 0)) { i_Params_Get_Category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Where.START_ROW == null) { i_Params_Get_Category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Category_By_Where.END_ROW == null) || (i_Params_Get_Category_By_Where.END_ROW == 0)) { i_Params_Get_Category_By_Where.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Where_Adv(i_Params_Get_Category_By_Where.NAME,i_Params_Get_Category_By_Where.DESCRIPTION,i_Params_Get_Category_By_Where.OWNER_ID,i_Params_Get_Category_By_Where.START_ROW,i_Params_Get_Category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
oList.Add(oCategory);
}
}
i_Params_Get_Category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Where_Adv");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_Criteria_Adv(Params_Get_Sub_category_By_Criteria i_Params_Get_Sub_category_By_Criteria)
{
List<Sub_category> oList = new List<Sub_category>();
long? tmp_TOTAL_COUNT = 0;
Sub_category oSub_category = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Sub_category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Sub_category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Sub_category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Sub_category_By_Criteria.START_ROW == null) { i_Params_Get_Sub_category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Sub_category_By_Criteria.END_ROW == null) || (i_Params_Get_Sub_category_By_Criteria.END_ROW == 0)) { i_Params_Get_Sub_category_By_Criteria.END_ROW = 1000000; }
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_Criteria_Adv(i_Params_Get_Sub_category_By_Criteria.NAME,i_Params_Get_Sub_category_By_Criteria.DESCRIPTION,i_Params_Get_Sub_category_By_Criteria.OWNER_ID,i_Params_Get_Sub_category_By_Criteria.START_ROW,i_Params_Get_Sub_category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oSub_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oSub_category.My_Category);
oList.Add(oSub_category);
}
}
i_Params_Get_Sub_category_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_Criteria_Adv");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_Where_Adv(Params_Get_Sub_category_By_Where i_Params_Get_Sub_category_By_Where)
{
List<Sub_category> oList = new List<Sub_category>();
long? tmp_TOTAL_COUNT = 0;
Sub_category oSub_category = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Sub_category_By_Where.OWNER_ID == null) || (i_Params_Get_Sub_category_By_Where.OWNER_ID == 0)) { i_Params_Get_Sub_category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Sub_category_By_Where.START_ROW == null) { i_Params_Get_Sub_category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Sub_category_By_Where.END_ROW == null) || (i_Params_Get_Sub_category_By_Where.END_ROW == 0)) { i_Params_Get_Sub_category_By_Where.END_ROW = 1000000; }
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_Where_Adv(i_Params_Get_Sub_category_By_Where.NAME,i_Params_Get_Sub_category_By_Where.DESCRIPTION,i_Params_Get_Sub_category_By_Where.OWNER_ID,i_Params_Get_Sub_category_By_Where.START_ROW,i_Params_Get_Sub_category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oSub_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oSub_category.My_Category);
oList.Add(oSub_category);
}
}
i_Params_Get_Sub_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_Where_Adv");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_Criteria_Adv(Params_Get_Coordinates_By_Criteria i_Params_Get_Coordinates_By_Criteria)
{
List<Coordinates> oList = new List<Coordinates>();
long? tmp_TOTAL_COUNT = 0;
Coordinates oCoordinates = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Coordinates_By_Criteria.OWNER_ID == null) || (i_Params_Get_Coordinates_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Coordinates_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coordinates_By_Criteria.START_ROW == null) { i_Params_Get_Coordinates_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Coordinates_By_Criteria.END_ROW == null) || (i_Params_Get_Coordinates_By_Criteria.END_ROW == 0)) { i_Params_Get_Coordinates_By_Criteria.END_ROW = 1000000; }
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_Criteria_Adv(i_Params_Get_Coordinates_By_Criteria.LONGITUDE,i_Params_Get_Coordinates_By_Criteria.LATITUDE,i_Params_Get_Coordinates_By_Criteria.DESCRIPTION,i_Params_Get_Coordinates_By_Criteria.OWNER_ID,i_Params_Get_Coordinates_By_Criteria.START_ROW,i_Params_Get_Coordinates_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oCoordinates.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oCoordinates.My_Booking);
oList.Add(oCoordinates);
}
}
i_Params_Get_Coordinates_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_Criteria_Adv");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_Where_Adv(Params_Get_Coordinates_By_Where i_Params_Get_Coordinates_By_Where)
{
List<Coordinates> oList = new List<Coordinates>();
long? tmp_TOTAL_COUNT = 0;
Coordinates oCoordinates = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Coordinates_By_Where.OWNER_ID == null) || (i_Params_Get_Coordinates_By_Where.OWNER_ID == 0)) { i_Params_Get_Coordinates_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coordinates_By_Where.START_ROW == null) { i_Params_Get_Coordinates_By_Where.START_ROW = 0; }
if ((i_Params_Get_Coordinates_By_Where.END_ROW == null) || (i_Params_Get_Coordinates_By_Where.END_ROW == 0)) { i_Params_Get_Coordinates_By_Where.END_ROW = 1000000; }
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_Where_Adv(i_Params_Get_Coordinates_By_Where.LONGITUDE,i_Params_Get_Coordinates_By_Where.LATITUDE,i_Params_Get_Coordinates_By_Where.DESCRIPTION,i_Params_Get_Coordinates_By_Where.OWNER_ID,i_Params_Get_Coordinates_By_Where.START_ROW,i_Params_Get_Coordinates_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oCoordinates.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oCoordinates.My_Booking);
oList.Add(oCoordinates);
}
}
i_Params_Get_Coordinates_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_Where_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_Criteria_Adv(Params_Get_Currency_By_Criteria i_Params_Get_Currency_By_Criteria)
{
List<Currency> oList = new List<Currency>();
long? tmp_TOTAL_COUNT = 0;
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Currency_By_Criteria.OWNER_ID == null) || (i_Params_Get_Currency_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Currency_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Criteria.START_ROW == null) { i_Params_Get_Currency_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Criteria.END_ROW == null) || (i_Params_Get_Currency_By_Criteria.END_ROW == 0)) { i_Params_Get_Currency_By_Criteria.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Criteria_Adv(i_Params_Get_Currency_By_Criteria.NAME,i_Params_Get_Currency_By_Criteria.SYMBOL,i_Params_Get_Currency_By_Criteria.ACRONYM,i_Params_Get_Currency_By_Criteria.DESCRIPTION,i_Params_Get_Currency_By_Criteria.OWNER_ID,i_Params_Get_Currency_By_Criteria.START_ROW,i_Params_Get_Currency_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
i_Params_Get_Currency_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Criteria_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_Where_Adv(Params_Get_Currency_By_Where i_Params_Get_Currency_By_Where)
{
List<Currency> oList = new List<Currency>();
long? tmp_TOTAL_COUNT = 0;
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Currency_By_Where.OWNER_ID == null) || (i_Params_Get_Currency_By_Where.OWNER_ID == 0)) { i_Params_Get_Currency_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Where.START_ROW == null) { i_Params_Get_Currency_By_Where.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Where.END_ROW == null) || (i_Params_Get_Currency_By_Where.END_ROW == 0)) { i_Params_Get_Currency_By_Where.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Where_Adv(i_Params_Get_Currency_By_Where.NAME,i_Params_Get_Currency_By_Where.SYMBOL,i_Params_Get_Currency_By_Where.ACRONYM,i_Params_Get_Currency_By_Where.DESCRIPTION,i_Params_Get_Currency_By_Where.OWNER_ID,i_Params_Get_Currency_By_Where.START_ROW,i_Params_Get_Currency_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
i_Params_Get_Currency_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Where_Adv");}
return oList;
}
public List<Status> Get_Status_By_Criteria_Adv(Params_Get_Status_By_Criteria i_Params_Get_Status_By_Criteria)
{
List<Status> oList = new List<Status>();
long? tmp_TOTAL_COUNT = 0;
Status oStatus = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Status_By_Criteria.OWNER_ID == null) || (i_Params_Get_Status_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Status_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Status_By_Criteria.START_ROW == null) { i_Params_Get_Status_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Status_By_Criteria.END_ROW == null) || (i_Params_Get_Status_By_Criteria.END_ROW == 0)) { i_Params_Get_Status_By_Criteria.END_ROW = 1000000; }
List<DALC.Status> oList_DBEntries = _AppContext.Get_Status_By_Criteria_Adv(i_Params_Get_Status_By_Criteria.NAME,i_Params_Get_Status_By_Criteria.DESCRIPTION,i_Params_Get_Status_By_Criteria.OWNER_ID,i_Params_Get_Status_By_Criteria.START_ROW,i_Params_Get_Status_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStatus = new Status();
oTools.CopyPropValues(oDBEntry, oStatus);
oList.Add(oStatus);
}
}
i_Params_Get_Status_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_Criteria_Adv");}
return oList;
}
public List<Status> Get_Status_By_Where_Adv(Params_Get_Status_By_Where i_Params_Get_Status_By_Where)
{
List<Status> oList = new List<Status>();
long? tmp_TOTAL_COUNT = 0;
Status oStatus = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Status_By_Where.OWNER_ID == null) || (i_Params_Get_Status_By_Where.OWNER_ID == 0)) { i_Params_Get_Status_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Status_By_Where.START_ROW == null) { i_Params_Get_Status_By_Where.START_ROW = 0; }
if ((i_Params_Get_Status_By_Where.END_ROW == null) || (i_Params_Get_Status_By_Where.END_ROW == 0)) { i_Params_Get_Status_By_Where.END_ROW = 1000000; }
List<DALC.Status> oList_DBEntries = _AppContext.Get_Status_By_Where_Adv(i_Params_Get_Status_By_Where.NAME,i_Params_Get_Status_By_Where.DESCRIPTION,i_Params_Get_Status_By_Where.OWNER_ID,i_Params_Get_Status_By_Where.START_ROW,i_Params_Get_Status_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStatus = new Status();
oTools.CopyPropValues(oDBEntry, oStatus);
oList.Add(oStatus);
}
}
i_Params_Get_Status_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_Where_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_Adv(Params_Get_Feedback_By_Criteria i_Params_Get_Feedback_By_Criteria)
{
List<Feedback> oList = new List<Feedback>();
long? tmp_TOTAL_COUNT = 0;
Feedback oFeedback = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Criteria.OWNER_ID == null) || (i_Params_Get_Feedback_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Criteria.START_ROW == null) { i_Params_Get_Feedback_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Criteria.END_ROW == null) || (i_Params_Get_Feedback_By_Criteria.END_ROW == 0)) { i_Params_Get_Feedback_By_Criteria.END_ROW = 1000000; }
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Criteria_Adv(i_Params_Get_Feedback_By_Criteria.COMMENT,i_Params_Get_Feedback_By_Criteria.DESCRIPTION,i_Params_Get_Feedback_By_Criteria.OWNER_ID,i_Params_Get_Feedback_By_Criteria.START_ROW,i_Params_Get_Feedback_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Criteria_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_Where_Adv(Params_Get_Feedback_By_Where i_Params_Get_Feedback_By_Where)
{
List<Feedback> oList = new List<Feedback>();
long? tmp_TOTAL_COUNT = 0;
Feedback oFeedback = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Where.OWNER_ID == null) || (i_Params_Get_Feedback_By_Where.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Where.START_ROW == null) { i_Params_Get_Feedback_By_Where.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Where.END_ROW == null) || (i_Params_Get_Feedback_By_Where.END_ROW == 0)) { i_Params_Get_Feedback_By_Where.END_ROW = 1000000; }
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Where_Adv(i_Params_Get_Feedback_By_Where.COMMENT,i_Params_Get_Feedback_By_Where.DESCRIPTION,i_Params_Get_Feedback_By_Where.OWNER_ID,i_Params_Get_Feedback_By_Where.START_ROW,i_Params_Get_Feedback_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Where_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_Adv_V2(Params_Get_Feedback_By_Criteria_V2 i_Params_Get_Feedback_By_Criteria_V2)
{
List<Feedback> oList = new List<Feedback>();
long? tmp_TOTAL_COUNT = 0;
Feedback oFeedback = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Criteria_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Feedback_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Criteria_V2.START_ROW == null) { i_Params_Get_Feedback_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Feedback_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Feedback_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Criteria_Adv_V2(i_Params_Get_Feedback_By_Criteria_V2.COMMENT,i_Params_Get_Feedback_By_Criteria_V2.DATE,i_Params_Get_Feedback_By_Criteria_V2.DESCRIPTION,i_Params_Get_Feedback_By_Criteria_V2.OWNER_ID,i_Params_Get_Feedback_By_Criteria_V2.START_ROW,i_Params_Get_Feedback_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Criteria_Adv_V2");}
return oList;
}
public List<Feedback> Get_Feedback_By_Where_Adv_V2(Params_Get_Feedback_By_Where_V2 i_Params_Get_Feedback_By_Where_V2)
{
List<Feedback> oList = new List<Feedback>();
long? tmp_TOTAL_COUNT = 0;
Feedback oFeedback = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Where_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Feedback_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Where_V2.START_ROW == null) { i_Params_Get_Feedback_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Where_V2.END_ROW == null) || (i_Params_Get_Feedback_By_Where_V2.END_ROW == 0)) { i_Params_Get_Feedback_By_Where_V2.END_ROW = 1000000; }
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Where_Adv_V2(i_Params_Get_Feedback_By_Where_V2.COMMENT,i_Params_Get_Feedback_By_Where_V2.DATE,i_Params_Get_Feedback_By_Where_V2.DESCRIPTION,i_Params_Get_Feedback_By_Where_V2.OWNER_ID,i_Params_Get_Feedback_By_Where_V2.START_ROW,i_Params_Get_Feedback_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Where_Adv_V2");}
return oList;
}
public List<Booking> Get_Booking_By_Criteria_Adv(Params_Get_Booking_By_Criteria i_Params_Get_Booking_By_Criteria)
{
List<Booking> oList = new List<Booking>();
long? tmp_TOTAL_COUNT = 0;
Booking oBooking = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Booking_By_Criteria.OWNER_ID == null) || (i_Params_Get_Booking_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Booking_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Criteria.START_ROW == null) { i_Params_Get_Booking_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Criteria.END_ROW == null) || (i_Params_Get_Booking_By_Criteria.END_ROW == 0)) { i_Params_Get_Booking_By_Criteria.END_ROW = 1000000; }
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Criteria_Adv(i_Params_Get_Booking_By_Criteria.DESCRIPTION,i_Params_Get_Booking_By_Criteria.OWNER_ID,i_Params_Get_Booking_By_Criteria.START_ROW,i_Params_Get_Booking_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Criteria_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_Where_Adv(Params_Get_Booking_By_Where i_Params_Get_Booking_By_Where)
{
List<Booking> oList = new List<Booking>();
long? tmp_TOTAL_COUNT = 0;
Booking oBooking = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Booking_By_Where.OWNER_ID == null) || (i_Params_Get_Booking_By_Where.OWNER_ID == 0)) { i_Params_Get_Booking_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Where.START_ROW == null) { i_Params_Get_Booking_By_Where.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Where.END_ROW == null) || (i_Params_Get_Booking_By_Where.END_ROW == 0)) { i_Params_Get_Booking_By_Where.END_ROW = 1000000; }
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Where_Adv(i_Params_Get_Booking_By_Where.DESCRIPTION,i_Params_Get_Booking_By_Where.OWNER_ID,i_Params_Get_Booking_By_Where.START_ROW,i_Params_Get_Booking_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Where_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_Criteria_Adv_V2(Params_Get_Booking_By_Criteria_V2 i_Params_Get_Booking_By_Criteria_V2)
{
List<Booking> oList = new List<Booking>();
long? tmp_TOTAL_COUNT = 0;
Booking oBooking = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Criteria_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Booking_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Booking_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Booking_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Criteria_V2.START_ROW == null) { i_Params_Get_Booking_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Booking_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Booking_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Criteria_Adv_V2(i_Params_Get_Booking_By_Criteria_V2.DATE,i_Params_Get_Booking_By_Criteria_V2.DESCRIPTION,i_Params_Get_Booking_By_Criteria_V2.OWNER_ID,i_Params_Get_Booking_By_Criteria_V2.START_ROW,i_Params_Get_Booking_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Criteria_Adv_V2");}
return oList;
}
public List<Booking> Get_Booking_By_Where_Adv_V2(Params_Get_Booking_By_Where_V2 i_Params_Get_Booking_By_Where_V2)
{
List<Booking> oList = new List<Booking>();
long? tmp_TOTAL_COUNT = 0;
Booking oBooking = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Where_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Booking_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Booking_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Booking_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Where_V2.START_ROW == null) { i_Params_Get_Booking_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Where_V2.END_ROW == null) || (i_Params_Get_Booking_By_Where_V2.END_ROW == 0)) { i_Params_Get_Booking_By_Where_V2.END_ROW = 1000000; }
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Where_Adv_V2(i_Params_Get_Booking_By_Where_V2.DATE,i_Params_Get_Booking_By_Where_V2.DESCRIPTION,i_Params_Get_Booking_By_Where_V2.OWNER_ID,i_Params_Get_Booking_By_Where_V2.START_ROW,i_Params_Get_Booking_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Where_Adv_V2");}
return oList;
}
public List<Business> Get_Business_By_Criteria_Adv(Params_Get_Business_By_Criteria i_Params_Get_Business_By_Criteria)
{
List<Business> oList = new List<Business>();
long? tmp_TOTAL_COUNT = 0;
Business oBusiness = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Business_By_Criteria.OWNER_ID == null) || (i_Params_Get_Business_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Business_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Business_By_Criteria.START_ROW == null) { i_Params_Get_Business_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Business_By_Criteria.END_ROW == null) || (i_Params_Get_Business_By_Criteria.END_ROW == 0)) { i_Params_Get_Business_By_Criteria.END_ROW = 1000000; }
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_Criteria_Adv(i_Params_Get_Business_By_Criteria.NAME,i_Params_Get_Business_By_Criteria.USERNAME,i_Params_Get_Business_By_Criteria.PASSWORD,i_Params_Get_Business_By_Criteria.EMAIL,i_Params_Get_Business_By_Criteria.DESCRIPTION,i_Params_Get_Business_By_Criteria.OWNER_ID,i_Params_Get_Business_By_Criteria.START_ROW,i_Params_Get_Business_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBusiness = new Business();
oTools.CopyPropValues(oDBEntry, oBusiness);
oList.Add(oBusiness);
}
}
i_Params_Get_Business_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_Criteria_Adv");}
return oList;
}
public List<Business> Get_Business_By_Where_Adv(Params_Get_Business_By_Where i_Params_Get_Business_By_Where)
{
List<Business> oList = new List<Business>();
long? tmp_TOTAL_COUNT = 0;
Business oBusiness = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Business_By_Where.OWNER_ID == null) || (i_Params_Get_Business_By_Where.OWNER_ID == 0)) { i_Params_Get_Business_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Business_By_Where.START_ROW == null) { i_Params_Get_Business_By_Where.START_ROW = 0; }
if ((i_Params_Get_Business_By_Where.END_ROW == null) || (i_Params_Get_Business_By_Where.END_ROW == 0)) { i_Params_Get_Business_By_Where.END_ROW = 1000000; }
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_Where_Adv(i_Params_Get_Business_By_Where.NAME,i_Params_Get_Business_By_Where.USERNAME,i_Params_Get_Business_By_Where.PASSWORD,i_Params_Get_Business_By_Where.EMAIL,i_Params_Get_Business_By_Where.DESCRIPTION,i_Params_Get_Business_By_Where.OWNER_ID,i_Params_Get_Business_By_Where.START_ROW,i_Params_Get_Business_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBusiness = new Business();
oTools.CopyPropValues(oDBEntry, oBusiness);
oList.Add(oBusiness);
}
}
i_Params_Get_Business_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_Where_Adv");}
return oList;
}
public List<Work_list> Get_Work_list_By_Criteria_Adv(Params_Get_Work_list_By_Criteria i_Params_Get_Work_list_By_Criteria)
{
List<Work_list> oList = new List<Work_list>();
long? tmp_TOTAL_COUNT = 0;
Work_list oWork_list = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Work_list_By_Criteria.OWNER_ID == null) || (i_Params_Get_Work_list_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Work_list_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_list_By_Criteria.START_ROW == null) { i_Params_Get_Work_list_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Work_list_By_Criteria.END_ROW == null) || (i_Params_Get_Work_list_By_Criteria.END_ROW == 0)) { i_Params_Get_Work_list_By_Criteria.END_ROW = 1000000; }
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_Criteria_Adv(i_Params_Get_Work_list_By_Criteria.DESCRIPTION,i_Params_Get_Work_list_By_Criteria.OWNER_ID,i_Params_Get_Work_list_By_Criteria.START_ROW,i_Params_Get_Work_list_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
i_Params_Get_Work_list_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_Criteria_Adv");}
return oList;
}
public List<Work_list> Get_Work_list_By_Where_Adv(Params_Get_Work_list_By_Where i_Params_Get_Work_list_By_Where)
{
List<Work_list> oList = new List<Work_list>();
long? tmp_TOTAL_COUNT = 0;
Work_list oWork_list = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Work_list_By_Where.OWNER_ID == null) || (i_Params_Get_Work_list_By_Where.OWNER_ID == 0)) { i_Params_Get_Work_list_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_list_By_Where.START_ROW == null) { i_Params_Get_Work_list_By_Where.START_ROW = 0; }
if ((i_Params_Get_Work_list_By_Where.END_ROW == null) || (i_Params_Get_Work_list_By_Where.END_ROW == 0)) { i_Params_Get_Work_list_By_Where.END_ROW = 1000000; }
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_Where_Adv(i_Params_Get_Work_list_By_Where.DESCRIPTION,i_Params_Get_Work_list_By_Where.OWNER_ID,i_Params_Get_Work_list_By_Where.START_ROW,i_Params_Get_Work_list_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
i_Params_Get_Work_list_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_Where_Adv");}
return oList;
}
public List<User> Get_User_By_Criteria_Adv(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_Adv");}
return oList;
}
public List<User> Get_User_By_Where_Adv(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_Adv");}
return oList;
}
public List<Work_area> Get_Work_area_By_Criteria_Adv(Params_Get_Work_area_By_Criteria i_Params_Get_Work_area_By_Criteria)
{
List<Work_area> oList = new List<Work_area>();
long? tmp_TOTAL_COUNT = 0;
Work_area oWork_area = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Work_area_By_Criteria.OWNER_ID == null) || (i_Params_Get_Work_area_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Work_area_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_area_By_Criteria.START_ROW == null) { i_Params_Get_Work_area_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Work_area_By_Criteria.END_ROW == null) || (i_Params_Get_Work_area_By_Criteria.END_ROW == 0)) { i_Params_Get_Work_area_By_Criteria.END_ROW = 1000000; }
List<DALC.Work_area> oList_DBEntries = _AppContext.Get_Work_area_By_Criteria_Adv(i_Params_Get_Work_area_By_Criteria.NAME,i_Params_Get_Work_area_By_Criteria.DESCRIPTION,i_Params_Get_Work_area_By_Criteria.OWNER_ID,i_Params_Get_Work_area_By_Criteria.START_ROW,i_Params_Get_Work_area_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_area = new Work_area();
oTools.CopyPropValues(oDBEntry, oWork_area);
oList.Add(oWork_area);
}
}
i_Params_Get_Work_area_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_Criteria_Adv");}
return oList;
}
public List<Work_area> Get_Work_area_By_Where_Adv(Params_Get_Work_area_By_Where i_Params_Get_Work_area_By_Where)
{
List<Work_area> oList = new List<Work_area>();
long? tmp_TOTAL_COUNT = 0;
Work_area oWork_area = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Work_area_By_Where.OWNER_ID == null) || (i_Params_Get_Work_area_By_Where.OWNER_ID == 0)) { i_Params_Get_Work_area_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_area_By_Where.START_ROW == null) { i_Params_Get_Work_area_By_Where.START_ROW = 0; }
if ((i_Params_Get_Work_area_By_Where.END_ROW == null) || (i_Params_Get_Work_area_By_Where.END_ROW == 0)) { i_Params_Get_Work_area_By_Where.END_ROW = 1000000; }
List<DALC.Work_area> oList_DBEntries = _AppContext.Get_Work_area_By_Where_Adv(i_Params_Get_Work_area_By_Where.NAME,i_Params_Get_Work_area_By_Where.DESCRIPTION,i_Params_Get_Work_area_By_Where.OWNER_ID,i_Params_Get_Work_area_By_Where.START_ROW,i_Params_Get_Work_area_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_area = new Work_area();
oTools.CopyPropValues(oDBEntry, oWork_area);
oList.Add(oWork_area);
}
}
i_Params_Get_Work_area_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_Where_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_Adv(Params_Get_Boost_listing_By_Criteria i_Params_Get_Boost_listing_By_Criteria)
{
List<Boost_listing> oList = new List<Boost_listing>();
long? tmp_TOTAL_COUNT = 0;
Boost_listing oBoost_listing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Criteria_Adv");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Criteria.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Criteria.START_ROW == null) { i_Params_Get_Boost_listing_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Criteria.END_ROW == null) || (i_Params_Get_Boost_listing_By_Criteria.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Criteria.END_ROW = 1000000; }
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Criteria_Adv(i_Params_Get_Boost_listing_By_Criteria.DESCRIPTION,i_Params_Get_Boost_listing_By_Criteria.OWNER_ID,i_Params_Get_Boost_listing_By_Criteria.START_ROW,i_Params_Get_Boost_listing_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Criteria_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_Adv(Params_Get_Boost_listing_By_Where i_Params_Get_Boost_listing_By_Where)
{
List<Boost_listing> oList = new List<Boost_listing>();
long? tmp_TOTAL_COUNT = 0;
Boost_listing oBoost_listing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Where_Adv");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Where.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Where.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Where.START_ROW == null) { i_Params_Get_Boost_listing_By_Where.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Where.END_ROW == null) || (i_Params_Get_Boost_listing_By_Where.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Where.END_ROW = 1000000; }
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Where_Adv(i_Params_Get_Boost_listing_By_Where.DESCRIPTION,i_Params_Get_Boost_listing_By_Where.OWNER_ID,i_Params_Get_Boost_listing_By_Where.START_ROW,i_Params_Get_Boost_listing_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Where_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_Adv_V2(Params_Get_Boost_listing_By_Criteria_V2 i_Params_Get_Boost_listing_By_Criteria_V2)
{
List<Boost_listing> oList = new List<Boost_listing>();
long? tmp_TOTAL_COUNT = 0;
Boost_listing oBoost_listing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Criteria_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Criteria_V2.START_ROW == null) { i_Params_Get_Boost_listing_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Boost_listing_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Criteria_Adv_V2(i_Params_Get_Boost_listing_By_Criteria_V2.START_DATE,i_Params_Get_Boost_listing_By_Criteria_V2.DESCRIPTION,i_Params_Get_Boost_listing_By_Criteria_V2.OWNER_ID,i_Params_Get_Boost_listing_By_Criteria_V2.START_ROW,i_Params_Get_Boost_listing_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Criteria_Adv_V2");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_Adv_V2(Params_Get_Boost_listing_By_Where_V2 i_Params_Get_Boost_listing_By_Where_V2)
{
List<Boost_listing> oList = new List<Boost_listing>();
long? tmp_TOTAL_COUNT = 0;
Boost_listing oBoost_listing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Where_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Where_V2.START_ROW == null) { i_Params_Get_Boost_listing_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Where_V2.END_ROW == null) || (i_Params_Get_Boost_listing_By_Where_V2.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Where_V2.END_ROW = 1000000; }
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Where_Adv_V2(i_Params_Get_Boost_listing_By_Where_V2.START_DATE,i_Params_Get_Boost_listing_By_Where_V2.DESCRIPTION,i_Params_Get_Boost_listing_By_Where_V2.OWNER_ID,i_Params_Get_Boost_listing_By_Where_V2.START_ROW,i_Params_Get_Boost_listing_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Where_Adv_V2");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_Criteria_InList_Adv(Params_Get_Service_prod_By_Criteria_InList i_Params_Get_Service_prod_By_Criteria_InList)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Service_prod_By_Criteria_InList_SP oParams_Get_Service_prod_By_Criteria_InList_SP = new Params_Get_Service_prod_By_Criteria_InList_SP();
Params_Get_Business_By_BUSINESS_ID oParams_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
Params_Get_Sub_category_By_SUB_CATEGORY_ID oParams_Get_Sub_category_By_SUB_CATEGORY_ID = new Params_Get_Sub_category_By_SUB_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_Criteria_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Service_prod_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Service_prod_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Service_prod_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Service_prod_By_Criteria_InList.START_ROW == null) { i_Params_Get_Service_prod_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Service_prod_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Service_prod_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Service_prod_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Service_prod_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Service_prod_By_Criteria_InList.OWNER_ID;
oParams_Get_Service_prod_By_Criteria_InList_SP.NAME = i_Params_Get_Service_prod_By_Criteria_InList.NAME;
oParams_Get_Service_prod_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Service_prod_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Service_prod_By_Criteria_InList.BUSINESS_ID_LIST == null)
{
i_Params_Get_Service_prod_By_Criteria_InList.BUSINESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Service_prod_By_Criteria_InList_SP.BUSINESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Service_prod_By_Criteria_InList.BUSINESS_ID_LIST);
if ( i_Params_Get_Service_prod_By_Criteria_InList.SUB_CATEGORY_ID_LIST == null)
{
i_Params_Get_Service_prod_By_Criteria_InList.SUB_CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Service_prod_By_Criteria_InList_SP.SUB_CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Service_prod_By_Criteria_InList.SUB_CATEGORY_ID_LIST);
oParams_Get_Service_prod_By_Criteria_InList_SP.START_ROW = i_Params_Get_Service_prod_By_Criteria_InList.START_ROW;
oParams_Get_Service_prod_By_Criteria_InList_SP.END_ROW = i_Params_Get_Service_prod_By_Criteria_InList.END_ROW;
oParams_Get_Service_prod_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Service_prod_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_Criteria_InList_Adv(i_Params_Get_Service_prod_By_Criteria_InList.NAME,i_Params_Get_Service_prod_By_Criteria_InList.DESCRIPTION,i_Params_Get_Service_prod_By_Criteria_InList.BUSINESS_ID_LIST,i_Params_Get_Service_prod_By_Criteria_InList.SUB_CATEGORY_ID_LIST,i_Params_Get_Service_prod_By_Criteria_InList.OWNER_ID,i_Params_Get_Service_prod_By_Criteria_InList.START_ROW,i_Params_Get_Service_prod_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
i_Params_Get_Service_prod_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Service_prod_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Service_prod_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_Criteria_InList_Adv");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_Where_InList_Adv(Params_Get_Service_prod_By_Where_InList i_Params_Get_Service_prod_By_Where_InList)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Service_prod_By_Where_InList_SP oParams_Get_Service_prod_By_Where_InList_SP = new Params_Get_Service_prod_By_Where_InList_SP();
Params_Get_Business_By_BUSINESS_ID oParams_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
Params_Get_Sub_category_By_SUB_CATEGORY_ID oParams_Get_Sub_category_By_SUB_CATEGORY_ID = new Params_Get_Sub_category_By_SUB_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_Where_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Service_prod_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Service_prod_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Service_prod_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Service_prod_By_Where_InList.START_ROW == null) { i_Params_Get_Service_prod_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Service_prod_By_Where_InList.END_ROW == null) || (i_Params_Get_Service_prod_By_Where_InList.END_ROW == 0)) { i_Params_Get_Service_prod_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Service_prod_By_Where_InList_SP.OWNER_ID = i_Params_Get_Service_prod_By_Where_InList.OWNER_ID;
oParams_Get_Service_prod_By_Where_InList_SP.NAME = i_Params_Get_Service_prod_By_Where_InList.NAME;
oParams_Get_Service_prod_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Service_prod_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Service_prod_By_Where_InList.BUSINESS_ID_LIST == null)
{
i_Params_Get_Service_prod_By_Where_InList.BUSINESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Service_prod_By_Where_InList_SP.BUSINESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Service_prod_By_Where_InList.BUSINESS_ID_LIST);
if ( i_Params_Get_Service_prod_By_Where_InList.SUB_CATEGORY_ID_LIST == null)
{
i_Params_Get_Service_prod_By_Where_InList.SUB_CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Service_prod_By_Where_InList_SP.SUB_CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Service_prod_By_Where_InList.SUB_CATEGORY_ID_LIST);
oParams_Get_Service_prod_By_Where_InList_SP.START_ROW = i_Params_Get_Service_prod_By_Where_InList.START_ROW;
oParams_Get_Service_prod_By_Where_InList_SP.END_ROW = i_Params_Get_Service_prod_By_Where_InList.END_ROW;
oParams_Get_Service_prod_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Service_prod_By_Where_InList.TOTAL_COUNT;
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_Where_InList_Adv(i_Params_Get_Service_prod_By_Where_InList.NAME,i_Params_Get_Service_prod_By_Where_InList.DESCRIPTION,i_Params_Get_Service_prod_By_Where_InList.BUSINESS_ID_LIST,i_Params_Get_Service_prod_By_Where_InList.SUB_CATEGORY_ID_LIST,i_Params_Get_Service_prod_By_Where_InList.OWNER_ID,i_Params_Get_Service_prod_By_Where_InList.START_ROW,i_Params_Get_Service_prod_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oService_prod.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oService_prod.My_Business);
oService_prod.My_Sub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry.My_Sub_category, oService_prod.My_Sub_category);
oList.Add(oService_prod);
}
}
i_Params_Get_Service_prod_By_Where_InList.TOTAL_COUNT = oParams_Get_Service_prod_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Service_prod_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_Where_InList_Adv");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_Criteria_InList_Adv(Params_Get_Sub_category_By_Criteria_InList i_Params_Get_Sub_category_By_Criteria_InList)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Sub_category_By_Criteria_InList_SP oParams_Get_Sub_category_By_Criteria_InList_SP = new Params_Get_Sub_category_By_Criteria_InList_SP();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_Criteria_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Sub_category_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Sub_category_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Sub_category_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Sub_category_By_Criteria_InList.START_ROW == null) { i_Params_Get_Sub_category_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Sub_category_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Sub_category_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Sub_category_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Sub_category_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Sub_category_By_Criteria_InList.OWNER_ID;
oParams_Get_Sub_category_By_Criteria_InList_SP.NAME = i_Params_Get_Sub_category_By_Criteria_InList.NAME;
oParams_Get_Sub_category_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Sub_category_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Sub_category_By_Criteria_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Sub_category_By_Criteria_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Sub_category_By_Criteria_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Sub_category_By_Criteria_InList.CATEGORY_ID_LIST);
oParams_Get_Sub_category_By_Criteria_InList_SP.START_ROW = i_Params_Get_Sub_category_By_Criteria_InList.START_ROW;
oParams_Get_Sub_category_By_Criteria_InList_SP.END_ROW = i_Params_Get_Sub_category_By_Criteria_InList.END_ROW;
oParams_Get_Sub_category_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Sub_category_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_Criteria_InList_Adv(i_Params_Get_Sub_category_By_Criteria_InList.NAME,i_Params_Get_Sub_category_By_Criteria_InList.DESCRIPTION,i_Params_Get_Sub_category_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Sub_category_By_Criteria_InList.OWNER_ID,i_Params_Get_Sub_category_By_Criteria_InList.START_ROW,i_Params_Get_Sub_category_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oSub_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oSub_category.My_Category);
oList.Add(oSub_category);
}
}
i_Params_Get_Sub_category_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Sub_category_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Sub_category_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_Criteria_InList_Adv");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_Where_InList_Adv(Params_Get_Sub_category_By_Where_InList i_Params_Get_Sub_category_By_Where_InList)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Sub_category_By_Where_InList_SP oParams_Get_Sub_category_By_Where_InList_SP = new Params_Get_Sub_category_By_Where_InList_SP();
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_Where_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Sub_category_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Sub_category_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Sub_category_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Sub_category_By_Where_InList.START_ROW == null) { i_Params_Get_Sub_category_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Sub_category_By_Where_InList.END_ROW == null) || (i_Params_Get_Sub_category_By_Where_InList.END_ROW == 0)) { i_Params_Get_Sub_category_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Sub_category_By_Where_InList_SP.OWNER_ID = i_Params_Get_Sub_category_By_Where_InList.OWNER_ID;
oParams_Get_Sub_category_By_Where_InList_SP.NAME = i_Params_Get_Sub_category_By_Where_InList.NAME;
oParams_Get_Sub_category_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Sub_category_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Sub_category_By_Where_InList.CATEGORY_ID_LIST == null)
{
i_Params_Get_Sub_category_By_Where_InList.CATEGORY_ID_LIST = new List<Int32?>();
}
oParams_Get_Sub_category_By_Where_InList_SP.CATEGORY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Sub_category_By_Where_InList.CATEGORY_ID_LIST);
oParams_Get_Sub_category_By_Where_InList_SP.START_ROW = i_Params_Get_Sub_category_By_Where_InList.START_ROW;
oParams_Get_Sub_category_By_Where_InList_SP.END_ROW = i_Params_Get_Sub_category_By_Where_InList.END_ROW;
oParams_Get_Sub_category_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Sub_category_By_Where_InList.TOTAL_COUNT;
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_Where_InList_Adv(i_Params_Get_Sub_category_By_Where_InList.NAME,i_Params_Get_Sub_category_By_Where_InList.DESCRIPTION,i_Params_Get_Sub_category_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Sub_category_By_Where_InList.OWNER_ID,i_Params_Get_Sub_category_By_Where_InList.START_ROW,i_Params_Get_Sub_category_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oSub_category.My_Category = new Category();
oTools.CopyPropValues(oDBEntry.My_Category, oSub_category.My_Category);
oList.Add(oSub_category);
}
}
i_Params_Get_Sub_category_By_Where_InList.TOTAL_COUNT = oParams_Get_Sub_category_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Sub_category_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_Where_InList_Adv");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_Criteria_InList_Adv(Params_Get_Coordinates_By_Criteria_InList i_Params_Get_Coordinates_By_Criteria_InList)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Coordinates_By_Criteria_InList_SP oParams_Get_Coordinates_By_Criteria_InList_SP = new Params_Get_Coordinates_By_Criteria_InList_SP();
Params_Get_Booking_By_BOOKING_ID oParams_Get_Booking_By_BOOKING_ID = new Params_Get_Booking_By_BOOKING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_Criteria_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Coordinates_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Coordinates_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Coordinates_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coordinates_By_Criteria_InList.START_ROW == null) { i_Params_Get_Coordinates_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Coordinates_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Coordinates_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Coordinates_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Coordinates_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Coordinates_By_Criteria_InList.OWNER_ID;
oParams_Get_Coordinates_By_Criteria_InList_SP.LONGITUDE = i_Params_Get_Coordinates_By_Criteria_InList.LONGITUDE;
oParams_Get_Coordinates_By_Criteria_InList_SP.LATITUDE = i_Params_Get_Coordinates_By_Criteria_InList.LATITUDE;
oParams_Get_Coordinates_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Coordinates_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Coordinates_By_Criteria_InList.BOOKING_ID_LIST == null)
{
i_Params_Get_Coordinates_By_Criteria_InList.BOOKING_ID_LIST = new List<Int32?>();
}
oParams_Get_Coordinates_By_Criteria_InList_SP.BOOKING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Coordinates_By_Criteria_InList.BOOKING_ID_LIST);
oParams_Get_Coordinates_By_Criteria_InList_SP.START_ROW = i_Params_Get_Coordinates_By_Criteria_InList.START_ROW;
oParams_Get_Coordinates_By_Criteria_InList_SP.END_ROW = i_Params_Get_Coordinates_By_Criteria_InList.END_ROW;
oParams_Get_Coordinates_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Coordinates_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_Criteria_InList_Adv(i_Params_Get_Coordinates_By_Criteria_InList.LONGITUDE,i_Params_Get_Coordinates_By_Criteria_InList.LATITUDE,i_Params_Get_Coordinates_By_Criteria_InList.DESCRIPTION,i_Params_Get_Coordinates_By_Criteria_InList.BOOKING_ID_LIST,i_Params_Get_Coordinates_By_Criteria_InList.OWNER_ID,i_Params_Get_Coordinates_By_Criteria_InList.START_ROW,i_Params_Get_Coordinates_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oCoordinates.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oCoordinates.My_Booking);
oList.Add(oCoordinates);
}
}
i_Params_Get_Coordinates_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Coordinates_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Coordinates_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_Criteria_InList_Adv");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_Where_InList_Adv(Params_Get_Coordinates_By_Where_InList i_Params_Get_Coordinates_By_Where_InList)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Coordinates_By_Where_InList_SP oParams_Get_Coordinates_By_Where_InList_SP = new Params_Get_Coordinates_By_Where_InList_SP();
Params_Get_Booking_By_BOOKING_ID oParams_Get_Booking_By_BOOKING_ID = new Params_Get_Booking_By_BOOKING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_Where_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Coordinates_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Coordinates_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Coordinates_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coordinates_By_Where_InList.START_ROW == null) { i_Params_Get_Coordinates_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Coordinates_By_Where_InList.END_ROW == null) || (i_Params_Get_Coordinates_By_Where_InList.END_ROW == 0)) { i_Params_Get_Coordinates_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Coordinates_By_Where_InList_SP.OWNER_ID = i_Params_Get_Coordinates_By_Where_InList.OWNER_ID;
oParams_Get_Coordinates_By_Where_InList_SP.LONGITUDE = i_Params_Get_Coordinates_By_Where_InList.LONGITUDE;
oParams_Get_Coordinates_By_Where_InList_SP.LATITUDE = i_Params_Get_Coordinates_By_Where_InList.LATITUDE;
oParams_Get_Coordinates_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Coordinates_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Coordinates_By_Where_InList.BOOKING_ID_LIST == null)
{
i_Params_Get_Coordinates_By_Where_InList.BOOKING_ID_LIST = new List<Int32?>();
}
oParams_Get_Coordinates_By_Where_InList_SP.BOOKING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Coordinates_By_Where_InList.BOOKING_ID_LIST);
oParams_Get_Coordinates_By_Where_InList_SP.START_ROW = i_Params_Get_Coordinates_By_Where_InList.START_ROW;
oParams_Get_Coordinates_By_Where_InList_SP.END_ROW = i_Params_Get_Coordinates_By_Where_InList.END_ROW;
oParams_Get_Coordinates_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Coordinates_By_Where_InList.TOTAL_COUNT;
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_Where_InList_Adv(i_Params_Get_Coordinates_By_Where_InList.LONGITUDE,i_Params_Get_Coordinates_By_Where_InList.LATITUDE,i_Params_Get_Coordinates_By_Where_InList.DESCRIPTION,i_Params_Get_Coordinates_By_Where_InList.BOOKING_ID_LIST,i_Params_Get_Coordinates_By_Where_InList.OWNER_ID,i_Params_Get_Coordinates_By_Where_InList.START_ROW,i_Params_Get_Coordinates_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oCoordinates.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oCoordinates.My_Booking);
oList.Add(oCoordinates);
}
}
i_Params_Get_Coordinates_By_Where_InList.TOTAL_COUNT = oParams_Get_Coordinates_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Coordinates_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_Where_InList_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_InList_Adv(Params_Get_Feedback_By_Criteria_InList i_Params_Get_Feedback_By_Criteria_InList)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Feedback_By_Criteria_InList_SP oParams_Get_Feedback_By_Criteria_InList_SP = new Params_Get_Feedback_By_Criteria_InList_SP();
Params_Get_Booking_By_BOOKING_ID oParams_Get_Booking_By_BOOKING_ID = new Params_Get_Booking_By_BOOKING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Criteria_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Feedback_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Criteria_InList.START_ROW == null) { i_Params_Get_Feedback_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Feedback_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Feedback_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Feedback_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Feedback_By_Criteria_InList.OWNER_ID;
oParams_Get_Feedback_By_Criteria_InList_SP.COMMENT = i_Params_Get_Feedback_By_Criteria_InList.COMMENT;
oParams_Get_Feedback_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Feedback_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Feedback_By_Criteria_InList.BOOKING_ID_LIST == null)
{
i_Params_Get_Feedback_By_Criteria_InList.BOOKING_ID_LIST = new List<Int32?>();
}
oParams_Get_Feedback_By_Criteria_InList_SP.BOOKING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Feedback_By_Criteria_InList.BOOKING_ID_LIST);
oParams_Get_Feedback_By_Criteria_InList_SP.START_ROW = i_Params_Get_Feedback_By_Criteria_InList.START_ROW;
oParams_Get_Feedback_By_Criteria_InList_SP.END_ROW = i_Params_Get_Feedback_By_Criteria_InList.END_ROW;
oParams_Get_Feedback_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Feedback_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Criteria_InList_Adv(i_Params_Get_Feedback_By_Criteria_InList.COMMENT,i_Params_Get_Feedback_By_Criteria_InList.DESCRIPTION,i_Params_Get_Feedback_By_Criteria_InList.BOOKING_ID_LIST,i_Params_Get_Feedback_By_Criteria_InList.OWNER_ID,i_Params_Get_Feedback_By_Criteria_InList.START_ROW,i_Params_Get_Feedback_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Feedback_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Feedback_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Criteria_InList_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_Where_InList_Adv(Params_Get_Feedback_By_Where_InList i_Params_Get_Feedback_By_Where_InList)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Feedback_By_Where_InList_SP oParams_Get_Feedback_By_Where_InList_SP = new Params_Get_Feedback_By_Where_InList_SP();
Params_Get_Booking_By_BOOKING_ID oParams_Get_Booking_By_BOOKING_ID = new Params_Get_Booking_By_BOOKING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Where_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Feedback_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Where_InList.START_ROW == null) { i_Params_Get_Feedback_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Where_InList.END_ROW == null) || (i_Params_Get_Feedback_By_Where_InList.END_ROW == 0)) { i_Params_Get_Feedback_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Feedback_By_Where_InList_SP.OWNER_ID = i_Params_Get_Feedback_By_Where_InList.OWNER_ID;
oParams_Get_Feedback_By_Where_InList_SP.COMMENT = i_Params_Get_Feedback_By_Where_InList.COMMENT;
oParams_Get_Feedback_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Feedback_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Feedback_By_Where_InList.BOOKING_ID_LIST == null)
{
i_Params_Get_Feedback_By_Where_InList.BOOKING_ID_LIST = new List<Int32?>();
}
oParams_Get_Feedback_By_Where_InList_SP.BOOKING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Feedback_By_Where_InList.BOOKING_ID_LIST);
oParams_Get_Feedback_By_Where_InList_SP.START_ROW = i_Params_Get_Feedback_By_Where_InList.START_ROW;
oParams_Get_Feedback_By_Where_InList_SP.END_ROW = i_Params_Get_Feedback_By_Where_InList.END_ROW;
oParams_Get_Feedback_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Feedback_By_Where_InList.TOTAL_COUNT;
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Where_InList_Adv(i_Params_Get_Feedback_By_Where_InList.COMMENT,i_Params_Get_Feedback_By_Where_InList.DESCRIPTION,i_Params_Get_Feedback_By_Where_InList.BOOKING_ID_LIST,i_Params_Get_Feedback_By_Where_InList.OWNER_ID,i_Params_Get_Feedback_By_Where_InList.START_ROW,i_Params_Get_Feedback_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Where_InList.TOTAL_COUNT = oParams_Get_Feedback_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Feedback_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Where_InList_Adv");}
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_InList_Adv_V2(Params_Get_Feedback_By_Criteria_InList_V2 i_Params_Get_Feedback_By_Criteria_InList_V2)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Feedback_By_Criteria_InList_SP_V2 oParams_Get_Feedback_By_Criteria_InList_SP_V2 = new Params_Get_Feedback_By_Criteria_InList_SP_V2();
Params_Get_Booking_By_BOOKING_ID oParams_Get_Booking_By_BOOKING_ID = new Params_Get_Booking_By_BOOKING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Criteria_InList_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Feedback_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Feedback_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Feedback_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Feedback_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Feedback_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Feedback_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Feedback_By_Criteria_InList_SP_V2.COMMENT = i_Params_Get_Feedback_By_Criteria_InList_V2.COMMENT;
oParams_Get_Feedback_By_Criteria_InList_SP_V2.DATE = i_Params_Get_Feedback_By_Criteria_InList_V2.DATE;
oParams_Get_Feedback_By_Criteria_InList_SP_V2.DESCRIPTION = i_Params_Get_Feedback_By_Criteria_InList_V2.DESCRIPTION;
if ( i_Params_Get_Feedback_By_Criteria_InList_V2.BOOKING_ID_LIST == null)
{
i_Params_Get_Feedback_By_Criteria_InList_V2.BOOKING_ID_LIST = new List<Int32?>();
}
oParams_Get_Feedback_By_Criteria_InList_SP_V2.BOOKING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Feedback_By_Criteria_InList_V2.BOOKING_ID_LIST);
oParams_Get_Feedback_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Feedback_By_Criteria_InList_V2.START_ROW;
oParams_Get_Feedback_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Feedback_By_Criteria_InList_V2.END_ROW;
oParams_Get_Feedback_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Feedback_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Criteria_InList_Adv_V2(i_Params_Get_Feedback_By_Criteria_InList_V2.COMMENT,i_Params_Get_Feedback_By_Criteria_InList_V2.DATE,i_Params_Get_Feedback_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Feedback_By_Criteria_InList_V2.BOOKING_ID_LIST,i_Params_Get_Feedback_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Feedback_By_Criteria_InList_V2.START_ROW,i_Params_Get_Feedback_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Feedback_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Feedback_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Feedback> Get_Feedback_By_Where_InList_Adv_V2(Params_Get_Feedback_By_Where_InList_V2 i_Params_Get_Feedback_By_Where_InList_V2)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Feedback_By_Where_InList_SP_V2 oParams_Get_Feedback_By_Where_InList_SP_V2 = new Params_Get_Feedback_By_Where_InList_SP_V2();
Params_Get_Booking_By_BOOKING_ID oParams_Get_Booking_By_BOOKING_ID = new Params_Get_Booking_By_BOOKING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Where_InList_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Feedback_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Feedback_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Feedback_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Feedback_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Feedback_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Feedback_By_Where_InList_V2.OWNER_ID;
oParams_Get_Feedback_By_Where_InList_SP_V2.COMMENT = i_Params_Get_Feedback_By_Where_InList_V2.COMMENT;
oParams_Get_Feedback_By_Where_InList_SP_V2.DATE = i_Params_Get_Feedback_By_Where_InList_V2.DATE;
oParams_Get_Feedback_By_Where_InList_SP_V2.DESCRIPTION = i_Params_Get_Feedback_By_Where_InList_V2.DESCRIPTION;
if ( i_Params_Get_Feedback_By_Where_InList_V2.BOOKING_ID_LIST == null)
{
i_Params_Get_Feedback_By_Where_InList_V2.BOOKING_ID_LIST = new List<Int32?>();
}
oParams_Get_Feedback_By_Where_InList_SP_V2.BOOKING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Feedback_By_Where_InList_V2.BOOKING_ID_LIST);
oParams_Get_Feedback_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Feedback_By_Where_InList_V2.START_ROW;
oParams_Get_Feedback_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Feedback_By_Where_InList_V2.END_ROW;
oParams_Get_Feedback_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Feedback_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Where_InList_Adv_V2(i_Params_Get_Feedback_By_Where_InList_V2.COMMENT,i_Params_Get_Feedback_By_Where_InList_V2.DATE,i_Params_Get_Feedback_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Feedback_By_Where_InList_V2.BOOKING_ID_LIST,i_Params_Get_Feedback_By_Where_InList_V2.OWNER_ID,i_Params_Get_Feedback_By_Where_InList_V2.START_ROW,i_Params_Get_Feedback_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oFeedback.My_Booking = new Booking();
oTools.CopyPropValues(oDBEntry.My_Booking, oFeedback.My_Booking);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Feedback_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Feedback_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Where_InList_Adv_V2");}
return oList;
}
public List<Booking> Get_Booking_By_Criteria_InList_Adv(Params_Get_Booking_By_Criteria_InList i_Params_Get_Booking_By_Criteria_InList)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Booking_By_Criteria_InList_SP oParams_Get_Booking_By_Criteria_InList_SP = new Params_Get_Booking_By_Criteria_InList_SP();
Params_Get_Service_prod_By_SERVICE_PROD_ID oParams_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Business_By_BUSINESS_ID oParams_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
Params_Get_Work_area_By_WORK_AREA_ID oParams_Get_Work_area_By_WORK_AREA_ID = new Params_Get_Work_area_By_WORK_AREA_ID();
Params_Get_Status_By_STATUS_ID oParams_Get_Status_By_STATUS_ID = new Params_Get_Status_By_STATUS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Criteria_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Booking_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Booking_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Booking_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Criteria_InList.START_ROW == null) { i_Params_Get_Booking_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Booking_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Booking_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Booking_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Booking_By_Criteria_InList.OWNER_ID;
oParams_Get_Booking_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Booking_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Booking_By_Criteria_InList.SERVICE_PROD_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList.SERVICE_PROD_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP.SERVICE_PROD_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList.SERVICE_PROD_ID_LIST);
if ( i_Params_Get_Booking_By_Criteria_InList.CLIENT_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList.CLIENT_ID_LIST);
if ( i_Params_Get_Booking_By_Criteria_InList.BUSINESS_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList.BUSINESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP.BUSINESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList.BUSINESS_ID_LIST);
if ( i_Params_Get_Booking_By_Criteria_InList.WORK_AREA_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList.WORK_AREA_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP.WORK_AREA_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList.WORK_AREA_ID_LIST);
if ( i_Params_Get_Booking_By_Criteria_InList.STATUS_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList.STATUS_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP.STATUS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList.STATUS_ID_LIST);
oParams_Get_Booking_By_Criteria_InList_SP.START_ROW = i_Params_Get_Booking_By_Criteria_InList.START_ROW;
oParams_Get_Booking_By_Criteria_InList_SP.END_ROW = i_Params_Get_Booking_By_Criteria_InList.END_ROW;
oParams_Get_Booking_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Booking_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Criteria_InList_Adv(i_Params_Get_Booking_By_Criteria_InList.DESCRIPTION,i_Params_Get_Booking_By_Criteria_InList.SERVICE_PROD_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.CLIENT_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.BUSINESS_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.WORK_AREA_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.STATUS_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.OWNER_ID,i_Params_Get_Booking_By_Criteria_InList.START_ROW,i_Params_Get_Booking_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Booking_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Booking_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Criteria_InList_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_Where_InList_Adv(Params_Get_Booking_By_Where_InList i_Params_Get_Booking_By_Where_InList)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Booking_By_Where_InList_SP oParams_Get_Booking_By_Where_InList_SP = new Params_Get_Booking_By_Where_InList_SP();
Params_Get_Service_prod_By_SERVICE_PROD_ID oParams_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Business_By_BUSINESS_ID oParams_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
Params_Get_Work_area_By_WORK_AREA_ID oParams_Get_Work_area_By_WORK_AREA_ID = new Params_Get_Work_area_By_WORK_AREA_ID();
Params_Get_Status_By_STATUS_ID oParams_Get_Status_By_STATUS_ID = new Params_Get_Status_By_STATUS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Where_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Booking_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Booking_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Booking_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Where_InList.START_ROW == null) { i_Params_Get_Booking_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Where_InList.END_ROW == null) || (i_Params_Get_Booking_By_Where_InList.END_ROW == 0)) { i_Params_Get_Booking_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Booking_By_Where_InList_SP.OWNER_ID = i_Params_Get_Booking_By_Where_InList.OWNER_ID;
oParams_Get_Booking_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Booking_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Booking_By_Where_InList.SERVICE_PROD_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList.SERVICE_PROD_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP.SERVICE_PROD_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList.SERVICE_PROD_ID_LIST);
if ( i_Params_Get_Booking_By_Where_InList.CLIENT_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList.CLIENT_ID_LIST);
if ( i_Params_Get_Booking_By_Where_InList.BUSINESS_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList.BUSINESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP.BUSINESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList.BUSINESS_ID_LIST);
if ( i_Params_Get_Booking_By_Where_InList.WORK_AREA_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList.WORK_AREA_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP.WORK_AREA_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList.WORK_AREA_ID_LIST);
if ( i_Params_Get_Booking_By_Where_InList.STATUS_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList.STATUS_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP.STATUS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList.STATUS_ID_LIST);
oParams_Get_Booking_By_Where_InList_SP.START_ROW = i_Params_Get_Booking_By_Where_InList.START_ROW;
oParams_Get_Booking_By_Where_InList_SP.END_ROW = i_Params_Get_Booking_By_Where_InList.END_ROW;
oParams_Get_Booking_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Booking_By_Where_InList.TOTAL_COUNT;
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Where_InList_Adv(i_Params_Get_Booking_By_Where_InList.DESCRIPTION,i_Params_Get_Booking_By_Where_InList.SERVICE_PROD_ID_LIST,i_Params_Get_Booking_By_Where_InList.CLIENT_ID_LIST,i_Params_Get_Booking_By_Where_InList.BUSINESS_ID_LIST,i_Params_Get_Booking_By_Where_InList.WORK_AREA_ID_LIST,i_Params_Get_Booking_By_Where_InList.STATUS_ID_LIST,i_Params_Get_Booking_By_Where_InList.OWNER_ID,i_Params_Get_Booking_By_Where_InList.START_ROW,i_Params_Get_Booking_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Where_InList.TOTAL_COUNT = oParams_Get_Booking_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Booking_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Where_InList_Adv");}
return oList;
}
public List<Booking> Get_Booking_By_Criteria_InList_Adv_V2(Params_Get_Booking_By_Criteria_InList_V2 i_Params_Get_Booking_By_Criteria_InList_V2)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Booking_By_Criteria_InList_SP_V2 oParams_Get_Booking_By_Criteria_InList_SP_V2 = new Params_Get_Booking_By_Criteria_InList_SP_V2();
Params_Get_Service_prod_By_SERVICE_PROD_ID oParams_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Business_By_BUSINESS_ID oParams_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
Params_Get_Work_area_By_WORK_AREA_ID oParams_Get_Work_area_By_WORK_AREA_ID = new Params_Get_Work_area_By_WORK_AREA_ID();
Params_Get_Status_By_STATUS_ID oParams_Get_Status_By_STATUS_ID = new Params_Get_Status_By_STATUS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Criteria_InList_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Booking_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Booking_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Booking_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Booking_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Booking_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Booking_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Booking_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Booking_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Booking_By_Criteria_InList_SP_V2.DATE = i_Params_Get_Booking_By_Criteria_InList_V2.DATE;
oParams_Get_Booking_By_Criteria_InList_SP_V2.DESCRIPTION = i_Params_Get_Booking_By_Criteria_InList_V2.DESCRIPTION;
if ( i_Params_Get_Booking_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP_V2.SERVICE_PROD_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST);
if ( i_Params_Get_Booking_By_Criteria_InList_V2.CLIENT_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList_V2.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP_V2.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList_V2.CLIENT_ID_LIST);
if ( i_Params_Get_Booking_By_Criteria_InList_V2.BUSINESS_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList_V2.BUSINESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP_V2.BUSINESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList_V2.BUSINESS_ID_LIST);
if ( i_Params_Get_Booking_By_Criteria_InList_V2.WORK_AREA_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList_V2.WORK_AREA_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP_V2.WORK_AREA_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList_V2.WORK_AREA_ID_LIST);
if ( i_Params_Get_Booking_By_Criteria_InList_V2.STATUS_ID_LIST == null)
{
i_Params_Get_Booking_By_Criteria_InList_V2.STATUS_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Criteria_InList_SP_V2.STATUS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Criteria_InList_V2.STATUS_ID_LIST);
oParams_Get_Booking_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Booking_By_Criteria_InList_V2.START_ROW;
oParams_Get_Booking_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Booking_By_Criteria_InList_V2.END_ROW;
oParams_Get_Booking_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Booking_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Criteria_InList_Adv_V2(i_Params_Get_Booking_By_Criteria_InList_V2.DATE,i_Params_Get_Booking_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Booking_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.CLIENT_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.BUSINESS_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.WORK_AREA_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.STATUS_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Booking_By_Criteria_InList_V2.START_ROW,i_Params_Get_Booking_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Booking_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Booking_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Booking> Get_Booking_By_Where_InList_Adv_V2(Params_Get_Booking_By_Where_InList_V2 i_Params_Get_Booking_By_Where_InList_V2)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Booking_By_Where_InList_SP_V2 oParams_Get_Booking_By_Where_InList_SP_V2 = new Params_Get_Booking_By_Where_InList_SP_V2();
Params_Get_Service_prod_By_SERVICE_PROD_ID oParams_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Business_By_BUSINESS_ID oParams_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
Params_Get_Work_area_By_WORK_AREA_ID oParams_Get_Work_area_By_WORK_AREA_ID = new Params_Get_Work_area_By_WORK_AREA_ID();
Params_Get_Status_By_STATUS_ID oParams_Get_Status_By_STATUS_ID = new Params_Get_Status_By_STATUS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Where_InList_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Booking_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Booking_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Booking_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Booking_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Booking_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Booking_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Booking_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Booking_By_Where_InList_V2.OWNER_ID;
oParams_Get_Booking_By_Where_InList_SP_V2.DATE = i_Params_Get_Booking_By_Where_InList_V2.DATE;
oParams_Get_Booking_By_Where_InList_SP_V2.DESCRIPTION = i_Params_Get_Booking_By_Where_InList_V2.DESCRIPTION;
if ( i_Params_Get_Booking_By_Where_InList_V2.SERVICE_PROD_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList_V2.SERVICE_PROD_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP_V2.SERVICE_PROD_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList_V2.SERVICE_PROD_ID_LIST);
if ( i_Params_Get_Booking_By_Where_InList_V2.CLIENT_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList_V2.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP_V2.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList_V2.CLIENT_ID_LIST);
if ( i_Params_Get_Booking_By_Where_InList_V2.BUSINESS_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList_V2.BUSINESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP_V2.BUSINESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList_V2.BUSINESS_ID_LIST);
if ( i_Params_Get_Booking_By_Where_InList_V2.WORK_AREA_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList_V2.WORK_AREA_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP_V2.WORK_AREA_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList_V2.WORK_AREA_ID_LIST);
if ( i_Params_Get_Booking_By_Where_InList_V2.STATUS_ID_LIST == null)
{
i_Params_Get_Booking_By_Where_InList_V2.STATUS_ID_LIST = new List<Int32?>();
}
oParams_Get_Booking_By_Where_InList_SP_V2.STATUS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Booking_By_Where_InList_V2.STATUS_ID_LIST);
oParams_Get_Booking_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Booking_By_Where_InList_V2.START_ROW;
oParams_Get_Booking_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Booking_By_Where_InList_V2.END_ROW;
oParams_Get_Booking_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Booking_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Where_InList_Adv_V2(i_Params_Get_Booking_By_Where_InList_V2.DATE,i_Params_Get_Booking_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Booking_By_Where_InList_V2.SERVICE_PROD_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.CLIENT_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.BUSINESS_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.WORK_AREA_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.STATUS_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.OWNER_ID,i_Params_Get_Booking_By_Where_InList_V2.START_ROW,i_Params_Get_Booking_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oBooking.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBooking.My_Service_prod);
oBooking.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oBooking.My_Client);
oBooking.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oBooking.My_Business);
oBooking.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oBooking.My_Work_area);
oBooking.My_Status = new Status();
oTools.CopyPropValues(oDBEntry.My_Status, oBooking.My_Status);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Booking_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Booking_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Where_InList_Adv_V2");}
return oList;
}
public List<Work_list> Get_Work_list_By_Criteria_InList_Adv(Params_Get_Work_list_By_Criteria_InList i_Params_Get_Work_list_By_Criteria_InList)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Work_list_By_Criteria_InList_SP oParams_Get_Work_list_By_Criteria_InList_SP = new Params_Get_Work_list_By_Criteria_InList_SP();
Params_Get_Business_By_BUSINESS_ID oParams_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
Params_Get_Work_area_By_WORK_AREA_ID oParams_Get_Work_area_By_WORK_AREA_ID = new Params_Get_Work_area_By_WORK_AREA_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_Criteria_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Work_list_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Work_list_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Work_list_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_list_By_Criteria_InList.START_ROW == null) { i_Params_Get_Work_list_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Work_list_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Work_list_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Work_list_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Work_list_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Work_list_By_Criteria_InList.OWNER_ID;
oParams_Get_Work_list_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Work_list_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Work_list_By_Criteria_InList.BUSINESS_ID_LIST == null)
{
i_Params_Get_Work_list_By_Criteria_InList.BUSINESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Work_list_By_Criteria_InList_SP.BUSINESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Work_list_By_Criteria_InList.BUSINESS_ID_LIST);
if ( i_Params_Get_Work_list_By_Criteria_InList.WORK_AREA_ID_LIST == null)
{
i_Params_Get_Work_list_By_Criteria_InList.WORK_AREA_ID_LIST = new List<Int32?>();
}
oParams_Get_Work_list_By_Criteria_InList_SP.WORK_AREA_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Work_list_By_Criteria_InList.WORK_AREA_ID_LIST);
oParams_Get_Work_list_By_Criteria_InList_SP.START_ROW = i_Params_Get_Work_list_By_Criteria_InList.START_ROW;
oParams_Get_Work_list_By_Criteria_InList_SP.END_ROW = i_Params_Get_Work_list_By_Criteria_InList.END_ROW;
oParams_Get_Work_list_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Work_list_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_Criteria_InList_Adv(i_Params_Get_Work_list_By_Criteria_InList.DESCRIPTION,i_Params_Get_Work_list_By_Criteria_InList.BUSINESS_ID_LIST,i_Params_Get_Work_list_By_Criteria_InList.WORK_AREA_ID_LIST,i_Params_Get_Work_list_By_Criteria_InList.OWNER_ID,i_Params_Get_Work_list_By_Criteria_InList.START_ROW,i_Params_Get_Work_list_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
i_Params_Get_Work_list_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Work_list_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Work_list_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_Criteria_InList_Adv");}
return oList;
}
public List<Work_list> Get_Work_list_By_Where_InList_Adv(Params_Get_Work_list_By_Where_InList i_Params_Get_Work_list_By_Where_InList)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Work_list_By_Where_InList_SP oParams_Get_Work_list_By_Where_InList_SP = new Params_Get_Work_list_By_Where_InList_SP();
Params_Get_Business_By_BUSINESS_ID oParams_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
Params_Get_Work_area_By_WORK_AREA_ID oParams_Get_Work_area_By_WORK_AREA_ID = new Params_Get_Work_area_By_WORK_AREA_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_Where_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Work_list_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Work_list_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Work_list_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_list_By_Where_InList.START_ROW == null) { i_Params_Get_Work_list_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Work_list_By_Where_InList.END_ROW == null) || (i_Params_Get_Work_list_By_Where_InList.END_ROW == 0)) { i_Params_Get_Work_list_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Work_list_By_Where_InList_SP.OWNER_ID = i_Params_Get_Work_list_By_Where_InList.OWNER_ID;
oParams_Get_Work_list_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Work_list_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Work_list_By_Where_InList.BUSINESS_ID_LIST == null)
{
i_Params_Get_Work_list_By_Where_InList.BUSINESS_ID_LIST = new List<Int32?>();
}
oParams_Get_Work_list_By_Where_InList_SP.BUSINESS_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Work_list_By_Where_InList.BUSINESS_ID_LIST);
if ( i_Params_Get_Work_list_By_Where_InList.WORK_AREA_ID_LIST == null)
{
i_Params_Get_Work_list_By_Where_InList.WORK_AREA_ID_LIST = new List<Int32?>();
}
oParams_Get_Work_list_By_Where_InList_SP.WORK_AREA_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Work_list_By_Where_InList.WORK_AREA_ID_LIST);
oParams_Get_Work_list_By_Where_InList_SP.START_ROW = i_Params_Get_Work_list_By_Where_InList.START_ROW;
oParams_Get_Work_list_By_Where_InList_SP.END_ROW = i_Params_Get_Work_list_By_Where_InList.END_ROW;
oParams_Get_Work_list_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Work_list_By_Where_InList.TOTAL_COUNT;
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_Where_InList_Adv(i_Params_Get_Work_list_By_Where_InList.DESCRIPTION,i_Params_Get_Work_list_By_Where_InList.BUSINESS_ID_LIST,i_Params_Get_Work_list_By_Where_InList.WORK_AREA_ID_LIST,i_Params_Get_Work_list_By_Where_InList.OWNER_ID,i_Params_Get_Work_list_By_Where_InList.START_ROW,i_Params_Get_Work_list_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oWork_list.My_Business = new Business();
oTools.CopyPropValues(oDBEntry.My_Business, oWork_list.My_Business);
oWork_list.My_Work_area = new Work_area();
oTools.CopyPropValues(oDBEntry.My_Work_area, oWork_list.My_Work_area);
oList.Add(oWork_list);
}
}
i_Params_Get_Work_list_By_Where_InList.TOTAL_COUNT = oParams_Get_Work_list_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Work_list_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_Where_InList_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_InList_Adv(Params_Get_Boost_listing_By_Criteria_InList i_Params_Get_Boost_listing_By_Criteria_InList)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Boost_listing_By_Criteria_InList_SP oParams_Get_Boost_listing_By_Criteria_InList_SP = new Params_Get_Boost_listing_By_Criteria_InList_SP();
Params_Get_Service_prod_By_SERVICE_PROD_ID oParams_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
Params_Get_Boost_pricing_By_BOOST_PRICING_ID oParams_Get_Boost_pricing_By_BOOST_PRICING_ID = new Params_Get_Boost_pricing_By_BOOST_PRICING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Criteria_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Criteria_InList.START_ROW == null) { i_Params_Get_Boost_listing_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Boost_listing_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Boost_listing_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Boost_listing_By_Criteria_InList.OWNER_ID;
oParams_Get_Boost_listing_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Boost_listing_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Boost_listing_By_Criteria_InList.SERVICE_PROD_ID_LIST == null)
{
i_Params_Get_Boost_listing_By_Criteria_InList.SERVICE_PROD_ID_LIST = new List<Int32?>();
}
oParams_Get_Boost_listing_By_Criteria_InList_SP.SERVICE_PROD_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Boost_listing_By_Criteria_InList.SERVICE_PROD_ID_LIST);
if ( i_Params_Get_Boost_listing_By_Criteria_InList.BOOST_PRICING_ID_LIST == null)
{
i_Params_Get_Boost_listing_By_Criteria_InList.BOOST_PRICING_ID_LIST = new List<Int32?>();
}
oParams_Get_Boost_listing_By_Criteria_InList_SP.BOOST_PRICING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Boost_listing_By_Criteria_InList.BOOST_PRICING_ID_LIST);
oParams_Get_Boost_listing_By_Criteria_InList_SP.START_ROW = i_Params_Get_Boost_listing_By_Criteria_InList.START_ROW;
oParams_Get_Boost_listing_By_Criteria_InList_SP.END_ROW = i_Params_Get_Boost_listing_By_Criteria_InList.END_ROW;
oParams_Get_Boost_listing_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Boost_listing_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Criteria_InList_Adv(i_Params_Get_Boost_listing_By_Criteria_InList.DESCRIPTION,i_Params_Get_Boost_listing_By_Criteria_InList.SERVICE_PROD_ID_LIST,i_Params_Get_Boost_listing_By_Criteria_InList.BOOST_PRICING_ID_LIST,i_Params_Get_Boost_listing_By_Criteria_InList.OWNER_ID,i_Params_Get_Boost_listing_By_Criteria_InList.START_ROW,i_Params_Get_Boost_listing_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Boost_listing_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Boost_listing_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Criteria_InList_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_InList_Adv(Params_Get_Boost_listing_By_Where_InList i_Params_Get_Boost_listing_By_Where_InList)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Boost_listing_By_Where_InList_SP oParams_Get_Boost_listing_By_Where_InList_SP = new Params_Get_Boost_listing_By_Where_InList_SP();
Params_Get_Service_prod_By_SERVICE_PROD_ID oParams_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
Params_Get_Boost_pricing_By_BOOST_PRICING_ID oParams_Get_Boost_pricing_By_BOOST_PRICING_ID = new Params_Get_Boost_pricing_By_BOOST_PRICING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Where_InList_Adv");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Where_InList.START_ROW == null) { i_Params_Get_Boost_listing_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Where_InList.END_ROW == null) || (i_Params_Get_Boost_listing_By_Where_InList.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Boost_listing_By_Where_InList_SP.OWNER_ID = i_Params_Get_Boost_listing_By_Where_InList.OWNER_ID;
oParams_Get_Boost_listing_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Boost_listing_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Boost_listing_By_Where_InList.SERVICE_PROD_ID_LIST == null)
{
i_Params_Get_Boost_listing_By_Where_InList.SERVICE_PROD_ID_LIST = new List<Int32?>();
}
oParams_Get_Boost_listing_By_Where_InList_SP.SERVICE_PROD_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Boost_listing_By_Where_InList.SERVICE_PROD_ID_LIST);
if ( i_Params_Get_Boost_listing_By_Where_InList.BOOST_PRICING_ID_LIST == null)
{
i_Params_Get_Boost_listing_By_Where_InList.BOOST_PRICING_ID_LIST = new List<Int32?>();
}
oParams_Get_Boost_listing_By_Where_InList_SP.BOOST_PRICING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Boost_listing_By_Where_InList.BOOST_PRICING_ID_LIST);
oParams_Get_Boost_listing_By_Where_InList_SP.START_ROW = i_Params_Get_Boost_listing_By_Where_InList.START_ROW;
oParams_Get_Boost_listing_By_Where_InList_SP.END_ROW = i_Params_Get_Boost_listing_By_Where_InList.END_ROW;
oParams_Get_Boost_listing_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Boost_listing_By_Where_InList.TOTAL_COUNT;
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Where_InList_Adv(i_Params_Get_Boost_listing_By_Where_InList.DESCRIPTION,i_Params_Get_Boost_listing_By_Where_InList.SERVICE_PROD_ID_LIST,i_Params_Get_Boost_listing_By_Where_InList.BOOST_PRICING_ID_LIST,i_Params_Get_Boost_listing_By_Where_InList.OWNER_ID,i_Params_Get_Boost_listing_By_Where_InList.START_ROW,i_Params_Get_Boost_listing_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Where_InList.TOTAL_COUNT = oParams_Get_Boost_listing_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Boost_listing_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Where_InList_Adv");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_InList_Adv_V2(Params_Get_Boost_listing_By_Criteria_InList_V2 i_Params_Get_Boost_listing_By_Criteria_InList_V2)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Boost_listing_By_Criteria_InList_SP_V2 oParams_Get_Boost_listing_By_Criteria_InList_SP_V2 = new Params_Get_Boost_listing_By_Criteria_InList_SP_V2();
Params_Get_Service_prod_By_SERVICE_PROD_ID oParams_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
Params_Get_Boost_pricing_By_BOOST_PRICING_ID oParams_Get_Boost_pricing_By_BOOST_PRICING_ID = new Params_Get_Boost_pricing_By_BOOST_PRICING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Criteria_InList_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Boost_listing_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Boost_listing_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Boost_listing_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.START_DATE = i_Params_Get_Boost_listing_By_Criteria_InList_V2.START_DATE;
oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.DESCRIPTION = i_Params_Get_Boost_listing_By_Criteria_InList_V2.DESCRIPTION;
if ( i_Params_Get_Boost_listing_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST == null)
{
i_Params_Get_Boost_listing_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST = new List<Int32?>();
}
oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.SERVICE_PROD_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Boost_listing_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST);
if ( i_Params_Get_Boost_listing_By_Criteria_InList_V2.BOOST_PRICING_ID_LIST == null)
{
i_Params_Get_Boost_listing_By_Criteria_InList_V2.BOOST_PRICING_ID_LIST = new List<Int32?>();
}
oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.BOOST_PRICING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Boost_listing_By_Criteria_InList_V2.BOOST_PRICING_ID_LIST);
oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Boost_listing_By_Criteria_InList_V2.START_ROW;
oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Boost_listing_By_Criteria_InList_V2.END_ROW;
oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Boost_listing_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Criteria_InList_Adv_V2(i_Params_Get_Boost_listing_By_Criteria_InList_V2.START_DATE,i_Params_Get_Boost_listing_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Boost_listing_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST,i_Params_Get_Boost_listing_By_Criteria_InList_V2.BOOST_PRICING_ID_LIST,i_Params_Get_Boost_listing_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Boost_listing_By_Criteria_InList_V2.START_ROW,i_Params_Get_Boost_listing_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Boost_listing_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_InList_Adv_V2(Params_Get_Boost_listing_By_Where_InList_V2 i_Params_Get_Boost_listing_By_Where_InList_V2)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Boost_listing_By_Where_InList_SP_V2 oParams_Get_Boost_listing_By_Where_InList_SP_V2 = new Params_Get_Boost_listing_By_Where_InList_SP_V2();
Params_Get_Service_prod_By_SERVICE_PROD_ID oParams_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
Params_Get_Boost_pricing_By_BOOST_PRICING_ID oParams_Get_Boost_pricing_By_BOOST_PRICING_ID = new Params_Get_Boost_pricing_By_BOOST_PRICING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Where_InList_Adv_V2");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Boost_listing_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Boost_listing_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Boost_listing_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Boost_listing_By_Where_InList_V2.OWNER_ID;
oParams_Get_Boost_listing_By_Where_InList_SP_V2.START_DATE = i_Params_Get_Boost_listing_By_Where_InList_V2.START_DATE;
oParams_Get_Boost_listing_By_Where_InList_SP_V2.DESCRIPTION = i_Params_Get_Boost_listing_By_Where_InList_V2.DESCRIPTION;
if ( i_Params_Get_Boost_listing_By_Where_InList_V2.SERVICE_PROD_ID_LIST == null)
{
i_Params_Get_Boost_listing_By_Where_InList_V2.SERVICE_PROD_ID_LIST = new List<Int32?>();
}
oParams_Get_Boost_listing_By_Where_InList_SP_V2.SERVICE_PROD_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Boost_listing_By_Where_InList_V2.SERVICE_PROD_ID_LIST);
if ( i_Params_Get_Boost_listing_By_Where_InList_V2.BOOST_PRICING_ID_LIST == null)
{
i_Params_Get_Boost_listing_By_Where_InList_V2.BOOST_PRICING_ID_LIST = new List<Int32?>();
}
oParams_Get_Boost_listing_By_Where_InList_SP_V2.BOOST_PRICING_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Boost_listing_By_Where_InList_V2.BOOST_PRICING_ID_LIST);
oParams_Get_Boost_listing_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Boost_listing_By_Where_InList_V2.START_ROW;
oParams_Get_Boost_listing_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Boost_listing_By_Where_InList_V2.END_ROW;
oParams_Get_Boost_listing_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Boost_listing_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Where_InList_Adv_V2(i_Params_Get_Boost_listing_By_Where_InList_V2.START_DATE,i_Params_Get_Boost_listing_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Boost_listing_By_Where_InList_V2.SERVICE_PROD_ID_LIST,i_Params_Get_Boost_listing_By_Where_InList_V2.BOOST_PRICING_ID_LIST,i_Params_Get_Boost_listing_By_Where_InList_V2.OWNER_ID,i_Params_Get_Boost_listing_By_Where_InList_V2.START_ROW,i_Params_Get_Boost_listing_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oBoost_listing.My_Service_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry.My_Service_prod, oBoost_listing.My_Service_prod);
oBoost_listing.My_Boost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry.My_Boost_pricing, oBoost_listing.My_Boost_pricing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Boost_listing_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Boost_listing_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Where_InList_Adv_V2");}
return oList;
}
}
}
