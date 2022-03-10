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
#region Params_Get_Boost_pricing_By_BOOST_PRICING_ID
public partial class Params_Get_Boost_pricing_By_BOOST_PRICING_ID
{
#region Properties
public Int32? BOOST_PRICING_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Client_By_CLIENT_ID
public partial class Params_Get_Client_By_CLIENT_ID
{
#region Properties
public Int32? CLIENT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Service_prod_By_SERVICE_PROD_ID
public partial class Params_Get_Service_prod_By_SERVICE_PROD_ID
{
#region Properties
public Int32? SERVICE_PROD_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Admin_By_ADMIN_ID
public partial class Params_Get_Admin_By_ADMIN_ID
{
#region Properties
public Int32? ADMIN_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Category_By_CATEGORY_ID
public partial class Params_Get_Category_By_CATEGORY_ID
{
#region Properties
public Int32? CATEGORY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Sub_category_By_SUB_CATEGORY_ID
public partial class Params_Get_Sub_category_By_SUB_CATEGORY_ID
{
#region Properties
public Int32? SUB_CATEGORY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Coordinates_By_COORDINATES_ID
public partial class Params_Get_Coordinates_By_COORDINATES_ID
{
#region Properties
public Int32? COORDINATES_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Currency_By_CURRENCY_ID
public partial class Params_Get_Currency_By_CURRENCY_ID
{
#region Properties
public Int32? CURRENCY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Status_By_STATUS_ID
public partial class Params_Get_Status_By_STATUS_ID
{
#region Properties
public Int32? STATUS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Owner_By_OWNER_ID
public partial class Params_Get_Owner_By_OWNER_ID
{
#region Properties
public Int32? OWNER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Feedback_By_FEEDBACK_ID
public partial class Params_Get_Feedback_By_FEEDBACK_ID
{
#region Properties
public Int32? FEEDBACK_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Booking_By_BOOKING_ID
public partial class Params_Get_Booking_By_BOOKING_ID
{
#region Properties
public Int32? BOOKING_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Business_By_BUSINESS_ID
public partial class Params_Get_Business_By_BUSINESS_ID
{
#region Properties
public Int32? BUSINESS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Work_list_By_WORK_LIST_ID
public partial class Params_Get_Work_list_By_WORK_LIST_ID
{
#region Properties
public Int32? WORK_LIST_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_By_USER_ID
public partial class Params_Get_User_By_USER_ID
{
#region Properties
public long? USER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Work_area_By_WORK_AREA_ID
public partial class Params_Get_Work_area_By_WORK_AREA_ID
{
#region Properties
public Int32? WORK_AREA_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Boost_listing_By_BOOST_LISTING_ID
public partial class Params_Get_Boost_listing_By_BOOST_LISTING_ID
{
#region Properties
public Int32? BOOST_LISTING_ID {get;set;}

#endregion
}
#endregion
public partial class Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List
{
public List<Int32?> BOOST_PRICING_ID_LIST {get;set;}
}
public partial class Params_Get_Boost_pricing_By_BOOST_PRICING_ID_List_SP
{
public string BOOST_PRICING_ID_LIST {get;set;}

}
public partial class Params_Get_Client_By_CLIENT_ID_List
{
public List<Int32?> CLIENT_ID_LIST {get;set;}
}
public partial class Params_Get_Client_By_CLIENT_ID_List_SP
{
public string CLIENT_ID_LIST {get;set;}

}
public partial class Params_Get_Service_prod_By_SERVICE_PROD_ID_List
{
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}
}
public partial class Params_Get_Service_prod_By_SERVICE_PROD_ID_List_SP
{
public string SERVICE_PROD_ID_LIST {get;set;}

}
public partial class Params_Get_Admin_By_ADMIN_ID_List
{
public List<Int32?> ADMIN_ID_LIST {get;set;}
}
public partial class Params_Get_Admin_By_ADMIN_ID_List_SP
{
public string ADMIN_ID_LIST {get;set;}

}
public partial class Params_Get_Category_By_CATEGORY_ID_List
{
public List<Int32?> CATEGORY_ID_LIST {get;set;}
}
public partial class Params_Get_Category_By_CATEGORY_ID_List_SP
{
public string CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Sub_category_By_SUB_CATEGORY_ID_List
{
public List<Int32?> SUB_CATEGORY_ID_LIST {get;set;}
}
public partial class Params_Get_Sub_category_By_SUB_CATEGORY_ID_List_SP
{
public string SUB_CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Coordinates_By_COORDINATES_ID_List
{
public List<Int32?> COORDINATES_ID_LIST {get;set;}
}
public partial class Params_Get_Coordinates_By_COORDINATES_ID_List_SP
{
public string COORDINATES_ID_LIST {get;set;}

}
public partial class Params_Get_Currency_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}
}
public partial class Params_Get_Currency_By_CURRENCY_ID_List_SP
{
public string CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Status_By_STATUS_ID_List
{
public List<Int32?> STATUS_ID_LIST {get;set;}
}
public partial class Params_Get_Status_By_STATUS_ID_List_SP
{
public string STATUS_ID_LIST {get;set;}

}
public partial class Params_Get_Owner_By_OWNER_ID_List
{
public List<Int32?> OWNER_ID_LIST {get;set;}
}
public partial class Params_Get_Owner_By_OWNER_ID_List_SP
{
public string OWNER_ID_LIST {get;set;}

}
public partial class Params_Get_Feedback_By_FEEDBACK_ID_List
{
public List<Int32?> FEEDBACK_ID_LIST {get;set;}
}
public partial class Params_Get_Feedback_By_FEEDBACK_ID_List_SP
{
public string FEEDBACK_ID_LIST {get;set;}

}
public partial class Params_Get_Booking_By_BOOKING_ID_List
{
public List<Int32?> BOOKING_ID_LIST {get;set;}
}
public partial class Params_Get_Booking_By_BOOKING_ID_List_SP
{
public string BOOKING_ID_LIST {get;set;}

}
public partial class Params_Get_Business_By_BUSINESS_ID_List
{
public List<Int32?> BUSINESS_ID_LIST {get;set;}
}
public partial class Params_Get_Business_By_BUSINESS_ID_List_SP
{
public string BUSINESS_ID_LIST {get;set;}

}
public partial class Params_Get_Work_list_By_WORK_LIST_ID_List
{
public List<Int32?> WORK_LIST_ID_LIST {get;set;}
}
public partial class Params_Get_Work_list_By_WORK_LIST_ID_List_SP
{
public string WORK_LIST_ID_LIST {get;set;}

}
public partial class Params_Get_User_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}
}
public partial class Params_Get_User_By_USER_ID_List_SP
{
public string USER_ID_LIST {get;set;}

}
public partial class Params_Get_Work_area_By_WORK_AREA_ID_List
{
public List<Int32?> WORK_AREA_ID_LIST {get;set;}
}
public partial class Params_Get_Work_area_By_WORK_AREA_ID_List_SP
{
public string WORK_AREA_ID_LIST {get;set;}

}
public partial class Params_Get_Boost_listing_By_BOOST_LISTING_ID_List
{
public List<Int32?> BOOST_LISTING_ID_LIST {get;set;}
}
public partial class Params_Get_Boost_listing_By_BOOST_LISTING_ID_List_SP
{
public string BOOST_LISTING_ID_LIST {get;set;}

}
public partial class Params_Get_Boost_pricing_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Client_By_PHONE_NUMBER
{
public Int32? PHONE_NUMBER {get;set;}

}
public partial class Params_Get_Client_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Client_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_Service_prod_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Service_prod_By_BUSINESS_ID
{
public Int32? BUSINESS_ID {get;set;}

}
public partial class Params_Get_Service_prod_By_SUB_CATEGORY_ID
{
public Int32? SUB_CATEGORY_ID {get;set;}

}
public partial class Params_Get_Admin_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Admin_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_Category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Sub_category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Sub_category_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}

}
public partial class Params_Get_Coordinates_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Coordinates_By_BOOKING_ID
{
public Int32? BOOKING_ID {get;set;}

}
public partial class Params_Get_Currency_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Status_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Feedback_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Feedback_By_BOOKING_ID
{
public Int32? BOOKING_ID {get;set;}

}
public partial class Params_Get_Booking_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Booking_By_SERVICE_PROD_ID
{
public Int32? SERVICE_PROD_ID {get;set;}

}
public partial class Params_Get_Booking_By_CLIENT_ID
{
public Int32? CLIENT_ID {get;set;}

}
public partial class Params_Get_Booking_By_WORK_AREA_ID
{
public Int32? WORK_AREA_ID {get;set;}

}
public partial class Params_Get_Booking_By_STATUS_ID
{
public Int32? STATUS_ID {get;set;}

}
public partial class Params_Get_Booking_By_BUSINESS_ID
{
public Int32? BUSINESS_ID {get;set;}

}
public partial class Params_Get_Business_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_Business_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Work_list_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Work_list_By_BUSINESS_ID
{
public Int32? BUSINESS_ID {get;set;}

}
public partial class Params_Get_Work_list_By_WORK_AREA_ID
{
public Int32? WORK_AREA_ID {get;set;}

}
public partial class Params_Get_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_User_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_Work_area_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Boost_listing_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Boost_listing_By_SERVICE_PROD_ID
{
public Int32? SERVICE_PROD_ID {get;set;}

}
public partial class Params_Get_Boost_listing_By_BOOST_PRICING_ID
{
public Int32? BOOST_PRICING_ID {get;set;}

}
public partial class Params_Get_Client_By_PHONE_NUMBER_List
{
public List<Int32?> PHONE_NUMBER_LIST {get;set;}

}
public partial class Params_Get_Service_prod_By_BUSINESS_ID_List
{
public List<Int32?> BUSINESS_ID_LIST {get;set;}

}
public partial class Params_Get_Service_prod_By_SUB_CATEGORY_ID_List
{
public List<Int32?> SUB_CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Sub_category_By_CATEGORY_ID_List
{
public List<Int32?> CATEGORY_ID_LIST {get;set;}

}
public partial class Params_Get_Coordinates_By_BOOKING_ID_List
{
public List<Int32?> BOOKING_ID_LIST {get;set;}

}
public partial class Params_Get_Feedback_By_BOOKING_ID_List
{
public List<Int32?> BOOKING_ID_LIST {get;set;}

}
public partial class Params_Get_Booking_By_SERVICE_PROD_ID_List
{
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}

}
public partial class Params_Get_Booking_By_CLIENT_ID_List
{
public List<Int32?> CLIENT_ID_LIST {get;set;}

}
public partial class Params_Get_Booking_By_WORK_AREA_ID_List
{
public List<Int32?> WORK_AREA_ID_LIST {get;set;}

}
public partial class Params_Get_Booking_By_STATUS_ID_List
{
public List<Int32?> STATUS_ID_LIST {get;set;}

}
public partial class Params_Get_Booking_By_BUSINESS_ID_List
{
public List<Int32?> BUSINESS_ID_LIST {get;set;}

}
public partial class Params_Get_Work_list_By_BUSINESS_ID_List
{
public List<Int32?> BUSINESS_ID_LIST {get;set;}

}
public partial class Params_Get_Work_list_By_WORK_AREA_ID_List
{
public List<Int32?> WORK_AREA_ID_LIST {get;set;}

}
public partial class Params_Get_Boost_listing_By_SERVICE_PROD_ID_List
{
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}

}
public partial class Params_Get_Boost_listing_By_BOOST_PRICING_ID_List
{
public List<Int32?> BOOST_PRICING_ID_LIST {get;set;}

}
public partial class Params_Get_Boost_pricing_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_pricing_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Service_prod_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Service_prod_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Admin_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Admin_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Category_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Sub_category_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Sub_category_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coordinates_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string LONGITUDE {get;set;}
public string LATITUDE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coordinates_By_Where
{

public Int32? OWNER_ID {get;set;}
public string LONGITUDE {get;set;}
public string LATITUDE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Currency_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string SYMBOL {get;set;}
public string ACRONYM {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Currency_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string SYMBOL {get;set;}
public string ACRONYM {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Status_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Status_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Where
{

public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Business_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Business_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Work_list_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Work_list_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Work_area_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Work_area_By_Where
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Where
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string START_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string START_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Service_prod_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BUSINESS_ID_LIST {get;set;}
public List<Int32?> SUB_CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Service_prod_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public string BUSINESS_ID_LIST {get;set;}
public string SUB_CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Service_prod_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BUSINESS_ID_LIST {get;set;}
public List<Int32?> SUB_CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Service_prod_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public string BUSINESS_ID_LIST {get;set;}
public string SUB_CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Sub_category_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Sub_category_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Sub_category_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Sub_category_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public string CATEGORY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coordinates_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string LONGITUDE {get;set;}
public string LATITUDE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coordinates_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string LONGITUDE {get;set;}
public string LATITUDE {get;set;}
public string DESCRIPTION {get;set;}
public string BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coordinates_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string LONGITUDE {get;set;}
public string LATITUDE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Coordinates_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string LONGITUDE {get;set;}
public string LATITUDE {get;set;}
public string DESCRIPTION {get;set;}
public string BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DESCRIPTION {get;set;}
public string BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DESCRIPTION {get;set;}
public string BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public string BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Feedback_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string COMMENT {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public string BOOKING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}
public List<Int32?> CLIENT_ID_LIST {get;set;}
public List<Int32?> BUSINESS_ID_LIST {get;set;}
public List<Int32?> WORK_AREA_ID_LIST {get;set;}
public List<Int32?> STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string SERVICE_PROD_ID_LIST {get;set;}
public string CLIENT_ID_LIST {get;set;}
public string BUSINESS_ID_LIST {get;set;}
public string WORK_AREA_ID_LIST {get;set;}
public string STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}
public List<Int32?> CLIENT_ID_LIST {get;set;}
public List<Int32?> BUSINESS_ID_LIST {get;set;}
public List<Int32?> WORK_AREA_ID_LIST {get;set;}
public List<Int32?> STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string SERVICE_PROD_ID_LIST {get;set;}
public string CLIENT_ID_LIST {get;set;}
public string BUSINESS_ID_LIST {get;set;}
public string WORK_AREA_ID_LIST {get;set;}
public string STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}
public List<Int32?> CLIENT_ID_LIST {get;set;}
public List<Int32?> BUSINESS_ID_LIST {get;set;}
public List<Int32?> WORK_AREA_ID_LIST {get;set;}
public List<Int32?> STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public string SERVICE_PROD_ID_LIST {get;set;}
public string CLIENT_ID_LIST {get;set;}
public string BUSINESS_ID_LIST {get;set;}
public string WORK_AREA_ID_LIST {get;set;}
public string STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}
public List<Int32?> CLIENT_ID_LIST {get;set;}
public List<Int32?> BUSINESS_ID_LIST {get;set;}
public List<Int32?> WORK_AREA_ID_LIST {get;set;}
public List<Int32?> STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Booking_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string DATE {get;set;}
public string DESCRIPTION {get;set;}
public string SERVICE_PROD_ID_LIST {get;set;}
public string CLIENT_ID_LIST {get;set;}
public string BUSINESS_ID_LIST {get;set;}
public string WORK_AREA_ID_LIST {get;set;}
public string STATUS_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Work_list_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BUSINESS_ID_LIST {get;set;}
public List<Int32?> WORK_AREA_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Work_list_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string BUSINESS_ID_LIST {get;set;}
public string WORK_AREA_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Work_list_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> BUSINESS_ID_LIST {get;set;}
public List<Int32?> WORK_AREA_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Work_list_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string BUSINESS_ID_LIST {get;set;}
public string WORK_AREA_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}
public List<Int32?> BOOST_PRICING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string SERVICE_PROD_ID_LIST {get;set;}
public string BOOST_PRICING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}
public List<Int32?> BOOST_PRICING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public string SERVICE_PROD_ID_LIST {get;set;}
public string BOOST_PRICING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string START_DATE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}
public List<Int32?> BOOST_PRICING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string START_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string SERVICE_PROD_ID_LIST {get;set;}
public string BOOST_PRICING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string START_DATE {get;set;}
public string DESCRIPTION {get;set;}
public List<Int32?> SERVICE_PROD_ID_LIST {get;set;}
public List<Int32?> BOOST_PRICING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Boost_listing_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string START_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string SERVICE_PROD_ID_LIST {get;set;}
public string BOOST_PRICING_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
#region Params_Delete_Boost_pricing
public partial class Params_Delete_Boost_pricing
{
#region Properties
public Int32? BOOST_PRICING_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Client
public partial class Params_Delete_Client
{
#region Properties
public Int32? CLIENT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Service_prod
public partial class Params_Delete_Service_prod
{
#region Properties
public Int32? SERVICE_PROD_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Admin
public partial class Params_Delete_Admin
{
#region Properties
public Int32? ADMIN_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Category
public partial class Params_Delete_Category
{
#region Properties
public Int32? CATEGORY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Sub_category
public partial class Params_Delete_Sub_category
{
#region Properties
public Int32? SUB_CATEGORY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Coordinates
public partial class Params_Delete_Coordinates
{
#region Properties
public Int32? COORDINATES_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Currency
public partial class Params_Delete_Currency
{
#region Properties
public Int32? CURRENCY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Status
public partial class Params_Delete_Status
{
#region Properties
public Int32? STATUS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Owner
public partial class Params_Delete_Owner
{
#region Properties
public Int32? OWNER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Feedback
public partial class Params_Delete_Feedback
{
#region Properties
public Int32? FEEDBACK_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Booking
public partial class Params_Delete_Booking
{
#region Properties
public Int32? BOOKING_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Business
public partial class Params_Delete_Business
{
#region Properties
public Int32? BUSINESS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Work_list
public partial class Params_Delete_Work_list
{
#region Properties
public Int32? WORK_LIST_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User
public partial class Params_Delete_User
{
#region Properties
public long? USER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Work_area
public partial class Params_Delete_Work_area
{
#region Properties
public Int32? WORK_AREA_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Boost_listing
public partial class Params_Delete_Boost_listing
{
#region Properties
public Int32? BOOST_LISTING_ID {get;set;}
#endregion
}
#endregion
public partial class Params_Delete_Boost_pricing_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Client_By_PHONE_NUMBER
{
public Int32? PHONE_NUMBER {get;set;}
}
public partial class Params_Delete_Client_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Client_By_USERNAME
{
public string USERNAME {get;set;}
}
public partial class Params_Delete_Service_prod_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Service_prod_By_BUSINESS_ID
{
public Int32? BUSINESS_ID {get;set;}
}
public partial class Params_Delete_Service_prod_By_SUB_CATEGORY_ID
{
public Int32? SUB_CATEGORY_ID {get;set;}
}
public partial class Params_Delete_Admin_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Admin_By_USERNAME
{
public string USERNAME {get;set;}
}
public partial class Params_Delete_Category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Sub_category_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Sub_category_By_CATEGORY_ID
{
public Int32? CATEGORY_ID {get;set;}
}
public partial class Params_Delete_Coordinates_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Coordinates_By_BOOKING_ID
{
public Int32? BOOKING_ID {get;set;}
}
public partial class Params_Delete_Currency_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Status_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Feedback_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Feedback_By_BOOKING_ID
{
public Int32? BOOKING_ID {get;set;}
}
public partial class Params_Delete_Booking_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Booking_By_SERVICE_PROD_ID
{
public Int32? SERVICE_PROD_ID {get;set;}
}
public partial class Params_Delete_Booking_By_CLIENT_ID
{
public Int32? CLIENT_ID {get;set;}
}
public partial class Params_Delete_Booking_By_WORK_AREA_ID
{
public Int32? WORK_AREA_ID {get;set;}
}
public partial class Params_Delete_Booking_By_STATUS_ID
{
public Int32? STATUS_ID {get;set;}
}
public partial class Params_Delete_Booking_By_BUSINESS_ID
{
public Int32? BUSINESS_ID {get;set;}
}
public partial class Params_Delete_Business_By_USERNAME
{
public string USERNAME {get;set;}
}
public partial class Params_Delete_Business_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Work_list_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Work_list_By_BUSINESS_ID
{
public Int32? BUSINESS_ID {get;set;}
}
public partial class Params_Delete_Work_list_By_WORK_AREA_ID
{
public Int32? WORK_AREA_ID {get;set;}
}
public partial class Params_Delete_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_User_By_USERNAME
{
public string USERNAME {get;set;}
}
public partial class Params_Delete_Work_area_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Boost_listing_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Boost_listing_By_SERVICE_PROD_ID
{
public Int32? SERVICE_PROD_ID {get;set;}
}
public partial class Params_Delete_Boost_listing_By_BOOST_PRICING_ID
{
public Int32? BOOST_PRICING_ID {get;set;}
}
public partial class Boost_pricing
{
public Int32? BOOST_PRICING_ID {get;set;}
public string NAME {get;set;}
public Int32? MINUTE {get;set;}
public decimal? PRICE_PER_MINUTE {get;set;}
public decimal? TOTAL_PRICE {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Client
{
public Int32? CLIENT_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public Int32? PHONE_NUMBER {get;set;}
public string EMAIL {get;set;}
public bool? IS_ACTIVE {get;set;}
public bool? IS_VERIFIED {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Service_prod
{
public Int32? SERVICE_PROD_ID {get;set;}
public Int32? BUSINESS_ID {get;set;}
public Int32? SUB_CATEGORY_ID {get;set;}
public string NAME {get;set;}
public decimal PRICE {get;set;}
public decimal PROFIT_PERCENTAGE {get;set;}
public bool? IS_BOOSTED {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Admin
{
public Int32? ADMIN_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public bool? IS_ACTIVE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Category
{
public Int32? CATEGORY_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Sub_category
{
public Int32? SUB_CATEGORY_ID {get;set;}
public Int32? CATEGORY_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Coordinates
{
public Int32? COORDINATES_ID {get;set;}
public Int32? BOOKING_ID {get;set;}
public string LONGITUDE {get;set;}
public string LATITUDE {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Currency
{
public Int32? CURRENCY_ID {get;set;}
public string NAME {get;set;}
public string SYMBOL {get;set;}
public string ACRONYM {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Status
{
public Int32? STATUS_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Feedback
{
public Int32? FEEDBACK_ID {get;set;}
public Int32? BOOKING_ID {get;set;}
public string COMMENT {get;set;}
public Int32? RATING {get;set;}
public string DATE {get;set;}
public string TIME {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Booking
{
public Int32? BOOKING_ID {get;set;}
public Int32? SERVICE_PROD_ID {get;set;}
public Int32? CLIENT_ID {get;set;}
public Int32? BUSINESS_ID {get;set;}
public Int32? WORK_AREA_ID {get;set;}
public string DATE {get;set;}
public decimal TOTAL_PRICE {get;set;}
public Int32? STATUS_ID {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Business
{
public Int32? BUSINESS_ID {get;set;}
public string NAME {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string EMAIL {get;set;}
public Int32? PHONE_NUMBER {get;set;}
public Int32? INTERVENTION_TIME {get;set;}
public decimal MINIMUM_COST {get;set;}
public bool? IS_VALIDATED {get;set;}
public bool? IS_CHECKMARK {get;set;}
public bool? IS_ACTIVE {get;set;}
public bool? IS_BOOSTED {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Work_list
{
public Int32? WORK_LIST_ID {get;set;}
public Int32? BUSINESS_ID {get;set;}
public Int32? WORK_AREA_ID {get;set;}
public bool? IS_TRUE {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class User
{
public long? USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Work_area
{
public Int32? WORK_AREA_ID {get;set;}
public string NAME {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Boost_listing
{
public Int32? BOOST_LISTING_ID {get;set;}
public Int32? SERVICE_PROD_ID {get;set;}
public Int32? BOOST_PRICING_ID {get;set;}
public string START_DATE {get;set;}
public string START_TIME {get;set;}
public bool? IS_ACTIVE {get;set;}
public bool? IS_PAID {get;set;}
public bool? IS_COMPLETED {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
#region Params_Edit_Boost_pricing_List
public partial class Params_Edit_Boost_pricing_List
{
#region Properties
public List<Boost_pricing> My_List_To_Edit { get; set; }
public List<Boost_pricing> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Client_List
public partial class Params_Edit_Client_List
{
#region Properties
public List<Client> My_List_To_Edit { get; set; }
public List<Client> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Service_prod_List
public partial class Params_Edit_Service_prod_List
{
#region Properties
public List<Service_prod> My_List_To_Edit { get; set; }
public List<Service_prod> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Admin_List
public partial class Params_Edit_Admin_List
{
#region Properties
public List<Admin> My_List_To_Edit { get; set; }
public List<Admin> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Category_List
public partial class Params_Edit_Category_List
{
#region Properties
public List<Category> My_List_To_Edit { get; set; }
public List<Category> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Sub_category_List
public partial class Params_Edit_Sub_category_List
{
#region Properties
public List<Sub_category> My_List_To_Edit { get; set; }
public List<Sub_category> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Coordinates_List
public partial class Params_Edit_Coordinates_List
{
#region Properties
public List<Coordinates> My_List_To_Edit { get; set; }
public List<Coordinates> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Currency_List
public partial class Params_Edit_Currency_List
{
#region Properties
public List<Currency> My_List_To_Edit { get; set; }
public List<Currency> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Status_List
public partial class Params_Edit_Status_List
{
#region Properties
public List<Status> My_List_To_Edit { get; set; }
public List<Status> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Owner_List
public partial class Params_Edit_Owner_List
{
#region Properties
public List<Owner> My_List_To_Edit { get; set; }
public List<Owner> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Feedback_List
public partial class Params_Edit_Feedback_List
{
#region Properties
public List<Feedback> My_List_To_Edit { get; set; }
public List<Feedback> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Booking_List
public partial class Params_Edit_Booking_List
{
#region Properties
public List<Booking> My_List_To_Edit { get; set; }
public List<Booking> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Business_List
public partial class Params_Edit_Business_List
{
#region Properties
public List<Business> My_List_To_Edit { get; set; }
public List<Business> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Work_list_List
public partial class Params_Edit_Work_list_List
{
#region Properties
public List<Work_list> My_List_To_Edit { get; set; }
public List<Work_list> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_List
public partial class Params_Edit_User_List
{
#region Properties
public List<User> My_List_To_Edit { get; set; }
public List<User> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Work_area_List
public partial class Params_Edit_Work_area_List
{
#region Properties
public List<Work_area> My_List_To_Edit { get; set; }
public List<Work_area> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Boost_listing_List
public partial class Params_Edit_Boost_listing_List
{
#region Properties
public List<Boost_listing> My_List_To_Edit { get; set; }
public List<Boost_listing> My_List_To_Delete { get; set; }
#endregion
}
#endregion
}
