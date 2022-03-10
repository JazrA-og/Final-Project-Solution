using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
namespace DALC
{
public partial class MSSQL_DALC : IDALC
{
public Boost_pricing Get_Boost_pricing_By_BOOST_PRICING_ID ( Int32? BOOST_PRICING_ID)
{
Boost_pricing o = new Boost_pricing();
dynamic p = new ExpandoObject();
p.BOOST_PRICING_ID = BOOST_PRICING_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_BOOST_PRICING_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Client Get_Client_By_CLIENT_ID ( Int32? CLIENT_ID)
{
Client o = new Client();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CLIENT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Service_prod Get_Service_prod_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID)
{
Service_prod o = new Service_prod();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID = SERVICE_PROD_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_SERVICE_PROD_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Admin Get_Admin_By_ADMIN_ID ( Int32? ADMIN_ID)
{
Admin o = new Admin();
dynamic p = new ExpandoObject();
p.ADMIN_ID = ADMIN_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADMIN_BY_ADMIN_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Category Get_Category_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
Category o = new Category();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Sub_category Get_Sub_category_By_SUB_CATEGORY_ID ( Int32? SUB_CATEGORY_ID)
{
Sub_category o = new Sub_category();
dynamic p = new ExpandoObject();
p.SUB_CATEGORY_ID = SUB_CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_SUB_CATEGORY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Coordinates Get_Coordinates_By_COORDINATES_ID ( Int32? COORDINATES_ID)
{
Coordinates o = new Coordinates();
dynamic p = new ExpandoObject();
p.COORDINATES_ID = COORDINATES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_COORDINATES_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Currency Get_Currency_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
Currency o = new Currency();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Status Get_Status_By_STATUS_ID ( Int32? STATUS_ID)
{
Status o = new Status();
dynamic p = new ExpandoObject();
p.STATUS_ID = STATUS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STATUS_BY_STATUS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID)
{
Owner o = new Owner();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Feedback Get_Feedback_By_FEEDBACK_ID ( Int32? FEEDBACK_ID)
{
Feedback o = new Feedback();
dynamic p = new ExpandoObject();
p.FEEDBACK_ID = FEEDBACK_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_FEEDBACK_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Booking Get_Booking_By_BOOKING_ID ( Int32? BOOKING_ID)
{
Booking o = new Booking();
dynamic p = new ExpandoObject();
p.BOOKING_ID = BOOKING_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BOOKING_BY_BOOKING_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Business Get_Business_By_BUSINESS_ID ( Int32? BUSINESS_ID)
{
Business o = new Business();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_BUSINESS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Work_list Get_Work_list_By_WORK_LIST_ID ( Int32? WORK_LIST_ID)
{
Work_list o = new Work_list();
dynamic p = new ExpandoObject();
p.WORK_LIST_ID = WORK_LIST_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WORK_LIST_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Work_area Get_Work_area_By_WORK_AREA_ID ( Int32? WORK_AREA_ID)
{
Work_area o = new Work_area();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID = WORK_AREA_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_WORK_AREA_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Boost_listing Get_Boost_listing_By_BOOST_LISTING_ID ( Int32? BOOST_LISTING_ID)
{
Boost_listing o = new Boost_listing();
dynamic p = new ExpandoObject();
p.BOOST_LISTING_ID = BOOST_LISTING_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_BOOST_LISTING_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Boost_pricing Get_Boost_pricing_By_BOOST_PRICING_ID_Adv ( Int32? BOOST_PRICING_ID)
{
Boost_pricing o = new Boost_pricing();
dynamic p = new ExpandoObject();
p.BOOST_PRICING_ID = BOOST_PRICING_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_BOOST_PRICING_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Client Get_Client_By_CLIENT_ID_Adv ( Int32? CLIENT_ID)
{
Client o = new Client();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CLIENT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Service_prod Get_Service_prod_By_SERVICE_PROD_ID_Adv ( Int32? SERVICE_PROD_ID)
{
Service_prod o = new Service_prod();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID = SERVICE_PROD_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_SERVICE_PROD_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(R["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(R["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(R["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(R["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(R["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(R["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(R["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(R["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(R["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(R["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(R["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(R["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(R["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(R["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(R["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(R["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(R["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(R["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(R["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(R["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(R["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(R["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(R["T_SUB_CATEGORY_OWNER_ID"]);
}
return o;
}
public Admin Get_Admin_By_ADMIN_ID_Adv ( Int32? ADMIN_ID)
{
Admin o = new Admin();
dynamic p = new ExpandoObject();
p.ADMIN_ID = ADMIN_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADMIN_BY_ADMIN_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Category Get_Category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID)
{
Category o = new Category();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Sub_category Get_Sub_category_By_SUB_CATEGORY_ID_Adv ( Int32? SUB_CATEGORY_ID)
{
Sub_category o = new Sub_category();
dynamic p = new ExpandoObject();
p.SUB_CATEGORY_ID = SUB_CATEGORY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_SUB_CATEGORY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(R["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(R["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(R["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(R["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(R["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(R["T_CATEGORY_OWNER_ID"]);
}
return o;
}
public Coordinates Get_Coordinates_By_COORDINATES_ID_Adv ( Int32? COORDINATES_ID)
{
Coordinates o = new Coordinates();
dynamic p = new ExpandoObject();
p.COORDINATES_ID = COORDINATES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_COORDINATES_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(R["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(R["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(R["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(R["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(R["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(R["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(R["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(R["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(R["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(R["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(R["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(R["T_BOOKING_OWNER_ID"]);
}
return o;
}
public Currency Get_Currency_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
Currency o = new Currency();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Status Get_Status_By_STATUS_ID_Adv ( Int32? STATUS_ID)
{
Status o = new Status();
dynamic p = new ExpandoObject();
p.STATUS_ID = STATUS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STATUS_BY_STATUS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Feedback Get_Feedback_By_FEEDBACK_ID_Adv ( Int32? FEEDBACK_ID)
{
Feedback o = new Feedback();
dynamic p = new ExpandoObject();
p.FEEDBACK_ID = FEEDBACK_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_FEEDBACK_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(R["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(R["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(R["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(R["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(R["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(R["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(R["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(R["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(R["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(R["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(R["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(R["T_BOOKING_OWNER_ID"]);
}
return o;
}
public Booking Get_Booking_By_BOOKING_ID_Adv ( Int32? BOOKING_ID)
{
Booking o = new Booking();
dynamic p = new ExpandoObject();
p.BOOKING_ID = BOOKING_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BOOKING_BY_BOOKING_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(R["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(R["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(R["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(R["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(R["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(R["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(R["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(R["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(R["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(R["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(R["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(R["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(R["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(R["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(R["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(R["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(R["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(R["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(R["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(R["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(R["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(R["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(R["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(R["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(R["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(R["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(R["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(R["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(R["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(R["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(R["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(R["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(R["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(R["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(R["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(R["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(R["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(R["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(R["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(R["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(R["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(R["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(R["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(R["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(R["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(R["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(R["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(R["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(R["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(R["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(R["T_STATUS_OWNER_ID"]);
}
return o;
}
public Business Get_Business_By_BUSINESS_ID_Adv ( Int32? BUSINESS_ID)
{
Business o = new Business();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_BUSINESS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Work_list Get_Work_list_By_WORK_LIST_ID_Adv ( Int32? WORK_LIST_ID)
{
Work_list o = new Work_list();
dynamic p = new ExpandoObject();
p.WORK_LIST_ID = WORK_LIST_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WORK_LIST_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(R["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(R["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(R["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(R["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(R["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(R["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(R["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(R["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(R["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(R["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(R["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(R["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(R["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(R["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(R["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(R["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(R["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(R["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(R["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(R["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(R["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(R["T_WORK_AREA_OWNER_ID"]);
}
return o;
}
public User Get_User_By_USER_ID_Adv ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Work_area Get_Work_area_By_WORK_AREA_ID_Adv ( Int32? WORK_AREA_ID)
{
Work_area o = new Work_area();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID = WORK_AREA_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_WORK_AREA_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Boost_listing Get_Boost_listing_By_BOOST_LISTING_ID_Adv ( Int32? BOOST_LISTING_ID)
{
Boost_listing o = new Boost_listing();
dynamic p = new ExpandoObject();
p.BOOST_LISTING_ID = BOOST_LISTING_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_BOOST_LISTING_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(R["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(R["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(R["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(R["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(R["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(R["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(R["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(R["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(R["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(R["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(R["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(R["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(R["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(R["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(R["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(R["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(R["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(R["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(R["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(R["T_BOOST_PRICING_OWNER_ID"]);
}
return o;
}
public List<Boost_pricing> Get_Boost_pricing_By_BOOST_PRICING_ID_List ( List<Int32?> BOOST_PRICING_ID_LIST)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
dynamic p = new ExpandoObject();
p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_BOOST_PRICING_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Boost_pricing o = new Boost_pricing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CLIENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SERVICE_PROD_ID_List ( List<Int32?> SERVICE_PROD_ID_LIST)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_SERVICE_PROD_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Admin> Get_Admin_By_ADMIN_ID_List ( List<Int32?> ADMIN_ID_LIST)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.ADMIN_ID_LIST = string.Join(",", ADMIN_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_ADMIN_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Sub_category> Get_Sub_category_By_SUB_CATEGORY_ID_List ( List<Int32?> SUB_CATEGORY_ID_LIST)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.SUB_CATEGORY_ID_LIST = string.Join(",", SUB_CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_SUB_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Coordinates> Get_Coordinates_By_COORDINATES_ID_List ( List<Int32?> COORDINATES_ID_LIST)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.COORDINATES_ID_LIST = string.Join(",", COORDINATES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_COORDINATES_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Status> Get_Status_By_STATUS_ID_List ( List<Int32?> STATUS_ID_LIST)
{
List<Status> oList = new List<Status>();
dynamic p = new ExpandoObject();
p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STATUS_BY_STATUS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Status o = new Status();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Feedback> Get_Feedback_By_FEEDBACK_ID_List ( List<Int32?> FEEDBACK_ID_LIST)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.FEEDBACK_ID_LIST = string.Join(",", FEEDBACK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_FEEDBACK_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_BOOKING_ID_List ( List<Int32?> BOOKING_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_BOOKING_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Business> Get_Business_By_BUSINESS_ID_List ( List<Int32?> BUSINESS_ID_LIST)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_BUSINESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_LIST_ID_List ( List<Int32?> WORK_LIST_ID_LIST)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.WORK_LIST_ID_LIST = string.Join(",", WORK_LIST_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WORK_LIST_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_area> Get_Work_area_By_WORK_AREA_ID_List ( List<Int32?> WORK_AREA_ID_LIST)
{
List<Work_area> oList = new List<Work_area>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_WORK_AREA_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Work_area o = new Work_area();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_LISTING_ID_List ( List<Int32?> BOOST_LISTING_ID_LIST)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.BOOST_LISTING_ID_LIST = string.Join(",", BOOST_LISTING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_BOOST_LISTING_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_BOOST_PRICING_ID_List_Adv ( List<Int32?> BOOST_PRICING_ID_LIST)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
dynamic p = new ExpandoObject();
p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_BOOST_PRICING_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_pricing o = new Boost_pricing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CLIENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SERVICE_PROD_ID_List_Adv ( List<Int32?> SERVICE_PROD_ID_LIST)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_SERVICE_PROD_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Admin> Get_Admin_By_ADMIN_ID_List_Adv ( List<Int32?> ADMIN_ID_LIST)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.ADMIN_ID_LIST = string.Join(",", ADMIN_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_ADMIN_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Sub_category> Get_Sub_category_By_SUB_CATEGORY_ID_List_Adv ( List<Int32?> SUB_CATEGORY_ID_LIST)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.SUB_CATEGORY_ID_LIST = string.Join(",", SUB_CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_SUB_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Coordinates> Get_Coordinates_By_COORDINATES_ID_List_Adv ( List<Int32?> COORDINATES_ID_LIST)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.COORDINATES_ID_LIST = string.Join(",", COORDINATES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_COORDINATES_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Status> Get_Status_By_STATUS_ID_List_Adv ( List<Int32?> STATUS_ID_LIST)
{
List<Status> oList = new List<Status>();
dynamic p = new ExpandoObject();
p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STATUS_BY_STATUS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Status o = new Status();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Feedback> Get_Feedback_By_FEEDBACK_ID_List_Adv ( List<Int32?> FEEDBACK_ID_LIST)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.FEEDBACK_ID_LIST = string.Join(",", FEEDBACK_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_FEEDBACK_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_BOOKING_ID_List_Adv ( List<Int32?> BOOKING_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_BOOKING_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Business> Get_Business_By_BUSINESS_ID_List_Adv ( List<Int32?> BUSINESS_ID_LIST)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_BUSINESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_LIST_ID_List_Adv ( List<Int32?> WORK_LIST_ID_LIST)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.WORK_LIST_ID_LIST = string.Join(",", WORK_LIST_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WORK_LIST_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_area> Get_Work_area_By_WORK_AREA_ID_List_Adv ( List<Int32?> WORK_AREA_ID_LIST)
{
List<Work_area> oList = new List<Work_area>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_WORK_AREA_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Work_area o = new Work_area();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_LISTING_ID_List_Adv ( List<Int32?> BOOST_LISTING_ID_LIST)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.BOOST_LISTING_ID_LIST = string.Join(",", BOOST_LISTING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_BOOST_LISTING_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Boost_pricing o = new Boost_pricing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_PHONE_NUMBER ( Int32? PHONE_NUMBER)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.PHONE_NUMBER = PHONE_NUMBER;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_PHONE_NUMBER", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_USERNAME ( string USERNAME)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_BUSINESS_ID ( Int32? BUSINESS_ID)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_BUSINESS_ID", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID ( Int32? SUB_CATEGORY_ID)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.SUB_CATEGORY_ID = SUB_CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_SUB_CATEGORY_ID", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Admin> Get_Admin_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Admin> Get_Admin_By_USERNAME ( string USERNAME)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Sub_category> Get_Sub_category_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Sub_category> Get_Sub_category_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_CATEGORY_ID", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Coordinates> Get_Coordinates_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Coordinates> Get_Coordinates_By_BOOKING_ID ( Int32? BOOKING_ID)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.BOOKING_ID = BOOKING_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_BOOKING_ID", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Status> Get_Status_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Status> oList = new List<Status>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STATUS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Status o = new Status();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Feedback> Get_Feedback_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Feedback> Get_Feedback_By_BOOKING_ID ( Int32? BOOKING_ID)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.BOOKING_ID = BOOKING_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_BOOKING_ID", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID = SERVICE_PROD_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_SERVICE_PROD_ID", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_CLIENT_ID ( Int32? CLIENT_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CLIENT_ID", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_WORK_AREA_ID ( Int32? WORK_AREA_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID = WORK_AREA_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WORK_AREA_ID", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_STATUS_ID ( Int32? STATUS_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.STATUS_ID = STATUS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_STATUS_ID", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_BUSINESS_ID ( Int32? BUSINESS_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_BUSINESS_ID", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Business> Get_Business_By_USERNAME ( string USERNAME)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Business> Get_Business_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_BUSINESS_ID ( Int32? BUSINESS_ID)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_BUSINESS_ID", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_AREA_ID ( Int32? WORK_AREA_ID)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID = WORK_AREA_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WORK_AREA_ID", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_area> Get_Work_area_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Work_area> oList = new List<Work_area>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Work_area o = new Work_area();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID = SERVICE_PROD_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_SERVICE_PROD_ID", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID ( Int32? BOOST_PRICING_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.BOOST_PRICING_ID = BOOST_PRICING_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_BOOST_PRICING_ID", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_pricing o = new Boost_pricing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_PHONE_NUMBER_Adv ( Int32? PHONE_NUMBER)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.PHONE_NUMBER = PHONE_NUMBER;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_PHONE_NUMBER_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_USERNAME_Adv ( string USERNAME)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_BUSINESS_ID_Adv ( Int32? BUSINESS_ID)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_BUSINESS_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID_Adv ( Int32? SUB_CATEGORY_ID)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.SUB_CATEGORY_ID = SUB_CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_SUB_CATEGORY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Admin> Get_Admin_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Admin> Get_Admin_By_USERNAME_Adv ( string USERNAME)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Category> Get_Category_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Sub_category> Get_Sub_category_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Sub_category> Get_Sub_category_By_CATEGORY_ID_Adv ( Int32? CATEGORY_ID)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_CATEGORY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Coordinates> Get_Coordinates_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Coordinates> Get_Coordinates_By_BOOKING_ID_Adv ( Int32? BOOKING_ID)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.BOOKING_ID = BOOKING_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_BOOKING_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Status> Get_Status_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Status> oList = new List<Status>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STATUS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Status o = new Status();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Feedback> Get_Feedback_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Feedback> Get_Feedback_By_BOOKING_ID_Adv ( Int32? BOOKING_ID)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.BOOKING_ID = BOOKING_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_BOOKING_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_SERVICE_PROD_ID_Adv ( Int32? SERVICE_PROD_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID = SERVICE_PROD_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_SERVICE_PROD_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_CLIENT_ID_Adv ( Int32? CLIENT_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CLIENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_WORK_AREA_ID_Adv ( Int32? WORK_AREA_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID = WORK_AREA_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WORK_AREA_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_STATUS_ID_Adv ( Int32? STATUS_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.STATUS_ID = STATUS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_STATUS_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_BUSINESS_ID_Adv ( Int32? BUSINESS_ID)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_BUSINESS_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Business> Get_Business_By_USERNAME_Adv ( string USERNAME)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Business> Get_Business_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_BUSINESS_ID_Adv ( Int32? BUSINESS_ID)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_BUSINESS_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_AREA_ID_Adv ( Int32? WORK_AREA_ID)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID = WORK_AREA_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WORK_AREA_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_area> Get_Work_area_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Work_area> oList = new List<Work_area>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Work_area o = new Work_area();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID_Adv ( Int32? SERVICE_PROD_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID = SERVICE_PROD_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_SERVICE_PROD_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID_Adv ( Int32? BOOST_PRICING_ID)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.BOOST_PRICING_ID = BOOST_PRICING_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_BOOST_PRICING_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_PHONE_NUMBER_List ( List<Int32?> PHONE_NUMBER_LIST)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.PHONE_NUMBER_LIST = string.Join(",", PHONE_NUMBER_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_PHONE_NUMBER_LIST", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_BUSINESS_ID_List ( List<Int32?> BUSINESS_ID_LIST)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_BUSINESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID_List ( List<Int32?> SUB_CATEGORY_ID_LIST)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.SUB_CATEGORY_ID_LIST = string.Join(",", SUB_CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_SUB_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Sub_category> Get_Sub_category_By_CATEGORY_ID_List ( List<Int32?> CATEGORY_ID_LIST)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_CATEGORY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Coordinates> Get_Coordinates_By_BOOKING_ID_List ( List<Int32?> BOOKING_ID_LIST)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_BOOKING_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Feedback> Get_Feedback_By_BOOKING_ID_List ( List<Int32?> BOOKING_ID_LIST)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_BOOKING_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_SERVICE_PROD_ID_List ( List<Int32?> SERVICE_PROD_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_SERVICE_PROD_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CLIENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_WORK_AREA_ID_List ( List<Int32?> WORK_AREA_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WORK_AREA_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_STATUS_ID_List ( List<Int32?> STATUS_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_STATUS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_BUSINESS_ID_List ( List<Int32?> BUSINESS_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_BUSINESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_BUSINESS_ID_List ( List<Int32?> BUSINESS_ID_LIST)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_BUSINESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_AREA_ID_List ( List<Int32?> WORK_AREA_ID_LIST)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WORK_AREA_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID_List ( List<Int32?> SERVICE_PROD_ID_LIST)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_SERVICE_PROD_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID_List ( List<Int32?> BOOST_PRICING_ID_LIST)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_BOOST_PRICING_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_PHONE_NUMBER_List_Adv ( List<Int32?> PHONE_NUMBER_LIST)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.PHONE_NUMBER_LIST = string.Join(",", PHONE_NUMBER_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_PHONE_NUMBER_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_BUSINESS_ID_List_Adv ( List<Int32?> BUSINESS_ID_LIST)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_BUSINESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Service_prod> Get_Service_prod_By_SUB_CATEGORY_ID_List_Adv ( List<Int32?> SUB_CATEGORY_ID_LIST)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.SUB_CATEGORY_ID_LIST = string.Join(",", SUB_CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_SUB_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Sub_category> Get_Sub_category_By_CATEGORY_ID_List_Adv ( List<Int32?> CATEGORY_ID_LIST)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_CATEGORY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Coordinates> Get_Coordinates_By_BOOKING_ID_List_Adv ( List<Int32?> BOOKING_ID_LIST)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_BOOKING_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Feedback> Get_Feedback_By_BOOKING_ID_List_Adv ( List<Int32?> BOOKING_ID_LIST)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_BOOKING_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_SERVICE_PROD_ID_List_Adv ( List<Int32?> SERVICE_PROD_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_SERVICE_PROD_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CLIENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_WORK_AREA_ID_List_Adv ( List<Int32?> WORK_AREA_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WORK_AREA_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_STATUS_ID_List_Adv ( List<Int32?> STATUS_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_STATUS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Booking> Get_Booking_By_BUSINESS_ID_List_Adv ( List<Int32?> BUSINESS_ID_LIST)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_BUSINESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_BUSINESS_ID_List_Adv ( List<Int32?> BUSINESS_ID_LIST)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_BUSINESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Work_list> Get_Work_list_By_WORK_AREA_ID_List_Adv ( List<Int32?> WORK_AREA_ID_LIST)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WORK_AREA_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_SERVICE_PROD_ID_List_Adv ( List<Int32?> SERVICE_PROD_ID_LIST)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_SERVICE_PROD_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_BOOST_PRICING_ID_List_Adv ( List<Int32?> BOOST_PRICING_ID_LIST)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_BOOST_PRICING_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Boost_pricing o = new Boost_pricing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Boost_pricing o = new Boost_pricing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Service_prod> Get_Service_prod_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Service_prod> Get_Service_prod_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Admin> Get_Admin_By_Criteria ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Admin> Get_Admin_By_Where ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Sub_category> Get_Sub_category_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Sub_category> Get_Sub_category_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coordinates> Get_Coordinates_By_Criteria ( string LONGITUDE, string LATITUDE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.LONGITUDE = LONGITUDE; p.LATITUDE = LATITUDE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coordinates> Get_Coordinates_By_Where ( string LONGITUDE, string LATITUDE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.LONGITUDE = LONGITUDE; p.LATITUDE = LATITUDE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Criteria ( string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.SYMBOL = SYMBOL; p.ACRONYM = ACRONYM; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Where ( string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.SYMBOL = SYMBOL; p.ACRONYM = ACRONYM; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Status> Get_Status_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Status> oList = new List<Status>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STATUS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Status o = new Status();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Status> Get_Status_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Status> oList = new List<Status>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STATUS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Status o = new Status();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria ( string COMMENT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Where ( string COMMENT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_V2 ( string COMMENT, string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Where_V2 ( string COMMENT, string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Criteria_V2 ( string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Where_V2 ( string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Business> Get_Business_By_Criteria ( string NAME, string USERNAME, string PASSWORD, string EMAIL, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Business> Get_Business_By_Where ( string NAME, string USERNAME, string PASSWORD, string EMAIL, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_list> Get_Work_list_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_list> Get_Work_list_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_area> Get_Work_area_By_Criteria ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_area> oList = new List<Work_area>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Work_area o = new Work_area();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_area> Get_Work_area_By_Where ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_area> oList = new List<Work_area>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Work_area o = new Work_area();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_V2 ( string START_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.START_DATE = START_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_V2 ( string START_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.START_DATE = START_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_pricing o = new Boost_pricing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_pricing> Get_Boost_pricing_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_pricing> oList = new List<Boost_pricing>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_PRICING_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_pricing o = new Boost_pricing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Service_prod> Get_Service_prod_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Service_prod> Get_Service_prod_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Admin> Get_Admin_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Admin> Get_Admin_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Admin> oList = new List<Admin>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADMIN_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Admin o = new Admin();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Category> Get_Category_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Category> oList = new List<Category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CATEGORY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Category o = new Category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Sub_category> Get_Sub_category_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Sub_category> Get_Sub_category_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coordinates> Get_Coordinates_By_Criteria_Adv ( string LONGITUDE, string LATITUDE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.LONGITUDE = LONGITUDE; p.LATITUDE = LATITUDE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coordinates> Get_Coordinates_By_Where_Adv ( string LONGITUDE, string LATITUDE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.LONGITUDE = LONGITUDE; p.LATITUDE = LATITUDE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Criteria_Adv ( string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.SYMBOL = SYMBOL; p.ACRONYM = ACRONYM; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Where_Adv ( string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.SYMBOL = SYMBOL; p.ACRONYM = ACRONYM; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Status> Get_Status_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Status> oList = new List<Status>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STATUS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Status o = new Status();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Status> Get_Status_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Status> oList = new List<Status>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STATUS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Status o = new Status();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_Adv ( string COMMENT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Where_Adv ( string COMMENT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_Adv_V2 ( string COMMENT, string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Where_Adv_V2 ( string COMMENT, string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Criteria_Adv_V2 ( string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Where_Adv_V2 ( string DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Business> Get_Business_By_Criteria_Adv ( string NAME, string USERNAME, string PASSWORD, string EMAIL, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Business> Get_Business_By_Where_Adv ( string NAME, string USERNAME, string PASSWORD, string EMAIL, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Business> oList = new List<Business>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.EMAIL = EMAIL; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BUSINESS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Business o = new Business();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_list> Get_Work_list_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_list> Get_Work_list_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_area> Get_Work_area_By_Criteria_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_area> oList = new List<Work_area>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Work_area o = new Work_area();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_area> Get_Work_area_By_Where_Adv ( string NAME, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_area> oList = new List<Work_area>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_AREA_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Work_area o = new Work_area();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_Adv_V2 ( string START_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.START_DATE = START_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_Adv_V2 ( string START_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.START_DATE = START_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Service_prod> Get_Service_prod_By_Criteria_InList ( string NAME, string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> SUB_CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.SUB_CATEGORY_ID_LIST = string.Join(",", SUB_CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Service_prod> Get_Service_prod_By_Where_InList ( string NAME, string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> SUB_CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.SUB_CATEGORY_ID_LIST = string.Join(",", SUB_CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Sub_category> Get_Sub_category_By_Criteria_InList ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Sub_category> Get_Sub_category_By_Where_InList ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coordinates> Get_Coordinates_By_Criteria_InList ( string LONGITUDE, string LATITUDE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.LONGITUDE = LONGITUDE; p.LATITUDE = LATITUDE; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coordinates> Get_Coordinates_By_Where_InList ( string LONGITUDE, string LATITUDE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.LONGITUDE = LONGITUDE; p.LATITUDE = LATITUDE; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_InList ( string COMMENT, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Where_InList ( string COMMENT, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_InList_V2 ( string COMMENT, string DATE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Where_InList_V2 ( string COMMENT, string DATE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Criteria_InList ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Where_InList ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Criteria_InList_V2 ( string DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Where_InList_V2 ( string DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_list> Get_Work_list_By_Criteria_InList ( string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_list> Get_Work_list_By_Where_InList ( string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_InList ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_InList ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_InList_V2 ( string START_DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.START_DATE = START_DATE; p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_InList_V2 ( string START_DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.START_DATE = START_DATE; p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Service_prod> Get_Service_prod_By_Criteria_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> SUB_CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.SUB_CATEGORY_ID_LIST = string.Join(",", SUB_CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Service_prod> Get_Service_prod_By_Where_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> SUB_CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Service_prod> oList = new List<Service_prod>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.SUB_CATEGORY_ID_LIST = string.Join(",", SUB_CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SERVICE_PROD_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Service_prod o = new Service_prod();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Sub_category = new Sub_category();
o.My_Sub_category.SUB_CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_SUB_CATEGORY_ID"]);o.My_Sub_category.CATEGORY_ID = GV<Int32>(X["T_SUB_CATEGORY_CATEGORY_ID"]);o.My_Sub_category.NAME = GV<String>(X["T_SUB_CATEGORY_NAME"]);o.My_Sub_category.DESCRIPTION = GV<String>(X["T_SUB_CATEGORY_DESCRIPTION"]);o.My_Sub_category.ENTRY_USER_ID = GV<Int64>(X["T_SUB_CATEGORY_ENTRY_USER_ID"]);o.My_Sub_category.ENTRY_DATE = GV<String>(X["T_SUB_CATEGORY_ENTRY_DATE"]);o.My_Sub_category.OWNER_ID = GV<Int32>(X["T_SUB_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Sub_category> Get_Sub_category_By_Criteria_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Sub_category> Get_Sub_category_By_Where_InList_Adv ( string NAME, string DESCRIPTION, List<Int32?> CATEGORY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Sub_category> oList = new List<Sub_category>();
dynamic p = new ExpandoObject();
p.NAME = NAME; p.DESCRIPTION = DESCRIPTION; p.CATEGORY_ID_LIST = string.Join(",", CATEGORY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUB_CATEGORY_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Sub_category o = new Sub_category();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Category = new Category();
o.My_Category.CATEGORY_ID = GV<Int32>(X["T_CATEGORY_CATEGORY_ID"]);o.My_Category.NAME = GV<String>(X["T_CATEGORY_NAME"]);o.My_Category.DESCRIPTION = GV<String>(X["T_CATEGORY_DESCRIPTION"]);o.My_Category.ENTRY_USER_ID = GV<Int64>(X["T_CATEGORY_ENTRY_USER_ID"]);o.My_Category.ENTRY_DATE = GV<String>(X["T_CATEGORY_ENTRY_DATE"]);o.My_Category.OWNER_ID = GV<Int32>(X["T_CATEGORY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coordinates> Get_Coordinates_By_Criteria_InList_Adv ( string LONGITUDE, string LATITUDE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.LONGITUDE = LONGITUDE; p.LATITUDE = LATITUDE; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Coordinates> Get_Coordinates_By_Where_InList_Adv ( string LONGITUDE, string LATITUDE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Coordinates> oList = new List<Coordinates>();
dynamic p = new ExpandoObject();
p.LONGITUDE = LONGITUDE; p.LATITUDE = LATITUDE; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_COORDINATES_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Coordinates o = new Coordinates();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_InList_Adv ( string COMMENT, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Where_InList_Adv ( string COMMENT, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Booking = new Booking();
o.My_Booking.BOOKING_ID = GV<Int32>(X["T_BOOKING_BOOKING_ID"]);o.My_Booking.SERVICE_PROD_ID = GV<Int32>(X["T_BOOKING_SERVICE_PROD_ID"]);o.My_Booking.CLIENT_ID = GV<Int32>(X["T_BOOKING_CLIENT_ID"]);o.My_Booking.BUSINESS_ID = GV<Int32>(X["T_BOOKING_BUSINESS_ID"]);o.My_Booking.WORK_AREA_ID = GV<Int32>(X["T_BOOKING_WORK_AREA_ID"]);o.My_Booking.DATE = GV<String>(X["T_BOOKING_DATE"]);o.My_Booking.TOTAL_PRICE = GV<Decimal>(X["T_BOOKING_TOTAL_PRICE"]);o.My_Booking.STATUS_ID = GV<Int32>(X["T_BOOKING_STATUS_ID"]);o.My_Booking.DESCRIPTION = GV<String>(X["T_BOOKING_DESCRIPTION"]);o.My_Booking.ENTRY_USER_ID = GV<Int64>(X["T_BOOKING_ENTRY_USER_ID"]);o.My_Booking.ENTRY_DATE = GV<String>(X["T_BOOKING_ENTRY_DATE"]);o.My_Booking.OWNER_ID = GV<Int32>(X["T_BOOKING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Criteria_InList_Adv_V2 ( string COMMENT, string DATE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Feedback> Get_Feedback_By_Where_InList_Adv_V2 ( string COMMENT, string DATE, string DESCRIPTION, List<Int32?> BOOKING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Feedback> oList = new List<Feedback>();
dynamic p = new ExpandoObject();
p.COMMENT = COMMENT; p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.BOOKING_ID_LIST = string.Join(",", BOOKING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEEDBACK_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Feedback o = new Feedback();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.FIRST_NAME = GV<String>(X["T_CLIENT_FIRST_NAME"]);o.My_Client.LAST_NAME = GV<String>(X["T_CLIENT_LAST_NAME"]);o.My_Client.USERNAME = GV<String>(X["T_CLIENT_USERNAME"]);o.My_Client.PASSWORD = GV<String>(X["T_CLIENT_PASSWORD"]);o.My_Client.PHONE_NUMBER = GV<Int32>(X["T_CLIENT_PHONE_NUMBER"]);o.My_Client.EMAIL = GV<String>(X["T_CLIENT_EMAIL"]);o.My_Client.IS_ACTIVE = GV<Boolean>(X["T_CLIENT_IS_ACTIVE"]);o.My_Client.IS_VERIFIED = GV<Boolean>(X["T_CLIENT_IS_VERIFIED"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
o.My_Status = new Status();
o.My_Status.STATUS_ID = GV<Int32>(X["T_STATUS_STATUS_ID"]);o.My_Status.NAME = GV<String>(X["T_STATUS_NAME"]);o.My_Status.DESCRIPTION = GV<String>(X["T_STATUS_DESCRIPTION"]);o.My_Status.ENTRY_USER_ID = GV<Int64>(X["T_STATUS_ENTRY_USER_ID"]);o.My_Status.ENTRY_DATE = GV<String>(X["T_STATUS_ENTRY_DATE"]);o.My_Status.OWNER_ID = GV<Int32>(X["T_STATUS_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Criteria_InList_Adv_V2 ( string DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Booking> Get_Booking_By_Where_InList_Adv_V2 ( string DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> CLIENT_ID_LIST, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, List<Int32?> STATUS_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Booking> oList = new List<Booking>();
dynamic p = new ExpandoObject();
p.DATE = DATE; p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.STATUS_ID_LIST = string.Join(",", STATUS_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOKING_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Booking o = new Booking();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_list> Get_Work_list_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Work_list> Get_Work_list_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> BUSINESS_ID_LIST, List<Int32?> WORK_AREA_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Work_list> oList = new List<Work_list>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.BUSINESS_ID_LIST = string.Join(",", BUSINESS_ID_LIST.ToArray()); p.WORK_AREA_ID_LIST = string.Join(",", WORK_AREA_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_WORK_LIST_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Work_list o = new Work_list();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Business = new Business();
o.My_Business.BUSINESS_ID = GV<Int32>(X["T_BUSINESS_BUSINESS_ID"]);o.My_Business.NAME = GV<String>(X["T_BUSINESS_NAME"]);o.My_Business.USERNAME = GV<String>(X["T_BUSINESS_USERNAME"]);o.My_Business.PASSWORD = GV<String>(X["T_BUSINESS_PASSWORD"]);o.My_Business.EMAIL = GV<String>(X["T_BUSINESS_EMAIL"]);o.My_Business.PHONE_NUMBER = GV<Int32>(X["T_BUSINESS_PHONE_NUMBER"]);o.My_Business.INTERVENTION_TIME = GV<Int32>(X["T_BUSINESS_INTERVENTION_TIME"]);o.My_Business.MINIMUM_COST = GV<Decimal>(X["T_BUSINESS_MINIMUM_COST"]);o.My_Business.IS_VALIDATED = GV<Boolean>(X["T_BUSINESS_IS_VALIDATED"]);o.My_Business.IS_CHECKMARK = GV<Boolean>(X["T_BUSINESS_IS_CHECKMARK"]);o.My_Business.IS_ACTIVE = GV<Boolean>(X["T_BUSINESS_IS_ACTIVE"]);o.My_Business.IS_BOOSTED = GV<Boolean>(X["T_BUSINESS_IS_BOOSTED"]);o.My_Business.DESCRIPTION = GV<String>(X["T_BUSINESS_DESCRIPTION"]);o.My_Business.ENTRY_USER_ID = GV<Int64>(X["T_BUSINESS_ENTRY_USER_ID"]);o.My_Business.ENTRY_DATE = GV<String>(X["T_BUSINESS_ENTRY_DATE"]);o.My_Business.OWNER_ID = GV<Int32>(X["T_BUSINESS_OWNER_ID"]);
o.My_Work_area = new Work_area();
o.My_Work_area.WORK_AREA_ID = GV<Int32>(X["T_WORK_AREA_WORK_AREA_ID"]);o.My_Work_area.NAME = GV<String>(X["T_WORK_AREA_NAME"]);o.My_Work_area.DESCRIPTION = GV<String>(X["T_WORK_AREA_DESCRIPTION"]);o.My_Work_area.ENTRY_USER_ID = GV<Int64>(X["T_WORK_AREA_ENTRY_USER_ID"]);o.My_Work_area.ENTRY_DATE = GV<String>(X["T_WORK_AREA_ENTRY_DATE"]);o.My_Work_area.OWNER_ID = GV<Int32>(X["T_WORK_AREA_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Service_prod = new Service_prod();
o.My_Service_prod.SERVICE_PROD_ID = GV<Int32>(X["T_SERVICE_PROD_SERVICE_PROD_ID"]);o.My_Service_prod.BUSINESS_ID = GV<Int32>(X["T_SERVICE_PROD_BUSINESS_ID"]);o.My_Service_prod.SUB_CATEGORY_ID = GV<Int32>(X["T_SERVICE_PROD_SUB_CATEGORY_ID"]);o.My_Service_prod.NAME = GV<String>(X["T_SERVICE_PROD_NAME"]);o.My_Service_prod.PRICE = GV<Decimal>(X["T_SERVICE_PROD_PRICE"]);o.My_Service_prod.PROFIT_PERCENTAGE = GV<Decimal>(X["T_SERVICE_PROD_PROFIT_PERCENTAGE"]);o.My_Service_prod.IS_BOOSTED = GV<Boolean>(X["T_SERVICE_PROD_IS_BOOSTED"]);o.My_Service_prod.DESCRIPTION = GV<String>(X["T_SERVICE_PROD_DESCRIPTION"]);o.My_Service_prod.ENTRY_USER_ID = GV<Int64>(X["T_SERVICE_PROD_ENTRY_USER_ID"]);o.My_Service_prod.ENTRY_DATE = GV<String>(X["T_SERVICE_PROD_ENTRY_DATE"]);o.My_Service_prod.OWNER_ID = GV<Int32>(X["T_SERVICE_PROD_OWNER_ID"]);
o.My_Boost_pricing = new Boost_pricing();
o.My_Boost_pricing.BOOST_PRICING_ID = GV<Int32>(X["T_BOOST_PRICING_BOOST_PRICING_ID"]);o.My_Boost_pricing.NAME = GV<String>(X["T_BOOST_PRICING_NAME"]);o.My_Boost_pricing.MINUTE = GV<Int32>(X["T_BOOST_PRICING_MINUTE"]);o.My_Boost_pricing.PRICE_PER_MINUTE = GV<Decimal>(X["T_BOOST_PRICING_PRICE_PER_MINUTE"]);o.My_Boost_pricing.TOTAL_PRICE = GV<Decimal>(X["T_BOOST_PRICING_TOTAL_PRICE"]);o.My_Boost_pricing.DESCRIPTION = GV<String>(X["T_BOOST_PRICING_DESCRIPTION"]);o.My_Boost_pricing.ENTRY_USER_ID = GV<Int64>(X["T_BOOST_PRICING_ENTRY_USER_ID"]);o.My_Boost_pricing.ENTRY_DATE = GV<String>(X["T_BOOST_PRICING_ENTRY_DATE"]);o.My_Boost_pricing.OWNER_ID = GV<Int32>(X["T_BOOST_PRICING_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Criteria_InList_Adv_V2 ( string START_DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.START_DATE = START_DATE; p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Boost_listing> Get_Boost_listing_By_Where_InList_Adv_V2 ( string START_DATE, string DESCRIPTION, List<Int32?> SERVICE_PROD_ID_LIST, List<Int32?> BOOST_PRICING_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Boost_listing> oList = new List<Boost_listing>();
dynamic p = new ExpandoObject();
p.START_DATE = START_DATE; p.DESCRIPTION = DESCRIPTION; p.SERVICE_PROD_ID_LIST = string.Join(",", SERVICE_PROD_ID_LIST.ToArray()); p.BOOST_PRICING_ID_LIST = string.Join(",", BOOST_PRICING_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BOOST_LISTING_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Boost_listing o = new Boost_listing();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public void Delete_Boost_pricing ( Int32? BOOST_PRICING_ID)
{
var p = new { BOOST_PRICING_ID = BOOST_PRICING_ID };
ExecuteDelete("UPG_DELETE_BOOST_PRICING", p);
}
public void Delete_Client ( Int32? CLIENT_ID)
{
var p = new { CLIENT_ID = CLIENT_ID };
ExecuteDelete("UPG_DELETE_CLIENT", p);
}
public void Delete_Service_prod ( Int32? SERVICE_PROD_ID)
{
var p = new { SERVICE_PROD_ID = SERVICE_PROD_ID };
ExecuteDelete("UPG_DELETE_SERVICE_PROD", p);
}
public void Delete_Admin ( Int32? ADMIN_ID)
{
var p = new { ADMIN_ID = ADMIN_ID };
ExecuteDelete("UPG_DELETE_ADMIN", p);
}
public void Delete_Category ( Int32? CATEGORY_ID)
{
var p = new { CATEGORY_ID = CATEGORY_ID };
ExecuteDelete("UPG_DELETE_CATEGORY", p);
}
public void Delete_Sub_category ( Int32? SUB_CATEGORY_ID)
{
var p = new { SUB_CATEGORY_ID = SUB_CATEGORY_ID };
ExecuteDelete("UPG_DELETE_SUB_CATEGORY", p);
}
public void Delete_Coordinates ( Int32? COORDINATES_ID)
{
var p = new { COORDINATES_ID = COORDINATES_ID };
ExecuteDelete("UPG_DELETE_COORDINATES", p);
}
public void Delete_Currency ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_CURRENCY", p);
}
public void Delete_Status ( Int32? STATUS_ID)
{
var p = new { STATUS_ID = STATUS_ID };
ExecuteDelete("UPG_DELETE_STATUS", p);
}
public void Delete_Owner ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OWNER", p);
}
public void Delete_Feedback ( Int32? FEEDBACK_ID)
{
var p = new { FEEDBACK_ID = FEEDBACK_ID };
ExecuteDelete("UPG_DELETE_FEEDBACK", p);
}
public void Delete_Booking ( Int32? BOOKING_ID)
{
var p = new { BOOKING_ID = BOOKING_ID };
ExecuteDelete("UPG_DELETE_BOOKING", p);
}
public void Delete_Business ( Int32? BUSINESS_ID)
{
var p = new { BUSINESS_ID = BUSINESS_ID };
ExecuteDelete("UPG_DELETE_BUSINESS", p);
}
public void Delete_Work_list ( Int32? WORK_LIST_ID)
{
var p = new { WORK_LIST_ID = WORK_LIST_ID };
ExecuteDelete("UPG_DELETE_WORK_LIST", p);
}
public void Delete_User ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_USER", p);
}
public void Delete_Work_area ( Int32? WORK_AREA_ID)
{
var p = new { WORK_AREA_ID = WORK_AREA_ID };
ExecuteDelete("UPG_DELETE_WORK_AREA", p);
}
public void Delete_Boost_listing ( Int32? BOOST_LISTING_ID)
{
var p = new { BOOST_LISTING_ID = BOOST_LISTING_ID };
ExecuteDelete("UPG_DELETE_BOOST_LISTING", p);
}
public void Delete_Boost_pricing_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_BOOST_PRICING_BY_OWNER_ID", p);
}
public void Delete_Client_By_PHONE_NUMBER ( Int32? PHONE_NUMBER)
{
var p = new { PHONE_NUMBER = PHONE_NUMBER };
ExecuteDelete("UPG_DELETE_CLIENT_BY_PHONE_NUMBER", p);
}
public void Delete_Client_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CLIENT_BY_OWNER_ID", p);
}
public void Delete_Client_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_CLIENT_BY_USERNAME", p);
}
public void Delete_Service_prod_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SERVICE_PROD_BY_OWNER_ID", p);
}
public void Delete_Service_prod_By_BUSINESS_ID ( Int32? BUSINESS_ID)
{
var p = new { BUSINESS_ID = BUSINESS_ID };
ExecuteDelete("UPG_DELETE_SERVICE_PROD_BY_BUSINESS_ID", p);
}
public void Delete_Service_prod_By_SUB_CATEGORY_ID ( Int32? SUB_CATEGORY_ID)
{
var p = new { SUB_CATEGORY_ID = SUB_CATEGORY_ID };
ExecuteDelete("UPG_DELETE_SERVICE_PROD_BY_SUB_CATEGORY_ID", p);
}
public void Delete_Admin_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ADMIN_BY_OWNER_ID", p);
}
public void Delete_Admin_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_ADMIN_BY_USERNAME", p);
}
public void Delete_Category_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CATEGORY_BY_OWNER_ID", p);
}
public void Delete_Sub_category_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SUB_CATEGORY_BY_OWNER_ID", p);
}
public void Delete_Sub_category_By_CATEGORY_ID ( Int32? CATEGORY_ID)
{
var p = new { CATEGORY_ID = CATEGORY_ID };
ExecuteDelete("UPG_DELETE_SUB_CATEGORY_BY_CATEGORY_ID", p);
}
public void Delete_Coordinates_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_COORDINATES_BY_OWNER_ID", p);
}
public void Delete_Coordinates_By_BOOKING_ID ( Int32? BOOKING_ID)
{
var p = new { BOOKING_ID = BOOKING_ID };
ExecuteDelete("UPG_DELETE_COORDINATES_BY_BOOKING_ID", p);
}
public void Delete_Currency_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CURRENCY_BY_OWNER_ID", p);
}
public void Delete_Status_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_STATUS_BY_OWNER_ID", p);
}
public void Delete_Feedback_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_FEEDBACK_BY_OWNER_ID", p);
}
public void Delete_Feedback_By_BOOKING_ID ( Int32? BOOKING_ID)
{
var p = new { BOOKING_ID = BOOKING_ID };
ExecuteDelete("UPG_DELETE_FEEDBACK_BY_BOOKING_ID", p);
}
public void Delete_Booking_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_BOOKING_BY_OWNER_ID", p);
}
public void Delete_Booking_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID)
{
var p = new { SERVICE_PROD_ID = SERVICE_PROD_ID };
ExecuteDelete("UPG_DELETE_BOOKING_BY_SERVICE_PROD_ID", p);
}
public void Delete_Booking_By_CLIENT_ID ( Int32? CLIENT_ID)
{
var p = new { CLIENT_ID = CLIENT_ID };
ExecuteDelete("UPG_DELETE_BOOKING_BY_CLIENT_ID", p);
}
public void Delete_Booking_By_WORK_AREA_ID ( Int32? WORK_AREA_ID)
{
var p = new { WORK_AREA_ID = WORK_AREA_ID };
ExecuteDelete("UPG_DELETE_BOOKING_BY_WORK_AREA_ID", p);
}
public void Delete_Booking_By_STATUS_ID ( Int32? STATUS_ID)
{
var p = new { STATUS_ID = STATUS_ID };
ExecuteDelete("UPG_DELETE_BOOKING_BY_STATUS_ID", p);
}
public void Delete_Booking_By_BUSINESS_ID ( Int32? BUSINESS_ID)
{
var p = new { BUSINESS_ID = BUSINESS_ID };
ExecuteDelete("UPG_DELETE_BOOKING_BY_BUSINESS_ID", p);
}
public void Delete_Business_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_BUSINESS_BY_USERNAME", p);
}
public void Delete_Business_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_BUSINESS_BY_OWNER_ID", p);
}
public void Delete_Work_list_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_WORK_LIST_BY_OWNER_ID", p);
}
public void Delete_Work_list_By_BUSINESS_ID ( Int32? BUSINESS_ID)
{
var p = new { BUSINESS_ID = BUSINESS_ID };
ExecuteDelete("UPG_DELETE_WORK_LIST_BY_BUSINESS_ID", p);
}
public void Delete_Work_list_By_WORK_AREA_ID ( Int32? WORK_AREA_ID)
{
var p = new { WORK_AREA_ID = WORK_AREA_ID };
ExecuteDelete("UPG_DELETE_WORK_LIST_BY_WORK_AREA_ID", p);
}
public void Delete_User_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", p);
}
public void Delete_User_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_USER_BY_USERNAME", p);
}
public void Delete_Work_area_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_WORK_AREA_BY_OWNER_ID", p);
}
public void Delete_Boost_listing_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_BOOST_LISTING_BY_OWNER_ID", p);
}
public void Delete_Boost_listing_By_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID)
{
var p = new { SERVICE_PROD_ID = SERVICE_PROD_ID };
ExecuteDelete("UPG_DELETE_BOOST_LISTING_BY_SERVICE_PROD_ID", p);
}
public void Delete_Boost_listing_By_BOOST_PRICING_ID ( Int32? BOOST_PRICING_ID)
{
var p = new { BOOST_PRICING_ID = BOOST_PRICING_ID };
ExecuteDelete("UPG_DELETE_BOOST_LISTING_BY_BOOST_PRICING_ID", p);
}
public Int32? Edit_Boost_pricing ( Int32? BOOST_PRICING_ID, string NAME, Int32? MINUTE, decimal? PRICE_PER_MINUTE, decimal? TOTAL_PRICE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Boost_pricing oBoost_pricing = new Boost_pricing();
oBoost_pricing.BOOST_PRICING_ID = BOOST_PRICING_ID;oBoost_pricing.NAME = NAME;oBoost_pricing.MINUTE = MINUTE;oBoost_pricing.PRICE_PER_MINUTE = PRICE_PER_MINUTE;oBoost_pricing.TOTAL_PRICE = TOTAL_PRICE;oBoost_pricing.DESCRIPTION = DESCRIPTION;oBoost_pricing.ENTRY_USER_ID = ENTRY_USER_ID;oBoost_pricing.ENTRY_DATE = ENTRY_DATE;oBoost_pricing.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_BOOST_PRICING", oBoost_pricing, "BOOST_PRICING_ID");
return oBoost_pricing.BOOST_PRICING_ID;
}
public Int32? Edit_Client ( Int32? CLIENT_ID, string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, Int32? PHONE_NUMBER, string EMAIL, bool? IS_ACTIVE, bool? IS_VERIFIED, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Client oClient = new Client();
oClient.CLIENT_ID = CLIENT_ID;oClient.FIRST_NAME = FIRST_NAME;oClient.LAST_NAME = LAST_NAME;oClient.USERNAME = USERNAME;oClient.PASSWORD = PASSWORD;oClient.PHONE_NUMBER = PHONE_NUMBER;oClient.EMAIL = EMAIL;oClient.IS_ACTIVE = IS_ACTIVE;oClient.IS_VERIFIED = IS_VERIFIED;oClient.ENTRY_USER_ID = ENTRY_USER_ID;oClient.ENTRY_DATE = ENTRY_DATE;oClient.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CLIENT", oClient, "CLIENT_ID");
return oClient.CLIENT_ID;
}
public Int32? Edit_Service_prod ( Int32? SERVICE_PROD_ID, Int32? BUSINESS_ID, Int32? SUB_CATEGORY_ID, string NAME, decimal PRICE, decimal PROFIT_PERCENTAGE, bool? IS_BOOSTED, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Service_prod oService_prod = new Service_prod();
oService_prod.SERVICE_PROD_ID = SERVICE_PROD_ID;oService_prod.BUSINESS_ID = BUSINESS_ID;oService_prod.SUB_CATEGORY_ID = SUB_CATEGORY_ID;oService_prod.NAME = NAME;oService_prod.PRICE = PRICE;oService_prod.PROFIT_PERCENTAGE = PROFIT_PERCENTAGE;oService_prod.IS_BOOSTED = IS_BOOSTED;oService_prod.DESCRIPTION = DESCRIPTION;oService_prod.ENTRY_USER_ID = ENTRY_USER_ID;oService_prod.ENTRY_DATE = ENTRY_DATE;oService_prod.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_SERVICE_PROD", oService_prod, "SERVICE_PROD_ID");
return oService_prod.SERVICE_PROD_ID;
}
public Int32? Edit_Admin ( Int32? ADMIN_ID, string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, bool? IS_ACTIVE, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Admin oAdmin = new Admin();
oAdmin.ADMIN_ID = ADMIN_ID;oAdmin.FIRST_NAME = FIRST_NAME;oAdmin.LAST_NAME = LAST_NAME;oAdmin.USERNAME = USERNAME;oAdmin.PASSWORD = PASSWORD;oAdmin.EMAIL = EMAIL;oAdmin.IS_ACTIVE = IS_ACTIVE;oAdmin.ENTRY_USER_ID = ENTRY_USER_ID;oAdmin.ENTRY_DATE = ENTRY_DATE;oAdmin.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_ADMIN", oAdmin, "ADMIN_ID");
return oAdmin.ADMIN_ID;
}
public Int32? Edit_Category ( Int32? CATEGORY_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Category oCategory = new Category();
oCategory.CATEGORY_ID = CATEGORY_ID;oCategory.NAME = NAME;oCategory.DESCRIPTION = DESCRIPTION;oCategory.ENTRY_USER_ID = ENTRY_USER_ID;oCategory.ENTRY_DATE = ENTRY_DATE;oCategory.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CATEGORY", oCategory, "CATEGORY_ID");
return oCategory.CATEGORY_ID;
}
public Int32? Edit_Sub_category ( Int32? SUB_CATEGORY_ID, Int32? CATEGORY_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Sub_category oSub_category = new Sub_category();
oSub_category.SUB_CATEGORY_ID = SUB_CATEGORY_ID;oSub_category.CATEGORY_ID = CATEGORY_ID;oSub_category.NAME = NAME;oSub_category.DESCRIPTION = DESCRIPTION;oSub_category.ENTRY_USER_ID = ENTRY_USER_ID;oSub_category.ENTRY_DATE = ENTRY_DATE;oSub_category.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_SUB_CATEGORY", oSub_category, "SUB_CATEGORY_ID");
return oSub_category.SUB_CATEGORY_ID;
}
public Int32? Edit_Coordinates ( Int32? COORDINATES_ID, Int32? BOOKING_ID, string LONGITUDE, string LATITUDE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Coordinates oCoordinates = new Coordinates();
oCoordinates.COORDINATES_ID = COORDINATES_ID;oCoordinates.BOOKING_ID = BOOKING_ID;oCoordinates.LONGITUDE = LONGITUDE;oCoordinates.LATITUDE = LATITUDE;oCoordinates.DESCRIPTION = DESCRIPTION;oCoordinates.ENTRY_USER_ID = ENTRY_USER_ID;oCoordinates.ENTRY_DATE = ENTRY_DATE;oCoordinates.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_COORDINATES", oCoordinates, "COORDINATES_ID");
return oCoordinates.COORDINATES_ID;
}
public Int32? Edit_Currency ( Int32? CURRENCY_ID, string NAME, string SYMBOL, string ACRONYM, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Currency oCurrency = new Currency();
oCurrency.CURRENCY_ID = CURRENCY_ID;oCurrency.NAME = NAME;oCurrency.SYMBOL = SYMBOL;oCurrency.ACRONYM = ACRONYM;oCurrency.DESCRIPTION = DESCRIPTION;oCurrency.ENTRY_USER_ID = ENTRY_USER_ID;oCurrency.ENTRY_DATE = ENTRY_DATE;oCurrency.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CURRENCY", oCurrency, "CURRENCY_ID");
return oCurrency.CURRENCY_ID;
}
public Int32? Edit_Status ( Int32? STATUS_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Status oStatus = new Status();
oStatus.STATUS_ID = STATUS_ID;oStatus.NAME = NAME;oStatus.DESCRIPTION = DESCRIPTION;oStatus.ENTRY_USER_ID = ENTRY_USER_ID;oStatus.ENTRY_DATE = ENTRY_DATE;oStatus.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_STATUS", oStatus, "STATUS_ID");
return oStatus.STATUS_ID;
}
public Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE)
{
Owner oOwner = new Owner();
oOwner.OWNER_ID = OWNER_ID;oOwner.CODE = CODE;oOwner.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE;oOwner.DESCRIPTION = DESCRIPTION;oOwner.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
return oOwner.OWNER_ID;
}
public Int32? Edit_Feedback ( Int32? FEEDBACK_ID, Int32? BOOKING_ID, string COMMENT, Int32? RATING, string DATE, string TIME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Feedback oFeedback = new Feedback();
oFeedback.FEEDBACK_ID = FEEDBACK_ID;oFeedback.BOOKING_ID = BOOKING_ID;oFeedback.COMMENT = COMMENT;oFeedback.RATING = RATING;oFeedback.DATE = DATE;oFeedback.TIME = TIME;oFeedback.DESCRIPTION = DESCRIPTION;oFeedback.ENTRY_USER_ID = ENTRY_USER_ID;oFeedback.ENTRY_DATE = ENTRY_DATE;oFeedback.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_FEEDBACK", oFeedback, "FEEDBACK_ID");
return oFeedback.FEEDBACK_ID;
}
public Int32? Edit_Booking ( Int32? BOOKING_ID, Int32? SERVICE_PROD_ID, Int32? CLIENT_ID, Int32? BUSINESS_ID, Int32? WORK_AREA_ID, string DATE, decimal TOTAL_PRICE, Int32? STATUS_ID, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Booking oBooking = new Booking();
oBooking.BOOKING_ID = BOOKING_ID;oBooking.SERVICE_PROD_ID = SERVICE_PROD_ID;oBooking.CLIENT_ID = CLIENT_ID;oBooking.BUSINESS_ID = BUSINESS_ID;oBooking.WORK_AREA_ID = WORK_AREA_ID;oBooking.DATE = DATE;oBooking.TOTAL_PRICE = TOTAL_PRICE;oBooking.STATUS_ID = STATUS_ID;oBooking.DESCRIPTION = DESCRIPTION;oBooking.ENTRY_USER_ID = ENTRY_USER_ID;oBooking.ENTRY_DATE = ENTRY_DATE;oBooking.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_BOOKING", oBooking, "BOOKING_ID");
return oBooking.BOOKING_ID;
}
public Int32? Edit_Business ( Int32? BUSINESS_ID, string NAME, string USERNAME, string PASSWORD, string EMAIL, Int32? PHONE_NUMBER, Int32? INTERVENTION_TIME, decimal MINIMUM_COST, bool? IS_VALIDATED, bool? IS_CHECKMARK, bool? IS_ACTIVE, bool? IS_BOOSTED, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Business oBusiness = new Business();
oBusiness.BUSINESS_ID = BUSINESS_ID;oBusiness.NAME = NAME;oBusiness.USERNAME = USERNAME;oBusiness.PASSWORD = PASSWORD;oBusiness.EMAIL = EMAIL;oBusiness.PHONE_NUMBER = PHONE_NUMBER;oBusiness.INTERVENTION_TIME = INTERVENTION_TIME;oBusiness.MINIMUM_COST = MINIMUM_COST;oBusiness.IS_VALIDATED = IS_VALIDATED;oBusiness.IS_CHECKMARK = IS_CHECKMARK;oBusiness.IS_ACTIVE = IS_ACTIVE;oBusiness.IS_BOOSTED = IS_BOOSTED;oBusiness.DESCRIPTION = DESCRIPTION;oBusiness.ENTRY_USER_ID = ENTRY_USER_ID;oBusiness.ENTRY_DATE = ENTRY_DATE;oBusiness.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_BUSINESS", oBusiness, "BUSINESS_ID");
return oBusiness.BUSINESS_ID;
}
public Int32? Edit_Work_list ( Int32? WORK_LIST_ID, Int32? BUSINESS_ID, Int32? WORK_AREA_ID, bool? IS_TRUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Work_list oWork_list = new Work_list();
oWork_list.WORK_LIST_ID = WORK_LIST_ID;oWork_list.BUSINESS_ID = BUSINESS_ID;oWork_list.WORK_AREA_ID = WORK_AREA_ID;oWork_list.IS_TRUE = IS_TRUE;oWork_list.DESCRIPTION = DESCRIPTION;oWork_list.ENTRY_USER_ID = ENTRY_USER_ID;oWork_list.ENTRY_DATE = ENTRY_DATE;oWork_list.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_WORK_LIST", oWork_list, "WORK_LIST_ID");
return oWork_list.WORK_LIST_ID;
}
public long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE)
{
User oUser = new User();
oUser.USER_ID = USER_ID;oUser.OWNER_ID = OWNER_ID;oUser.USERNAME = USERNAME;oUser.PASSWORD = PASSWORD;oUser.USER_TYPE_CODE = USER_TYPE_CODE;oUser.IS_ACTIVE = IS_ACTIVE;oUser.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
return oUser.USER_ID;
}
public Int32? Edit_Work_area ( Int32? WORK_AREA_ID, string NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Work_area oWork_area = new Work_area();
oWork_area.WORK_AREA_ID = WORK_AREA_ID;oWork_area.NAME = NAME;oWork_area.DESCRIPTION = DESCRIPTION;oWork_area.ENTRY_USER_ID = ENTRY_USER_ID;oWork_area.ENTRY_DATE = ENTRY_DATE;oWork_area.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_WORK_AREA", oWork_area, "WORK_AREA_ID");
return oWork_area.WORK_AREA_ID;
}
public Int32? Edit_Boost_listing ( Int32? BOOST_LISTING_ID, Int32? SERVICE_PROD_ID, Int32? BOOST_PRICING_ID, string START_DATE, string START_TIME, bool? IS_ACTIVE, bool? IS_PAID, bool? IS_COMPLETED, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Boost_listing oBoost_listing = new Boost_listing();
oBoost_listing.BOOST_LISTING_ID = BOOST_LISTING_ID;oBoost_listing.SERVICE_PROD_ID = SERVICE_PROD_ID;oBoost_listing.BOOST_PRICING_ID = BOOST_PRICING_ID;oBoost_listing.START_DATE = START_DATE;oBoost_listing.START_TIME = START_TIME;oBoost_listing.IS_ACTIVE = IS_ACTIVE;oBoost_listing.IS_PAID = IS_PAID;oBoost_listing.IS_COMPLETED = IS_COMPLETED;oBoost_listing.DESCRIPTION = DESCRIPTION;oBoost_listing.ENTRY_USER_ID = ENTRY_USER_ID;oBoost_listing.ENTRY_DATE = ENTRY_DATE;oBoost_listing.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_BOOST_LISTING", oBoost_listing, "BOOST_LISTING_ID");
return oBoost_listing.BOOST_LISTING_ID;
}
public List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_DISTINCT_SETUP_TBL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TBL_NAME = GV<String>(X["TBL_NAME"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LAST_VALUE = GV<Int64>(X["LAST_VALUE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_TBL_SETUP ()
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_TBL_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ADMIN ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ADMIN", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ADMIN_ID = GV<Int32>(X["ADMIN_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_BOOKING ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_BOOKING", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BOOKING_ID = GV<Int32>(X["BOOKING_ID"]);o.SERVICE_PROD_ID = GV<Int32>(X["SERVICE_PROD_ID"]);o.CLIENT_ID = GV<Int32>(X["CLIENT_ID"]);o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.WORK_AREA_ID = GV<Int32>(X["WORK_AREA_ID"]);o.DATE = GV<String>(X["DATE"]);o.TOTAL_PRICE = GV<Decimal>(X["TOTAL_PRICE"]);o.STATUS_ID = GV<Int32>(X["STATUS_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_BOOST_LISTING ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_BOOST_LISTING", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BOOST_LISTING_ID = GV<Int32>(X["BOOST_LISTING_ID"]);o.SERVICE_PROD_ID = GV<Int32>(X["SERVICE_PROD_ID"]);o.BOOST_PRICING_ID = GV<Int32>(X["BOOST_PRICING_ID"]);o.START_DATE = GV<String>(X["START_DATE"]);o.START_TIME = GV<String>(X["START_TIME"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_PAID = GV<Boolean>(X["IS_PAID"]);o.IS_COMPLETED = GV<Boolean>(X["IS_COMPLETED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_BOOST_PRICING ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_BOOST_PRICING", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BOOST_PRICING_ID = GV<Int32>(X["BOOST_PRICING_ID"]);o.NAME = GV<String>(X["NAME"]);o.MINUTE = GV<Int32>(X["MINUTE"]);o.PRICE_PER_MINUTE = GV<Decimal>(X["PRICE_PER_MINUTE"]);o.TOTAL_PRICE = GV<Decimal>(X["TOTAL_PRICE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_BUSINESS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_BUSINESS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.NAME = GV<String>(X["NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.PHONE_NUMBER = GV<Int32>(X["PHONE_NUMBER"]);o.INTERVENTION_TIME = GV<Int32>(X["INTERVENTION_TIME"]);o.MINIMUM_COST = GV<Decimal>(X["MINIMUM_COST"]);o.IS_VALIDATED = GV<Boolean>(X["IS_VALIDATED"]);o.IS_CHECKMARK = GV<Boolean>(X["IS_CHECKMARK"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_BOOSTED = GV<Boolean>(X["IS_BOOSTED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CATEGORY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CATEGORY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.NAME = GV<String>(X["NAME"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CLIENT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CLIENT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CLIENT_ID = GV<Int32>(X["CLIENT_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.PHONE_NUMBER = GV<Int32>(X["PHONE_NUMBER"]);o.EMAIL = GV<String>(X["EMAIL"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_VERIFIED = GV<Boolean>(X["IS_VERIFIED"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_COORDINATES ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_COORDINATES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.COORDINATES_ID = GV<Int32>(X["COORDINATES_ID"]);o.BOOKING_ID = GV<Int32>(X["BOOKING_ID"]);o.LONGITUDE = GV<String>(X["LONGITUDE"]);o.LATITUDE = GV<String>(X["LATITUDE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CURRENCY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CURRENCY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.NAME = GV<String>(X["NAME"]);o.SYMBOL = GV<String>(X["SYMBOL"]);o.ACRONYM = GV<String>(X["ACRONYM"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_FEEDBACK ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_FEEDBACK", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.FEEDBACK_ID = GV<Int32>(X["FEEDBACK_ID"]);o.BOOKING_ID = GV<Int32>(X["BOOKING_ID"]);o.COMMENT = GV<String>(X["COMMENT"]);o.RATING = GV<Int32>(X["RATING"]);o.DATE = GV<String>(X["DATE"]);o.TIME = GV<String>(X["TIME"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OWNER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CODE = GV<String>(X["CODE"]);o.MAINTENANCE_DUE_DATE = GV<String>(X["MAINTENANCE_DUE_DATE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_SERVICE_PROD ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_SERVICE_PROD", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SERVICE_PROD_ID = GV<Int32>(X["SERVICE_PROD_ID"]);o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.SUB_CATEGORY_ID = GV<Int32>(X["SUB_CATEGORY_ID"]);o.NAME = GV<String>(X["NAME"]);o.PRICE = GV<Decimal>(X["PRICE"]);o.PROFIT_PERCENTAGE = GV<Decimal>(X["PROFIT_PERCENTAGE"]);o.IS_BOOSTED = GV<Boolean>(X["IS_BOOSTED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_STATUS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_STATUS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.STATUS_ID = GV<Int32>(X["STATUS_ID"]);o.NAME = GV<String>(X["NAME"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_SUB_CATEGORY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_SUB_CATEGORY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SUB_CATEGORY_ID = GV<Int32>(X["SUB_CATEGORY_ID"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.NAME = GV<String>(X["NAME"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_USER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.USER_TYPE_CODE = GV<String>(X["USER_TYPE_CODE"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_WORK_AREA ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_WORK_AREA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.WORK_AREA_ID = GV<Int32>(X["WORK_AREA_ID"]);o.NAME = GV<String>(X["NAME"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_WORK_LIST ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_WORK_LIST", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.WORK_LIST_ID = GV<Int32>(X["WORK_LIST_ID"]);o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.WORK_AREA_ID = GV<Int32>(X["WORK_AREA_ID"]);o.IS_TRUE = GV<Boolean>(X["IS_TRUE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.EXISTS = EXISTS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHECK_USER_EXISTENCE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
EXISTS = p.EXISTS;
return oList;
}
public List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME; p.ISSYSTEM = ISSYSTEM; p.ISDELETEABLE = ISDELETEABLE; p.ISUPDATEABLE = ISUPDATEABLE; p.ISVISIBLE = ISVISIBLE; p.ISDELETED = ISDELETED; p.DISPLAY_ORDER = DISPLAY_ORDER; p.CODE_VALUE_EN = CODE_VALUE_EN; p.CODE_VALUE_FR = CODE_VALUE_FR; p.CODE_VALUE_AR = CODE_VALUE_AR; p.ENTRY_DATE = ENTRY_DATE; p.ENTRY_USER_ID = ENTRY_USER_ID; p.NOTES = NOTES;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EDIT_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_PARAMETERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.PARAM_NAME = GV<String>(X["PARAM_NAME"]);o.PARAM_TYPE = GV<String>(X["PARAM_TYPE"]);o.IS_OUTPUT = GV<Boolean>(X["IS_OUTPUT"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_RESULT_SCHEMA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.COLUMN_NAME = GV<String>(X["COLUMN_NAME"]);o.COLUMN_TYPE = GV<String>(X["COLUMN_TYPE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.@tableName = @tableName;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GENERATE_INSERT_STATEMENTS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_ADMIN_BY_ADMIN_ID ( Int32? ADMIN_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ADMIN_ID = ADMIN_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_ADMIN_BY_ADMIN_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ADMIN_ID = GV<Int32>(X["ADMIN_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_ADMIN_BY_EMAIL ( string EMAIL)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_ADMIN_BY_EMAIL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ADMIN_ID = GV<Int32>(X["ADMIN_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_ADMIN_BY_USERNAME ( string USERNAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_ADMIN_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.NAME = GV<String>(X["NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.PHONE_NUMBER = GV<Int32>(X["PHONE_NUMBER"]);o.INTERVENTION_TIME = GV<Int32>(X["INTERVENTION_TIME"]);o.MINIMUM_COST = GV<Decimal>(X["MINIMUM_COST"]);o.IS_VALIDATED = GV<Boolean>(X["IS_VALIDATED"]);o.IS_CHECKMARK = GV<Boolean>(X["IS_CHECKMARK"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_BOOSTED = GV<Boolean>(X["IS_BOOSTED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_BOOST_LISTING_BY_BOOST_LISTING_ID ( Int32? BOOST_LISTING_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.BOOST_LISTING_ID = BOOST_LISTING_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_BOOST_LISTING_BY_BOOST_LISTING_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BOOST_LISTING_ID = GV<Int32>(X["BOOST_LISTING_ID"]);o.SERVICE_PROD_ID = GV<Int32>(X["SERVICE_PROD_ID"]);o.BOOST_PRICING_ID = GV<Int32>(X["BOOST_PRICING_ID"]);o.START_DATE = GV<String>(X["START_DATE"]);o.START_TIME = GV<String>(X["START_TIME"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_PAID = GV<Boolean>(X["IS_PAID"]);o.IS_COMPLETED = GV<Boolean>(X["IS_COMPLETED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_BUSINESS_BY_BUSINESS_ID ( Int32? BUSINESS_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_BUSINESS_BY_BUSINESS_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.NAME = GV<String>(X["NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.PHONE_NUMBER = GV<Int32>(X["PHONE_NUMBER"]);o.INTERVENTION_TIME = GV<Int32>(X["INTERVENTION_TIME"]);o.MINIMUM_COST = GV<Decimal>(X["MINIMUM_COST"]);o.IS_VALIDATED = GV<Boolean>(X["IS_VALIDATED"]);o.IS_CHECKMARK = GV<Boolean>(X["IS_CHECKMARK"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_BOOSTED = GV<Boolean>(X["IS_BOOSTED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_BUSINESS_BY_EMAIL ( string EMAIL)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_BUSINESS_BY_EMAIL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.NAME = GV<String>(X["NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.PHONE_NUMBER = GV<Int32>(X["PHONE_NUMBER"]);o.INTERVENTION_TIME = GV<Int32>(X["INTERVENTION_TIME"]);o.MINIMUM_COST = GV<Decimal>(X["MINIMUM_COST"]);o.IS_VALIDATED = GV<Boolean>(X["IS_VALIDATED"]);o.IS_CHECKMARK = GV<Boolean>(X["IS_CHECKMARK"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_BOOSTED = GV<Boolean>(X["IS_BOOSTED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_BUSINESS_BY_OWNER_ID ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_BUSINESS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.NAME = GV<String>(X["NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.PHONE_NUMBER = GV<Int32>(X["PHONE_NUMBER"]);o.INTERVENTION_TIME = GV<Int32>(X["INTERVENTION_TIME"]);o.MINIMUM_COST = GV<Decimal>(X["MINIMUM_COST"]);o.IS_VALIDATED = GV<Boolean>(X["IS_VALIDATED"]);o.IS_CHECKMARK = GV<Boolean>(X["IS_CHECKMARK"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_BOOSTED = GV<Boolean>(X["IS_BOOSTED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_BUSINESS_ID_BY_USERNAME ( string USERNAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_BUSINESS_ID_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_CLIENT_BY_CLIENT_ID ( Int32? CLIENT_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_CLIENT_BY_CLIENT_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CLIENT_ID = GV<Int32>(X["CLIENT_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.PHONE_NUMBER = GV<Int32>(X["PHONE_NUMBER"]);o.EMAIL = GV<String>(X["EMAIL"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_VERIFIED = GV<Boolean>(X["IS_VERIFIED"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_CLIENT_BY_EMAIL ( string EMAIL)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_CLIENT_BY_EMAIL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CLIENT_ID = GV<Int32>(X["CLIENT_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.PHONE_NUMBER = GV<Int32>(X["PHONE_NUMBER"]);o.EMAIL = GV<String>(X["EMAIL"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_VERIFIED = GV<Boolean>(X["IS_VERIFIED"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_CLIENT_BY_USERNAME ( string USERNAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_CLIENT_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.NAME = GV<String>(X["NAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.EMAIL = GV<String>(X["EMAIL"]);o.PHONE_NUMBER = GV<Int32>(X["PHONE_NUMBER"]);o.INTERVENTION_TIME = GV<Int32>(X["INTERVENTION_TIME"]);o.MINIMUM_COST = GV<Decimal>(X["MINIMUM_COST"]);o.IS_VALIDATED = GV<Boolean>(X["IS_VALIDATED"]);o.IS_CHECKMARK = GV<Boolean>(X["IS_CHECKMARK"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.IS_BOOSTED = GV<Boolean>(X["IS_BOOSTED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE; p.VALUE = VALUE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
VALUE = p.VALUE;
return oList;
}
public List<dynamic> UP_GET_SERVICE_PROD_BY_SERVICE_PROD_ID ( Int32? SERVICE_PROD_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.SERVICE_PROD_ID = SERVICE_PROD_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SERVICE_PROD_BY_SERVICE_PROD_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SERVICE_PROD_ID = GV<Int32>(X["SERVICE_PROD_ID"]);o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.SUB_CATEGORY_ID = GV<Int32>(X["SUB_CATEGORY_ID"]);o.NAME = GV<String>(X["NAME"]);o.PRICE = GV<Decimal>(X["PRICE"]);o.PROFIT_PERCENTAGE = GV<Decimal>(X["PROFIT_PERCENTAGE"]);o.IS_BOOSTED = GV<Boolean>(X["IS_BOOSTED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.ISDELETED = ISDELETED; p.ISVISIBLE = ISVISIBLE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES_PER_TABLE ( string NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.NAME = NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES_PER_TABLE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SUB_CATEGORY_BY_CATEGORY_ID ( Int32? CATEGORY_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.CATEGORY_ID = CATEGORY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SUB_CATEGORY_BY_CATEGORY_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SUB_CATEGORY_ID = GV<Int32>(X["SUB_CATEGORY_ID"]);o.CATEGORY_ID = GV<Int32>(X["CATEGORY_ID"]);o.NAME = GV<String>(X["NAME"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_CREDENTIALS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_EMAIL ( string EMAIL)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.EMAIL = EMAIL;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_EMAIL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USERNAME = GV<String>(X["USERNAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.USERNAME = GV<String>(X["USERNAME"]);o.ADMIN_ID = GV<Int32>(X["ADMIN_ID"]);o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.CLIENT_ID = GV<Int32>(X["CLIENT_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_USERNAME ( string USERNAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.USER_TYPE_CODE = GV<String>(X["USER_TYPE_CODE"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_WORK_AREA_BY_OWNER_ID ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_WORK_AREA_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.WORK_AREA_ID = GV<Int32>(X["WORK_AREA_ID"]);o.NAME = GV<String>(X["NAME"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_WORK_LIST_BY_BUSINESS_ID ( Int32? BUSINESS_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.BUSINESS_ID = BUSINESS_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_WORK_LIST_BY_BUSINESS_ID", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.WORK_LIST_ID = GV<Int32>(X["WORK_LIST_ID"]);o.BUSINESS_ID = GV<Int32>(X["BUSINESS_ID"]);o.WORK_AREA_ID = GV<Int32>(X["WORK_AREA_ID"]);o.IS_TRUE = GV<Boolean>(X["IS_TRUE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FTS = GV<String>(X["FTS"]);
oList.Add(o);
}
}
return oList;
}
}
}
