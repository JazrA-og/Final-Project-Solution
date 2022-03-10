using System;
using System.Collections.Generic;
namespace DALC
{
#region Entities
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
public Business My_Business {get;set;}
public Sub_category My_Sub_category {get;set;}
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
public Category My_Category {get;set;}
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
public Booking My_Booking {get;set;}
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
public Booking My_Booking {get;set;}
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
public Service_prod My_Service_prod {get;set;}
public Client My_Client {get;set;}
public Business My_Business {get;set;}
public Work_area My_Work_area {get;set;}
public Status My_Status {get;set;}
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
public Business My_Business {get;set;}
public Work_area My_Work_area {get;set;}
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
public Service_prod My_Service_prod {get;set;}
public Boost_pricing My_Boost_pricing {get;set;}
}
#endregion 
public partial interface IDALC
{
Boost_pricing Get_Boost_pricing_By_BOOST_PRICING_ID ( Int32? BOOST_PRICING_ID);
Client Get_Client_By_CLIENT_ID ( Int32? CLIENT_ID);
Service_prod Get_Service_prod_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID);
Admin Get_Admin_By_ADMIN_ID ( Int32? ADMIN_ID);
Category Get_Category_By_CATEGORY_ID ( Int32? CATEGORY_ID);
Sub_category Get_Sub_category_By_SUB_CATEGORY_ID ( Int32? SUB_CATEGORY_ID);
Coordinates Get_Coordinates_By_COORDINATES_ID ( Int32? COORDINATES_ID);
Currency Get_Currency_By_CURRENCY_ID ( Int32? CURRENCY_ID);
Status Get_Status_By_STATUS_ID ( Int32? STATUS_ID);
Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID);
Feedback Get_Feedback_By_FEEDBACK_ID ( Int32? FEEDBACK_ID);
Booking Get_Booking_By_BOOKING_ID ( Int32? BOOKING_ID);
Business Get_Business_By_BUSINESS_ID ( Int32? BUSINESS_ID);
Work_list Get_Work_list_By_WORK_LIST_ID ( Int32? WORK_LIST_ID);
User Get_User_By_USER_ID ( long? USER_ID);
Work_area Get_Work_area_By_WORK_AREA_ID ( Int32? WORK_AREA_ID);
Boost_listing Get_Boost_listing_By_BOOST_LISTING_ID ( Int32? BOOST_LISTING_ID);
Boost_pricing Get_Boost_pricing_By_BOOST_PRICING_ID_Adv ( Int32? BOOST_PRICING_ID);
Client Get_Client_By_CLIENT_ID_Adv ( Int32? CLIENT_ID);
Service_prod Get_Service_prod_By_SERVICE_PROD_ID_Adv ( Int32? SERVICE_PROD_ID);
Admin Get_Admin_By_ADMIN_ID_Adv ( Int32? ADMIN_ID);
Category Get_Category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID);
Sub_category Get_Sub_category_By_SUB_CATEGORY_ID_Adv ( Int32? SUB_CATEGORY_ID);
Coordinates Get_Coordinates_By_COORDINATES_ID_Adv ( Int32? COORDINATES_ID);
Currency Get_Currency_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
Status Get_Status_By_STATUS_ID_Adv ( Int32? STATUS_ID);
Feedback Get_Feedback_By_FEEDBACK_ID_Adv ( Int32? FEEDBACK_ID);
Booking Get_Booking_By_BOOKING_ID_Adv ( Int32? BOOKING_ID);
Business Get_Business_By_BUSINESS_ID_Adv ( Int32? BUSINESS_ID);
Work_list Get_Work_list_By_WORK_LIST_ID_Adv ( Int32? WORK_LIST_ID);
User Get_User_By_USER_ID_Adv ( long? USER_ID);
Work_area Get_Work_area_By_WORK_AREA_ID_Adv ( Int32? WORK_AREA_ID);
Boost_listing Get_Boost_listing_By_BOOST_LISTING_ID_Adv ( Int32? BOOST_LISTING_ID);
List<Boost_pricing> Get_Boost_pricing_By_BOOST_PRICING_ID_List ( List<Int32?> BOOST_PRICING_ID_LIST);
List<Client> Get_Client_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST);
List<Service_prod> Get_Service_prod_By_SERVICE_PROD_ID_List ( List<Int32?> SERVICE_PROD_ID_LIST);
List<Admin> Get_Admin_By_ADMIN_ID_List ( List<Int32?> ADMIN_ID_LIST);
List<Category> Get_Category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST);
List<Sub_category> Get_Sub_category_By_SUB_CATEGORY_ID_List ( List<Int32?> SUB_CATEGORY_ID_LIST);
List<Coordinates> Get_Coordinates_By_COORDINATES_ID_List ( List<Int32?> COORDINATES_ID_LIST);
List<Currency> Get_Currency_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Status> Get_Status_By_STATUS_ID_List ( List<Int32?> STATUS_ID_LIST);
List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST);
List<Feedback> Get_Feedback_By_FEEDBACK_ID_List ( List<Int32?> FEEDBACK_ID_LIST);
List<Booking> Get_Booking_By_BOOKING_ID_List ( List<Int32?> BOOKING_ID_LIST);
List<Business> Get_Business_By_BUSINESS_ID_List ( List<Int32?> BUSINESS_ID_LIST);
List<Work_list> Get_Work_list_By_WORK_LIST_ID_List ( List<Int32?> WORK_LIST_ID_LIST);
List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Work_area> Get_Work_area_By_WORK_AREA_ID_List ( List<Int32?> WORK_AREA_ID_LIST);
List<Boost_listing> Get_Boost_listing_By_BOOST_LISTING_ID_List ( List<Int32?> BOOST_LISTING_ID_LIST);
List<Boost_pricing> Get_Boost_pricing_By_BOOST_PRICING_ID_List_Adv ( List<Int32?> BOOST_PRICING_ID_LIST);
List<Client> Get_Client_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST);
List<Service_prod> Get_Service_prod_By_SERVICE_PROD_ID_List_Adv ( List<Int32?> SERVICE_PROD_ID_LIST);
List<Admin> Get_Admin_By_ADMIN_ID_List_Adv ( List<Int32?> ADMIN_ID_LIST);
List<Category> Get_Category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST);
List<Sub_category> Get_Sub_category_By_SUB_CATEGORY_ID_List_Adv ( List<Int32?> SUB_CATEGORY_ID_LIST);
List<Coordinates> Get_Coordinates_By_COORDINATES_ID_List_Adv ( List<Int32?> COORDINATES_ID_LIST);
List<Currency> Get_Currency_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Status> Get_Status_By_STATUS_ID_List_Adv ( List<Int32?> STATUS_ID_LIST);
List<Feedback> Get_Feedback_By_FEEDBACK_ID_List_Adv ( List<Int32?> FEEDBACK_ID_LIST);
List<Booking> Get_Booking_By_BOOKING_ID_List_Adv ( List<Int32?> BOOKING_ID_LIST);
List<Business> Get_Business_By_BUSINESS_ID_List_Adv ( List<Int32?> BUSINESS_ID_LIST);
List<Work_list> Get_Work_list_By_WORK_LIST_ID_List_Adv ( List<Int32?> WORK_LIST_ID_LIST);
List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Work_area> Get_Work_area_By_WORK_AREA_ID_List_Adv ( List<Int32?> WORK_AREA_ID_LIST);
List<Boost_listing> Get_Boost_listing_By_BOOST_LISTING_ID_List_Adv ( List<Int32?> BOOST_LISTING_ID_LIST);
List<Boost_pricing> Get_Boost_pricing_By_OWNER_ID ( Int32? OWNER_ID);
List<Client> Get_Client_By_PHONE_NUMBER ( Int32? PHONE_NUMBER);
List<Client> Get_Client_By_OWNER_ID ( Int32? OWNER_ID);
List<Client> Get_Client_By_USERNAME ( string USERNAME);
List<Service_prod> Get_Service_prod_By_OWNER_ID ( Int32? OWNER_ID);
List<Service_prod> Get_Service_prod_By_BUSINESS_ID ( Int32? BUSINESS_ID);
List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID ( Int32? SUB_CATEGORY_ID);
List<Admin> Get_Admin_By_OWNER_ID ( Int32? OWNER_ID);
List<Admin> Get_Admin_By_USERNAME ( string USERNAME);
List<Category> Get_Category_By_OWNER_ID ( Int32? OWNER_ID);
List<Sub_category> Get_Sub_category_By_OWNER_ID ( Int32? OWNER_ID);
List<Sub_category> Get_Sub_category_By_CATEGORY_ID ( Int32? CATEGORY_ID);
List<Coordinates> Get_Coordinates_By_OWNER_ID ( Int32? OWNER_ID);
List<Coordinates> Get_Coordinates_By_BOOKING_ID ( Int32? BOOKING_ID);
List<Currency> Get_Currency_By_OWNER_ID ( Int32? OWNER_ID);
List<Status> Get_Status_By_OWNER_ID ( Int32? OWNER_ID);
List<Feedback> Get_Feedback_By_OWNER_ID ( Int32? OWNER_ID);
List<Feedback> Get_Feedback_By_BOOKING_ID ( Int32? BOOKING_ID);
List<Booking> Get_Booking_By_OWNER_ID ( Int32? OWNER_ID);
List<Booking> Get_Booking_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID);
List<Booking> Get_Booking_By_CLIENT_ID ( Int32? CLIENT_ID);
List<Booking> Get_Booking_By_WORK_AREA_ID ( Int32? WORK_AREA_ID);
List<Booking> Get_Booking_By_STATUS_ID ( Int32? STATUS_ID);
List<Booking> Get_Booking_By_BUSINESS_ID ( Int32? BUSINESS_ID);
List<Business> Get_Business_By_USERNAME ( string USERNAME);
List<Business> Get_Business_By_OWNER_ID ( Int32? OWNER_ID);
List<Work_list> Get_Work_list_By_OWNER_ID ( Int32? OWNER_ID);
List<Work_list> Get_Work_list_By_BUSINESS_ID ( Int32? BUSINESS_ID);
List<Work_list> Get_Work_list_By_WORK_AREA_ID ( Int32? WORK_AREA_ID);
List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME ( string USERNAME);
List<Work_area> Get_Work_area_By_OWNER_ID ( Int32? OWNER_ID);
List<Boost_listing> Get_Boost_listing_By_OWNER_ID ( Int32? OWNER_ID);
List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID);
List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID ( Int32? BOOST_PRICING_ID);
List<Boost_pricing> Get_Boost_pricing_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Client> Get_Client_By_PHONE_NUMBER_Adv ( Int32? PHONE_NUMBER);
List<Client> Get_Client_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Client> Get_Client_By_USERNAME_Adv ( string USERNAME);
List<Service_prod> Get_Service_prod_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Service_prod> Get_Service_prod_By_BUSINESS_ID_Adv ( Int32? BUSINESS_ID);
List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID_Adv ( Int32? SUB_CATEGORY_ID);
List<Admin> Get_Admin_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Admin> Get_Admin_By_USERNAME_Adv ( string USERNAME);
List<Category> Get_Category_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Sub_category> Get_Sub_category_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Sub_category> Get_Sub_category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID);
List<Coordinates> Get_Coordinates_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Coordinates> Get_Coordinates_By_BOOKING_ID_Adv ( Int32? BOOKING_ID);
List<Currency> Get_Currency_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Status> Get_Status_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Feedback> Get_Feedback_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Feedback> Get_Feedback_By_BOOKING_ID_Adv ( Int32? BOOKING_ID);
List<Booking> Get_Booking_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Booking> Get_Booking_By_SERVICE_PROD_ID_Adv ( Int32? SERVICE_PROD_ID);
List<Booking> Get_Booking_By_CLIENT_ID_Adv ( Int32? CLIENT_ID);
List<Booking> Get_Booking_By_WORK_AREA_ID_Adv ( Int32? WORK_AREA_ID);
List<Booking> Get_Booking_By_STATUS_ID_Adv ( Int32? STATUS_ID);
List<Booking> Get_Booking_By_BUSINESS_ID_Adv ( Int32? BUSINESS_ID);
List<Business> Get_Business_By_USERNAME_Adv ( string USERNAME);
List<Business> Get_Business_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Work_list> Get_Work_list_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Work_list> Get_Work_list_By_BUSINESS_ID_Adv ( Int32? BUSINESS_ID);
List<Work_list> Get_Work_list_By_WORK_AREA_ID_Adv ( Int32? WORK_AREA_ID);
List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME_Adv ( string USERNAME);
List<Work_area> Get_Work_area_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Boost_listing> Get_Boost_listing_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID_Adv ( Int32? SERVICE_PROD_ID);
List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID_Adv ( Int32? BOOST_PRICING_ID);
List<Client> Get_Client_By_PHONE_NUMBER_List ( List<Int32?> PHONE_NUMBER_LIST);
List<Service_prod> Get_Service_prod_By_BUSINESS_ID_List ( List<Int32?> BUSINESS_ID_LIST);
List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID_List ( List<Int32?> SUB_CATEGORY_ID_LIST);
List<Sub_category> Get_Sub_category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST);
List<Coordinates> Get_Coordinates_By_BOOKING_ID_List ( List<Int32?> BOOKING_ID_LIST);
List<Feedback> Get_Feedback_By_BOOKING_ID_List ( List<Int32?> BOOKING_ID_LIST);
List<Booking> Get_Booking_By_SERVICE_PROD_ID_List ( List<Int32?> SERVICE_PROD_ID_LIST);
List<Booking> Get_Booking_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST);
List<Booking> Get_Booking_By_WORK_AREA_ID_List ( List<Int32?> WORK_AREA_ID_LIST);
List<Booking> Get_Booking_By_STATUS_ID_List ( List<Int32?> STATUS_ID_LIST);
List<Booking> Get_Booking_By_BUSINESS_ID_List ( List<Int32?> BUSINESS_ID_LIST);
List<Work_list> Get_Work_list_By_BUSINESS_ID_List ( List<Int32?> BUSINESS_ID_LIST);
List<Work_list> Get_Work_list_By_WORK_AREA_ID_List ( List<Int32?> WORK_AREA_ID_LIST);
List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID_List ( List<Int32?> SERVICE_PROD_ID_LIST);
List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID_List ( List<Int32?> BOOST_PRICING_ID_LIST);
List<Client> Get_Client_By_PHONE_NUMBER_List_Adv ( List<Int32?> PHONE_NUMBER_LIST);
List<Service_prod> Get_Service_prod_By_BUSINESS_ID_List_Adv ( List<Int32?> BUSINESS_ID_LIST);
List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID_List_Adv ( List<Int32?> SUB_CATEGORY_ID_LIST);
List<Sub_category> Get_Sub_category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST);
List<Coordinates> Get_Coordinates_By_BOOKING_ID_List_Adv ( List<Int32?> BOOKING_ID_LIST);
List<Feedback> Get_Feedback_By_BOOKING_ID_List_Adv ( List<Int32?> BOOKING_ID_LIST);
List<Booking> Get_Booking_By_SERVICE_PROD_ID_List_Adv ( List<Int32?> SERVICE_PROD_ID_LIST);
List<Booking> Get_Booking_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST);
List<Booking> Get_Booking_By_WORK_AREA_ID_List_Adv ( List<Int32?> WORK_AREA_ID_LIST);
List<Booking> Get_Booking_By_STATUS_ID_List_Adv ( List<Int32?> STATUS_ID_LIST);
List<Booking> Get_Booking_By_BUSINESS_ID_List_Adv ( List<Int32?> BUSINESS_ID_LIST);
List<Work_list> Get_Work_list_By_BUSINESS_ID_List_Adv ( List<Int32?> BUSINESS_ID_LIST);
List<Work_list> Get_Work_list_By_WORK_AREA_ID_List_Adv ( List<Int32?> WORK_AREA_ID_LIST);
List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID_List_Adv ( List<Int32?> SERVICE_PROD_ID_LIST);
List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID_List_Adv ( List<Int32?> BOOST_PRICING_ID_LIST);
List<Boost_pricing> Get_Boost_pricing_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_pricing> Get_Boost_pricing_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Service_prod> Get_Service_prod_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Service_prod> Get_Service_prod_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Admin> Get_Admin_By_Criteria ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Admin> Get_Admin_By_Where ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Sub_category> Get_Sub_category_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Sub_category> Get_Sub_category_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coordinates> Get_Coordinates_By_Criteria ( string LONGITUDE, string LATITUDE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coordinates> Get_Coordinates_By_Where ( string LONGITUDE, string LATITUDE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Criteria ( string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Where ( string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Status> Get_Status_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Status> Get_Status_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Criteria ( string COMMENT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Where ( string COMMENT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Criteria_V2 ( string COMMENT, string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Where_V2 ( string COMMENT, string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Criteria_V2 ( string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Where_V2 ( string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Business> Get_Business_By_Criteria ( string NAME, string USERNAME, string PASSWORD, string EMAIL, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Business> Get_Business_By_Where ( string NAME, string USERNAME, string PASSWORD, string EMAIL, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_list> Get_Work_list_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_list> Get_Work_list_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_area> Get_Work_area_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_area> Get_Work_area_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Criteria_V2 ( string START_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Where_V2 ( string START_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_pricing> Get_Boost_pricing_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_pricing> Get_Boost_pricing_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Service_prod> Get_Service_prod_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Service_prod> Get_Service_prod_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Admin> Get_Admin_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Admin> Get_Admin_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Category> Get_Category_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Sub_category> Get_Sub_category_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Sub_category> Get_Sub_category_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coordinates> Get_Coordinates_By_Criteria_Adv ( string LONGITUDE, string LATITUDE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coordinates> Get_Coordinates_By_Where_Adv ( string LONGITUDE, string LATITUDE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Criteria_Adv ( string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Where_Adv ( string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Status> Get_Status_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Status> Get_Status_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Criteria_Adv ( string COMMENT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Where_Adv ( string COMMENT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Criteria_Adv_V2 ( string COMMENT, string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Where_Adv_V2 ( string COMMENT, string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Criteria_Adv_V2 ( string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Where_Adv_V2 ( string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Business> Get_Business_By_Criteria_Adv ( string NAME, string USERNAME, string PASSWORD, string EMAIL, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Business> Get_Business_By_Where_Adv ( string NAME, string USERNAME, string PASSWORD, string EMAIL, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_list> Get_Work_list_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_list> Get_Work_list_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_area> Get_Work_area_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_area> Get_Work_area_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Criteria_Adv_V2 ( string START_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Where_Adv_V2 ( string START_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Service_prod> Get_Service_prod_By_Criteria_InList ( string NAME, string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> SUB_CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Service_prod> Get_Service_prod_By_Where_InList ( string NAME, string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> SUB_CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Sub_category> Get_Sub_category_By_Criteria_InList ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Sub_category> Get_Sub_category_By_Where_InList ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coordinates> Get_Coordinates_By_Criteria_InList ( string LONGITUDE, string LATITUDE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coordinates> Get_Coordinates_By_Where_InList ( string LONGITUDE, string LATITUDE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Criteria_InList ( string COMMENT, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Where_InList ( string COMMENT, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Criteria_InList_V2 ( string COMMENT, string DATE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Where_InList_V2 ( string COMMENT, string DATE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Criteria_InList ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Where_InList ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Criteria_InList_V2 ( string DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Where_InList_V2 ( string DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_list> Get_Work_list_By_Criteria_InList ( string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_list> Get_Work_list_By_Where_InList ( string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Criteria_InList ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Where_InList ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Criteria_InList_V2 ( string START_DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Where_InList_V2 ( string START_DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Service_prod> Get_Service_prod_By_Criteria_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> SUB_CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Service_prod> Get_Service_prod_By_Where_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> SUB_CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Sub_category> Get_Sub_category_By_Criteria_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Sub_category> Get_Sub_category_By_Where_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coordinates> Get_Coordinates_By_Criteria_InList_Adv ( string LONGITUDE, string LATITUDE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Coordinates> Get_Coordinates_By_Where_InList_Adv ( string LONGITUDE, string LATITUDE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Criteria_InList_Adv ( string COMMENT, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Where_InList_Adv ( string COMMENT, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Criteria_InList_Adv_V2 ( string COMMENT, string DATE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Feedback> Get_Feedback_By_Where_InList_Adv_V2 ( string COMMENT, string DATE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Criteria_InList_Adv_V2 ( string DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Booking> Get_Booking_By_Where_InList_Adv_V2 ( string DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_list> Get_Work_list_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Work_list> Get_Work_list_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Criteria_InList_Adv_V2 ( string START_DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Boost_listing> Get_Boost_listing_By_Where_InList_Adv_V2 ( string START_DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
void Delete_Boost_pricing ( Int32? BOOST_PRICING_ID);
void Delete_Client ( Int32? CLIENT_ID);
void Delete_Service_prod ( Int32? SERVICE_PROD_ID);
void Delete_Admin ( Int32? ADMIN_ID);
void Delete_Category ( Int32? CATEGORY_ID);
void Delete_Sub_category ( Int32? SUB_CATEGORY_ID);
void Delete_Coordinates ( Int32? COORDINATES_ID);
void Delete_Currency ( Int32? CURRENCY_ID);
void Delete_Status ( Int32? STATUS_ID);
void Delete_Owner ( Int32? OWNER_ID);
void Delete_Feedback ( Int32? FEEDBACK_ID);
void Delete_Booking ( Int32? BOOKING_ID);
void Delete_Business ( Int32? BUSINESS_ID);
void Delete_Work_list ( Int32? WORK_LIST_ID);
void Delete_User ( long? USER_ID);
void Delete_Work_area ( Int32? WORK_AREA_ID);
void Delete_Boost_listing ( Int32? BOOST_LISTING_ID);
void Delete_Boost_pricing_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Client_By_PHONE_NUMBER ( Int32? PHONE_NUMBER);
void Delete_Client_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Client_By_USERNAME ( string USERNAME);
void Delete_Service_prod_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Service_prod_By_BUSINESS_ID ( Int32? BUSINESS_ID);
void Delete_Service_prod_By_SUB_CATEGORY_ID ( Int32? SUB_CATEGORY_ID);
void Delete_Admin_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Admin_By_USERNAME ( string USERNAME);
void Delete_Category_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Sub_category_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Sub_category_By_CATEGORY_ID ( Int32? CATEGORY_ID);
void Delete_Coordinates_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Coordinates_By_BOOKING_ID ( Int32? BOOKING_ID);
void Delete_Currency_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Status_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Feedback_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Feedback_By_BOOKING_ID ( Int32? BOOKING_ID);
void Delete_Booking_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Booking_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID);
void Delete_Booking_By_CLIENT_ID ( Int32? CLIENT_ID);
void Delete_Booking_By_WORK_AREA_ID ( Int32? WORK_AREA_ID);
void Delete_Booking_By_STATUS_ID ( Int32? STATUS_ID);
void Delete_Booking_By_BUSINESS_ID ( Int32? BUSINESS_ID);
void Delete_Business_By_USERNAME ( string USERNAME);
void Delete_Business_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Work_list_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Work_list_By_BUSINESS_ID ( Int32? BUSINESS_ID);
void Delete_Work_list_By_WORK_AREA_ID ( Int32? WORK_AREA_ID);
void Delete_User_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_By_USERNAME ( string USERNAME);
void Delete_Work_area_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Boost_listing_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Boost_listing_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID);
void Delete_Boost_listing_By_BOOST_PRICING_ID ( Int32? BOOST_PRICING_ID);
Int32? Edit_Boost_pricing ( Int32? BOOST_PRICING_ID, string NAME, Int32? MINUTE, decimal? PRICE_PER_MINUTE, decimal? TOTAL_PRICE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Client ( Int32? CLIENT_ID, string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, Int32? PHONE_NUMBER, string EMAIL, bool? IS_ACTIVE, bool? IS_VERIFIED, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Service_prod ( Int32? SERVICE_PROD_ID, Int32? BUSINESS_ID, Int32? SUB_CATEGORY_ID, string NAME, decimal PRICE, decimal PROFIT_PERCENTAGE, bool? IS_BOOSTED, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Admin ( Int32? ADMIN_ID, string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, bool? IS_ACTIVE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Category ( Int32? CATEGORY_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Sub_category ( Int32? SUB_CATEGORY_ID, Int32? CATEGORY_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Coordinates ( Int32? COORDINATES_ID, Int32? BOOKING_ID, string LONGITUDE, string LATITUDE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Currency ( Int32? CURRENCY_ID, string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Status ( Int32? STATUS_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE);
Int32? Edit_Feedback ( Int32? FEEDBACK_ID, Int32? BOOKING_ID, string COMMENT, Int32? RATING, string DATE, string TIME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Booking ( Int32? BOOKING_ID, Int32? SERVICE_PROD_ID, Int32? CLIENT_ID, Int32? BUSINESS_ID, Int32? WORK_AREA_ID, string DATE, decimal TOTAL_PRICE, Int32? STATUS_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Business ( Int32? BUSINESS_ID, string NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? PHONE_NUMBER, Int32? INTERVENTION_TIME, decimal MINIMUM_COST, bool? IS_VALIDATED, bool? IS_CHECKMARK, bool? IS_ACTIVE, bool? IS_BOOSTED, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Work_list ( Int32? WORK_LIST_ID, Int32? BUSINESS_ID, Int32? WORK_AREA_ID, bool? IS_TRUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE);
Int32? Edit_Work_area ( Int32? WORK_AREA_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Boost_listing ( Int32? BOOST_LISTING_ID, Int32? SERVICE_PROD_ID, Int32? BOOST_PRICING_ID, string START_DATE, string START_TIME, bool? IS_ACTIVE, bool? IS_PAID, bool? IS_COMPLETED, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID);
List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE);
List<dynamic> GET_TBL_SETUP ();
List<dynamic> UP_BULK_UPSERT_ADMIN ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_BOOKING ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_BOOST_LISTING ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_BOOST_PRICING ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_BUSINESS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CATEGORY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CLIENT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_COORDINATES ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CURRENCY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_FEEDBACK ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SERVICE_PROD ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_STATUS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SUB_CATEGORY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_WORK_AREA ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_WORK_LIST ( string JSON_CONTENT);
List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS);
List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES);
List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME);
List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME);
List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName);
List<dynamic> UP_GET_ADMIN_BY_ADMIN_ID ( Int32? ADMIN_ID);
List<dynamic> UP_GET_ADMIN_BY_EMAIL ( string EMAIL);
List<dynamic> UP_GET_ADMIN_BY_USERNAME ( string USERNAME);
List<dynamic> UP_GET_BOOST_LISTING_BY_BOOST_LISTING_ID ( Int32? BOOST_LISTING_ID);
List<dynamic> UP_GET_BUSINESS_BY_BUSINESS_ID ( Int32? BUSINESS_ID);
List<dynamic> UP_GET_BUSINESS_BY_EMAIL ( string EMAIL);
List<dynamic> UP_GET_BUSINESS_BY_OWNER_ID ( Int32? OWNER_ID);
List<dynamic> UP_GET_BUSINESS_ID_BY_USERNAME ( string USERNAME);
List<dynamic> UP_GET_CLIENT_BY_CLIENT_ID ( Int32? CLIENT_ID);
List<dynamic> UP_GET_CLIENT_BY_EMAIL ( string EMAIL);
List<dynamic> UP_GET_CLIENT_BY_USERNAME ( string USERNAME);
List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE);
List<dynamic> UP_GET_SERVICE_PROD_BY_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID);
List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE);
List<dynamic> UP_GET_SETUP_ENTRIES_PER_TABLE ( string NAME);
List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME);
List<dynamic> UP_GET_SUB_CATEGORY_BY_CATEGORY_ID ( Int32? CATEGORY_ID);
List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD);
List<dynamic> UP_GET_USER_BY_EMAIL ( string EMAIL);
List<dynamic> UP_GET_USER_BY_USERNAME ( string USERNAME);
List<dynamic> UP_GET_WORK_AREA_BY_OWNER_ID ( Int32? OWNER_ID);
List<dynamic> UP_GET_WORK_LIST_BY_BUSINESS_ID ( Int32? BUSINESS_ID);
}
}
