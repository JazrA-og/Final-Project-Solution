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
#region Members
#region Used For Delete Operations
private Boost_pricing _Boost_pricing;
private Client _Client;
private Service_prod _Service_prod;
private Admin _Admin;
private Category _Category;
private Sub_category _Sub_category;
private Coordinates _Coordinates;
private Currency _Currency;
private Status _Status;
private Owner _Owner;
private Feedback _Feedback;
private Booking _Booking;
private Business _Business;
private Work_list _Work_list;
private User _User;
private Work_area _Work_area;
private Boost_listing _Boost_listing;
#endregion
#region Stop Executing Flags For Edit and Delete Operations
private bool _Stop_Edit_Boost_pricing_Execution;
private bool _Stop_Delete_Boost_pricing_Execution;
private bool _Stop_Edit_Client_Execution;
private bool _Stop_Delete_Client_Execution;
private bool _Stop_Edit_Service_prod_Execution;
private bool _Stop_Delete_Service_prod_Execution;
private bool _Stop_Edit_Admin_Execution;
private bool _Stop_Delete_Admin_Execution;
private bool _Stop_Edit_Category_Execution;
private bool _Stop_Delete_Category_Execution;
private bool _Stop_Edit_Sub_category_Execution;
private bool _Stop_Delete_Sub_category_Execution;
private bool _Stop_Edit_Coordinates_Execution;
private bool _Stop_Delete_Coordinates_Execution;
private bool _Stop_Edit_Currency_Execution;
private bool _Stop_Delete_Currency_Execution;
private bool _Stop_Edit_Status_Execution;
private bool _Stop_Delete_Status_Execution;
private bool _Stop_Edit_Owner_Execution;
private bool _Stop_Delete_Owner_Execution;
private bool _Stop_Edit_Feedback_Execution;
private bool _Stop_Delete_Feedback_Execution;
private bool _Stop_Edit_Booking_Execution;
private bool _Stop_Delete_Booking_Execution;
private bool _Stop_Edit_Business_Execution;
private bool _Stop_Delete_Business_Execution;
private bool _Stop_Edit_Work_list_Execution;
private bool _Stop_Delete_Work_list_Execution;
private bool _Stop_Edit_User_Execution;
private bool _Stop_Delete_User_Execution;
private bool _Stop_Edit_Work_area_Execution;
private bool _Stop_Delete_Work_area_Execution;
private bool _Stop_Edit_Boost_listing_Execution;
private bool _Stop_Delete_Boost_listing_Execution;
#endregion
#endregion
public Boost_pricing Get_Boost_pricing_By_BOOST_PRICING_ID(Params_Get_Boost_pricing_By_BOOST_PRICING_ID i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID)
{
Boost_pricing oBoost_pricing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_BOOST_PRICING_ID");}
#region Body Section.
DALC.Boost_pricing oDBEntry = _AppContext.Get_Boost_pricing_By_BOOST_PRICING_ID(i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID.BOOST_PRICING_ID);
oBoost_pricing = new Boost_pricing();
oTools.CopyPropValues(oDBEntry, oBoost_pricing);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_BOOST_PRICING_ID");}
return oBoost_pricing;
}
public Client Get_Client_By_CLIENT_ID(Params_Get_Client_By_CLIENT_ID i_Params_Get_Client_By_CLIENT_ID)
{
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_CLIENT_ID");}
#region Body Section.
DALC.Client oDBEntry = _AppContext.Get_Client_By_CLIENT_ID(i_Params_Get_Client_By_CLIENT_ID.CLIENT_ID);
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_CLIENT_ID");}
return oClient;
}
public Service_prod Get_Service_prod_By_SERVICE_PROD_ID(Params_Get_Service_prod_By_SERVICE_PROD_ID i_Params_Get_Service_prod_By_SERVICE_PROD_ID)
{
Service_prod oService_prod = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_SERVICE_PROD_ID");}
#region Body Section.
DALC.Service_prod oDBEntry = _AppContext.Get_Service_prod_By_SERVICE_PROD_ID(i_Params_Get_Service_prod_By_SERVICE_PROD_ID.SERVICE_PROD_ID);
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_SERVICE_PROD_ID");}
return oService_prod;
}
public Admin Get_Admin_By_ADMIN_ID(Params_Get_Admin_By_ADMIN_ID i_Params_Get_Admin_By_ADMIN_ID)
{
Admin oAdmin = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_ADMIN_ID");}
#region Body Section.
DALC.Admin oDBEntry = _AppContext.Get_Admin_By_ADMIN_ID(i_Params_Get_Admin_By_ADMIN_ID.ADMIN_ID);
oAdmin = new Admin();
oTools.CopyPropValues(oDBEntry, oAdmin);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_ADMIN_ID");}
return oAdmin;
}
public Category Get_Category_By_CATEGORY_ID(Params_Get_Category_By_CATEGORY_ID i_Params_Get_Category_By_CATEGORY_ID)
{
Category oCategory = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID");}
#region Body Section.
DALC.Category oDBEntry = _AppContext.Get_Category_By_CATEGORY_ID(i_Params_Get_Category_By_CATEGORY_ID.CATEGORY_ID);
oCategory = new Category();
oTools.CopyPropValues(oDBEntry, oCategory);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID");}
return oCategory;
}
public Sub_category Get_Sub_category_By_SUB_CATEGORY_ID(Params_Get_Sub_category_By_SUB_CATEGORY_ID i_Params_Get_Sub_category_By_SUB_CATEGORY_ID)
{
Sub_category oSub_category = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_SUB_CATEGORY_ID");}
#region Body Section.
DALC.Sub_category oDBEntry = _AppContext.Get_Sub_category_By_SUB_CATEGORY_ID(i_Params_Get_Sub_category_By_SUB_CATEGORY_ID.SUB_CATEGORY_ID);
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_SUB_CATEGORY_ID");}
return oSub_category;
}
public Coordinates Get_Coordinates_By_COORDINATES_ID(Params_Get_Coordinates_By_COORDINATES_ID i_Params_Get_Coordinates_By_COORDINATES_ID)
{
Coordinates oCoordinates = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_COORDINATES_ID");}
#region Body Section.
DALC.Coordinates oDBEntry = _AppContext.Get_Coordinates_By_COORDINATES_ID(i_Params_Get_Coordinates_By_COORDINATES_ID.COORDINATES_ID);
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_COORDINATES_ID");}
return oCoordinates;
}
public Currency Get_Currency_By_CURRENCY_ID(Params_Get_Currency_By_CURRENCY_ID i_Params_Get_Currency_By_CURRENCY_ID)
{
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID");}
#region Body Section.
DALC.Currency oDBEntry = _AppContext.Get_Currency_By_CURRENCY_ID(i_Params_Get_Currency_By_CURRENCY_ID.CURRENCY_ID);
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID");}
return oCurrency;
}
public Status Get_Status_By_STATUS_ID(Params_Get_Status_By_STATUS_ID i_Params_Get_Status_By_STATUS_ID)
{
Status oStatus = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_STATUS_ID");}
#region Body Section.
DALC.Status oDBEntry = _AppContext.Get_Status_By_STATUS_ID(i_Params_Get_Status_By_STATUS_ID.STATUS_ID);
oStatus = new Status();
oTools.CopyPropValues(oDBEntry, oStatus);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_STATUS_ID");}
return oStatus;
}
public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
{
Owner oOwner = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID");}
#region Body Section.
DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID");}
return oOwner;
}
public Feedback Get_Feedback_By_FEEDBACK_ID(Params_Get_Feedback_By_FEEDBACK_ID i_Params_Get_Feedback_By_FEEDBACK_ID)
{
Feedback oFeedback = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_FEEDBACK_ID");}
#region Body Section.
DALC.Feedback oDBEntry = _AppContext.Get_Feedback_By_FEEDBACK_ID(i_Params_Get_Feedback_By_FEEDBACK_ID.FEEDBACK_ID);
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_FEEDBACK_ID");}
return oFeedback;
}
public Booking Get_Booking_By_BOOKING_ID(Params_Get_Booking_By_BOOKING_ID i_Params_Get_Booking_By_BOOKING_ID)
{
Booking oBooking = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_BOOKING_ID");}
#region Body Section.
DALC.Booking oDBEntry = _AppContext.Get_Booking_By_BOOKING_ID(i_Params_Get_Booking_By_BOOKING_ID.BOOKING_ID);
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_BOOKING_ID");}
return oBooking;
}
public Business Get_Business_By_BUSINESS_ID(Params_Get_Business_By_BUSINESS_ID i_Params_Get_Business_By_BUSINESS_ID)
{
Business oBusiness = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_BUSINESS_ID");}
#region Body Section.
DALC.Business oDBEntry = _AppContext.Get_Business_By_BUSINESS_ID(i_Params_Get_Business_By_BUSINESS_ID.BUSINESS_ID);
oBusiness = new Business();
oTools.CopyPropValues(oDBEntry, oBusiness);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_BUSINESS_ID");}
return oBusiness;
}
public Work_list Get_Work_list_By_WORK_LIST_ID(Params_Get_Work_list_By_WORK_LIST_ID i_Params_Get_Work_list_By_WORK_LIST_ID)
{
Work_list oWork_list = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_WORK_LIST_ID");}
#region Body Section.
DALC.Work_list oDBEntry = _AppContext.Get_Work_list_By_WORK_LIST_ID(i_Params_Get_Work_list_By_WORK_LIST_ID.WORK_LIST_ID);
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_WORK_LIST_ID");}
return oWork_list;
}
public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID");}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID");}
return oUser;
}
public Work_area Get_Work_area_By_WORK_AREA_ID(Params_Get_Work_area_By_WORK_AREA_ID i_Params_Get_Work_area_By_WORK_AREA_ID)
{
Work_area oWork_area = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_WORK_AREA_ID");}
#region Body Section.
DALC.Work_area oDBEntry = _AppContext.Get_Work_area_By_WORK_AREA_ID(i_Params_Get_Work_area_By_WORK_AREA_ID.WORK_AREA_ID);
oWork_area = new Work_area();
oTools.CopyPropValues(oDBEntry, oWork_area);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_WORK_AREA_ID");}
return oWork_area;
}
public Boost_listing Get_Boost_listing_By_BOOST_LISTING_ID(Params_Get_Boost_listing_By_BOOST_LISTING_ID i_Params_Get_Boost_listing_By_BOOST_LISTING_ID)
{
Boost_listing oBoost_listing = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_BOOST_LISTING_ID");}
#region Body Section.
DALC.Boost_listing oDBEntry = _AppContext.Get_Boost_listing_By_BOOST_LISTING_ID(i_Params_Get_Boost_listing_By_BOOST_LISTING_ID.BOOST_LISTING_ID);
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_BOOST_LISTING_ID");}
return oBoost_listing;
}
public List<Boost_pricing> Get_Boost_pricing_By_BOOST_PRICING_ID_List(Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List)
{
Boost_pricing oBoost_pricing = null;
List<Boost_pricing> oList = new List<Boost_pricing>();
Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List_SP oParams_Get_Boost_pricing_By_BOOST_PRICING_ID_List_SP = new Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_BOOST_PRICING_ID_List");}
#region Body Section.
List<DALC.Boost_pricing> oList_DBEntries = _AppContext.Get_Boost_pricing_By_BOOST_PRICING_ID_List(i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List.BOOST_PRICING_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_BOOST_PRICING_ID_List");}
return oList;
}
public List<Client> Get_Client_By_CLIENT_ID_List(Params_Get_Client_By_CLIENT_ID_List i_Params_Get_Client_By_CLIENT_ID_List)
{
Client oClient = null;
List<Client> oList = new List<Client>();
Params_Get_Client_By_CLIENT_ID_List_SP oParams_Get_Client_By_CLIENT_ID_List_SP = new Params_Get_Client_By_CLIENT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_CLIENT_ID_List");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_CLIENT_ID_List(i_Params_Get_Client_By_CLIENT_ID_List.CLIENT_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_CLIENT_ID_List");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SERVICE_PROD_ID_List(Params_Get_Service_prod_By_SERVICE_PROD_ID_List i_Params_Get_Service_prod_By_SERVICE_PROD_ID_List)
{
Service_prod oService_prod = null;
List<Service_prod> oList = new List<Service_prod>();
Params_Get_Service_prod_By_SERVICE_PROD_ID_List_SP oParams_Get_Service_prod_By_SERVICE_PROD_ID_List_SP = new Params_Get_Service_prod_By_SERVICE_PROD_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_SERVICE_PROD_ID_List");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_SERVICE_PROD_ID_List(i_Params_Get_Service_prod_By_SERVICE_PROD_ID_List.SERVICE_PROD_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_SERVICE_PROD_ID_List");}
return oList;
}
public List<Admin> Get_Admin_By_ADMIN_ID_List(Params_Get_Admin_By_ADMIN_ID_List i_Params_Get_Admin_By_ADMIN_ID_List)
{
Admin oAdmin = null;
List<Admin> oList = new List<Admin>();
Params_Get_Admin_By_ADMIN_ID_List_SP oParams_Get_Admin_By_ADMIN_ID_List_SP = new Params_Get_Admin_By_ADMIN_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_ADMIN_ID_List");}
#region Body Section.
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_ADMIN_ID_List(i_Params_Get_Admin_By_ADMIN_ID_List.ADMIN_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_ADMIN_ID_List");}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List(Params_Get_Category_By_CATEGORY_ID_List i_Params_Get_Category_By_CATEGORY_ID_List)
{
Category oCategory = null;
List<Category> oList = new List<Category>();
Params_Get_Category_By_CATEGORY_ID_List_SP oParams_Get_Category_By_CATEGORY_ID_List_SP = new Params_Get_Category_By_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_CATEGORY_ID_List(i_Params_Get_Category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_CATEGORY_ID_List");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_SUB_CATEGORY_ID_List(Params_Get_Sub_category_By_SUB_CATEGORY_ID_List i_Params_Get_Sub_category_By_SUB_CATEGORY_ID_List)
{
Sub_category oSub_category = null;
List<Sub_category> oList = new List<Sub_category>();
Params_Get_Sub_category_By_SUB_CATEGORY_ID_List_SP oParams_Get_Sub_category_By_SUB_CATEGORY_ID_List_SP = new Params_Get_Sub_category_By_SUB_CATEGORY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_SUB_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_SUB_CATEGORY_ID_List(i_Params_Get_Sub_category_By_SUB_CATEGORY_ID_List.SUB_CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oList.Add(oSub_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_SUB_CATEGORY_ID_List");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_COORDINATES_ID_List(Params_Get_Coordinates_By_COORDINATES_ID_List i_Params_Get_Coordinates_By_COORDINATES_ID_List)
{
Coordinates oCoordinates = null;
List<Coordinates> oList = new List<Coordinates>();
Params_Get_Coordinates_By_COORDINATES_ID_List_SP oParams_Get_Coordinates_By_COORDINATES_ID_List_SP = new Params_Get_Coordinates_By_COORDINATES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_COORDINATES_ID_List");}
#region Body Section.
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_COORDINATES_ID_List(i_Params_Get_Coordinates_By_COORDINATES_ID_List.COORDINATES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oList.Add(oCoordinates);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_COORDINATES_ID_List");}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List(Params_Get_Currency_By_CURRENCY_ID_List i_Params_Get_Currency_By_CURRENCY_ID_List)
{
Currency oCurrency = null;
List<Currency> oList = new List<Currency>();
Params_Get_Currency_By_CURRENCY_ID_List_SP oParams_Get_Currency_By_CURRENCY_ID_List_SP = new Params_Get_Currency_By_CURRENCY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID_List");}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_CURRENCY_ID_List(i_Params_Get_Currency_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID_List");}
return oList;
}
public List<Status> Get_Status_By_STATUS_ID_List(Params_Get_Status_By_STATUS_ID_List i_Params_Get_Status_By_STATUS_ID_List)
{
Status oStatus = null;
List<Status> oList = new List<Status>();
Params_Get_Status_By_STATUS_ID_List_SP oParams_Get_Status_By_STATUS_ID_List_SP = new Params_Get_Status_By_STATUS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_STATUS_ID_List");}
#region Body Section.
List<DALC.Status> oList_DBEntries = _AppContext.Get_Status_By_STATUS_ID_List(i_Params_Get_Status_By_STATUS_ID_List.STATUS_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_STATUS_ID_List");}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
{
Owner oOwner = null;
List<Owner> oList = new List<Owner>();
Params_Get_Owner_By_OWNER_ID_List_SP oParams_Get_Owner_By_OWNER_ID_List_SP = new Params_Get_Owner_By_OWNER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID_List");}
#region Body Section.
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID_List");}
return oList;
}
public List<Feedback> Get_Feedback_By_FEEDBACK_ID_List(Params_Get_Feedback_By_FEEDBACK_ID_List i_Params_Get_Feedback_By_FEEDBACK_ID_List)
{
Feedback oFeedback = null;
List<Feedback> oList = new List<Feedback>();
Params_Get_Feedback_By_FEEDBACK_ID_List_SP oParams_Get_Feedback_By_FEEDBACK_ID_List_SP = new Params_Get_Feedback_By_FEEDBACK_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_FEEDBACK_ID_List");}
#region Body Section.
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_FEEDBACK_ID_List(i_Params_Get_Feedback_By_FEEDBACK_ID_List.FEEDBACK_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_FEEDBACK_ID_List");}
return oList;
}
public List<Booking> Get_Booking_By_BOOKING_ID_List(Params_Get_Booking_By_BOOKING_ID_List i_Params_Get_Booking_By_BOOKING_ID_List)
{
Booking oBooking = null;
List<Booking> oList = new List<Booking>();
Params_Get_Booking_By_BOOKING_ID_List_SP oParams_Get_Booking_By_BOOKING_ID_List_SP = new Params_Get_Booking_By_BOOKING_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_BOOKING_ID_List");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_BOOKING_ID_List(i_Params_Get_Booking_By_BOOKING_ID_List.BOOKING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_BOOKING_ID_List");}
return oList;
}
public List<Business> Get_Business_By_BUSINESS_ID_List(Params_Get_Business_By_BUSINESS_ID_List i_Params_Get_Business_By_BUSINESS_ID_List)
{
Business oBusiness = null;
List<Business> oList = new List<Business>();
Params_Get_Business_By_BUSINESS_ID_List_SP oParams_Get_Business_By_BUSINESS_ID_List_SP = new Params_Get_Business_By_BUSINESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_BUSINESS_ID_List");}
#region Body Section.
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_BUSINESS_ID_List(i_Params_Get_Business_By_BUSINESS_ID_List.BUSINESS_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_BUSINESS_ID_List");}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_LIST_ID_List(Params_Get_Work_list_By_WORK_LIST_ID_List i_Params_Get_Work_list_By_WORK_LIST_ID_List)
{
Work_list oWork_list = null;
List<Work_list> oList = new List<Work_list>();
Params_Get_Work_list_By_WORK_LIST_ID_List_SP oParams_Get_Work_list_By_WORK_LIST_ID_List_SP = new Params_Get_Work_list_By_WORK_LIST_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_WORK_LIST_ID_List");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_WORK_LIST_ID_List(i_Params_Get_Work_list_By_WORK_LIST_ID_List.WORK_LIST_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_WORK_LIST_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List");}
return oList;
}
public List<Work_area> Get_Work_area_By_WORK_AREA_ID_List(Params_Get_Work_area_By_WORK_AREA_ID_List i_Params_Get_Work_area_By_WORK_AREA_ID_List)
{
Work_area oWork_area = null;
List<Work_area> oList = new List<Work_area>();
Params_Get_Work_area_By_WORK_AREA_ID_List_SP oParams_Get_Work_area_By_WORK_AREA_ID_List_SP = new Params_Get_Work_area_By_WORK_AREA_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_WORK_AREA_ID_List");}
#region Body Section.
List<DALC.Work_area> oList_DBEntries = _AppContext.Get_Work_area_By_WORK_AREA_ID_List(i_Params_Get_Work_area_By_WORK_AREA_ID_List.WORK_AREA_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_WORK_AREA_ID_List");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_LISTING_ID_List(Params_Get_Boost_listing_By_BOOST_LISTING_ID_List i_Params_Get_Boost_listing_By_BOOST_LISTING_ID_List)
{
Boost_listing oBoost_listing = null;
List<Boost_listing> oList = new List<Boost_listing>();
Params_Get_Boost_listing_By_BOOST_LISTING_ID_List_SP oParams_Get_Boost_listing_By_BOOST_LISTING_ID_List_SP = new Params_Get_Boost_listing_By_BOOST_LISTING_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_BOOST_LISTING_ID_List");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_BOOST_LISTING_ID_List(i_Params_Get_Boost_listing_By_BOOST_LISTING_ID_List.BOOST_LISTING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_BOOST_LISTING_ID_List");}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_OWNER_ID(Params_Get_Boost_pricing_By_OWNER_ID i_Params_Get_Boost_pricing_By_OWNER_ID)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
Boost_pricing oBoost_pricing = new Boost_pricing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_OWNER_ID");}
#region Body Section.
List<DALC.Boost_pricing> oList_DBEntries = _AppContext.Get_Boost_pricing_By_OWNER_ID(i_Params_Get_Boost_pricing_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_OWNER_ID");}
return oList;
}
public List<Client> Get_Client_By_PHONE_NUMBER(Params_Get_Client_By_PHONE_NUMBER i_Params_Get_Client_By_PHONE_NUMBER)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_PHONE_NUMBER");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_PHONE_NUMBER(i_Params_Get_Client_By_PHONE_NUMBER.PHONE_NUMBER);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_PHONE_NUMBER");}
return oList;
}
public List<Client> Get_Client_By_OWNER_ID(Params_Get_Client_By_OWNER_ID i_Params_Get_Client_By_OWNER_ID)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_OWNER_ID");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_OWNER_ID(i_Params_Get_Client_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_OWNER_ID");}
return oList;
}
public List<Client> Get_Client_By_USERNAME(Params_Get_Client_By_USERNAME i_Params_Get_Client_By_USERNAME)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_USERNAME");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_USERNAME(i_Params_Get_Client_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_USERNAME");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_OWNER_ID(Params_Get_Service_prod_By_OWNER_ID i_Params_Get_Service_prod_By_OWNER_ID)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_OWNER_ID");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_OWNER_ID(i_Params_Get_Service_prod_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_OWNER_ID");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_BUSINESS_ID(Params_Get_Service_prod_By_BUSINESS_ID i_Params_Get_Service_prod_By_BUSINESS_ID)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_BUSINESS_ID");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_BUSINESS_ID(i_Params_Get_Service_prod_By_BUSINESS_ID.BUSINESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_BUSINESS_ID");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID(Params_Get_Service_prod_By_SUB_CATEGORY_ID i_Params_Get_Service_prod_By_SUB_CATEGORY_ID)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_SUB_CATEGORY_ID");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_SUB_CATEGORY_ID(i_Params_Get_Service_prod_By_SUB_CATEGORY_ID.SUB_CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_SUB_CATEGORY_ID");}
return oList;
}
public List<Admin> Get_Admin_By_OWNER_ID(Params_Get_Admin_By_OWNER_ID i_Params_Get_Admin_By_OWNER_ID)
{
List<Admin> oList = new List<Admin>();
Admin oAdmin = new Admin();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_OWNER_ID");}
#region Body Section.
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_OWNER_ID(i_Params_Get_Admin_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_OWNER_ID");}
return oList;
}
public List<Admin> Get_Admin_By_USERNAME(Params_Get_Admin_By_USERNAME i_Params_Get_Admin_By_USERNAME)
{
List<Admin> oList = new List<Admin>();
Admin oAdmin = new Admin();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_USERNAME");}
#region Body Section.
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_USERNAME(i_Params_Get_Admin_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_USERNAME");}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID(Params_Get_Category_By_OWNER_ID i_Params_Get_Category_By_OWNER_ID)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_OWNER_ID");}
#region Body Section.
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_OWNER_ID(i_Params_Get_Category_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_OWNER_ID");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_OWNER_ID(Params_Get_Sub_category_By_OWNER_ID i_Params_Get_Sub_category_By_OWNER_ID)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_OWNER_ID");}
#region Body Section.
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_OWNER_ID(i_Params_Get_Sub_category_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oList.Add(oSub_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_OWNER_ID");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_CATEGORY_ID(Params_Get_Sub_category_By_CATEGORY_ID i_Params_Get_Sub_category_By_CATEGORY_ID)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_CATEGORY_ID");}
#region Body Section.
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_CATEGORY_ID(i_Params_Get_Sub_category_By_CATEGORY_ID.CATEGORY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oList.Add(oSub_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_CATEGORY_ID");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_OWNER_ID(Params_Get_Coordinates_By_OWNER_ID i_Params_Get_Coordinates_By_OWNER_ID)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_OWNER_ID");}
#region Body Section.
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_OWNER_ID(i_Params_Get_Coordinates_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oList.Add(oCoordinates);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_OWNER_ID");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_BOOKING_ID(Params_Get_Coordinates_By_BOOKING_ID i_Params_Get_Coordinates_By_BOOKING_ID)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_BOOKING_ID");}
#region Body Section.
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_BOOKING_ID(i_Params_Get_Coordinates_By_BOOKING_ID.BOOKING_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oList.Add(oCoordinates);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_BOOKING_ID");}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID(Params_Get_Currency_By_OWNER_ID i_Params_Get_Currency_By_OWNER_ID)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_OWNER_ID");}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_OWNER_ID(i_Params_Get_Currency_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_OWNER_ID");}
return oList;
}
public List<Status> Get_Status_By_OWNER_ID(Params_Get_Status_By_OWNER_ID i_Params_Get_Status_By_OWNER_ID)
{
List<Status> oList = new List<Status>();
Status oStatus = new Status();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_OWNER_ID");}
#region Body Section.
List<DALC.Status> oList_DBEntries = _AppContext.Get_Status_By_OWNER_ID(i_Params_Get_Status_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_OWNER_ID");}
return oList;
}
public List<Feedback> Get_Feedback_By_OWNER_ID(Params_Get_Feedback_By_OWNER_ID i_Params_Get_Feedback_By_OWNER_ID)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_OWNER_ID");}
#region Body Section.
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_OWNER_ID(i_Params_Get_Feedback_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_OWNER_ID");}
return oList;
}
public List<Feedback> Get_Feedback_By_BOOKING_ID(Params_Get_Feedback_By_BOOKING_ID i_Params_Get_Feedback_By_BOOKING_ID)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_BOOKING_ID");}
#region Body Section.
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_BOOKING_ID(i_Params_Get_Feedback_By_BOOKING_ID.BOOKING_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_BOOKING_ID");}
return oList;
}
public List<Booking> Get_Booking_By_OWNER_ID(Params_Get_Booking_By_OWNER_ID i_Params_Get_Booking_By_OWNER_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_OWNER_ID");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_OWNER_ID(i_Params_Get_Booking_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_OWNER_ID");}
return oList;
}
public List<Booking> Get_Booking_By_SERVICE_PROD_ID(Params_Get_Booking_By_SERVICE_PROD_ID i_Params_Get_Booking_By_SERVICE_PROD_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_SERVICE_PROD_ID");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_SERVICE_PROD_ID(i_Params_Get_Booking_By_SERVICE_PROD_ID.SERVICE_PROD_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_SERVICE_PROD_ID");}
return oList;
}
public List<Booking> Get_Booking_By_CLIENT_ID(Params_Get_Booking_By_CLIENT_ID i_Params_Get_Booking_By_CLIENT_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_CLIENT_ID");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_CLIENT_ID(i_Params_Get_Booking_By_CLIENT_ID.CLIENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_CLIENT_ID");}
return oList;
}
public List<Booking> Get_Booking_By_WORK_AREA_ID(Params_Get_Booking_By_WORK_AREA_ID i_Params_Get_Booking_By_WORK_AREA_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_WORK_AREA_ID");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_WORK_AREA_ID(i_Params_Get_Booking_By_WORK_AREA_ID.WORK_AREA_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_WORK_AREA_ID");}
return oList;
}
public List<Booking> Get_Booking_By_STATUS_ID(Params_Get_Booking_By_STATUS_ID i_Params_Get_Booking_By_STATUS_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_STATUS_ID");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_STATUS_ID(i_Params_Get_Booking_By_STATUS_ID.STATUS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_STATUS_ID");}
return oList;
}
public List<Booking> Get_Booking_By_BUSINESS_ID(Params_Get_Booking_By_BUSINESS_ID i_Params_Get_Booking_By_BUSINESS_ID)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_BUSINESS_ID");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_BUSINESS_ID(i_Params_Get_Booking_By_BUSINESS_ID.BUSINESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_BUSINESS_ID");}
return oList;
}
public List<Business> Get_Business_By_USERNAME(Params_Get_Business_By_USERNAME i_Params_Get_Business_By_USERNAME)
{
List<Business> oList = new List<Business>();
Business oBusiness = new Business();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_USERNAME");}
#region Body Section.
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_USERNAME(i_Params_Get_Business_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_USERNAME");}
return oList;
}
public List<Business> Get_Business_By_OWNER_ID(Params_Get_Business_By_OWNER_ID i_Params_Get_Business_By_OWNER_ID)
{
List<Business> oList = new List<Business>();
Business oBusiness = new Business();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_OWNER_ID");}
#region Body Section.
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_OWNER_ID(i_Params_Get_Business_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_OWNER_ID");}
return oList;
}
public List<Work_list> Get_Work_list_By_OWNER_ID(Params_Get_Work_list_By_OWNER_ID i_Params_Get_Work_list_By_OWNER_ID)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_OWNER_ID");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_OWNER_ID(i_Params_Get_Work_list_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_OWNER_ID");}
return oList;
}
public List<Work_list> Get_Work_list_By_BUSINESS_ID(Params_Get_Work_list_By_BUSINESS_ID i_Params_Get_Work_list_By_BUSINESS_ID)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_BUSINESS_ID");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_BUSINESS_ID(i_Params_Get_Work_list_By_BUSINESS_ID.BUSINESS_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_BUSINESS_ID");}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_AREA_ID(Params_Get_Work_list_By_WORK_AREA_ID i_Params_Get_Work_list_By_WORK_AREA_ID)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_WORK_AREA_ID");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_WORK_AREA_ID(i_Params_Get_Work_list_By_WORK_AREA_ID.WORK_AREA_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_WORK_AREA_ID");}
return oList;
}
public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID");}
return oList;
}
public List<User> Get_User_By_USERNAME(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME");}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME(i_Params_Get_User_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME");}
return oList;
}
public List<Work_area> Get_Work_area_By_OWNER_ID(Params_Get_Work_area_By_OWNER_ID i_Params_Get_Work_area_By_OWNER_ID)
{
List<Work_area> oList = new List<Work_area>();
Work_area oWork_area = new Work_area();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_OWNER_ID");}
#region Body Section.
List<DALC.Work_area> oList_DBEntries = _AppContext.Get_Work_area_By_OWNER_ID(i_Params_Get_Work_area_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_OWNER_ID");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_OWNER_ID(Params_Get_Boost_listing_By_OWNER_ID i_Params_Get_Boost_listing_By_OWNER_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_OWNER_ID");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_OWNER_ID(i_Params_Get_Boost_listing_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_OWNER_ID");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID(Params_Get_Boost_listing_By_SERVICE_PROD_ID i_Params_Get_Boost_listing_By_SERVICE_PROD_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_SERVICE_PROD_ID");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_SERVICE_PROD_ID(i_Params_Get_Boost_listing_By_SERVICE_PROD_ID.SERVICE_PROD_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_SERVICE_PROD_ID");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID(Params_Get_Boost_listing_By_BOOST_PRICING_ID i_Params_Get_Boost_listing_By_BOOST_PRICING_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_BOOST_PRICING_ID");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_BOOST_PRICING_ID(i_Params_Get_Boost_listing_By_BOOST_PRICING_ID.BOOST_PRICING_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_BOOST_PRICING_ID");}
return oList;
}
public List<Client> Get_Client_By_PHONE_NUMBER_List(Params_Get_Client_By_PHONE_NUMBER_List i_Params_Get_Client_By_PHONE_NUMBER_List)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_PHONE_NUMBER_List");}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_PHONE_NUMBER_List(i_Params_Get_Client_By_PHONE_NUMBER_List.PHONE_NUMBER_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_PHONE_NUMBER_List");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_BUSINESS_ID_List(Params_Get_Service_prod_By_BUSINESS_ID_List i_Params_Get_Service_prod_By_BUSINESS_ID_List)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_BUSINESS_ID_List");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_BUSINESS_ID_List(i_Params_Get_Service_prod_By_BUSINESS_ID_List.BUSINESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_BUSINESS_ID_List");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID_List(Params_Get_Service_prod_By_SUB_CATEGORY_ID_List i_Params_Get_Service_prod_By_SUB_CATEGORY_ID_List)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_SUB_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_SUB_CATEGORY_ID_List(i_Params_Get_Service_prod_By_SUB_CATEGORY_ID_List.SUB_CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_SUB_CATEGORY_ID_List");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_CATEGORY_ID_List(Params_Get_Sub_category_By_CATEGORY_ID_List i_Params_Get_Sub_category_By_CATEGORY_ID_List)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_CATEGORY_ID_List");}
#region Body Section.
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_CATEGORY_ID_List(i_Params_Get_Sub_category_By_CATEGORY_ID_List.CATEGORY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oList.Add(oSub_category);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_CATEGORY_ID_List");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_BOOKING_ID_List(Params_Get_Coordinates_By_BOOKING_ID_List i_Params_Get_Coordinates_By_BOOKING_ID_List)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_BOOKING_ID_List");}
#region Body Section.
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_BOOKING_ID_List(i_Params_Get_Coordinates_By_BOOKING_ID_List.BOOKING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oList.Add(oCoordinates);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_BOOKING_ID_List");}
return oList;
}
public List<Feedback> Get_Feedback_By_BOOKING_ID_List(Params_Get_Feedback_By_BOOKING_ID_List i_Params_Get_Feedback_By_BOOKING_ID_List)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_BOOKING_ID_List");}
#region Body Section.
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_BOOKING_ID_List(i_Params_Get_Feedback_By_BOOKING_ID_List.BOOKING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_BOOKING_ID_List");}
return oList;
}
public List<Booking> Get_Booking_By_SERVICE_PROD_ID_List(Params_Get_Booking_By_SERVICE_PROD_ID_List i_Params_Get_Booking_By_SERVICE_PROD_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_SERVICE_PROD_ID_List");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_SERVICE_PROD_ID_List(i_Params_Get_Booking_By_SERVICE_PROD_ID_List.SERVICE_PROD_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_SERVICE_PROD_ID_List");}
return oList;
}
public List<Booking> Get_Booking_By_CLIENT_ID_List(Params_Get_Booking_By_CLIENT_ID_List i_Params_Get_Booking_By_CLIENT_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_CLIENT_ID_List");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_CLIENT_ID_List(i_Params_Get_Booking_By_CLIENT_ID_List.CLIENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_CLIENT_ID_List");}
return oList;
}
public List<Booking> Get_Booking_By_WORK_AREA_ID_List(Params_Get_Booking_By_WORK_AREA_ID_List i_Params_Get_Booking_By_WORK_AREA_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_WORK_AREA_ID_List");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_WORK_AREA_ID_List(i_Params_Get_Booking_By_WORK_AREA_ID_List.WORK_AREA_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_WORK_AREA_ID_List");}
return oList;
}
public List<Booking> Get_Booking_By_STATUS_ID_List(Params_Get_Booking_By_STATUS_ID_List i_Params_Get_Booking_By_STATUS_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_STATUS_ID_List");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_STATUS_ID_List(i_Params_Get_Booking_By_STATUS_ID_List.STATUS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_STATUS_ID_List");}
return oList;
}
public List<Booking> Get_Booking_By_BUSINESS_ID_List(Params_Get_Booking_By_BUSINESS_ID_List i_Params_Get_Booking_By_BUSINESS_ID_List)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_BUSINESS_ID_List");}
#region Body Section.
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_BUSINESS_ID_List(i_Params_Get_Booking_By_BUSINESS_ID_List.BUSINESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_BUSINESS_ID_List");}
return oList;
}
public List<Work_list> Get_Work_list_By_BUSINESS_ID_List(Params_Get_Work_list_By_BUSINESS_ID_List i_Params_Get_Work_list_By_BUSINESS_ID_List)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_BUSINESS_ID_List");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_BUSINESS_ID_List(i_Params_Get_Work_list_By_BUSINESS_ID_List.BUSINESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_BUSINESS_ID_List");}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_AREA_ID_List(Params_Get_Work_list_By_WORK_AREA_ID_List i_Params_Get_Work_list_By_WORK_AREA_ID_List)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_WORK_AREA_ID_List");}
#region Body Section.
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_WORK_AREA_ID_List(i_Params_Get_Work_list_By_WORK_AREA_ID_List.WORK_AREA_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_WORK_AREA_ID_List");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID_List(Params_Get_Boost_listing_By_SERVICE_PROD_ID_List i_Params_Get_Boost_listing_By_SERVICE_PROD_ID_List)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_SERVICE_PROD_ID_List");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_SERVICE_PROD_ID_List(i_Params_Get_Boost_listing_By_SERVICE_PROD_ID_List.SERVICE_PROD_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_SERVICE_PROD_ID_List");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID_List(Params_Get_Boost_listing_By_BOOST_PRICING_ID_List i_Params_Get_Boost_listing_By_BOOST_PRICING_ID_List)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_BOOST_PRICING_ID_List");}
#region Body Section.
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_BOOST_PRICING_ID_List(i_Params_Get_Boost_listing_By_BOOST_PRICING_ID_List.BOOST_PRICING_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_BOOST_PRICING_ID_List");}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_Criteria(Params_Get_Boost_pricing_By_Criteria i_Params_Get_Boost_pricing_By_Criteria)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
Boost_pricing oBoost_pricing = new Boost_pricing();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Boost_pricing_By_Criteria.OWNER_ID == null) || (i_Params_Get_Boost_pricing_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Boost_pricing_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_pricing_By_Criteria.START_ROW == null) { i_Params_Get_Boost_pricing_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Boost_pricing_By_Criteria.END_ROW == null) || (i_Params_Get_Boost_pricing_By_Criteria.END_ROW == 0)) { i_Params_Get_Boost_pricing_By_Criteria.END_ROW = 1000000; }
List<DALC.Boost_pricing> oList_DBEntries = _AppContext.Get_Boost_pricing_By_Criteria(i_Params_Get_Boost_pricing_By_Criteria.NAME,i_Params_Get_Boost_pricing_By_Criteria.DESCRIPTION,i_Params_Get_Boost_pricing_By_Criteria.OWNER_ID,i_Params_Get_Boost_pricing_By_Criteria.START_ROW,i_Params_Get_Boost_pricing_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_Criteria");}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_Where(Params_Get_Boost_pricing_By_Where i_Params_Get_Boost_pricing_By_Where)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
Boost_pricing oBoost_pricing = new Boost_pricing();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_pricing_By_Where");}
#region Body Section.
if ((i_Params_Get_Boost_pricing_By_Where.OWNER_ID == null) || (i_Params_Get_Boost_pricing_By_Where.OWNER_ID == 0)) { i_Params_Get_Boost_pricing_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_pricing_By_Where.START_ROW == null) { i_Params_Get_Boost_pricing_By_Where.START_ROW = 0; }
if ((i_Params_Get_Boost_pricing_By_Where.END_ROW == null) || (i_Params_Get_Boost_pricing_By_Where.END_ROW == 0)) { i_Params_Get_Boost_pricing_By_Where.END_ROW = 1000000; }
List<DALC.Boost_pricing> oList_DBEntries = _AppContext.Get_Boost_pricing_By_Where(i_Params_Get_Boost_pricing_By_Where.NAME,i_Params_Get_Boost_pricing_By_Where.DESCRIPTION,i_Params_Get_Boost_pricing_By_Where.OWNER_ID,i_Params_Get_Boost_pricing_By_Where.START_ROW,i_Params_Get_Boost_pricing_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_pricing_By_Where");}
return oList;
}
public List<Client> Get_Client_By_Criteria(Params_Get_Client_By_Criteria i_Params_Get_Client_By_Criteria)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria.START_ROW == null) { i_Params_Get_Client_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria.END_ROW == null) || (i_Params_Get_Client_By_Criteria.END_ROW == 0)) { i_Params_Get_Client_By_Criteria.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria(i_Params_Get_Client_By_Criteria.FIRST_NAME,i_Params_Get_Client_By_Criteria.LAST_NAME,i_Params_Get_Client_By_Criteria.USERNAME,i_Params_Get_Client_By_Criteria.PASSWORD,i_Params_Get_Client_By_Criteria.EMAIL,i_Params_Get_Client_By_Criteria.OWNER_ID,i_Params_Get_Client_By_Criteria.START_ROW,i_Params_Get_Client_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria");}
return oList;
}
public List<Client> Get_Client_By_Where(Params_Get_Client_By_Where i_Params_Get_Client_By_Where)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where");}
#region Body Section.
if ((i_Params_Get_Client_By_Where.OWNER_ID == null) || (i_Params_Get_Client_By_Where.OWNER_ID == 0)) { i_Params_Get_Client_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where.START_ROW == null) { i_Params_Get_Client_By_Where.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where.END_ROW == null) || (i_Params_Get_Client_By_Where.END_ROW == 0)) { i_Params_Get_Client_By_Where.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where(i_Params_Get_Client_By_Where.FIRST_NAME,i_Params_Get_Client_By_Where.LAST_NAME,i_Params_Get_Client_By_Where.USERNAME,i_Params_Get_Client_By_Where.PASSWORD,i_Params_Get_Client_By_Where.EMAIL,i_Params_Get_Client_By_Where.OWNER_ID,i_Params_Get_Client_By_Where.START_ROW,i_Params_Get_Client_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_Criteria(Params_Get_Service_prod_By_Criteria i_Params_Get_Service_prod_By_Criteria)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Service_prod_By_Criteria.OWNER_ID == null) || (i_Params_Get_Service_prod_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Service_prod_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Service_prod_By_Criteria.START_ROW == null) { i_Params_Get_Service_prod_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Service_prod_By_Criteria.END_ROW == null) || (i_Params_Get_Service_prod_By_Criteria.END_ROW == 0)) { i_Params_Get_Service_prod_By_Criteria.END_ROW = 1000000; }
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_Criteria(i_Params_Get_Service_prod_By_Criteria.NAME,i_Params_Get_Service_prod_By_Criteria.DESCRIPTION,i_Params_Get_Service_prod_By_Criteria.OWNER_ID,i_Params_Get_Service_prod_By_Criteria.START_ROW,i_Params_Get_Service_prod_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
i_Params_Get_Service_prod_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_Criteria");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_Where(Params_Get_Service_prod_By_Where i_Params_Get_Service_prod_By_Where)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_Where");}
#region Body Section.
if ((i_Params_Get_Service_prod_By_Where.OWNER_ID == null) || (i_Params_Get_Service_prod_By_Where.OWNER_ID == 0)) { i_Params_Get_Service_prod_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Service_prod_By_Where.START_ROW == null) { i_Params_Get_Service_prod_By_Where.START_ROW = 0; }
if ((i_Params_Get_Service_prod_By_Where.END_ROW == null) || (i_Params_Get_Service_prod_By_Where.END_ROW == 0)) { i_Params_Get_Service_prod_By_Where.END_ROW = 1000000; }
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_Where(i_Params_Get_Service_prod_By_Where.NAME,i_Params_Get_Service_prod_By_Where.DESCRIPTION,i_Params_Get_Service_prod_By_Where.OWNER_ID,i_Params_Get_Service_prod_By_Where.START_ROW,i_Params_Get_Service_prod_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
i_Params_Get_Service_prod_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_Where");}
return oList;
}
public List<Admin> Get_Admin_By_Criteria(Params_Get_Admin_By_Criteria i_Params_Get_Admin_By_Criteria)
{
List<Admin> oList = new List<Admin>();
Admin oAdmin = new Admin();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Admin_By_Criteria.OWNER_ID == null) || (i_Params_Get_Admin_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Admin_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Admin_By_Criteria.START_ROW == null) { i_Params_Get_Admin_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Admin_By_Criteria.END_ROW == null) || (i_Params_Get_Admin_By_Criteria.END_ROW == 0)) { i_Params_Get_Admin_By_Criteria.END_ROW = 1000000; }
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_Criteria(i_Params_Get_Admin_By_Criteria.FIRST_NAME,i_Params_Get_Admin_By_Criteria.LAST_NAME,i_Params_Get_Admin_By_Criteria.USERNAME,i_Params_Get_Admin_By_Criteria.PASSWORD,i_Params_Get_Admin_By_Criteria.EMAIL,i_Params_Get_Admin_By_Criteria.OWNER_ID,i_Params_Get_Admin_By_Criteria.START_ROW,i_Params_Get_Admin_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_Criteria");}
return oList;
}
public List<Admin> Get_Admin_By_Where(Params_Get_Admin_By_Where i_Params_Get_Admin_By_Where)
{
List<Admin> oList = new List<Admin>();
Admin oAdmin = new Admin();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Admin_By_Where");}
#region Body Section.
if ((i_Params_Get_Admin_By_Where.OWNER_ID == null) || (i_Params_Get_Admin_By_Where.OWNER_ID == 0)) { i_Params_Get_Admin_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Admin_By_Where.START_ROW == null) { i_Params_Get_Admin_By_Where.START_ROW = 0; }
if ((i_Params_Get_Admin_By_Where.END_ROW == null) || (i_Params_Get_Admin_By_Where.END_ROW == 0)) { i_Params_Get_Admin_By_Where.END_ROW = 1000000; }
List<DALC.Admin> oList_DBEntries = _AppContext.Get_Admin_By_Where(i_Params_Get_Admin_By_Where.FIRST_NAME,i_Params_Get_Admin_By_Where.LAST_NAME,i_Params_Get_Admin_By_Where.USERNAME,i_Params_Get_Admin_By_Where.PASSWORD,i_Params_Get_Admin_By_Where.EMAIL,i_Params_Get_Admin_By_Where.OWNER_ID,i_Params_Get_Admin_By_Where.START_ROW,i_Params_Get_Admin_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Admin_By_Where");}
return oList;
}
public List<Category> Get_Category_By_Criteria(Params_Get_Category_By_Criteria i_Params_Get_Category_By_Criteria)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Criteria.START_ROW == null) { i_Params_Get_Category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Category_By_Criteria.END_ROW == null) || (i_Params_Get_Category_By_Criteria.END_ROW == 0)) { i_Params_Get_Category_By_Criteria.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Criteria(i_Params_Get_Category_By_Criteria.NAME,i_Params_Get_Category_By_Criteria.DESCRIPTION,i_Params_Get_Category_By_Criteria.OWNER_ID,i_Params_Get_Category_By_Criteria.START_ROW,i_Params_Get_Category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Criteria");}
return oList;
}
public List<Category> Get_Category_By_Where(Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
List<Category> oList = new List<Category>();
Category oCategory = new Category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Category_By_Where");}
#region Body Section.
if ((i_Params_Get_Category_By_Where.OWNER_ID == null) || (i_Params_Get_Category_By_Where.OWNER_ID == 0)) { i_Params_Get_Category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Category_By_Where.START_ROW == null) { i_Params_Get_Category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Category_By_Where.END_ROW == null) || (i_Params_Get_Category_By_Where.END_ROW == 0)) { i_Params_Get_Category_By_Where.END_ROW = 1000000; }
List<DALC.Category> oList_DBEntries = _AppContext.Get_Category_By_Where(i_Params_Get_Category_By_Where.NAME,i_Params_Get_Category_By_Where.DESCRIPTION,i_Params_Get_Category_By_Where.OWNER_ID,i_Params_Get_Category_By_Where.START_ROW,i_Params_Get_Category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Category_By_Where");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_Criteria(Params_Get_Sub_category_By_Criteria i_Params_Get_Sub_category_By_Criteria)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Sub_category_By_Criteria.OWNER_ID == null) || (i_Params_Get_Sub_category_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Sub_category_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Sub_category_By_Criteria.START_ROW == null) { i_Params_Get_Sub_category_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Sub_category_By_Criteria.END_ROW == null) || (i_Params_Get_Sub_category_By_Criteria.END_ROW == 0)) { i_Params_Get_Sub_category_By_Criteria.END_ROW = 1000000; }
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_Criteria(i_Params_Get_Sub_category_By_Criteria.NAME,i_Params_Get_Sub_category_By_Criteria.DESCRIPTION,i_Params_Get_Sub_category_By_Criteria.OWNER_ID,i_Params_Get_Sub_category_By_Criteria.START_ROW,i_Params_Get_Sub_category_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oList.Add(oSub_category);
}
}
i_Params_Get_Sub_category_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_Criteria");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_Where(Params_Get_Sub_category_By_Where i_Params_Get_Sub_category_By_Where)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_Where");}
#region Body Section.
if ((i_Params_Get_Sub_category_By_Where.OWNER_ID == null) || (i_Params_Get_Sub_category_By_Where.OWNER_ID == 0)) { i_Params_Get_Sub_category_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Sub_category_By_Where.START_ROW == null) { i_Params_Get_Sub_category_By_Where.START_ROW = 0; }
if ((i_Params_Get_Sub_category_By_Where.END_ROW == null) || (i_Params_Get_Sub_category_By_Where.END_ROW == 0)) { i_Params_Get_Sub_category_By_Where.END_ROW = 1000000; }
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_Where(i_Params_Get_Sub_category_By_Where.NAME,i_Params_Get_Sub_category_By_Where.DESCRIPTION,i_Params_Get_Sub_category_By_Where.OWNER_ID,i_Params_Get_Sub_category_By_Where.START_ROW,i_Params_Get_Sub_category_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oList.Add(oSub_category);
}
}
i_Params_Get_Sub_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_Where");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_Criteria(Params_Get_Coordinates_By_Criteria i_Params_Get_Coordinates_By_Criteria)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Coordinates_By_Criteria.OWNER_ID == null) || (i_Params_Get_Coordinates_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Coordinates_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coordinates_By_Criteria.START_ROW == null) { i_Params_Get_Coordinates_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Coordinates_By_Criteria.END_ROW == null) || (i_Params_Get_Coordinates_By_Criteria.END_ROW == 0)) { i_Params_Get_Coordinates_By_Criteria.END_ROW = 1000000; }
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_Criteria(i_Params_Get_Coordinates_By_Criteria.LONGITUDE,i_Params_Get_Coordinates_By_Criteria.LATITUDE,i_Params_Get_Coordinates_By_Criteria.DESCRIPTION,i_Params_Get_Coordinates_By_Criteria.OWNER_ID,i_Params_Get_Coordinates_By_Criteria.START_ROW,i_Params_Get_Coordinates_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oList.Add(oCoordinates);
}
}
i_Params_Get_Coordinates_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_Criteria");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_Where(Params_Get_Coordinates_By_Where i_Params_Get_Coordinates_By_Where)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_Where");}
#region Body Section.
if ((i_Params_Get_Coordinates_By_Where.OWNER_ID == null) || (i_Params_Get_Coordinates_By_Where.OWNER_ID == 0)) { i_Params_Get_Coordinates_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Coordinates_By_Where.START_ROW == null) { i_Params_Get_Coordinates_By_Where.START_ROW = 0; }
if ((i_Params_Get_Coordinates_By_Where.END_ROW == null) || (i_Params_Get_Coordinates_By_Where.END_ROW == 0)) { i_Params_Get_Coordinates_By_Where.END_ROW = 1000000; }
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_Where(i_Params_Get_Coordinates_By_Where.LONGITUDE,i_Params_Get_Coordinates_By_Where.LATITUDE,i_Params_Get_Coordinates_By_Where.DESCRIPTION,i_Params_Get_Coordinates_By_Where.OWNER_ID,i_Params_Get_Coordinates_By_Where.START_ROW,i_Params_Get_Coordinates_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oList.Add(oCoordinates);
}
}
i_Params_Get_Coordinates_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_Where");}
return oList;
}
public List<Currency> Get_Currency_By_Criteria(Params_Get_Currency_By_Criteria i_Params_Get_Currency_By_Criteria)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Currency_By_Criteria.OWNER_ID == null) || (i_Params_Get_Currency_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Currency_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Criteria.START_ROW == null) { i_Params_Get_Currency_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Criteria.END_ROW == null) || (i_Params_Get_Currency_By_Criteria.END_ROW == 0)) { i_Params_Get_Currency_By_Criteria.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Criteria(i_Params_Get_Currency_By_Criteria.NAME,i_Params_Get_Currency_By_Criteria.SYMBOL,i_Params_Get_Currency_By_Criteria.ACRONYM,i_Params_Get_Currency_By_Criteria.DESCRIPTION,i_Params_Get_Currency_By_Criteria.OWNER_ID,i_Params_Get_Currency_By_Criteria.START_ROW,i_Params_Get_Currency_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Criteria");}
return oList;
}
public List<Currency> Get_Currency_By_Where(Params_Get_Currency_By_Where i_Params_Get_Currency_By_Where)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Where");}
#region Body Section.
if ((i_Params_Get_Currency_By_Where.OWNER_ID == null) || (i_Params_Get_Currency_By_Where.OWNER_ID == 0)) { i_Params_Get_Currency_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Where.START_ROW == null) { i_Params_Get_Currency_By_Where.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Where.END_ROW == null) || (i_Params_Get_Currency_By_Where.END_ROW == 0)) { i_Params_Get_Currency_By_Where.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Where(i_Params_Get_Currency_By_Where.NAME,i_Params_Get_Currency_By_Where.SYMBOL,i_Params_Get_Currency_By_Where.ACRONYM,i_Params_Get_Currency_By_Where.DESCRIPTION,i_Params_Get_Currency_By_Where.OWNER_ID,i_Params_Get_Currency_By_Where.START_ROW,i_Params_Get_Currency_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Where");}
return oList;
}
public List<Status> Get_Status_By_Criteria(Params_Get_Status_By_Criteria i_Params_Get_Status_By_Criteria)
{
List<Status> oList = new List<Status>();
Status oStatus = new Status();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Status_By_Criteria.OWNER_ID == null) || (i_Params_Get_Status_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Status_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Status_By_Criteria.START_ROW == null) { i_Params_Get_Status_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Status_By_Criteria.END_ROW == null) || (i_Params_Get_Status_By_Criteria.END_ROW == 0)) { i_Params_Get_Status_By_Criteria.END_ROW = 1000000; }
List<DALC.Status> oList_DBEntries = _AppContext.Get_Status_By_Criteria(i_Params_Get_Status_By_Criteria.NAME,i_Params_Get_Status_By_Criteria.DESCRIPTION,i_Params_Get_Status_By_Criteria.OWNER_ID,i_Params_Get_Status_By_Criteria.START_ROW,i_Params_Get_Status_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_Criteria");}
return oList;
}
public List<Status> Get_Status_By_Where(Params_Get_Status_By_Where i_Params_Get_Status_By_Where)
{
List<Status> oList = new List<Status>();
Status oStatus = new Status();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Status_By_Where");}
#region Body Section.
if ((i_Params_Get_Status_By_Where.OWNER_ID == null) || (i_Params_Get_Status_By_Where.OWNER_ID == 0)) { i_Params_Get_Status_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Status_By_Where.START_ROW == null) { i_Params_Get_Status_By_Where.START_ROW = 0; }
if ((i_Params_Get_Status_By_Where.END_ROW == null) || (i_Params_Get_Status_By_Where.END_ROW == 0)) { i_Params_Get_Status_By_Where.END_ROW = 1000000; }
List<DALC.Status> oList_DBEntries = _AppContext.Get_Status_By_Where(i_Params_Get_Status_By_Where.NAME,i_Params_Get_Status_By_Where.DESCRIPTION,i_Params_Get_Status_By_Where.OWNER_ID,i_Params_Get_Status_By_Where.START_ROW,i_Params_Get_Status_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Status_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria(Params_Get_Owner_By_Criteria i_Params_Get_Owner_By_Criteria)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria.START_ROW == null) { i_Params_Get_Owner_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria.END_ROW == null) || (i_Params_Get_Owner_By_Criteria.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria(i_Params_Get_Owner_By_Criteria.CODE,i_Params_Get_Owner_By_Criteria.DESCRIPTION,i_Params_Get_Owner_By_Criteria.OWNER_ID,i_Params_Get_Owner_By_Criteria.START_ROW,i_Params_Get_Owner_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria");}
return oList;
}
public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where.OWNER_ID == null) || (i_Params_Get_Owner_By_Where.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where.START_ROW == null) { i_Params_Get_Owner_By_Where.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where.END_ROW == null) || (i_Params_Get_Owner_By_Where.END_ROW == 0)) { i_Params_Get_Owner_By_Where.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE,i_Params_Get_Owner_By_Where.DESCRIPTION,i_Params_Get_Owner_By_Where.OWNER_ID,i_Params_Get_Owner_By_Where.START_ROW,i_Params_Get_Owner_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2(Params_Get_Owner_By_Criteria_V2 i_Params_Get_Owner_By_Criteria_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria_V2.START_ROW == null) { i_Params_Get_Owner_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Owner_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria_V2(i_Params_Get_Owner_By_Criteria_V2.CODE,i_Params_Get_Owner_By_Criteria_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Criteria_V2.DESCRIPTION,i_Params_Get_Owner_By_Criteria_V2.OWNER_ID,i_Params_Get_Owner_By_Criteria_V2.START_ROW,i_Params_Get_Owner_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Where_V2(Params_Get_Owner_By_Where_V2 i_Params_Get_Owner_By_Where_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Owner_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where_V2.START_ROW == null) { i_Params_Get_Owner_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where_V2.END_ROW == null) || (i_Params_Get_Owner_By_Where_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Where_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where_V2(i_Params_Get_Owner_By_Where_V2.CODE,i_Params_Get_Owner_By_Where_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Where_V2.DESCRIPTION,i_Params_Get_Owner_By_Where_V2.OWNER_ID,i_Params_Get_Owner_By_Where_V2.START_ROW,i_Params_Get_Owner_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where_V2");}
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria(Params_Get_Feedback_By_Criteria i_Params_Get_Feedback_By_Criteria)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Criteria.OWNER_ID == null) || (i_Params_Get_Feedback_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Criteria.START_ROW == null) { i_Params_Get_Feedback_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Criteria.END_ROW == null) || (i_Params_Get_Feedback_By_Criteria.END_ROW == 0)) { i_Params_Get_Feedback_By_Criteria.END_ROW = 1000000; }
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Criteria(i_Params_Get_Feedback_By_Criteria.COMMENT,i_Params_Get_Feedback_By_Criteria.DESCRIPTION,i_Params_Get_Feedback_By_Criteria.OWNER_ID,i_Params_Get_Feedback_By_Criteria.START_ROW,i_Params_Get_Feedback_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Criteria");}
return oList;
}
public List<Feedback> Get_Feedback_By_Where(Params_Get_Feedback_By_Where i_Params_Get_Feedback_By_Where)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Where");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Where.OWNER_ID == null) || (i_Params_Get_Feedback_By_Where.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Where.START_ROW == null) { i_Params_Get_Feedback_By_Where.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Where.END_ROW == null) || (i_Params_Get_Feedback_By_Where.END_ROW == 0)) { i_Params_Get_Feedback_By_Where.END_ROW = 1000000; }
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Where(i_Params_Get_Feedback_By_Where.COMMENT,i_Params_Get_Feedback_By_Where.DESCRIPTION,i_Params_Get_Feedback_By_Where.OWNER_ID,i_Params_Get_Feedback_By_Where.START_ROW,i_Params_Get_Feedback_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Where");}
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_V2(Params_Get_Feedback_By_Criteria_V2 i_Params_Get_Feedback_By_Criteria_V2)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Feedback_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Criteria_V2.START_ROW == null) { i_Params_Get_Feedback_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Feedback_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Feedback_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Criteria_V2(i_Params_Get_Feedback_By_Criteria_V2.COMMENT,i_Params_Get_Feedback_By_Criteria_V2.DATE,i_Params_Get_Feedback_By_Criteria_V2.DESCRIPTION,i_Params_Get_Feedback_By_Criteria_V2.OWNER_ID,i_Params_Get_Feedback_By_Criteria_V2.START_ROW,i_Params_Get_Feedback_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Criteria_V2");}
return oList;
}
public List<Feedback> Get_Feedback_By_Where_V2(Params_Get_Feedback_By_Where_V2 i_Params_Get_Feedback_By_Where_V2)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Feedback_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Feedback_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Feedback_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Feedback_By_Where_V2.START_ROW == null) { i_Params_Get_Feedback_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Feedback_By_Where_V2.END_ROW == null) || (i_Params_Get_Feedback_By_Where_V2.END_ROW == 0)) { i_Params_Get_Feedback_By_Where_V2.END_ROW = 1000000; }
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Where_V2(i_Params_Get_Feedback_By_Where_V2.COMMENT,i_Params_Get_Feedback_By_Where_V2.DATE,i_Params_Get_Feedback_By_Where_V2.DESCRIPTION,i_Params_Get_Feedback_By_Where_V2.OWNER_ID,i_Params_Get_Feedback_By_Where_V2.START_ROW,i_Params_Get_Feedback_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Where_V2");}
return oList;
}
public List<Booking> Get_Booking_By_Criteria(Params_Get_Booking_By_Criteria i_Params_Get_Booking_By_Criteria)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Booking_By_Criteria.OWNER_ID == null) || (i_Params_Get_Booking_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Booking_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Criteria.START_ROW == null) { i_Params_Get_Booking_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Criteria.END_ROW == null) || (i_Params_Get_Booking_By_Criteria.END_ROW == 0)) { i_Params_Get_Booking_By_Criteria.END_ROW = 1000000; }
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Criteria(i_Params_Get_Booking_By_Criteria.DESCRIPTION,i_Params_Get_Booking_By_Criteria.OWNER_ID,i_Params_Get_Booking_By_Criteria.START_ROW,i_Params_Get_Booking_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Criteria");}
return oList;
}
public List<Booking> Get_Booking_By_Where(Params_Get_Booking_By_Where i_Params_Get_Booking_By_Where)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Where");}
#region Body Section.
if ((i_Params_Get_Booking_By_Where.OWNER_ID == null) || (i_Params_Get_Booking_By_Where.OWNER_ID == 0)) { i_Params_Get_Booking_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Where.START_ROW == null) { i_Params_Get_Booking_By_Where.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Where.END_ROW == null) || (i_Params_Get_Booking_By_Where.END_ROW == 0)) { i_Params_Get_Booking_By_Where.END_ROW = 1000000; }
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Where(i_Params_Get_Booking_By_Where.DESCRIPTION,i_Params_Get_Booking_By_Where.OWNER_ID,i_Params_Get_Booking_By_Where.START_ROW,i_Params_Get_Booking_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Where");}
return oList;
}
public List<Booking> Get_Booking_By_Criteria_V2(Params_Get_Booking_By_Criteria_V2 i_Params_Get_Booking_By_Criteria_V2)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Booking_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Booking_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Booking_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Criteria_V2.START_ROW == null) { i_Params_Get_Booking_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Booking_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Booking_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Criteria_V2(i_Params_Get_Booking_By_Criteria_V2.DATE,i_Params_Get_Booking_By_Criteria_V2.DESCRIPTION,i_Params_Get_Booking_By_Criteria_V2.OWNER_ID,i_Params_Get_Booking_By_Criteria_V2.START_ROW,i_Params_Get_Booking_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Criteria_V2");}
return oList;
}
public List<Booking> Get_Booking_By_Where_V2(Params_Get_Booking_By_Where_V2 i_Params_Get_Booking_By_Where_V2)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Booking_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Booking_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Booking_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Booking_By_Where_V2.START_ROW == null) { i_Params_Get_Booking_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Booking_By_Where_V2.END_ROW == null) || (i_Params_Get_Booking_By_Where_V2.END_ROW == 0)) { i_Params_Get_Booking_By_Where_V2.END_ROW = 1000000; }
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Where_V2(i_Params_Get_Booking_By_Where_V2.DATE,i_Params_Get_Booking_By_Where_V2.DESCRIPTION,i_Params_Get_Booking_By_Where_V2.OWNER_ID,i_Params_Get_Booking_By_Where_V2.START_ROW,i_Params_Get_Booking_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Where_V2");}
return oList;
}
public List<Business> Get_Business_By_Criteria(Params_Get_Business_By_Criteria i_Params_Get_Business_By_Criteria)
{
List<Business> oList = new List<Business>();
Business oBusiness = new Business();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Business_By_Criteria.OWNER_ID == null) || (i_Params_Get_Business_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Business_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Business_By_Criteria.START_ROW == null) { i_Params_Get_Business_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Business_By_Criteria.END_ROW == null) || (i_Params_Get_Business_By_Criteria.END_ROW == 0)) { i_Params_Get_Business_By_Criteria.END_ROW = 1000000; }
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_Criteria(i_Params_Get_Business_By_Criteria.NAME,i_Params_Get_Business_By_Criteria.USERNAME,i_Params_Get_Business_By_Criteria.PASSWORD,i_Params_Get_Business_By_Criteria.EMAIL,i_Params_Get_Business_By_Criteria.DESCRIPTION,i_Params_Get_Business_By_Criteria.OWNER_ID,i_Params_Get_Business_By_Criteria.START_ROW,i_Params_Get_Business_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_Criteria");}
return oList;
}
public List<Business> Get_Business_By_Where(Params_Get_Business_By_Where i_Params_Get_Business_By_Where)
{
List<Business> oList = new List<Business>();
Business oBusiness = new Business();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Business_By_Where");}
#region Body Section.
if ((i_Params_Get_Business_By_Where.OWNER_ID == null) || (i_Params_Get_Business_By_Where.OWNER_ID == 0)) { i_Params_Get_Business_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Business_By_Where.START_ROW == null) { i_Params_Get_Business_By_Where.START_ROW = 0; }
if ((i_Params_Get_Business_By_Where.END_ROW == null) || (i_Params_Get_Business_By_Where.END_ROW == 0)) { i_Params_Get_Business_By_Where.END_ROW = 1000000; }
List<DALC.Business> oList_DBEntries = _AppContext.Get_Business_By_Where(i_Params_Get_Business_By_Where.NAME,i_Params_Get_Business_By_Where.USERNAME,i_Params_Get_Business_By_Where.PASSWORD,i_Params_Get_Business_By_Where.EMAIL,i_Params_Get_Business_By_Where.DESCRIPTION,i_Params_Get_Business_By_Where.OWNER_ID,i_Params_Get_Business_By_Where.START_ROW,i_Params_Get_Business_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Business_By_Where");}
return oList;
}
public List<Work_list> Get_Work_list_By_Criteria(Params_Get_Work_list_By_Criteria i_Params_Get_Work_list_By_Criteria)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Work_list_By_Criteria.OWNER_ID == null) || (i_Params_Get_Work_list_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Work_list_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_list_By_Criteria.START_ROW == null) { i_Params_Get_Work_list_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Work_list_By_Criteria.END_ROW == null) || (i_Params_Get_Work_list_By_Criteria.END_ROW == 0)) { i_Params_Get_Work_list_By_Criteria.END_ROW = 1000000; }
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_Criteria(i_Params_Get_Work_list_By_Criteria.DESCRIPTION,i_Params_Get_Work_list_By_Criteria.OWNER_ID,i_Params_Get_Work_list_By_Criteria.START_ROW,i_Params_Get_Work_list_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
i_Params_Get_Work_list_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_Criteria");}
return oList;
}
public List<Work_list> Get_Work_list_By_Where(Params_Get_Work_list_By_Where i_Params_Get_Work_list_By_Where)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_Where");}
#region Body Section.
if ((i_Params_Get_Work_list_By_Where.OWNER_ID == null) || (i_Params_Get_Work_list_By_Where.OWNER_ID == 0)) { i_Params_Get_Work_list_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_list_By_Where.START_ROW == null) { i_Params_Get_Work_list_By_Where.START_ROW = 0; }
if ((i_Params_Get_Work_list_By_Where.END_ROW == null) || (i_Params_Get_Work_list_By_Where.END_ROW == 0)) { i_Params_Get_Work_list_By_Where.END_ROW = 1000000; }
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_Where(i_Params_Get_Work_list_By_Where.DESCRIPTION,i_Params_Get_Work_list_By_Where.OWNER_ID,i_Params_Get_Work_list_By_Where.START_ROW,i_Params_Get_Work_list_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
i_Params_Get_Work_list_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_Where");}
return oList;
}
public List<User> Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria");}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria");}
return oList;
}
public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where");}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where");}
return oList;
}
public List<Work_area> Get_Work_area_By_Criteria(Params_Get_Work_area_By_Criteria i_Params_Get_Work_area_By_Criteria)
{
List<Work_area> oList = new List<Work_area>();
Work_area oWork_area = new Work_area();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Work_area_By_Criteria.OWNER_ID == null) || (i_Params_Get_Work_area_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Work_area_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_area_By_Criteria.START_ROW == null) { i_Params_Get_Work_area_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Work_area_By_Criteria.END_ROW == null) || (i_Params_Get_Work_area_By_Criteria.END_ROW == 0)) { i_Params_Get_Work_area_By_Criteria.END_ROW = 1000000; }
List<DALC.Work_area> oList_DBEntries = _AppContext.Get_Work_area_By_Criteria(i_Params_Get_Work_area_By_Criteria.NAME,i_Params_Get_Work_area_By_Criteria.DESCRIPTION,i_Params_Get_Work_area_By_Criteria.OWNER_ID,i_Params_Get_Work_area_By_Criteria.START_ROW,i_Params_Get_Work_area_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_Criteria");}
return oList;
}
public List<Work_area> Get_Work_area_By_Where(Params_Get_Work_area_By_Where i_Params_Get_Work_area_By_Where)
{
List<Work_area> oList = new List<Work_area>();
Work_area oWork_area = new Work_area();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_area_By_Where");}
#region Body Section.
if ((i_Params_Get_Work_area_By_Where.OWNER_ID == null) || (i_Params_Get_Work_area_By_Where.OWNER_ID == 0)) { i_Params_Get_Work_area_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Work_area_By_Where.START_ROW == null) { i_Params_Get_Work_area_By_Where.START_ROW = 0; }
if ((i_Params_Get_Work_area_By_Where.END_ROW == null) || (i_Params_Get_Work_area_By_Where.END_ROW == 0)) { i_Params_Get_Work_area_By_Where.END_ROW = 1000000; }
List<DALC.Work_area> oList_DBEntries = _AppContext.Get_Work_area_By_Where(i_Params_Get_Work_area_By_Where.NAME,i_Params_Get_Work_area_By_Where.DESCRIPTION,i_Params_Get_Work_area_By_Where.OWNER_ID,i_Params_Get_Work_area_By_Where.START_ROW,i_Params_Get_Work_area_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_area_By_Where");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria(Params_Get_Boost_listing_By_Criteria i_Params_Get_Boost_listing_By_Criteria)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Criteria");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Criteria.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Criteria.START_ROW == null) { i_Params_Get_Boost_listing_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Criteria.END_ROW == null) || (i_Params_Get_Boost_listing_By_Criteria.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Criteria.END_ROW = 1000000; }
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Criteria(i_Params_Get_Boost_listing_By_Criteria.DESCRIPTION,i_Params_Get_Boost_listing_By_Criteria.OWNER_ID,i_Params_Get_Boost_listing_By_Criteria.START_ROW,i_Params_Get_Boost_listing_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Criteria");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where(Params_Get_Boost_listing_By_Where i_Params_Get_Boost_listing_By_Where)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Where");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Where.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Where.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Where.START_ROW == null) { i_Params_Get_Boost_listing_By_Where.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Where.END_ROW == null) || (i_Params_Get_Boost_listing_By_Where.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Where.END_ROW = 1000000; }
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Where(i_Params_Get_Boost_listing_By_Where.DESCRIPTION,i_Params_Get_Boost_listing_By_Where.OWNER_ID,i_Params_Get_Boost_listing_By_Where.START_ROW,i_Params_Get_Boost_listing_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Where");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_V2(Params_Get_Boost_listing_By_Criteria_V2 i_Params_Get_Boost_listing_By_Criteria_V2)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Criteria_V2");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Criteria_V2.START_ROW == null) { i_Params_Get_Boost_listing_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Boost_listing_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Criteria_V2(i_Params_Get_Boost_listing_By_Criteria_V2.START_DATE,i_Params_Get_Boost_listing_By_Criteria_V2.DESCRIPTION,i_Params_Get_Boost_listing_By_Criteria_V2.OWNER_ID,i_Params_Get_Boost_listing_By_Criteria_V2.START_ROW,i_Params_Get_Boost_listing_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Criteria_V2");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_V2(Params_Get_Boost_listing_By_Where_V2 i_Params_Get_Boost_listing_By_Where_V2)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Where_V2");}
#region Body Section.
if ((i_Params_Get_Boost_listing_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Boost_listing_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Boost_listing_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Boost_listing_By_Where_V2.START_ROW == null) { i_Params_Get_Boost_listing_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Boost_listing_By_Where_V2.END_ROW == null) || (i_Params_Get_Boost_listing_By_Where_V2.END_ROW == 0)) { i_Params_Get_Boost_listing_By_Where_V2.END_ROW = 1000000; }
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Where_V2(i_Params_Get_Boost_listing_By_Where_V2.START_DATE,i_Params_Get_Boost_listing_By_Where_V2.DESCRIPTION,i_Params_Get_Boost_listing_By_Where_V2.OWNER_ID,i_Params_Get_Boost_listing_By_Where_V2.START_ROW,i_Params_Get_Boost_listing_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Where_V2");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_Criteria_InList(Params_Get_Service_prod_By_Criteria_InList i_Params_Get_Service_prod_By_Criteria_InList)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Service_prod_By_Criteria_InList_SP oParams_Get_Service_prod_By_Criteria_InList_SP = new Params_Get_Service_prod_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_Criteria_InList");}
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
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_Criteria_InList(i_Params_Get_Service_prod_By_Criteria_InList.NAME,i_Params_Get_Service_prod_By_Criteria_InList.DESCRIPTION,i_Params_Get_Service_prod_By_Criteria_InList.BUSINESS_ID_LIST,i_Params_Get_Service_prod_By_Criteria_InList.SUB_CATEGORY_ID_LIST,i_Params_Get_Service_prod_By_Criteria_InList.OWNER_ID,i_Params_Get_Service_prod_By_Criteria_InList.START_ROW,i_Params_Get_Service_prod_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
i_Params_Get_Service_prod_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Service_prod_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Service_prod_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_Criteria_InList");}
return oList;
}
public List<Service_prod> Get_Service_prod_By_Where_InList(Params_Get_Service_prod_By_Where_InList i_Params_Get_Service_prod_By_Where_InList)
{
List<Service_prod> oList = new List<Service_prod>();
Service_prod oService_prod = new Service_prod();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Service_prod_By_Where_InList_SP oParams_Get_Service_prod_By_Where_InList_SP = new Params_Get_Service_prod_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Service_prod_By_Where_InList");}
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
List<DALC.Service_prod> oList_DBEntries = _AppContext.Get_Service_prod_By_Where_InList(i_Params_Get_Service_prod_By_Where_InList.NAME,i_Params_Get_Service_prod_By_Where_InList.DESCRIPTION,i_Params_Get_Service_prod_By_Where_InList.BUSINESS_ID_LIST,i_Params_Get_Service_prod_By_Where_InList.SUB_CATEGORY_ID_LIST,i_Params_Get_Service_prod_By_Where_InList.OWNER_ID,i_Params_Get_Service_prod_By_Where_InList.START_ROW,i_Params_Get_Service_prod_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oService_prod = new Service_prod();
oTools.CopyPropValues(oDBEntry, oService_prod);
oList.Add(oService_prod);
}
}
i_Params_Get_Service_prod_By_Where_InList.TOTAL_COUNT = oParams_Get_Service_prod_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Service_prod_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Service_prod_By_Where_InList");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_Criteria_InList(Params_Get_Sub_category_By_Criteria_InList i_Params_Get_Sub_category_By_Criteria_InList)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Sub_category_By_Criteria_InList_SP oParams_Get_Sub_category_By_Criteria_InList_SP = new Params_Get_Sub_category_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_Criteria_InList");}
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
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_Criteria_InList(i_Params_Get_Sub_category_By_Criteria_InList.NAME,i_Params_Get_Sub_category_By_Criteria_InList.DESCRIPTION,i_Params_Get_Sub_category_By_Criteria_InList.CATEGORY_ID_LIST,i_Params_Get_Sub_category_By_Criteria_InList.OWNER_ID,i_Params_Get_Sub_category_By_Criteria_InList.START_ROW,i_Params_Get_Sub_category_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oList.Add(oSub_category);
}
}
i_Params_Get_Sub_category_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Sub_category_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Sub_category_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_Criteria_InList");}
return oList;
}
public List<Sub_category> Get_Sub_category_By_Where_InList(Params_Get_Sub_category_By_Where_InList i_Params_Get_Sub_category_By_Where_InList)
{
List<Sub_category> oList = new List<Sub_category>();
Sub_category oSub_category = new Sub_category();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Sub_category_By_Where_InList_SP oParams_Get_Sub_category_By_Where_InList_SP = new Params_Get_Sub_category_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Sub_category_By_Where_InList");}
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
List<DALC.Sub_category> oList_DBEntries = _AppContext.Get_Sub_category_By_Where_InList(i_Params_Get_Sub_category_By_Where_InList.NAME,i_Params_Get_Sub_category_By_Where_InList.DESCRIPTION,i_Params_Get_Sub_category_By_Where_InList.CATEGORY_ID_LIST,i_Params_Get_Sub_category_By_Where_InList.OWNER_ID,i_Params_Get_Sub_category_By_Where_InList.START_ROW,i_Params_Get_Sub_category_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSub_category = new Sub_category();
oTools.CopyPropValues(oDBEntry, oSub_category);
oList.Add(oSub_category);
}
}
i_Params_Get_Sub_category_By_Where_InList.TOTAL_COUNT = oParams_Get_Sub_category_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Sub_category_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Sub_category_By_Where_InList");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_Criteria_InList(Params_Get_Coordinates_By_Criteria_InList i_Params_Get_Coordinates_By_Criteria_InList)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Coordinates_By_Criteria_InList_SP oParams_Get_Coordinates_By_Criteria_InList_SP = new Params_Get_Coordinates_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_Criteria_InList");}
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
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_Criteria_InList(i_Params_Get_Coordinates_By_Criteria_InList.LONGITUDE,i_Params_Get_Coordinates_By_Criteria_InList.LATITUDE,i_Params_Get_Coordinates_By_Criteria_InList.DESCRIPTION,i_Params_Get_Coordinates_By_Criteria_InList.BOOKING_ID_LIST,i_Params_Get_Coordinates_By_Criteria_InList.OWNER_ID,i_Params_Get_Coordinates_By_Criteria_InList.START_ROW,i_Params_Get_Coordinates_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oList.Add(oCoordinates);
}
}
i_Params_Get_Coordinates_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Coordinates_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Coordinates_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_Criteria_InList");}
return oList;
}
public List<Coordinates> Get_Coordinates_By_Where_InList(Params_Get_Coordinates_By_Where_InList i_Params_Get_Coordinates_By_Where_InList)
{
List<Coordinates> oList = new List<Coordinates>();
Coordinates oCoordinates = new Coordinates();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Coordinates_By_Where_InList_SP oParams_Get_Coordinates_By_Where_InList_SP = new Params_Get_Coordinates_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Coordinates_By_Where_InList");}
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
List<DALC.Coordinates> oList_DBEntries = _AppContext.Get_Coordinates_By_Where_InList(i_Params_Get_Coordinates_By_Where_InList.LONGITUDE,i_Params_Get_Coordinates_By_Where_InList.LATITUDE,i_Params_Get_Coordinates_By_Where_InList.DESCRIPTION,i_Params_Get_Coordinates_By_Where_InList.BOOKING_ID_LIST,i_Params_Get_Coordinates_By_Where_InList.OWNER_ID,i_Params_Get_Coordinates_By_Where_InList.START_ROW,i_Params_Get_Coordinates_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCoordinates = new Coordinates();
oTools.CopyPropValues(oDBEntry, oCoordinates);
oList.Add(oCoordinates);
}
}
i_Params_Get_Coordinates_By_Where_InList.TOTAL_COUNT = oParams_Get_Coordinates_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Coordinates_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Coordinates_By_Where_InList");}
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_InList(Params_Get_Feedback_By_Criteria_InList i_Params_Get_Feedback_By_Criteria_InList)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Feedback_By_Criteria_InList_SP oParams_Get_Feedback_By_Criteria_InList_SP = new Params_Get_Feedback_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Criteria_InList");}
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
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Criteria_InList(i_Params_Get_Feedback_By_Criteria_InList.COMMENT,i_Params_Get_Feedback_By_Criteria_InList.DESCRIPTION,i_Params_Get_Feedback_By_Criteria_InList.BOOKING_ID_LIST,i_Params_Get_Feedback_By_Criteria_InList.OWNER_ID,i_Params_Get_Feedback_By_Criteria_InList.START_ROW,i_Params_Get_Feedback_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Feedback_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Feedback_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Criteria_InList");}
return oList;
}
public List<Feedback> Get_Feedback_By_Where_InList(Params_Get_Feedback_By_Where_InList i_Params_Get_Feedback_By_Where_InList)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Feedback_By_Where_InList_SP oParams_Get_Feedback_By_Where_InList_SP = new Params_Get_Feedback_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Where_InList");}
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
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Where_InList(i_Params_Get_Feedback_By_Where_InList.COMMENT,i_Params_Get_Feedback_By_Where_InList.DESCRIPTION,i_Params_Get_Feedback_By_Where_InList.BOOKING_ID_LIST,i_Params_Get_Feedback_By_Where_InList.OWNER_ID,i_Params_Get_Feedback_By_Where_InList.START_ROW,i_Params_Get_Feedback_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Where_InList.TOTAL_COUNT = oParams_Get_Feedback_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Feedback_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Where_InList");}
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_InList_V2(Params_Get_Feedback_By_Criteria_InList_V2 i_Params_Get_Feedback_By_Criteria_InList_V2)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Feedback_By_Criteria_InList_SP_V2 oParams_Get_Feedback_By_Criteria_InList_SP_V2 = new Params_Get_Feedback_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Criteria_InList_V2");}
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
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Criteria_InList_V2(i_Params_Get_Feedback_By_Criteria_InList_V2.COMMENT,i_Params_Get_Feedback_By_Criteria_InList_V2.DATE,i_Params_Get_Feedback_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Feedback_By_Criteria_InList_V2.BOOKING_ID_LIST,i_Params_Get_Feedback_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Feedback_By_Criteria_InList_V2.START_ROW,i_Params_Get_Feedback_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Feedback_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Feedback_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Criteria_InList_V2");}
return oList;
}
public List<Feedback> Get_Feedback_By_Where_InList_V2(Params_Get_Feedback_By_Where_InList_V2 i_Params_Get_Feedback_By_Where_InList_V2)
{
List<Feedback> oList = new List<Feedback>();
Feedback oFeedback = new Feedback();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Feedback_By_Where_InList_SP_V2 oParams_Get_Feedback_By_Where_InList_SP_V2 = new Params_Get_Feedback_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Feedback_By_Where_InList_V2");}
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
List<DALC.Feedback> oList_DBEntries = _AppContext.Get_Feedback_By_Where_InList_V2(i_Params_Get_Feedback_By_Where_InList_V2.COMMENT,i_Params_Get_Feedback_By_Where_InList_V2.DATE,i_Params_Get_Feedback_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Feedback_By_Where_InList_V2.BOOKING_ID_LIST,i_Params_Get_Feedback_By_Where_InList_V2.OWNER_ID,i_Params_Get_Feedback_By_Where_InList_V2.START_ROW,i_Params_Get_Feedback_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFeedback = new Feedback();
oTools.CopyPropValues(oDBEntry, oFeedback);
oList.Add(oFeedback);
}
}
i_Params_Get_Feedback_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Feedback_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Feedback_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Feedback_By_Where_InList_V2");}
return oList;
}
public List<Booking> Get_Booking_By_Criteria_InList(Params_Get_Booking_By_Criteria_InList i_Params_Get_Booking_By_Criteria_InList)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Booking_By_Criteria_InList_SP oParams_Get_Booking_By_Criteria_InList_SP = new Params_Get_Booking_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Criteria_InList");}
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
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Criteria_InList(i_Params_Get_Booking_By_Criteria_InList.DESCRIPTION,i_Params_Get_Booking_By_Criteria_InList.SERVICE_PROD_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.CLIENT_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.BUSINESS_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.WORK_AREA_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.STATUS_ID_LIST,i_Params_Get_Booking_By_Criteria_InList.OWNER_ID,i_Params_Get_Booking_By_Criteria_InList.START_ROW,i_Params_Get_Booking_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Booking_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Booking_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Criteria_InList");}
return oList;
}
public List<Booking> Get_Booking_By_Where_InList(Params_Get_Booking_By_Where_InList i_Params_Get_Booking_By_Where_InList)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Booking_By_Where_InList_SP oParams_Get_Booking_By_Where_InList_SP = new Params_Get_Booking_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Where_InList");}
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
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Where_InList(i_Params_Get_Booking_By_Where_InList.DESCRIPTION,i_Params_Get_Booking_By_Where_InList.SERVICE_PROD_ID_LIST,i_Params_Get_Booking_By_Where_InList.CLIENT_ID_LIST,i_Params_Get_Booking_By_Where_InList.BUSINESS_ID_LIST,i_Params_Get_Booking_By_Where_InList.WORK_AREA_ID_LIST,i_Params_Get_Booking_By_Where_InList.STATUS_ID_LIST,i_Params_Get_Booking_By_Where_InList.OWNER_ID,i_Params_Get_Booking_By_Where_InList.START_ROW,i_Params_Get_Booking_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Where_InList.TOTAL_COUNT = oParams_Get_Booking_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Booking_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Where_InList");}
return oList;
}
public List<Booking> Get_Booking_By_Criteria_InList_V2(Params_Get_Booking_By_Criteria_InList_V2 i_Params_Get_Booking_By_Criteria_InList_V2)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Booking_By_Criteria_InList_SP_V2 oParams_Get_Booking_By_Criteria_InList_SP_V2 = new Params_Get_Booking_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Criteria_InList_V2");}
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
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Criteria_InList_V2(i_Params_Get_Booking_By_Criteria_InList_V2.DATE,i_Params_Get_Booking_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Booking_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.CLIENT_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.BUSINESS_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.WORK_AREA_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.STATUS_ID_LIST,i_Params_Get_Booking_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Booking_By_Criteria_InList_V2.START_ROW,i_Params_Get_Booking_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Booking_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Booking_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Criteria_InList_V2");}
return oList;
}
public List<Booking> Get_Booking_By_Where_InList_V2(Params_Get_Booking_By_Where_InList_V2 i_Params_Get_Booking_By_Where_InList_V2)
{
List<Booking> oList = new List<Booking>();
Booking oBooking = new Booking();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Booking_By_Where_InList_SP_V2 oParams_Get_Booking_By_Where_InList_SP_V2 = new Params_Get_Booking_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Booking_By_Where_InList_V2");}
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
List<DALC.Booking> oList_DBEntries = _AppContext.Get_Booking_By_Where_InList_V2(i_Params_Get_Booking_By_Where_InList_V2.DATE,i_Params_Get_Booking_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Booking_By_Where_InList_V2.SERVICE_PROD_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.CLIENT_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.BUSINESS_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.WORK_AREA_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.STATUS_ID_LIST,i_Params_Get_Booking_By_Where_InList_V2.OWNER_ID,i_Params_Get_Booking_By_Where_InList_V2.START_ROW,i_Params_Get_Booking_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBooking = new Booking();
oTools.CopyPropValues(oDBEntry, oBooking);
oList.Add(oBooking);
}
}
i_Params_Get_Booking_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Booking_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Booking_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Booking_By_Where_InList_V2");}
return oList;
}
public List<Work_list> Get_Work_list_By_Criteria_InList(Params_Get_Work_list_By_Criteria_InList i_Params_Get_Work_list_By_Criteria_InList)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Work_list_By_Criteria_InList_SP oParams_Get_Work_list_By_Criteria_InList_SP = new Params_Get_Work_list_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_Criteria_InList");}
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
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_Criteria_InList(i_Params_Get_Work_list_By_Criteria_InList.DESCRIPTION,i_Params_Get_Work_list_By_Criteria_InList.BUSINESS_ID_LIST,i_Params_Get_Work_list_By_Criteria_InList.WORK_AREA_ID_LIST,i_Params_Get_Work_list_By_Criteria_InList.OWNER_ID,i_Params_Get_Work_list_By_Criteria_InList.START_ROW,i_Params_Get_Work_list_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
i_Params_Get_Work_list_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Work_list_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Work_list_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_Criteria_InList");}
return oList;
}
public List<Work_list> Get_Work_list_By_Where_InList(Params_Get_Work_list_By_Where_InList i_Params_Get_Work_list_By_Where_InList)
{
List<Work_list> oList = new List<Work_list>();
Work_list oWork_list = new Work_list();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Work_list_By_Where_InList_SP oParams_Get_Work_list_By_Where_InList_SP = new Params_Get_Work_list_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Work_list_By_Where_InList");}
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
List<DALC.Work_list> oList_DBEntries = _AppContext.Get_Work_list_By_Where_InList(i_Params_Get_Work_list_By_Where_InList.DESCRIPTION,i_Params_Get_Work_list_By_Where_InList.BUSINESS_ID_LIST,i_Params_Get_Work_list_By_Where_InList.WORK_AREA_ID_LIST,i_Params_Get_Work_list_By_Where_InList.OWNER_ID,i_Params_Get_Work_list_By_Where_InList.START_ROW,i_Params_Get_Work_list_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oWork_list = new Work_list();
oTools.CopyPropValues(oDBEntry, oWork_list);
oList.Add(oWork_list);
}
}
i_Params_Get_Work_list_By_Where_InList.TOTAL_COUNT = oParams_Get_Work_list_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Work_list_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Work_list_By_Where_InList");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_InList(Params_Get_Boost_listing_By_Criteria_InList i_Params_Get_Boost_listing_By_Criteria_InList)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Boost_listing_By_Criteria_InList_SP oParams_Get_Boost_listing_By_Criteria_InList_SP = new Params_Get_Boost_listing_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Criteria_InList");}
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
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Criteria_InList(i_Params_Get_Boost_listing_By_Criteria_InList.DESCRIPTION,i_Params_Get_Boost_listing_By_Criteria_InList.SERVICE_PROD_ID_LIST,i_Params_Get_Boost_listing_By_Criteria_InList.BOOST_PRICING_ID_LIST,i_Params_Get_Boost_listing_By_Criteria_InList.OWNER_ID,i_Params_Get_Boost_listing_By_Criteria_InList.START_ROW,i_Params_Get_Boost_listing_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Boost_listing_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Boost_listing_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Criteria_InList");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_InList(Params_Get_Boost_listing_By_Where_InList i_Params_Get_Boost_listing_By_Where_InList)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Boost_listing_By_Where_InList_SP oParams_Get_Boost_listing_By_Where_InList_SP = new Params_Get_Boost_listing_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Where_InList");}
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
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Where_InList(i_Params_Get_Boost_listing_By_Where_InList.DESCRIPTION,i_Params_Get_Boost_listing_By_Where_InList.SERVICE_PROD_ID_LIST,i_Params_Get_Boost_listing_By_Where_InList.BOOST_PRICING_ID_LIST,i_Params_Get_Boost_listing_By_Where_InList.OWNER_ID,i_Params_Get_Boost_listing_By_Where_InList.START_ROW,i_Params_Get_Boost_listing_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Where_InList.TOTAL_COUNT = oParams_Get_Boost_listing_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Boost_listing_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Where_InList");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_InList_V2(Params_Get_Boost_listing_By_Criteria_InList_V2 i_Params_Get_Boost_listing_By_Criteria_InList_V2)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Boost_listing_By_Criteria_InList_SP_V2 oParams_Get_Boost_listing_By_Criteria_InList_SP_V2 = new Params_Get_Boost_listing_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Criteria_InList_V2");}
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
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Criteria_InList_V2(i_Params_Get_Boost_listing_By_Criteria_InList_V2.START_DATE,i_Params_Get_Boost_listing_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Boost_listing_By_Criteria_InList_V2.SERVICE_PROD_ID_LIST,i_Params_Get_Boost_listing_By_Criteria_InList_V2.BOOST_PRICING_ID_LIST,i_Params_Get_Boost_listing_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Boost_listing_By_Criteria_InList_V2.START_ROW,i_Params_Get_Boost_listing_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Boost_listing_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Boost_listing_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Criteria_InList_V2");}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_InList_V2(Params_Get_Boost_listing_By_Where_InList_V2 i_Params_Get_Boost_listing_By_Where_InList_V2)
{
List<Boost_listing> oList = new List<Boost_listing>();
Boost_listing oBoost_listing = new Boost_listing();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Boost_listing_By_Where_InList_SP_V2 oParams_Get_Boost_listing_By_Where_InList_SP_V2 = new Params_Get_Boost_listing_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Boost_listing_By_Where_InList_V2");}
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
List<DALC.Boost_listing> oList_DBEntries = _AppContext.Get_Boost_listing_By_Where_InList_V2(i_Params_Get_Boost_listing_By_Where_InList_V2.START_DATE,i_Params_Get_Boost_listing_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Boost_listing_By_Where_InList_V2.SERVICE_PROD_ID_LIST,i_Params_Get_Boost_listing_By_Where_InList_V2.BOOST_PRICING_ID_LIST,i_Params_Get_Boost_listing_By_Where_InList_V2.OWNER_ID,i_Params_Get_Boost_listing_By_Where_InList_V2.START_ROW,i_Params_Get_Boost_listing_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBoost_listing = new Boost_listing();
oTools.CopyPropValues(oDBEntry, oBoost_listing);
oList.Add(oBoost_listing);
}
}
i_Params_Get_Boost_listing_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Boost_listing_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Boost_listing_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Boost_listing_By_Where_InList_V2");}
return oList;
}
public void Delete_Boost_pricing(Params_Delete_Boost_pricing i_Params_Delete_Boost_pricing)
{
Params_Get_Boost_pricing_By_BOOST_PRICING_ID oParams_Get_Boost_pricing_By_BOOST_PRICING_ID = new Params_Get_Boost_pricing_By_BOOST_PRICING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Boost_pricing");}
#region Body Section.
try
{
oParams_Get_Boost_pricing_By_BOOST_PRICING_ID.BOOST_PRICING_ID = i_Params_Delete_Boost_pricing.BOOST_PRICING_ID;
_Boost_pricing = Get_Boost_pricing_By_BOOST_PRICING_ID_Adv(oParams_Get_Boost_pricing_By_BOOST_PRICING_ID);
if (_Boost_pricing != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Boost_pricing
if (OnPreEvent_Delete_Boost_pricing != null)
{
OnPreEvent_Delete_Boost_pricing(i_Params_Delete_Boost_pricing);
}
#endregion
if (_Stop_Delete_Boost_pricing_Execution)
{
_Stop_Delete_Boost_pricing_Execution = false;
return;
}
_AppContext.Delete_Boost_pricing(i_Params_Delete_Boost_pricing.BOOST_PRICING_ID);
#region PostEvent_Delete_Boost_pricing
if (OnPostEvent_Delete_Boost_pricing != null)
{
OnPostEvent_Delete_Boost_pricing(i_Params_Delete_Boost_pricing);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Boost_pricing");}
}
public void Delete_Client(Params_Delete_Client i_Params_Delete_Client)
{
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client");}
#region Body Section.
try
{
oParams_Get_Client_By_CLIENT_ID.CLIENT_ID = i_Params_Delete_Client.CLIENT_ID;
_Client = Get_Client_By_CLIENT_ID_Adv(oParams_Get_Client_By_CLIENT_ID);
if (_Client != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Client
if (OnPreEvent_Delete_Client != null)
{
OnPreEvent_Delete_Client(i_Params_Delete_Client);
}
#endregion
if (_Stop_Delete_Client_Execution)
{
_Stop_Delete_Client_Execution = false;
return;
}
_AppContext.Delete_Client(i_Params_Delete_Client.CLIENT_ID);
#region PostEvent_Delete_Client
if (OnPostEvent_Delete_Client != null)
{
OnPostEvent_Delete_Client(i_Params_Delete_Client);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client");}
}
public void Delete_Service_prod(Params_Delete_Service_prod i_Params_Delete_Service_prod)
{
Params_Get_Service_prod_By_SERVICE_PROD_ID oParams_Get_Service_prod_By_SERVICE_PROD_ID = new Params_Get_Service_prod_By_SERVICE_PROD_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Service_prod");}
#region Body Section.
try
{
oParams_Get_Service_prod_By_SERVICE_PROD_ID.SERVICE_PROD_ID = i_Params_Delete_Service_prod.SERVICE_PROD_ID;
_Service_prod = Get_Service_prod_By_SERVICE_PROD_ID_Adv(oParams_Get_Service_prod_By_SERVICE_PROD_ID);
if (_Service_prod != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Service_prod
if (OnPreEvent_Delete_Service_prod != null)
{
OnPreEvent_Delete_Service_prod(i_Params_Delete_Service_prod);
}
#endregion
if (_Stop_Delete_Service_prod_Execution)
{
_Stop_Delete_Service_prod_Execution = false;
return;
}
_AppContext.Delete_Service_prod(i_Params_Delete_Service_prod.SERVICE_PROD_ID);
#region PostEvent_Delete_Service_prod
if (OnPostEvent_Delete_Service_prod != null)
{
OnPostEvent_Delete_Service_prod(i_Params_Delete_Service_prod);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Service_prod");}
}
public void Delete_Admin(Params_Delete_Admin i_Params_Delete_Admin)
{
Params_Get_Admin_By_ADMIN_ID oParams_Get_Admin_By_ADMIN_ID = new Params_Get_Admin_By_ADMIN_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Admin");}
#region Body Section.
try
{
oParams_Get_Admin_By_ADMIN_ID.ADMIN_ID = i_Params_Delete_Admin.ADMIN_ID;
_Admin = Get_Admin_By_ADMIN_ID_Adv(oParams_Get_Admin_By_ADMIN_ID);
if (_Admin != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Admin
if (OnPreEvent_Delete_Admin != null)
{
OnPreEvent_Delete_Admin(i_Params_Delete_Admin);
}
#endregion
if (_Stop_Delete_Admin_Execution)
{
_Stop_Delete_Admin_Execution = false;
return;
}
_AppContext.Delete_Admin(i_Params_Delete_Admin.ADMIN_ID);
#region PostEvent_Delete_Admin
if (OnPostEvent_Delete_Admin != null)
{
OnPostEvent_Delete_Admin(i_Params_Delete_Admin);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Admin");}
}
public void Delete_Category(Params_Delete_Category i_Params_Delete_Category)
{
Params_Get_Category_By_CATEGORY_ID oParams_Get_Category_By_CATEGORY_ID = new Params_Get_Category_By_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category");}
#region Body Section.
try
{
oParams_Get_Category_By_CATEGORY_ID.CATEGORY_ID = i_Params_Delete_Category.CATEGORY_ID;
_Category = Get_Category_By_CATEGORY_ID_Adv(oParams_Get_Category_By_CATEGORY_ID);
if (_Category != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Category
if (OnPreEvent_Delete_Category != null)
{
OnPreEvent_Delete_Category(i_Params_Delete_Category);
}
#endregion
if (_Stop_Delete_Category_Execution)
{
_Stop_Delete_Category_Execution = false;
return;
}
_AppContext.Delete_Category(i_Params_Delete_Category.CATEGORY_ID);
#region PostEvent_Delete_Category
if (OnPostEvent_Delete_Category != null)
{
OnPostEvent_Delete_Category(i_Params_Delete_Category);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category");}
}
public void Delete_Sub_category(Params_Delete_Sub_category i_Params_Delete_Sub_category)
{
Params_Get_Sub_category_By_SUB_CATEGORY_ID oParams_Get_Sub_category_By_SUB_CATEGORY_ID = new Params_Get_Sub_category_By_SUB_CATEGORY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Sub_category");}
#region Body Section.
try
{
oParams_Get_Sub_category_By_SUB_CATEGORY_ID.SUB_CATEGORY_ID = i_Params_Delete_Sub_category.SUB_CATEGORY_ID;
_Sub_category = Get_Sub_category_By_SUB_CATEGORY_ID_Adv(oParams_Get_Sub_category_By_SUB_CATEGORY_ID);
if (_Sub_category != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Sub_category_Execution)
{
_Stop_Delete_Sub_category_Execution = false;
return;
}
_AppContext.Delete_Sub_category(i_Params_Delete_Sub_category.SUB_CATEGORY_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Sub_category");}
}
public void Delete_Coordinates(Params_Delete_Coordinates i_Params_Delete_Coordinates)
{
Params_Get_Coordinates_By_COORDINATES_ID oParams_Get_Coordinates_By_COORDINATES_ID = new Params_Get_Coordinates_By_COORDINATES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Coordinates");}
#region Body Section.
try
{
oParams_Get_Coordinates_By_COORDINATES_ID.COORDINATES_ID = i_Params_Delete_Coordinates.COORDINATES_ID;
_Coordinates = Get_Coordinates_By_COORDINATES_ID_Adv(oParams_Get_Coordinates_By_COORDINATES_ID);
if (_Coordinates != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Coordinates_Execution)
{
_Stop_Delete_Coordinates_Execution = false;
return;
}
_AppContext.Delete_Coordinates(i_Params_Delete_Coordinates.COORDINATES_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Coordinates");}
}
public void Delete_Currency(Params_Delete_Currency i_Params_Delete_Currency)
{
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Currency");}
#region Body Section.
try
{
oParams_Get_Currency_By_CURRENCY_ID.CURRENCY_ID = i_Params_Delete_Currency.CURRENCY_ID;
_Currency = Get_Currency_By_CURRENCY_ID_Adv(oParams_Get_Currency_By_CURRENCY_ID);
if (_Currency != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Currency_Execution)
{
_Stop_Delete_Currency_Execution = false;
return;
}
_AppContext.Delete_Currency(i_Params_Delete_Currency.CURRENCY_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Currency");}
}
public void Delete_Status(Params_Delete_Status i_Params_Delete_Status)
{
Params_Get_Status_By_STATUS_ID oParams_Get_Status_By_STATUS_ID = new Params_Get_Status_By_STATUS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Status");}
#region Body Section.
try
{
oParams_Get_Status_By_STATUS_ID.STATUS_ID = i_Params_Delete_Status.STATUS_ID;
_Status = Get_Status_By_STATUS_ID_Adv(oParams_Get_Status_By_STATUS_ID);
if (_Status != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Status
if (OnPreEvent_Delete_Status != null)
{
OnPreEvent_Delete_Status(i_Params_Delete_Status);
}
#endregion
if (_Stop_Delete_Status_Execution)
{
_Stop_Delete_Status_Execution = false;
return;
}
_AppContext.Delete_Status(i_Params_Delete_Status.STATUS_ID);
#region PostEvent_Delete_Status
if (OnPostEvent_Delete_Status != null)
{
OnPostEvent_Delete_Status(i_Params_Delete_Status);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Status");}
}
public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Owner");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Owner_Execution)
{
_Stop_Delete_Owner_Execution = false;
return;
}
_AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Owner");}
}
public void Delete_Feedback(Params_Delete_Feedback i_Params_Delete_Feedback)
{
Params_Get_Feedback_By_FEEDBACK_ID oParams_Get_Feedback_By_FEEDBACK_ID = new Params_Get_Feedback_By_FEEDBACK_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Feedback");}
#region Body Section.
try
{
oParams_Get_Feedback_By_FEEDBACK_ID.FEEDBACK_ID = i_Params_Delete_Feedback.FEEDBACK_ID;
_Feedback = Get_Feedback_By_FEEDBACK_ID_Adv(oParams_Get_Feedback_By_FEEDBACK_ID);
if (_Feedback != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Feedback_Execution)
{
_Stop_Delete_Feedback_Execution = false;
return;
}
_AppContext.Delete_Feedback(i_Params_Delete_Feedback.FEEDBACK_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Feedback");}
}
public void Delete_Booking(Params_Delete_Booking i_Params_Delete_Booking)
{
Params_Get_Booking_By_BOOKING_ID oParams_Get_Booking_By_BOOKING_ID = new Params_Get_Booking_By_BOOKING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Booking");}
#region Body Section.
try
{
oParams_Get_Booking_By_BOOKING_ID.BOOKING_ID = i_Params_Delete_Booking.BOOKING_ID;
_Booking = Get_Booking_By_BOOKING_ID_Adv(oParams_Get_Booking_By_BOOKING_ID);
if (_Booking != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Booking
if (OnPreEvent_Delete_Booking != null)
{
OnPreEvent_Delete_Booking(i_Params_Delete_Booking);
}
#endregion
if (_Stop_Delete_Booking_Execution)
{
_Stop_Delete_Booking_Execution = false;
return;
}
_AppContext.Delete_Booking(i_Params_Delete_Booking.BOOKING_ID);
#region PostEvent_Delete_Booking
if (OnPostEvent_Delete_Booking != null)
{
OnPostEvent_Delete_Booking(i_Params_Delete_Booking);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Booking");}
}
public void Delete_Business(Params_Delete_Business i_Params_Delete_Business)
{
Params_Get_Business_By_BUSINESS_ID oParams_Get_Business_By_BUSINESS_ID = new Params_Get_Business_By_BUSINESS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Business");}
#region Body Section.
try
{
oParams_Get_Business_By_BUSINESS_ID.BUSINESS_ID = i_Params_Delete_Business.BUSINESS_ID;
_Business = Get_Business_By_BUSINESS_ID_Adv(oParams_Get_Business_By_BUSINESS_ID);
if (_Business != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Business
if (OnPreEvent_Delete_Business != null)
{
OnPreEvent_Delete_Business(i_Params_Delete_Business);
}
#endregion
if (_Stop_Delete_Business_Execution)
{
_Stop_Delete_Business_Execution = false;
return;
}
_AppContext.Delete_Business(i_Params_Delete_Business.BUSINESS_ID);
#region PostEvent_Delete_Business
if (OnPostEvent_Delete_Business != null)
{
OnPostEvent_Delete_Business(i_Params_Delete_Business);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Business");}
}
public void Delete_Work_list(Params_Delete_Work_list i_Params_Delete_Work_list)
{
Params_Get_Work_list_By_WORK_LIST_ID oParams_Get_Work_list_By_WORK_LIST_ID = new Params_Get_Work_list_By_WORK_LIST_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Work_list");}
#region Body Section.
try
{
oParams_Get_Work_list_By_WORK_LIST_ID.WORK_LIST_ID = i_Params_Delete_Work_list.WORK_LIST_ID;
_Work_list = Get_Work_list_By_WORK_LIST_ID_Adv(oParams_Get_Work_list_By_WORK_LIST_ID);
if (_Work_list != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Work_list_Execution)
{
_Stop_Delete_Work_list_Execution = false;
return;
}
_AppContext.Delete_Work_list(i_Params_Delete_Work_list.WORK_LIST_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Work_list");}
}
public void Delete_User(Params_Delete_User i_Params_Delete_User)
{
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User");}
#region Body Section.
try
{
oParams_Get_User_By_USER_ID.USER_ID = i_Params_Delete_User.USER_ID;
_User = Get_User_By_USER_ID_Adv(oParams_Get_User_By_USER_ID);
if (_User != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User(i_Params_Delete_User.USER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User");}
}
public void Delete_Work_area(Params_Delete_Work_area i_Params_Delete_Work_area)
{
Params_Get_Work_area_By_WORK_AREA_ID oParams_Get_Work_area_By_WORK_AREA_ID = new Params_Get_Work_area_By_WORK_AREA_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Work_area");}
#region Body Section.
try
{
oParams_Get_Work_area_By_WORK_AREA_ID.WORK_AREA_ID = i_Params_Delete_Work_area.WORK_AREA_ID;
_Work_area = Get_Work_area_By_WORK_AREA_ID_Adv(oParams_Get_Work_area_By_WORK_AREA_ID);
if (_Work_area != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Work_area
if (OnPreEvent_Delete_Work_area != null)
{
OnPreEvent_Delete_Work_area(i_Params_Delete_Work_area);
}
#endregion
if (_Stop_Delete_Work_area_Execution)
{
_Stop_Delete_Work_area_Execution = false;
return;
}
_AppContext.Delete_Work_area(i_Params_Delete_Work_area.WORK_AREA_ID);
#region PostEvent_Delete_Work_area
if (OnPostEvent_Delete_Work_area != null)
{
OnPostEvent_Delete_Work_area(i_Params_Delete_Work_area);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Work_area");}
}
public void Delete_Boost_listing(Params_Delete_Boost_listing i_Params_Delete_Boost_listing)
{
Params_Get_Boost_listing_By_BOOST_LISTING_ID oParams_Get_Boost_listing_By_BOOST_LISTING_ID = new Params_Get_Boost_listing_By_BOOST_LISTING_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Boost_listing");}
#region Body Section.
try
{
oParams_Get_Boost_listing_By_BOOST_LISTING_ID.BOOST_LISTING_ID = i_Params_Delete_Boost_listing.BOOST_LISTING_ID;
_Boost_listing = Get_Boost_listing_By_BOOST_LISTING_ID_Adv(oParams_Get_Boost_listing_By_BOOST_LISTING_ID);
if (_Boost_listing != null)
{
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Delete_Boost_listing
if (OnPreEvent_Delete_Boost_listing != null)
{
OnPreEvent_Delete_Boost_listing(i_Params_Delete_Boost_listing);
}
#endregion
if (_Stop_Delete_Boost_listing_Execution)
{
_Stop_Delete_Boost_listing_Execution = false;
return;
}
_AppContext.Delete_Boost_listing(i_Params_Delete_Boost_listing.BOOST_LISTING_ID);
#region PostEvent_Delete_Boost_listing
if (OnPostEvent_Delete_Boost_listing != null)
{
OnPostEvent_Delete_Boost_listing(i_Params_Delete_Boost_listing);
}
#endregion
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Boost_listing");}
}
public void Delete_Boost_pricing_By_OWNER_ID(Params_Delete_Boost_pricing_By_OWNER_ID i_Params_Delete_Boost_pricing_By_OWNER_ID)
{
Params_Get_Boost_pricing_By_OWNER_ID oParams_Get_Boost_pricing_By_OWNER_ID = new Params_Get_Boost_pricing_By_OWNER_ID();
List<Boost_pricing> _List_Boost_pricing = new List<Boost_pricing>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Boost_pricing_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Boost_pricing_Execution)
{
_Stop_Delete_Boost_pricing_Execution = false;
return;
}
_AppContext.Delete_Boost_pricing_By_OWNER_ID(i_Params_Delete_Boost_pricing_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Boost_pricing_By_OWNER_ID");}
}
public void Delete_Client_By_PHONE_NUMBER(Params_Delete_Client_By_PHONE_NUMBER i_Params_Delete_Client_By_PHONE_NUMBER)
{
Params_Get_Client_By_PHONE_NUMBER oParams_Get_Client_By_PHONE_NUMBER = new Params_Get_Client_By_PHONE_NUMBER();
List<Client> _List_Client = new List<Client>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_By_PHONE_NUMBER");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_Execution)
{
_Stop_Delete_Client_Execution = false;
return;
}
_AppContext.Delete_Client_By_PHONE_NUMBER(i_Params_Delete_Client_By_PHONE_NUMBER.PHONE_NUMBER);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_By_PHONE_NUMBER");}
}
public void Delete_Client_By_OWNER_ID(Params_Delete_Client_By_OWNER_ID i_Params_Delete_Client_By_OWNER_ID)
{
Params_Get_Client_By_OWNER_ID oParams_Get_Client_By_OWNER_ID = new Params_Get_Client_By_OWNER_ID();
List<Client> _List_Client = new List<Client>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_Execution)
{
_Stop_Delete_Client_Execution = false;
return;
}
_AppContext.Delete_Client_By_OWNER_ID(i_Params_Delete_Client_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_By_OWNER_ID");}
}
public void Delete_Client_By_USERNAME(Params_Delete_Client_By_USERNAME i_Params_Delete_Client_By_USERNAME)
{
Params_Get_Client_By_USERNAME oParams_Get_Client_By_USERNAME = new Params_Get_Client_By_USERNAME();
List<Client> _List_Client = new List<Client>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_Execution)
{
_Stop_Delete_Client_Execution = false;
return;
}
_AppContext.Delete_Client_By_USERNAME(i_Params_Delete_Client_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_By_USERNAME");}
}
public void Delete_Service_prod_By_OWNER_ID(Params_Delete_Service_prod_By_OWNER_ID i_Params_Delete_Service_prod_By_OWNER_ID)
{
Params_Get_Service_prod_By_OWNER_ID oParams_Get_Service_prod_By_OWNER_ID = new Params_Get_Service_prod_By_OWNER_ID();
List<Service_prod> _List_Service_prod = new List<Service_prod>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Service_prod_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Service_prod_Execution)
{
_Stop_Delete_Service_prod_Execution = false;
return;
}
_AppContext.Delete_Service_prod_By_OWNER_ID(i_Params_Delete_Service_prod_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Service_prod_By_OWNER_ID");}
}
public void Delete_Service_prod_By_BUSINESS_ID(Params_Delete_Service_prod_By_BUSINESS_ID i_Params_Delete_Service_prod_By_BUSINESS_ID)
{
Params_Get_Service_prod_By_BUSINESS_ID oParams_Get_Service_prod_By_BUSINESS_ID = new Params_Get_Service_prod_By_BUSINESS_ID();
List<Service_prod> _List_Service_prod = new List<Service_prod>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Service_prod_By_BUSINESS_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Service_prod_Execution)
{
_Stop_Delete_Service_prod_Execution = false;
return;
}
_AppContext.Delete_Service_prod_By_BUSINESS_ID(i_Params_Delete_Service_prod_By_BUSINESS_ID.BUSINESS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Service_prod_By_BUSINESS_ID");}
}
public void Delete_Service_prod_By_SUB_CATEGORY_ID(Params_Delete_Service_prod_By_SUB_CATEGORY_ID i_Params_Delete_Service_prod_By_SUB_CATEGORY_ID)
{
Params_Get_Service_prod_By_SUB_CATEGORY_ID oParams_Get_Service_prod_By_SUB_CATEGORY_ID = new Params_Get_Service_prod_By_SUB_CATEGORY_ID();
List<Service_prod> _List_Service_prod = new List<Service_prod>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Service_prod_By_SUB_CATEGORY_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Service_prod_Execution)
{
_Stop_Delete_Service_prod_Execution = false;
return;
}
_AppContext.Delete_Service_prod_By_SUB_CATEGORY_ID(i_Params_Delete_Service_prod_By_SUB_CATEGORY_ID.SUB_CATEGORY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Service_prod_By_SUB_CATEGORY_ID");}
}
public void Delete_Admin_By_OWNER_ID(Params_Delete_Admin_By_OWNER_ID i_Params_Delete_Admin_By_OWNER_ID)
{
Params_Get_Admin_By_OWNER_ID oParams_Get_Admin_By_OWNER_ID = new Params_Get_Admin_By_OWNER_ID();
List<Admin> _List_Admin = new List<Admin>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Admin_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Admin_Execution)
{
_Stop_Delete_Admin_Execution = false;
return;
}
_AppContext.Delete_Admin_By_OWNER_ID(i_Params_Delete_Admin_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Admin_By_OWNER_ID");}
}
public void Delete_Admin_By_USERNAME(Params_Delete_Admin_By_USERNAME i_Params_Delete_Admin_By_USERNAME)
{
Params_Get_Admin_By_USERNAME oParams_Get_Admin_By_USERNAME = new Params_Get_Admin_By_USERNAME();
List<Admin> _List_Admin = new List<Admin>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Admin_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Admin_Execution)
{
_Stop_Delete_Admin_Execution = false;
return;
}
_AppContext.Delete_Admin_By_USERNAME(i_Params_Delete_Admin_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Admin_By_USERNAME");}
}
public void Delete_Category_By_OWNER_ID(Params_Delete_Category_By_OWNER_ID i_Params_Delete_Category_By_OWNER_ID)
{
Params_Get_Category_By_OWNER_ID oParams_Get_Category_By_OWNER_ID = new Params_Get_Category_By_OWNER_ID();
List<Category> _List_Category = new List<Category>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Category_Execution)
{
_Stop_Delete_Category_Execution = false;
return;
}
_AppContext.Delete_Category_By_OWNER_ID(i_Params_Delete_Category_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_By_OWNER_ID");}
}
public void Delete_Sub_category_By_OWNER_ID(Params_Delete_Sub_category_By_OWNER_ID i_Params_Delete_Sub_category_By_OWNER_ID)
{
Params_Get_Sub_category_By_OWNER_ID oParams_Get_Sub_category_By_OWNER_ID = new Params_Get_Sub_category_By_OWNER_ID();
List<Sub_category> _List_Sub_category = new List<Sub_category>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Sub_category_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Sub_category_Execution)
{
_Stop_Delete_Sub_category_Execution = false;
return;
}
_AppContext.Delete_Sub_category_By_OWNER_ID(i_Params_Delete_Sub_category_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Sub_category_By_OWNER_ID");}
}
public void Delete_Sub_category_By_CATEGORY_ID(Params_Delete_Sub_category_By_CATEGORY_ID i_Params_Delete_Sub_category_By_CATEGORY_ID)
{
Params_Get_Sub_category_By_CATEGORY_ID oParams_Get_Sub_category_By_CATEGORY_ID = new Params_Get_Sub_category_By_CATEGORY_ID();
List<Sub_category> _List_Sub_category = new List<Sub_category>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Sub_category_By_CATEGORY_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Sub_category_Execution)
{
_Stop_Delete_Sub_category_Execution = false;
return;
}
_AppContext.Delete_Sub_category_By_CATEGORY_ID(i_Params_Delete_Sub_category_By_CATEGORY_ID.CATEGORY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Sub_category_By_CATEGORY_ID");}
}
public void Delete_Coordinates_By_OWNER_ID(Params_Delete_Coordinates_By_OWNER_ID i_Params_Delete_Coordinates_By_OWNER_ID)
{
Params_Get_Coordinates_By_OWNER_ID oParams_Get_Coordinates_By_OWNER_ID = new Params_Get_Coordinates_By_OWNER_ID();
List<Coordinates> _List_Coordinates = new List<Coordinates>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Coordinates_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Coordinates_Execution)
{
_Stop_Delete_Coordinates_Execution = false;
return;
}
_AppContext.Delete_Coordinates_By_OWNER_ID(i_Params_Delete_Coordinates_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Coordinates_By_OWNER_ID");}
}
public void Delete_Coordinates_By_BOOKING_ID(Params_Delete_Coordinates_By_BOOKING_ID i_Params_Delete_Coordinates_By_BOOKING_ID)
{
Params_Get_Coordinates_By_BOOKING_ID oParams_Get_Coordinates_By_BOOKING_ID = new Params_Get_Coordinates_By_BOOKING_ID();
List<Coordinates> _List_Coordinates = new List<Coordinates>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Coordinates_By_BOOKING_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Coordinates_Execution)
{
_Stop_Delete_Coordinates_Execution = false;
return;
}
_AppContext.Delete_Coordinates_By_BOOKING_ID(i_Params_Delete_Coordinates_By_BOOKING_ID.BOOKING_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Coordinates_By_BOOKING_ID");}
}
public void Delete_Currency_By_OWNER_ID(Params_Delete_Currency_By_OWNER_ID i_Params_Delete_Currency_By_OWNER_ID)
{
Params_Get_Currency_By_OWNER_ID oParams_Get_Currency_By_OWNER_ID = new Params_Get_Currency_By_OWNER_ID();
List<Currency> _List_Currency = new List<Currency>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Currency_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Currency_Execution)
{
_Stop_Delete_Currency_Execution = false;
return;
}
_AppContext.Delete_Currency_By_OWNER_ID(i_Params_Delete_Currency_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Currency_By_OWNER_ID");}
}
public void Delete_Status_By_OWNER_ID(Params_Delete_Status_By_OWNER_ID i_Params_Delete_Status_By_OWNER_ID)
{
Params_Get_Status_By_OWNER_ID oParams_Get_Status_By_OWNER_ID = new Params_Get_Status_By_OWNER_ID();
List<Status> _List_Status = new List<Status>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Status_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Status_Execution)
{
_Stop_Delete_Status_Execution = false;
return;
}
_AppContext.Delete_Status_By_OWNER_ID(i_Params_Delete_Status_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Status_By_OWNER_ID");}
}
public void Delete_Feedback_By_OWNER_ID(Params_Delete_Feedback_By_OWNER_ID i_Params_Delete_Feedback_By_OWNER_ID)
{
Params_Get_Feedback_By_OWNER_ID oParams_Get_Feedback_By_OWNER_ID = new Params_Get_Feedback_By_OWNER_ID();
List<Feedback> _List_Feedback = new List<Feedback>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Feedback_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Feedback_Execution)
{
_Stop_Delete_Feedback_Execution = false;
return;
}
_AppContext.Delete_Feedback_By_OWNER_ID(i_Params_Delete_Feedback_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Feedback_By_OWNER_ID");}
}
public void Delete_Feedback_By_BOOKING_ID(Params_Delete_Feedback_By_BOOKING_ID i_Params_Delete_Feedback_By_BOOKING_ID)
{
Params_Get_Feedback_By_BOOKING_ID oParams_Get_Feedback_By_BOOKING_ID = new Params_Get_Feedback_By_BOOKING_ID();
List<Feedback> _List_Feedback = new List<Feedback>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Feedback_By_BOOKING_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Feedback_Execution)
{
_Stop_Delete_Feedback_Execution = false;
return;
}
_AppContext.Delete_Feedback_By_BOOKING_ID(i_Params_Delete_Feedback_By_BOOKING_ID.BOOKING_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Feedback_By_BOOKING_ID");}
}
public void Delete_Booking_By_OWNER_ID(Params_Delete_Booking_By_OWNER_ID i_Params_Delete_Booking_By_OWNER_ID)
{
Params_Get_Booking_By_OWNER_ID oParams_Get_Booking_By_OWNER_ID = new Params_Get_Booking_By_OWNER_ID();
List<Booking> _List_Booking = new List<Booking>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Booking_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Booking_Execution)
{
_Stop_Delete_Booking_Execution = false;
return;
}
_AppContext.Delete_Booking_By_OWNER_ID(i_Params_Delete_Booking_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Booking_By_OWNER_ID");}
}
public void Delete_Booking_By_SERVICE_PROD_ID(Params_Delete_Booking_By_SERVICE_PROD_ID i_Params_Delete_Booking_By_SERVICE_PROD_ID)
{
Params_Get_Booking_By_SERVICE_PROD_ID oParams_Get_Booking_By_SERVICE_PROD_ID = new Params_Get_Booking_By_SERVICE_PROD_ID();
List<Booking> _List_Booking = new List<Booking>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Booking_By_SERVICE_PROD_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Booking_Execution)
{
_Stop_Delete_Booking_Execution = false;
return;
}
_AppContext.Delete_Booking_By_SERVICE_PROD_ID(i_Params_Delete_Booking_By_SERVICE_PROD_ID.SERVICE_PROD_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Booking_By_SERVICE_PROD_ID");}
}
public void Delete_Booking_By_CLIENT_ID(Params_Delete_Booking_By_CLIENT_ID i_Params_Delete_Booking_By_CLIENT_ID)
{
Params_Get_Booking_By_CLIENT_ID oParams_Get_Booking_By_CLIENT_ID = new Params_Get_Booking_By_CLIENT_ID();
List<Booking> _List_Booking = new List<Booking>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Booking_By_CLIENT_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Booking_Execution)
{
_Stop_Delete_Booking_Execution = false;
return;
}
_AppContext.Delete_Booking_By_CLIENT_ID(i_Params_Delete_Booking_By_CLIENT_ID.CLIENT_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Booking_By_CLIENT_ID");}
}
public void Delete_Booking_By_WORK_AREA_ID(Params_Delete_Booking_By_WORK_AREA_ID i_Params_Delete_Booking_By_WORK_AREA_ID)
{
Params_Get_Booking_By_WORK_AREA_ID oParams_Get_Booking_By_WORK_AREA_ID = new Params_Get_Booking_By_WORK_AREA_ID();
List<Booking> _List_Booking = new List<Booking>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Booking_By_WORK_AREA_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Booking_Execution)
{
_Stop_Delete_Booking_Execution = false;
return;
}
_AppContext.Delete_Booking_By_WORK_AREA_ID(i_Params_Delete_Booking_By_WORK_AREA_ID.WORK_AREA_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Booking_By_WORK_AREA_ID");}
}
public void Delete_Booking_By_STATUS_ID(Params_Delete_Booking_By_STATUS_ID i_Params_Delete_Booking_By_STATUS_ID)
{
Params_Get_Booking_By_STATUS_ID oParams_Get_Booking_By_STATUS_ID = new Params_Get_Booking_By_STATUS_ID();
List<Booking> _List_Booking = new List<Booking>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Booking_By_STATUS_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Booking_Execution)
{
_Stop_Delete_Booking_Execution = false;
return;
}
_AppContext.Delete_Booking_By_STATUS_ID(i_Params_Delete_Booking_By_STATUS_ID.STATUS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Booking_By_STATUS_ID");}
}
public void Delete_Booking_By_BUSINESS_ID(Params_Delete_Booking_By_BUSINESS_ID i_Params_Delete_Booking_By_BUSINESS_ID)
{
Params_Get_Booking_By_BUSINESS_ID oParams_Get_Booking_By_BUSINESS_ID = new Params_Get_Booking_By_BUSINESS_ID();
List<Booking> _List_Booking = new List<Booking>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Booking_By_BUSINESS_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Booking_Execution)
{
_Stop_Delete_Booking_Execution = false;
return;
}
_AppContext.Delete_Booking_By_BUSINESS_ID(i_Params_Delete_Booking_By_BUSINESS_ID.BUSINESS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Booking_By_BUSINESS_ID");}
}
public void Delete_Business_By_USERNAME(Params_Delete_Business_By_USERNAME i_Params_Delete_Business_By_USERNAME)
{
Params_Get_Business_By_USERNAME oParams_Get_Business_By_USERNAME = new Params_Get_Business_By_USERNAME();
List<Business> _List_Business = new List<Business>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Business_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Business_Execution)
{
_Stop_Delete_Business_Execution = false;
return;
}
_AppContext.Delete_Business_By_USERNAME(i_Params_Delete_Business_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Business_By_USERNAME");}
}
public void Delete_Business_By_OWNER_ID(Params_Delete_Business_By_OWNER_ID i_Params_Delete_Business_By_OWNER_ID)
{
Params_Get_Business_By_OWNER_ID oParams_Get_Business_By_OWNER_ID = new Params_Get_Business_By_OWNER_ID();
List<Business> _List_Business = new List<Business>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Business_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Business_Execution)
{
_Stop_Delete_Business_Execution = false;
return;
}
_AppContext.Delete_Business_By_OWNER_ID(i_Params_Delete_Business_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Business_By_OWNER_ID");}
}
public void Delete_Work_list_By_OWNER_ID(Params_Delete_Work_list_By_OWNER_ID i_Params_Delete_Work_list_By_OWNER_ID)
{
Params_Get_Work_list_By_OWNER_ID oParams_Get_Work_list_By_OWNER_ID = new Params_Get_Work_list_By_OWNER_ID();
List<Work_list> _List_Work_list = new List<Work_list>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Work_list_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Work_list_Execution)
{
_Stop_Delete_Work_list_Execution = false;
return;
}
_AppContext.Delete_Work_list_By_OWNER_ID(i_Params_Delete_Work_list_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Work_list_By_OWNER_ID");}
}
public void Delete_Work_list_By_BUSINESS_ID(Params_Delete_Work_list_By_BUSINESS_ID i_Params_Delete_Work_list_By_BUSINESS_ID)
{
Params_Get_Work_list_By_BUSINESS_ID oParams_Get_Work_list_By_BUSINESS_ID = new Params_Get_Work_list_By_BUSINESS_ID();
List<Work_list> _List_Work_list = new List<Work_list>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Work_list_By_BUSINESS_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Work_list_Execution)
{
_Stop_Delete_Work_list_Execution = false;
return;
}
_AppContext.Delete_Work_list_By_BUSINESS_ID(i_Params_Delete_Work_list_By_BUSINESS_ID.BUSINESS_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Work_list_By_BUSINESS_ID");}
}
public void Delete_Work_list_By_WORK_AREA_ID(Params_Delete_Work_list_By_WORK_AREA_ID i_Params_Delete_Work_list_By_WORK_AREA_ID)
{
Params_Get_Work_list_By_WORK_AREA_ID oParams_Get_Work_list_By_WORK_AREA_ID = new Params_Get_Work_list_By_WORK_AREA_ID();
List<Work_list> _List_Work_list = new List<Work_list>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Work_list_By_WORK_AREA_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Work_list_Execution)
{
_Stop_Delete_Work_list_Execution = false;
return;
}
_AppContext.Delete_Work_list_By_WORK_AREA_ID(i_Params_Delete_Work_list_By_WORK_AREA_ID.WORK_AREA_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Work_list_By_WORK_AREA_ID");}
}
public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
{
Params_Get_User_By_OWNER_ID oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_OWNER_ID");}
}
public void Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
Params_Get_User_By_USERNAME oParams_Get_User_By_USERNAME = new Params_Get_User_By_USERNAME();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USERNAME");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USERNAME");}
}
public void Delete_Work_area_By_OWNER_ID(Params_Delete_Work_area_By_OWNER_ID i_Params_Delete_Work_area_By_OWNER_ID)
{
Params_Get_Work_area_By_OWNER_ID oParams_Get_Work_area_By_OWNER_ID = new Params_Get_Work_area_By_OWNER_ID();
List<Work_area> _List_Work_area = new List<Work_area>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Work_area_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Work_area_Execution)
{
_Stop_Delete_Work_area_Execution = false;
return;
}
_AppContext.Delete_Work_area_By_OWNER_ID(i_Params_Delete_Work_area_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Work_area_By_OWNER_ID");}
}
public void Delete_Boost_listing_By_OWNER_ID(Params_Delete_Boost_listing_By_OWNER_ID i_Params_Delete_Boost_listing_By_OWNER_ID)
{
Params_Get_Boost_listing_By_OWNER_ID oParams_Get_Boost_listing_By_OWNER_ID = new Params_Get_Boost_listing_By_OWNER_ID();
List<Boost_listing> _List_Boost_listing = new List<Boost_listing>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Boost_listing_By_OWNER_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Boost_listing_Execution)
{
_Stop_Delete_Boost_listing_Execution = false;
return;
}
_AppContext.Delete_Boost_listing_By_OWNER_ID(i_Params_Delete_Boost_listing_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Boost_listing_By_OWNER_ID");}
}
public void Delete_Boost_listing_By_SERVICE_PROD_ID(Params_Delete_Boost_listing_By_SERVICE_PROD_ID i_Params_Delete_Boost_listing_By_SERVICE_PROD_ID)
{
Params_Get_Boost_listing_By_SERVICE_PROD_ID oParams_Get_Boost_listing_By_SERVICE_PROD_ID = new Params_Get_Boost_listing_By_SERVICE_PROD_ID();
List<Boost_listing> _List_Boost_listing = new List<Boost_listing>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Boost_listing_By_SERVICE_PROD_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Boost_listing_Execution)
{
_Stop_Delete_Boost_listing_Execution = false;
return;
}
_AppContext.Delete_Boost_listing_By_SERVICE_PROD_ID(i_Params_Delete_Boost_listing_By_SERVICE_PROD_ID.SERVICE_PROD_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Boost_listing_By_SERVICE_PROD_ID");}
}
public void Delete_Boost_listing_By_BOOST_PRICING_ID(Params_Delete_Boost_listing_By_BOOST_PRICING_ID i_Params_Delete_Boost_listing_By_BOOST_PRICING_ID)
{
Params_Get_Boost_listing_By_BOOST_PRICING_ID oParams_Get_Boost_listing_By_BOOST_PRICING_ID = new Params_Get_Boost_listing_By_BOOST_PRICING_ID();
List<Boost_listing> _List_Boost_listing = new List<Boost_listing>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Boost_listing_By_BOOST_PRICING_ID");}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Boost_listing_Execution)
{
_Stop_Delete_Boost_listing_Execution = false;
return;
}
_AppContext.Delete_Boost_listing_By_BOOST_PRICING_ID(i_Params_Delete_Boost_listing_By_BOOST_PRICING_ID.BOOST_PRICING_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Boost_listing_By_BOOST_PRICING_ID");}
}
public void Edit_Boost_pricing(Boost_pricing i_Boost_pricing) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Boost_pricing.BOOST_PRICING_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Boost_pricing");}
#region Body Section.
if ((i_Boost_pricing.BOOST_PRICING_ID == null) || (i_Boost_pricing.BOOST_PRICING_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Boost_pricing"); }
i_Boost_pricing.ENTRY_USER_ID = this.UserID;
i_Boost_pricing.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Boost_pricing.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Boost_pricing
if (OnPreEvent_Edit_Boost_pricing != null)
{
OnPreEvent_Edit_Boost_pricing(i_Boost_pricing,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Boost_pricing_Execution)
{
_Stop_Edit_Boost_pricing_Execution = false;
return;
}
i_Boost_pricing.BOOST_PRICING_ID = _AppContext.Edit_Boost_pricing
(
i_Boost_pricing.BOOST_PRICING_ID
,i_Boost_pricing.NAME
,i_Boost_pricing.MINUTE
,i_Boost_pricing.PRICE_PER_MINUTE
,i_Boost_pricing.TOTAL_PRICE
,i_Boost_pricing.DESCRIPTION
,i_Boost_pricing.ENTRY_USER_ID
,i_Boost_pricing.ENTRY_DATE
,i_Boost_pricing.OWNER_ID
);
#region PostEvent_Edit_Boost_pricing
if (OnPostEvent_Edit_Boost_pricing != null)
{
OnPostEvent_Edit_Boost_pricing(i_Boost_pricing,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Boost_pricing");}
}
public void Edit_Client(Client i_Client) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Client.CLIENT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client");}
#region Body Section.
if ((i_Client.CLIENT_ID == null) || (i_Client.CLIENT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Client"); }
i_Client.ENTRY_USER_ID = this.UserID;
i_Client.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Client.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Client
if (OnPreEvent_Edit_Client != null)
{
OnPreEvent_Edit_Client(i_Client,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Client_Execution)
{
_Stop_Edit_Client_Execution = false;
return;
}
i_Client.CLIENT_ID = _AppContext.Edit_Client
(
i_Client.CLIENT_ID
,i_Client.FIRST_NAME
,i_Client.LAST_NAME
,i_Client.USERNAME
,i_Client.PASSWORD
,i_Client.PHONE_NUMBER
,i_Client.EMAIL
,i_Client.IS_ACTIVE
,i_Client.IS_VERIFIED
,i_Client.ENTRY_USER_ID
,i_Client.ENTRY_DATE
,i_Client.OWNER_ID
);
#region PostEvent_Edit_Client
if (OnPostEvent_Edit_Client != null)
{
OnPostEvent_Edit_Client(i_Client,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client");}
}
public void Edit_Service_prod(Service_prod i_Service_prod) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Service_prod.SERVICE_PROD_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Service_prod");}
#region Body Section.
if ((i_Service_prod.SERVICE_PROD_ID == null) || (i_Service_prod.SERVICE_PROD_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Service_prod"); }
i_Service_prod.ENTRY_USER_ID = this.UserID;
i_Service_prod.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Service_prod.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Service_prod
if (OnPreEvent_Edit_Service_prod != null)
{
OnPreEvent_Edit_Service_prod(i_Service_prod,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Service_prod_Execution)
{
_Stop_Edit_Service_prod_Execution = false;
return;
}
i_Service_prod.SERVICE_PROD_ID = _AppContext.Edit_Service_prod
(
i_Service_prod.SERVICE_PROD_ID
,i_Service_prod.BUSINESS_ID
,i_Service_prod.SUB_CATEGORY_ID
,i_Service_prod.NAME
,i_Service_prod.PRICE
,i_Service_prod.PROFIT_PERCENTAGE
,i_Service_prod.IS_BOOSTED
,i_Service_prod.DESCRIPTION
,i_Service_prod.ENTRY_USER_ID
,i_Service_prod.ENTRY_DATE
,i_Service_prod.OWNER_ID
);
#region PostEvent_Edit_Service_prod
if (OnPostEvent_Edit_Service_prod != null)
{
OnPostEvent_Edit_Service_prod(i_Service_prod,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Service_prod");}
}
public void Edit_Admin(Admin i_Admin) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Admin.ADMIN_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Admin");}
#region Body Section.
if ((i_Admin.ADMIN_ID == null) || (i_Admin.ADMIN_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Admin"); }
i_Admin.ENTRY_USER_ID = this.UserID;
i_Admin.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Admin.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Admin
if (OnPreEvent_Edit_Admin != null)
{
OnPreEvent_Edit_Admin(i_Admin,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Admin_Execution)
{
_Stop_Edit_Admin_Execution = false;
return;
}
i_Admin.ADMIN_ID = _AppContext.Edit_Admin
(
i_Admin.ADMIN_ID
,i_Admin.FIRST_NAME
,i_Admin.LAST_NAME
,i_Admin.USERNAME
,i_Admin.PASSWORD
,i_Admin.EMAIL
,i_Admin.IS_ACTIVE
,i_Admin.ENTRY_USER_ID
,i_Admin.ENTRY_DATE
,i_Admin.OWNER_ID
);
#region PostEvent_Edit_Admin
if (OnPostEvent_Edit_Admin != null)
{
OnPostEvent_Edit_Admin(i_Admin,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Admin");}
}
public void Edit_Category(Category i_Category) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Category.CATEGORY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category");}
#region Body Section.
if ((i_Category.CATEGORY_ID == null) || (i_Category.CATEGORY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Category"); }
i_Category.ENTRY_USER_ID = this.UserID;
i_Category.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Category.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Category
if (OnPreEvent_Edit_Category != null)
{
OnPreEvent_Edit_Category(i_Category,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Category_Execution)
{
_Stop_Edit_Category_Execution = false;
return;
}
i_Category.CATEGORY_ID = _AppContext.Edit_Category
(
i_Category.CATEGORY_ID
,i_Category.NAME
,i_Category.DESCRIPTION
,i_Category.ENTRY_USER_ID
,i_Category.ENTRY_DATE
,i_Category.OWNER_ID
);
#region PostEvent_Edit_Category
if (OnPostEvent_Edit_Category != null)
{
OnPostEvent_Edit_Category(i_Category,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category");}
}
public void Edit_Sub_category(Sub_category i_Sub_category) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Sub_category.SUB_CATEGORY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Sub_category");}
#region Body Section.
if ((i_Sub_category.SUB_CATEGORY_ID == null) || (i_Sub_category.SUB_CATEGORY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Sub_category"); }
i_Sub_category.ENTRY_USER_ID = this.UserID;
i_Sub_category.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Sub_category.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Sub_category_Execution)
{
_Stop_Edit_Sub_category_Execution = false;
return;
}
i_Sub_category.SUB_CATEGORY_ID = _AppContext.Edit_Sub_category
(
i_Sub_category.SUB_CATEGORY_ID
,i_Sub_category.CATEGORY_ID
,i_Sub_category.NAME
,i_Sub_category.DESCRIPTION
,i_Sub_category.ENTRY_USER_ID
,i_Sub_category.ENTRY_DATE
,i_Sub_category.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Sub_category");}
}
public void Edit_Coordinates(Coordinates i_Coordinates) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Coordinates.COORDINATES_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coordinates");}
#region Body Section.
if ((i_Coordinates.COORDINATES_ID == null) || (i_Coordinates.COORDINATES_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Coordinates"); }
i_Coordinates.ENTRY_USER_ID = this.UserID;
i_Coordinates.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Coordinates.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Coordinates_Execution)
{
_Stop_Edit_Coordinates_Execution = false;
return;
}
i_Coordinates.COORDINATES_ID = _AppContext.Edit_Coordinates
(
i_Coordinates.COORDINATES_ID
,i_Coordinates.BOOKING_ID
,i_Coordinates.LONGITUDE
,i_Coordinates.LATITUDE
,i_Coordinates.DESCRIPTION
,i_Coordinates.ENTRY_USER_ID
,i_Coordinates.ENTRY_DATE
,i_Coordinates.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coordinates");}
}
public void Edit_Currency(Currency i_Currency) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Currency.CURRENCY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency");}
#region Body Section.
if ((i_Currency.CURRENCY_ID == null) || (i_Currency.CURRENCY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Currency"); }
i_Currency.ENTRY_USER_ID = this.UserID;
i_Currency.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Currency.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Currency_Execution)
{
_Stop_Edit_Currency_Execution = false;
return;
}
i_Currency.CURRENCY_ID = _AppContext.Edit_Currency
(
i_Currency.CURRENCY_ID
,i_Currency.NAME
,i_Currency.SYMBOL
,i_Currency.ACRONYM
,i_Currency.DESCRIPTION
,i_Currency.ENTRY_USER_ID
,i_Currency.ENTRY_DATE
,i_Currency.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency");}
}
public void Edit_Status(Status i_Status) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Status.STATUS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Status");}
#region Body Section.
if ((i_Status.STATUS_ID == null) || (i_Status.STATUS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Status"); }
i_Status.ENTRY_USER_ID = this.UserID;
i_Status.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Status.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Status
if (OnPreEvent_Edit_Status != null)
{
OnPreEvent_Edit_Status(i_Status,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Status_Execution)
{
_Stop_Edit_Status_Execution = false;
return;
}
i_Status.STATUS_ID = _AppContext.Edit_Status
(
i_Status.STATUS_ID
,i_Status.NAME
,i_Status.DESCRIPTION
,i_Status.ENTRY_USER_ID
,i_Status.ENTRY_DATE
,i_Status.OWNER_ID
);
#region PostEvent_Edit_Status
if (OnPostEvent_Edit_Status != null)
{
OnPostEvent_Edit_Status(i_Status,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Status");}
}
public void Edit_Owner(Owner i_Owner) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Owner.OWNER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner");}
#region Body Section.
if ((i_Owner.OWNER_ID == null) || (i_Owner.OWNER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Owner"); }
i_Owner.ENTRY_DATE    = oTools.GetDateTimeString(DateTime.Now);
i_Owner.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Owner_Execution)
{
_Stop_Edit_Owner_Execution = false;
return;
}
i_Owner.OWNER_ID = _AppContext.Edit_Owner
(
i_Owner.OWNER_ID
,i_Owner.CODE
,i_Owner.MAINTENANCE_DUE_DATE
,i_Owner.DESCRIPTION
,i_Owner.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner");}
}
public void Edit_Feedback(Feedback i_Feedback) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Feedback.FEEDBACK_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Feedback");}
#region Body Section.
if ((i_Feedback.FEEDBACK_ID == null) || (i_Feedback.FEEDBACK_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Feedback"); }
i_Feedback.ENTRY_USER_ID = this.UserID;
i_Feedback.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Feedback.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Feedback
if (OnPreEvent_Edit_Feedback != null)
{
OnPreEvent_Edit_Feedback(i_Feedback,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Feedback_Execution)
{
_Stop_Edit_Feedback_Execution = false;
return;
}
i_Feedback.FEEDBACK_ID = _AppContext.Edit_Feedback
(
i_Feedback.FEEDBACK_ID
,i_Feedback.BOOKING_ID
,i_Feedback.COMMENT
,i_Feedback.RATING
,i_Feedback.DATE
,i_Feedback.TIME
,i_Feedback.DESCRIPTION
,i_Feedback.ENTRY_USER_ID
,i_Feedback.ENTRY_DATE
,i_Feedback.OWNER_ID
);
#region PostEvent_Edit_Feedback
if (OnPostEvent_Edit_Feedback != null)
{
OnPostEvent_Edit_Feedback(i_Feedback,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Feedback");}
}
public void Edit_Booking(Booking i_Booking) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Booking.BOOKING_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Booking");}
#region Body Section.
if ((i_Booking.BOOKING_ID == null) || (i_Booking.BOOKING_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Booking"); }
i_Booking.ENTRY_USER_ID = this.UserID;
i_Booking.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Booking.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Booking
if (OnPreEvent_Edit_Booking != null)
{
OnPreEvent_Edit_Booking(i_Booking,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Booking_Execution)
{
_Stop_Edit_Booking_Execution = false;
return;
}
i_Booking.BOOKING_ID = _AppContext.Edit_Booking
(
i_Booking.BOOKING_ID
,i_Booking.SERVICE_PROD_ID
,i_Booking.CLIENT_ID
,i_Booking.BUSINESS_ID
,i_Booking.WORK_AREA_ID
,i_Booking.DATE
,i_Booking.TOTAL_PRICE
,i_Booking.STATUS_ID
,i_Booking.DESCRIPTION
,i_Booking.ENTRY_USER_ID
,i_Booking.ENTRY_DATE
,i_Booking.OWNER_ID
);
#region PostEvent_Edit_Booking
if (OnPostEvent_Edit_Booking != null)
{
OnPostEvent_Edit_Booking(i_Booking,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Booking");}
}
public void Edit_Business(Business i_Business) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Business.BUSINESS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Business");}
#region Body Section.
if ((i_Business.BUSINESS_ID == null) || (i_Business.BUSINESS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Business"); }
i_Business.ENTRY_USER_ID = this.UserID;
i_Business.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Business.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Business
if (OnPreEvent_Edit_Business != null)
{
OnPreEvent_Edit_Business(i_Business,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Business_Execution)
{
_Stop_Edit_Business_Execution = false;
return;
}
i_Business.BUSINESS_ID = _AppContext.Edit_Business
(
i_Business.BUSINESS_ID
,i_Business.NAME
,i_Business.USERNAME
,i_Business.PASSWORD
,i_Business.EMAIL
,i_Business.PHONE_NUMBER
,i_Business.INTERVENTION_TIME
,i_Business.MINIMUM_COST
,i_Business.IS_VALIDATED
,i_Business.IS_CHECKMARK
,i_Business.IS_ACTIVE
,i_Business.IS_BOOSTED
,i_Business.DESCRIPTION
,i_Business.ENTRY_USER_ID
,i_Business.ENTRY_DATE
,i_Business.OWNER_ID
);
#region PostEvent_Edit_Business
if (OnPostEvent_Edit_Business != null)
{
OnPostEvent_Edit_Business(i_Business,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Business");}
}
public void Edit_Work_list(Work_list i_Work_list) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Work_list.WORK_LIST_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Work_list");}
#region Body Section.
if ((i_Work_list.WORK_LIST_ID == null) || (i_Work_list.WORK_LIST_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Work_list"); }
i_Work_list.ENTRY_USER_ID = this.UserID;
i_Work_list.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Work_list.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Work_list
if (OnPreEvent_Edit_Work_list != null)
{
OnPreEvent_Edit_Work_list(i_Work_list,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Work_list_Execution)
{
_Stop_Edit_Work_list_Execution = false;
return;
}
i_Work_list.WORK_LIST_ID = _AppContext.Edit_Work_list
(
i_Work_list.WORK_LIST_ID
,i_Work_list.BUSINESS_ID
,i_Work_list.WORK_AREA_ID
,i_Work_list.IS_TRUE
,i_Work_list.DESCRIPTION
,i_Work_list.ENTRY_USER_ID
,i_Work_list.ENTRY_DATE
,i_Work_list.OWNER_ID
);
#region PostEvent_Edit_Work_list
if (OnPostEvent_Edit_Work_list != null)
{
OnPostEvent_Edit_Work_list(i_Work_list,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Work_list");}
}
public void Edit_User(User i_User) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User.USER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User");}
#region Body Section.
if ((i_User.USER_ID == null) || (i_User.USER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User"); }
i_User.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_Execution)
{
_Stop_Edit_User_Execution = false;
return;
}
i_User.USER_ID = _AppContext.Edit_User
(
i_User.USER_ID
,i_User.OWNER_ID
,i_User.USERNAME
,i_User.PASSWORD
,i_User.USER_TYPE_CODE
,i_User.IS_ACTIVE
,i_User.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User");}
}
public void Edit_Work_area(Work_area i_Work_area) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Work_area.WORK_AREA_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Work_area");}
#region Body Section.
if ((i_Work_area.WORK_AREA_ID == null) || (i_Work_area.WORK_AREA_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Work_area"); }
i_Work_area.ENTRY_USER_ID = this.UserID;
i_Work_area.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Work_area.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Work_area
if (OnPreEvent_Edit_Work_area != null)
{
OnPreEvent_Edit_Work_area(i_Work_area,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Work_area_Execution)
{
_Stop_Edit_Work_area_Execution = false;
return;
}
i_Work_area.WORK_AREA_ID = _AppContext.Edit_Work_area
(
i_Work_area.WORK_AREA_ID
,i_Work_area.NAME
,i_Work_area.DESCRIPTION
,i_Work_area.ENTRY_USER_ID
,i_Work_area.ENTRY_DATE
,i_Work_area.OWNER_ID
);
#region PostEvent_Edit_Work_area
if (OnPostEvent_Edit_Work_area != null)
{
OnPostEvent_Edit_Work_area(i_Work_area,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Work_area");}
}
public void Edit_Boost_listing(Boost_listing i_Boost_listing) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Boost_listing.BOOST_LISTING_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Boost_listing");}
#region Body Section.
if ((i_Boost_listing.BOOST_LISTING_ID == null) || (i_Boost_listing.BOOST_LISTING_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Boost_listing"); }
i_Boost_listing.ENTRY_USER_ID = this.UserID;
i_Boost_listing.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Boost_listing.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Boost_listing
if (OnPreEvent_Edit_Boost_listing != null)
{
OnPreEvent_Edit_Boost_listing(i_Boost_listing,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Boost_listing_Execution)
{
_Stop_Edit_Boost_listing_Execution = false;
return;
}
i_Boost_listing.BOOST_LISTING_ID = _AppContext.Edit_Boost_listing
(
i_Boost_listing.BOOST_LISTING_ID
,i_Boost_listing.SERVICE_PROD_ID
,i_Boost_listing.BOOST_PRICING_ID
,i_Boost_listing.START_DATE
,i_Boost_listing.START_TIME
,i_Boost_listing.IS_ACTIVE
,i_Boost_listing.IS_PAID
,i_Boost_listing.IS_COMPLETED
,i_Boost_listing.DESCRIPTION
,i_Boost_listing.ENTRY_USER_ID
,i_Boost_listing.ENTRY_DATE
,i_Boost_listing.OWNER_ID
);
#region PostEvent_Edit_Boost_listing
if (OnPostEvent_Edit_Boost_listing != null)
{
OnPostEvent_Edit_Boost_listing(i_Boost_listing,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Boost_listing");}
}
public void Edit_Boost_pricing_List(List<Boost_pricing> i_List_Boost_pricing)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Boost_pricing_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Boost_pricing != null)
{
foreach (var oRow in i_List_Boost_pricing)
{
Edit_Boost_pricing(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Boost_pricing_List");}
}
public void Edit_Boost_pricing_List(Params_Edit_Boost_pricing_List i_Params_Edit_Boost_pricing_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Boost_pricing_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Boost_pricing_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Boost_pricing_List.My_List_To_Delete)
{
Delete_Boost_pricing(new Params_Delete_Boost_pricing() { BOOST_PRICING_ID = oRow.BOOST_PRICING_ID });
}
}
if (i_Params_Edit_Boost_pricing_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Boost_pricing_List.My_List_To_Edit)
{
Edit_Boost_pricing(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Boost_pricing_List");}
}
public void Edit_Client_List(List<Client> i_List_Client)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Client != null)
{
foreach (var oRow in i_List_Client)
{
Edit_Client(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_List");}
}
public void Edit_Client_List(Params_Edit_Client_List i_Params_Edit_Client_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Client_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Client_List.My_List_To_Delete)
{
Delete_Client(new Params_Delete_Client() { CLIENT_ID = oRow.CLIENT_ID });
}
}
if (i_Params_Edit_Client_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Client_List.My_List_To_Edit)
{
Edit_Client(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_List");}
}
public void Edit_Service_prod_List(List<Service_prod> i_List_Service_prod)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Service_prod_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Service_prod != null)
{
foreach (var oRow in i_List_Service_prod)
{
Edit_Service_prod(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Service_prod_List");}
}
public void Edit_Service_prod_List(Params_Edit_Service_prod_List i_Params_Edit_Service_prod_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Service_prod_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Service_prod_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Service_prod_List.My_List_To_Delete)
{
Delete_Service_prod(new Params_Delete_Service_prod() { SERVICE_PROD_ID = oRow.SERVICE_PROD_ID });
}
}
if (i_Params_Edit_Service_prod_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Service_prod_List.My_List_To_Edit)
{
Edit_Service_prod(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Service_prod_List");}
}
public void Edit_Admin_List(List<Admin> i_List_Admin)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Admin_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Admin != null)
{
foreach (var oRow in i_List_Admin)
{
Edit_Admin(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Admin_List");}
}
public void Edit_Admin_List(Params_Edit_Admin_List i_Params_Edit_Admin_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Admin_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Admin_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Admin_List.My_List_To_Delete)
{
Delete_Admin(new Params_Delete_Admin() { ADMIN_ID = oRow.ADMIN_ID });
}
}
if (i_Params_Edit_Admin_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Admin_List.My_List_To_Edit)
{
Edit_Admin(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Admin_List");}
}
public void Edit_Category_List(List<Category> i_List_Category)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Category != null)
{
foreach (var oRow in i_List_Category)
{
Edit_Category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_List");}
}
public void Edit_Category_List(Params_Edit_Category_List i_Params_Edit_Category_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Category_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Category_List.My_List_To_Delete)
{
Delete_Category(new Params_Delete_Category() { CATEGORY_ID = oRow.CATEGORY_ID });
}
}
if (i_Params_Edit_Category_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Category_List.My_List_To_Edit)
{
Edit_Category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_List");}
}
public void Edit_Sub_category_List(List<Sub_category> i_List_Sub_category)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Sub_category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Sub_category != null)
{
foreach (var oRow in i_List_Sub_category)
{
Edit_Sub_category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Sub_category_List");}
}
public void Edit_Sub_category_List(Params_Edit_Sub_category_List i_Params_Edit_Sub_category_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Sub_category_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Sub_category_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Sub_category_List.My_List_To_Delete)
{
Delete_Sub_category(new Params_Delete_Sub_category() { SUB_CATEGORY_ID = oRow.SUB_CATEGORY_ID });
}
}
if (i_Params_Edit_Sub_category_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Sub_category_List.My_List_To_Edit)
{
Edit_Sub_category(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Sub_category_List");}
}
public void Edit_Coordinates_List(List<Coordinates> i_List_Coordinates)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coordinates_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Coordinates != null)
{
foreach (var oRow in i_List_Coordinates)
{
Edit_Coordinates(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coordinates_List");}
}
public void Edit_Coordinates_List(Params_Edit_Coordinates_List i_Params_Edit_Coordinates_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Coordinates_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Coordinates_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Coordinates_List.My_List_To_Delete)
{
Delete_Coordinates(new Params_Delete_Coordinates() { COORDINATES_ID = oRow.COORDINATES_ID });
}
}
if (i_Params_Edit_Coordinates_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Coordinates_List.My_List_To_Edit)
{
Edit_Coordinates(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Coordinates_List");}
}
public void Edit_Currency_List(List<Currency> i_List_Currency)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Currency != null)
{
foreach (var oRow in i_List_Currency)
{
Edit_Currency(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_List");}
}
public void Edit_Currency_List(Params_Edit_Currency_List i_Params_Edit_Currency_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Currency_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Currency_List.My_List_To_Delete)
{
Delete_Currency(new Params_Delete_Currency() { CURRENCY_ID = oRow.CURRENCY_ID });
}
}
if (i_Params_Edit_Currency_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Currency_List.My_List_To_Edit)
{
Edit_Currency(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_List");}
}
public void Edit_Status_List(List<Status> i_List_Status)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Status_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Status != null)
{
foreach (var oRow in i_List_Status)
{
Edit_Status(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Status_List");}
}
public void Edit_Status_List(Params_Edit_Status_List i_Params_Edit_Status_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Status_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Status_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Status_List.My_List_To_Delete)
{
Delete_Status(new Params_Delete_Status() { STATUS_ID = oRow.STATUS_ID });
}
}
if (i_Params_Edit_Status_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Status_List.My_List_To_Edit)
{
Edit_Status(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Status_List");}
}
public void Edit_Owner_List(List<Owner> i_List_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Owner != null)
{
foreach (var oRow in i_List_Owner)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Owner_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Delete)
{
Delete_Owner(new Params_Delete_Owner() { OWNER_ID = oRow.OWNER_ID });
}
}
if (i_Params_Edit_Owner_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Edit)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Feedback_List(List<Feedback> i_List_Feedback)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Feedback_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Feedback != null)
{
foreach (var oRow in i_List_Feedback)
{
Edit_Feedback(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Feedback_List");}
}
public void Edit_Feedback_List(Params_Edit_Feedback_List i_Params_Edit_Feedback_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Feedback_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Feedback_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Feedback_List.My_List_To_Delete)
{
Delete_Feedback(new Params_Delete_Feedback() { FEEDBACK_ID = oRow.FEEDBACK_ID });
}
}
if (i_Params_Edit_Feedback_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Feedback_List.My_List_To_Edit)
{
Edit_Feedback(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Feedback_List");}
}
public void Edit_Booking_List(List<Booking> i_List_Booking)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Booking_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Booking != null)
{
foreach (var oRow in i_List_Booking)
{
Edit_Booking(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Booking_List");}
}
public void Edit_Booking_List(Params_Edit_Booking_List i_Params_Edit_Booking_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Booking_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Booking_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Booking_List.My_List_To_Delete)
{
Delete_Booking(new Params_Delete_Booking() { BOOKING_ID = oRow.BOOKING_ID });
}
}
if (i_Params_Edit_Booking_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Booking_List.My_List_To_Edit)
{
Edit_Booking(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Booking_List");}
}
public void Edit_Business_List(List<Business> i_List_Business)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Business_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Business != null)
{
foreach (var oRow in i_List_Business)
{
Edit_Business(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Business_List");}
}
public void Edit_Business_List(Params_Edit_Business_List i_Params_Edit_Business_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Business_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Business_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Business_List.My_List_To_Delete)
{
Delete_Business(new Params_Delete_Business() { BUSINESS_ID = oRow.BUSINESS_ID });
}
}
if (i_Params_Edit_Business_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Business_List.My_List_To_Edit)
{
Edit_Business(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Business_List");}
}
public void Edit_Work_list_List(List<Work_list> i_List_Work_list)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Work_list_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Work_list != null)
{
foreach (var oRow in i_List_Work_list)
{
Edit_Work_list(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Work_list_List");}
}
public void Edit_Work_list_List(Params_Edit_Work_list_List i_Params_Edit_Work_list_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Work_list_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Work_list_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Work_list_List.My_List_To_Delete)
{
Delete_Work_list(new Params_Delete_Work_list() { WORK_LIST_ID = oRow.WORK_LIST_ID });
}
}
if (i_Params_Edit_Work_list_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Work_list_List.My_List_To_Edit)
{
Edit_Work_list(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Work_list_List");}
}
public void Edit_User_List(List<User> i_List_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User != null)
{
foreach (var oRow in i_List_User)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Delete)
{
Delete_User(new Params_Delete_User() { USER_ID = oRow.USER_ID });
}
}
if (i_Params_Edit_User_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Edit)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_Work_area_List(List<Work_area> i_List_Work_area)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Work_area_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Work_area != null)
{
foreach (var oRow in i_List_Work_area)
{
Edit_Work_area(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Work_area_List");}
}
public void Edit_Work_area_List(Params_Edit_Work_area_List i_Params_Edit_Work_area_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Work_area_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Work_area_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Work_area_List.My_List_To_Delete)
{
Delete_Work_area(new Params_Delete_Work_area() { WORK_AREA_ID = oRow.WORK_AREA_ID });
}
}
if (i_Params_Edit_Work_area_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Work_area_List.My_List_To_Edit)
{
Edit_Work_area(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Work_area_List");}
}
public void Edit_Boost_listing_List(List<Boost_listing> i_List_Boost_listing)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Boost_listing_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Boost_listing != null)
{
foreach (var oRow in i_List_Boost_listing)
{
Edit_Boost_listing(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Boost_listing_List");}
}
public void Edit_Boost_listing_List(Params_Edit_Boost_listing_List i_Params_Edit_Boost_listing_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Boost_listing_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Boost_listing_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Boost_listing_List.My_List_To_Delete)
{
Delete_Boost_listing(new Params_Delete_Boost_listing() { BOOST_LISTING_ID = oRow.BOOST_LISTING_ID });
}
}
if (i_Params_Edit_Boost_listing_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Boost_listing_List.My_List_To_Edit)
{
Edit_Boost_listing(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Boost_listing_List");}
}
}
}
