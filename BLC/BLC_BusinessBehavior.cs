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
#region Reset_Boost_listing_By_Boost_pricing
public void Reset_Boost_listing_By_Boost_pricing(Boost_pricing i_Boost_pricing, List<Boost_listing> i_Boost_listing_List)
{
#region Declaration And Initialization Section.
Params_Delete_Boost_listing_By_BOOST_PRICING_ID oParams_Delete_Boost_listing_By_BOOST_PRICING_ID = new Params_Delete_Boost_listing_By_BOOST_PRICING_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Boost_listing_By_Boost_pricing");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Boost_listing
//---------------------------------
oParams_Delete_Boost_listing_By_BOOST_PRICING_ID.BOOST_PRICING_ID = i_Boost_pricing.BOOST_PRICING_ID;
Delete_Boost_listing_By_BOOST_PRICING_ID(oParams_Delete_Boost_listing_By_BOOST_PRICING_ID);
//---------------------------------
// Edit Boost_listing
//---------------------------------
Edit_Boost_pricing_WithBoost_listing(i_Boost_pricing, i_Boost_listing_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Boost_listing_By_Boost_pricing");}
}
#endregion
#region Reset_Boost_listing_By_Boost_pricing
public void Reset_Boost_listing_By_Boost_pricing(Boost_pricing i_Boost_pricing, List<Boost_listing> i_Boost_listing_List_To_Delete,List<Boost_listing> i_Boost_listing_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Boost_listing oParams_Delete_Boost_listing = new Params_Delete_Boost_listing();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Boost_listing_By_Boost_pricing");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Boost_listing_List_To_Delete != null)
{
foreach (var oRow in i_Boost_listing_List_To_Delete)
{
oParams_Delete_Boost_listing.BOOST_LISTING_ID = oRow.BOOST_LISTING_ID;
Delete_Boost_listing(oParams_Delete_Boost_listing);
}
}
//---------------------------------
// Edit Boost_listing
//---------------------------------
Edit_Boost_pricing_WithBoost_listing(i_Boost_pricing, i_Boost_listing_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Boost_listing_By_Boost_pricing");}
}
#endregion
#region Edit_Boost_pricing_With_Boost_listing(Boost_pricing i_Boost_pricing,List<Boost_listing> i_Boost_listingList)
public void Edit_Boost_pricing_WithBoost_listing(Boost_pricing i_Boost_pricing,List<Boost_listing> i_List_Boost_listing)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Boost_pricing_WithBoost_listing");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Boost_pricing(i_Boost_pricing);
if (i_List_Boost_listing != null)
{
foreach(Boost_listing oBoost_listing in i_List_Boost_listing)
{
oBoost_listing.BOOST_PRICING_ID = i_Boost_pricing.BOOST_PRICING_ID;
Edit_Boost_listing(oBoost_listing);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Boost_pricing_WithBoost_listing");}
}
#endregion
#region Edit_Boost_pricing_WithRelatedData(Boost_pricing i_Boost_pricing,List<Boost_listing> i_List_Boost_listing)
public void Edit_Boost_pricing_WithRelatedData(Boost_pricing i_Boost_pricing,List<Boost_listing> i_List_Boost_listing)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Boost_pricing_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Boost_pricing(i_Boost_pricing);
if (i_List_Boost_listing != null)
{
foreach(Boost_listing oBoost_listing in i_List_Boost_listing)
{
oBoost_listing.BOOST_PRICING_ID = i_Boost_pricing.BOOST_PRICING_ID;
Edit_Boost_listing(oBoost_listing);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Boost_pricing_WithRelatedData");}
}
#endregion
#region Delete_Boost_pricing_With_Children(Boost_pricing i_Boost_pricing)
public void Delete_Boost_pricing_With_Children(Boost_pricing i_Boost_pricing)
{
 #region Declaration And Initialization Section.
Params_Delete_Boost_pricing oParams_Delete_Boost_pricing = new Params_Delete_Boost_pricing();
Params_Delete_Boost_listing_By_BOOST_PRICING_ID oParams_Delete_Boost_listing_By_BOOST_PRICING_ID = new Params_Delete_Boost_listing_By_BOOST_PRICING_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Boost_pricing_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Boost_listing_By_BOOST_PRICING_ID.BOOST_PRICING_ID = i_Boost_pricing.BOOST_PRICING_ID;
Delete_Boost_listing_By_BOOST_PRICING_ID(oParams_Delete_Boost_listing_By_BOOST_PRICING_ID);
//-------------------------

//-------------------------
oParams_Delete_Boost_pricing.BOOST_PRICING_ID = i_Boost_pricing.BOOST_PRICING_ID;
Delete_Boost_pricing(oParams_Delete_Boost_pricing);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Boost_pricing_With_Children");}
}
#endregion
#region Reset_Booking_By_Client
public void Reset_Booking_By_Client(Client i_Client, List<Booking> i_Booking_List)
{
#region Declaration And Initialization Section.
Params_Delete_Booking_By_CLIENT_ID oParams_Delete_Booking_By_CLIENT_ID = new Params_Delete_Booking_By_CLIENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Client");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Booking
//---------------------------------
oParams_Delete_Booking_By_CLIENT_ID.CLIENT_ID = i_Client.CLIENT_ID;
Delete_Booking_By_CLIENT_ID(oParams_Delete_Booking_By_CLIENT_ID);
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Client_WithBooking(i_Client, i_Booking_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Client");}
}
#endregion
#region Reset_Booking_By_Client
public void Reset_Booking_By_Client(Client i_Client, List<Booking> i_Booking_List_To_Delete,List<Booking> i_Booking_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Booking oParams_Delete_Booking = new Params_Delete_Booking();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Client");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Booking_List_To_Delete != null)
{
foreach (var oRow in i_Booking_List_To_Delete)
{
oParams_Delete_Booking.BOOKING_ID = oRow.BOOKING_ID;
Delete_Booking(oParams_Delete_Booking);
}
}
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Client_WithBooking(i_Client, i_Booking_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Client");}
}
#endregion
#region Edit_Client_With_Booking(Client i_Client,List<Booking> i_BookingList)
public void Edit_Client_WithBooking(Client i_Client,List<Booking> i_List_Booking)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_WithBooking");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Client(i_Client);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.CLIENT_ID = i_Client.CLIENT_ID;
Edit_Booking(oBooking);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_WithBooking");}
}
#endregion
#region Edit_Client_WithRelatedData(Client i_Client,List<Booking> i_List_Booking)
public void Edit_Client_WithRelatedData(Client i_Client,List<Booking> i_List_Booking)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Client(i_Client);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.CLIENT_ID = i_Client.CLIENT_ID;
Edit_Booking(oBooking);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_WithRelatedData");}
}
#endregion
#region Delete_Client_With_Children(Client i_Client)
public void Delete_Client_With_Children(Client i_Client)
{
 #region Declaration And Initialization Section.
Params_Delete_Client oParams_Delete_Client = new Params_Delete_Client();
Params_Delete_Booking_By_CLIENT_ID oParams_Delete_Booking_By_CLIENT_ID = new Params_Delete_Booking_By_CLIENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Booking_By_CLIENT_ID.CLIENT_ID = i_Client.CLIENT_ID;
Delete_Booking_By_CLIENT_ID(oParams_Delete_Booking_By_CLIENT_ID);
//-------------------------

//-------------------------
oParams_Delete_Client.CLIENT_ID = i_Client.CLIENT_ID;
Delete_Client(oParams_Delete_Client);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_With_Children");}
}
#endregion
#region Reset_Booking_By_Service_prod
public void Reset_Booking_By_Service_prod(Service_prod i_Service_prod, List<Booking> i_Booking_List)
{
#region Declaration And Initialization Section.
Params_Delete_Booking_By_SERVICE_PROD_ID oParams_Delete_Booking_By_SERVICE_PROD_ID = new Params_Delete_Booking_By_SERVICE_PROD_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Service_prod");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Booking
//---------------------------------
oParams_Delete_Booking_By_SERVICE_PROD_ID.SERVICE_PROD_ID = i_Service_prod.SERVICE_PROD_ID;
Delete_Booking_By_SERVICE_PROD_ID(oParams_Delete_Booking_By_SERVICE_PROD_ID);
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Service_prod_WithBooking(i_Service_prod, i_Booking_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Service_prod");}
}
#endregion
#region Reset_Booking_By_Service_prod
public void Reset_Booking_By_Service_prod(Service_prod i_Service_prod, List<Booking> i_Booking_List_To_Delete,List<Booking> i_Booking_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Booking oParams_Delete_Booking = new Params_Delete_Booking();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Service_prod");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Booking_List_To_Delete != null)
{
foreach (var oRow in i_Booking_List_To_Delete)
{
oParams_Delete_Booking.BOOKING_ID = oRow.BOOKING_ID;
Delete_Booking(oParams_Delete_Booking);
}
}
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Service_prod_WithBooking(i_Service_prod, i_Booking_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Service_prod");}
}
#endregion
#region Edit_Service_prod_With_Booking(Service_prod i_Service_prod,List<Booking> i_BookingList)
public void Edit_Service_prod_WithBooking(Service_prod i_Service_prod,List<Booking> i_List_Booking)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Service_prod_WithBooking");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Service_prod(i_Service_prod);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.SERVICE_PROD_ID = i_Service_prod.SERVICE_PROD_ID;
Edit_Booking(oBooking);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Service_prod_WithBooking");}
}
#endregion
#region Reset_Boost_listing_By_Service_prod
public void Reset_Boost_listing_By_Service_prod(Service_prod i_Service_prod, List<Boost_listing> i_Boost_listing_List)
{
#region Declaration And Initialization Section.
Params_Delete_Boost_listing_By_SERVICE_PROD_ID oParams_Delete_Boost_listing_By_SERVICE_PROD_ID = new Params_Delete_Boost_listing_By_SERVICE_PROD_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Boost_listing_By_Service_prod");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Boost_listing
//---------------------------------
oParams_Delete_Boost_listing_By_SERVICE_PROD_ID.SERVICE_PROD_ID = i_Service_prod.SERVICE_PROD_ID;
Delete_Boost_listing_By_SERVICE_PROD_ID(oParams_Delete_Boost_listing_By_SERVICE_PROD_ID);
//---------------------------------
// Edit Boost_listing
//---------------------------------
Edit_Service_prod_WithBoost_listing(i_Service_prod, i_Boost_listing_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Boost_listing_By_Service_prod");}
}
#endregion
#region Reset_Boost_listing_By_Service_prod
public void Reset_Boost_listing_By_Service_prod(Service_prod i_Service_prod, List<Boost_listing> i_Boost_listing_List_To_Delete,List<Boost_listing> i_Boost_listing_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Boost_listing oParams_Delete_Boost_listing = new Params_Delete_Boost_listing();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Boost_listing_By_Service_prod");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Boost_listing_List_To_Delete != null)
{
foreach (var oRow in i_Boost_listing_List_To_Delete)
{
oParams_Delete_Boost_listing.BOOST_LISTING_ID = oRow.BOOST_LISTING_ID;
Delete_Boost_listing(oParams_Delete_Boost_listing);
}
}
//---------------------------------
// Edit Boost_listing
//---------------------------------
Edit_Service_prod_WithBoost_listing(i_Service_prod, i_Boost_listing_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Boost_listing_By_Service_prod");}
}
#endregion
#region Edit_Service_prod_With_Boost_listing(Service_prod i_Service_prod,List<Boost_listing> i_Boost_listingList)
public void Edit_Service_prod_WithBoost_listing(Service_prod i_Service_prod,List<Boost_listing> i_List_Boost_listing)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Service_prod_WithBoost_listing");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Service_prod(i_Service_prod);
if (i_List_Boost_listing != null)
{
foreach(Boost_listing oBoost_listing in i_List_Boost_listing)
{
oBoost_listing.SERVICE_PROD_ID = i_Service_prod.SERVICE_PROD_ID;
Edit_Boost_listing(oBoost_listing);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Service_prod_WithBoost_listing");}
}
#endregion
#region Edit_Service_prod_WithRelatedData(Service_prod i_Service_prod,List<Booking> i_List_Booking,List<Boost_listing> i_List_Boost_listing)
public void Edit_Service_prod_WithRelatedData(Service_prod i_Service_prod,List<Booking> i_List_Booking,List<Boost_listing> i_List_Boost_listing)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Service_prod_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Service_prod(i_Service_prod);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.SERVICE_PROD_ID = i_Service_prod.SERVICE_PROD_ID;
Edit_Booking(oBooking);
}
}
if (i_List_Boost_listing != null)
{
foreach(Boost_listing oBoost_listing in i_List_Boost_listing)
{
oBoost_listing.SERVICE_PROD_ID = i_Service_prod.SERVICE_PROD_ID;
Edit_Boost_listing(oBoost_listing);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Service_prod_WithRelatedData");}
}
#endregion
#region Delete_Service_prod_With_Children(Service_prod i_Service_prod)
public void Delete_Service_prod_With_Children(Service_prod i_Service_prod)
{
 #region Declaration And Initialization Section.
Params_Delete_Service_prod oParams_Delete_Service_prod = new Params_Delete_Service_prod();
Params_Delete_Booking_By_SERVICE_PROD_ID oParams_Delete_Booking_By_SERVICE_PROD_ID = new Params_Delete_Booking_By_SERVICE_PROD_ID();
Params_Delete_Boost_listing_By_SERVICE_PROD_ID oParams_Delete_Boost_listing_By_SERVICE_PROD_ID = new Params_Delete_Boost_listing_By_SERVICE_PROD_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Service_prod_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Booking_By_SERVICE_PROD_ID.SERVICE_PROD_ID = i_Service_prod.SERVICE_PROD_ID;
Delete_Booking_By_SERVICE_PROD_ID(oParams_Delete_Booking_By_SERVICE_PROD_ID);
oParams_Delete_Boost_listing_By_SERVICE_PROD_ID.SERVICE_PROD_ID = i_Service_prod.SERVICE_PROD_ID;
Delete_Boost_listing_By_SERVICE_PROD_ID(oParams_Delete_Boost_listing_By_SERVICE_PROD_ID);
//-------------------------

//-------------------------
oParams_Delete_Service_prod.SERVICE_PROD_ID = i_Service_prod.SERVICE_PROD_ID;
Delete_Service_prod(oParams_Delete_Service_prod);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Service_prod_With_Children");}
}
#endregion
#region Reset_Sub_category_By_Category
public void Reset_Sub_category_By_Category(Category i_Category, List<Sub_category> i_Sub_category_List)
{
#region Declaration And Initialization Section.
Params_Delete_Sub_category_By_CATEGORY_ID oParams_Delete_Sub_category_By_CATEGORY_ID = new Params_Delete_Sub_category_By_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Sub_category_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Sub_category
//---------------------------------
oParams_Delete_Sub_category_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Sub_category_By_CATEGORY_ID(oParams_Delete_Sub_category_By_CATEGORY_ID);
//---------------------------------
// Edit Sub_category
//---------------------------------
Edit_Category_WithSub_category(i_Category, i_Sub_category_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Sub_category_By_Category");}
}
#endregion
#region Reset_Sub_category_By_Category
public void Reset_Sub_category_By_Category(Category i_Category, List<Sub_category> i_Sub_category_List_To_Delete,List<Sub_category> i_Sub_category_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Sub_category oParams_Delete_Sub_category = new Params_Delete_Sub_category();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Sub_category_By_Category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Sub_category_List_To_Delete != null)
{
foreach (var oRow in i_Sub_category_List_To_Delete)
{
oParams_Delete_Sub_category.SUB_CATEGORY_ID = oRow.SUB_CATEGORY_ID;
Delete_Sub_category(oParams_Delete_Sub_category);
}
}
//---------------------------------
// Edit Sub_category
//---------------------------------
Edit_Category_WithSub_category(i_Category, i_Sub_category_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Sub_category_By_Category");}
}
#endregion
#region Edit_Category_With_Sub_category(Category i_Category,List<Sub_category> i_Sub_categoryList)
public void Edit_Category_WithSub_category(Category i_Category,List<Sub_category> i_List_Sub_category)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_WithSub_category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Category(i_Category);
if (i_List_Sub_category != null)
{
foreach(Sub_category oSub_category in i_List_Sub_category)
{
oSub_category.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Sub_category(oSub_category);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_WithSub_category");}
}
#endregion
#region Edit_Category_WithRelatedData(Category i_Category,List<Sub_category> i_List_Sub_category)
public void Edit_Category_WithRelatedData(Category i_Category,List<Sub_category> i_List_Sub_category)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Category_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Category(i_Category);
if (i_List_Sub_category != null)
{
foreach(Sub_category oSub_category in i_List_Sub_category)
{
oSub_category.CATEGORY_ID = i_Category.CATEGORY_ID;
Edit_Sub_category(oSub_category);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Category_WithRelatedData");}
}
#endregion
#region Delete_Category_With_Children(Category i_Category)
public void Delete_Category_With_Children(Category i_Category)
{
 #region Declaration And Initialization Section.
Params_Delete_Category oParams_Delete_Category = new Params_Delete_Category();
Params_Delete_Sub_category_By_CATEGORY_ID oParams_Delete_Sub_category_By_CATEGORY_ID = new Params_Delete_Sub_category_By_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Category_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Sub_category_By_CATEGORY_ID.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Sub_category_By_CATEGORY_ID(oParams_Delete_Sub_category_By_CATEGORY_ID);
//-------------------------

//-------------------------
oParams_Delete_Category.CATEGORY_ID = i_Category.CATEGORY_ID;
Delete_Category(oParams_Delete_Category);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Category_With_Children");}
}
#endregion
#region Reset_Service_prod_By_Sub_category
public void Reset_Service_prod_By_Sub_category(Sub_category i_Sub_category, List<Service_prod> i_Service_prod_List)
{
#region Declaration And Initialization Section.
Params_Delete_Service_prod_By_SUB_CATEGORY_ID oParams_Delete_Service_prod_By_SUB_CATEGORY_ID = new Params_Delete_Service_prod_By_SUB_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Service_prod_By_Sub_category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Service_prod
//---------------------------------
oParams_Delete_Service_prod_By_SUB_CATEGORY_ID.SUB_CATEGORY_ID = i_Sub_category.SUB_CATEGORY_ID;
Delete_Service_prod_By_SUB_CATEGORY_ID(oParams_Delete_Service_prod_By_SUB_CATEGORY_ID);
//---------------------------------
// Edit Service_prod
//---------------------------------
Edit_Sub_category_WithService_prod(i_Sub_category, i_Service_prod_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Service_prod_By_Sub_category");}
}
#endregion
#region Reset_Service_prod_By_Sub_category
public void Reset_Service_prod_By_Sub_category(Sub_category i_Sub_category, List<Service_prod> i_Service_prod_List_To_Delete,List<Service_prod> i_Service_prod_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Service_prod oParams_Delete_Service_prod = new Params_Delete_Service_prod();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Service_prod_By_Sub_category");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Service_prod_List_To_Delete != null)
{
foreach (var oRow in i_Service_prod_List_To_Delete)
{
oParams_Delete_Service_prod.SERVICE_PROD_ID = oRow.SERVICE_PROD_ID;
Delete_Service_prod(oParams_Delete_Service_prod);
}
}
//---------------------------------
// Edit Service_prod
//---------------------------------
Edit_Sub_category_WithService_prod(i_Sub_category, i_Service_prod_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Service_prod_By_Sub_category");}
}
#endregion
#region Edit_Sub_category_With_Service_prod(Sub_category i_Sub_category,List<Service_prod> i_Service_prodList)
public void Edit_Sub_category_WithService_prod(Sub_category i_Sub_category,List<Service_prod> i_List_Service_prod)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Sub_category_WithService_prod");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Sub_category(i_Sub_category);
if (i_List_Service_prod != null)
{
foreach(Service_prod oService_prod in i_List_Service_prod)
{
oService_prod.SUB_CATEGORY_ID = i_Sub_category.SUB_CATEGORY_ID;
Edit_Service_prod(oService_prod);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Sub_category_WithService_prod");}
}
#endregion
#region Edit_Sub_category_WithRelatedData(Sub_category i_Sub_category,List<Service_prod> i_List_Service_prod)
public void Edit_Sub_category_WithRelatedData(Sub_category i_Sub_category,List<Service_prod> i_List_Service_prod)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Sub_category_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Sub_category(i_Sub_category);
if (i_List_Service_prod != null)
{
foreach(Service_prod oService_prod in i_List_Service_prod)
{
oService_prod.SUB_CATEGORY_ID = i_Sub_category.SUB_CATEGORY_ID;
Edit_Service_prod(oService_prod);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Sub_category_WithRelatedData");}
}
#endregion
#region Delete_Sub_category_With_Children(Sub_category i_Sub_category)
public void Delete_Sub_category_With_Children(Sub_category i_Sub_category)
{
 #region Declaration And Initialization Section.
Params_Delete_Sub_category oParams_Delete_Sub_category = new Params_Delete_Sub_category();
Params_Delete_Service_prod_By_SUB_CATEGORY_ID oParams_Delete_Service_prod_By_SUB_CATEGORY_ID = new Params_Delete_Service_prod_By_SUB_CATEGORY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Sub_category_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Service_prod_By_SUB_CATEGORY_ID.SUB_CATEGORY_ID = i_Sub_category.SUB_CATEGORY_ID;
Delete_Service_prod_By_SUB_CATEGORY_ID(oParams_Delete_Service_prod_By_SUB_CATEGORY_ID);
//-------------------------

//-------------------------
oParams_Delete_Sub_category.SUB_CATEGORY_ID = i_Sub_category.SUB_CATEGORY_ID;
Delete_Sub_category(oParams_Delete_Sub_category);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Sub_category_With_Children");}
}
#endregion
#region Reset_Booking_By_Status
public void Reset_Booking_By_Status(Status i_Status, List<Booking> i_Booking_List)
{
#region Declaration And Initialization Section.
Params_Delete_Booking_By_STATUS_ID oParams_Delete_Booking_By_STATUS_ID = new Params_Delete_Booking_By_STATUS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Status");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Booking
//---------------------------------
oParams_Delete_Booking_By_STATUS_ID.STATUS_ID = i_Status.STATUS_ID;
Delete_Booking_By_STATUS_ID(oParams_Delete_Booking_By_STATUS_ID);
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Status_WithBooking(i_Status, i_Booking_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Status");}
}
#endregion
#region Reset_Booking_By_Status
public void Reset_Booking_By_Status(Status i_Status, List<Booking> i_Booking_List_To_Delete,List<Booking> i_Booking_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Booking oParams_Delete_Booking = new Params_Delete_Booking();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Status");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Booking_List_To_Delete != null)
{
foreach (var oRow in i_Booking_List_To_Delete)
{
oParams_Delete_Booking.BOOKING_ID = oRow.BOOKING_ID;
Delete_Booking(oParams_Delete_Booking);
}
}
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Status_WithBooking(i_Status, i_Booking_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Status");}
}
#endregion
#region Edit_Status_With_Booking(Status i_Status,List<Booking> i_BookingList)
public void Edit_Status_WithBooking(Status i_Status,List<Booking> i_List_Booking)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Status_WithBooking");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Status(i_Status);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.STATUS_ID = i_Status.STATUS_ID;
Edit_Booking(oBooking);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Status_WithBooking");}
}
#endregion
#region Edit_Status_WithRelatedData(Status i_Status,List<Booking> i_List_Booking)
public void Edit_Status_WithRelatedData(Status i_Status,List<Booking> i_List_Booking)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Status_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Status(i_Status);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.STATUS_ID = i_Status.STATUS_ID;
Edit_Booking(oBooking);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Status_WithRelatedData");}
}
#endregion
#region Delete_Status_With_Children(Status i_Status)
public void Delete_Status_With_Children(Status i_Status)
{
 #region Declaration And Initialization Section.
Params_Delete_Status oParams_Delete_Status = new Params_Delete_Status();
Params_Delete_Booking_By_STATUS_ID oParams_Delete_Booking_By_STATUS_ID = new Params_Delete_Booking_By_STATUS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Status_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Booking_By_STATUS_ID.STATUS_ID = i_Status.STATUS_ID;
Delete_Booking_By_STATUS_ID(oParams_Delete_Booking_By_STATUS_ID);
//-------------------------

//-------------------------
oParams_Delete_Status.STATUS_ID = i_Status.STATUS_ID;
Delete_Status(oParams_Delete_Status);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Status_With_Children");}
}
#endregion
#region Reset_Coordinates_By_Booking
public void Reset_Coordinates_By_Booking(Booking i_Booking, List<Coordinates> i_Coordinates_List)
{
#region Declaration And Initialization Section.
Params_Delete_Coordinates_By_BOOKING_ID oParams_Delete_Coordinates_By_BOOKING_ID = new Params_Delete_Coordinates_By_BOOKING_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Coordinates_By_Booking");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Coordinates
//---------------------------------
oParams_Delete_Coordinates_By_BOOKING_ID.BOOKING_ID = i_Booking.BOOKING_ID;
Delete_Coordinates_By_BOOKING_ID(oParams_Delete_Coordinates_By_BOOKING_ID);
//---------------------------------
// Edit Coordinates
//---------------------------------
Edit_Booking_WithCoordinates(i_Booking, i_Coordinates_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Coordinates_By_Booking");}
}
#endregion
#region Reset_Coordinates_By_Booking
public void Reset_Coordinates_By_Booking(Booking i_Booking, List<Coordinates> i_Coordinates_List_To_Delete,List<Coordinates> i_Coordinates_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Coordinates oParams_Delete_Coordinates = new Params_Delete_Coordinates();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Coordinates_By_Booking");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Coordinates_List_To_Delete != null)
{
foreach (var oRow in i_Coordinates_List_To_Delete)
{
oParams_Delete_Coordinates.COORDINATES_ID = oRow.COORDINATES_ID;
Delete_Coordinates(oParams_Delete_Coordinates);
}
}
//---------------------------------
// Edit Coordinates
//---------------------------------
Edit_Booking_WithCoordinates(i_Booking, i_Coordinates_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Coordinates_By_Booking");}
}
#endregion
#region Edit_Booking_With_Coordinates(Booking i_Booking,List<Coordinates> i_CoordinatesList)
public void Edit_Booking_WithCoordinates(Booking i_Booking,List<Coordinates> i_List_Coordinates)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Booking_WithCoordinates");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Booking(i_Booking);
if (i_List_Coordinates != null)
{
foreach(Coordinates oCoordinates in i_List_Coordinates)
{
oCoordinates.BOOKING_ID = i_Booking.BOOKING_ID;
Edit_Coordinates(oCoordinates);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Booking_WithCoordinates");}
}
#endregion
#region Reset_Feedback_By_Booking
public void Reset_Feedback_By_Booking(Booking i_Booking, List<Feedback> i_Feedback_List)
{
#region Declaration And Initialization Section.
Params_Delete_Feedback_By_BOOKING_ID oParams_Delete_Feedback_By_BOOKING_ID = new Params_Delete_Feedback_By_BOOKING_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Feedback_By_Booking");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Feedback
//---------------------------------
oParams_Delete_Feedback_By_BOOKING_ID.BOOKING_ID = i_Booking.BOOKING_ID;
Delete_Feedback_By_BOOKING_ID(oParams_Delete_Feedback_By_BOOKING_ID);
//---------------------------------
// Edit Feedback
//---------------------------------
Edit_Booking_WithFeedback(i_Booking, i_Feedback_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Feedback_By_Booking");}
}
#endregion
#region Reset_Feedback_By_Booking
public void Reset_Feedback_By_Booking(Booking i_Booking, List<Feedback> i_Feedback_List_To_Delete,List<Feedback> i_Feedback_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Feedback oParams_Delete_Feedback = new Params_Delete_Feedback();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Feedback_By_Booking");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Feedback_List_To_Delete != null)
{
foreach (var oRow in i_Feedback_List_To_Delete)
{
oParams_Delete_Feedback.FEEDBACK_ID = oRow.FEEDBACK_ID;
Delete_Feedback(oParams_Delete_Feedback);
}
}
//---------------------------------
// Edit Feedback
//---------------------------------
Edit_Booking_WithFeedback(i_Booking, i_Feedback_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Feedback_By_Booking");}
}
#endregion
#region Edit_Booking_With_Feedback(Booking i_Booking,List<Feedback> i_FeedbackList)
public void Edit_Booking_WithFeedback(Booking i_Booking,List<Feedback> i_List_Feedback)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Booking_WithFeedback");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Booking(i_Booking);
if (i_List_Feedback != null)
{
foreach(Feedback oFeedback in i_List_Feedback)
{
oFeedback.BOOKING_ID = i_Booking.BOOKING_ID;
Edit_Feedback(oFeedback);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Booking_WithFeedback");}
}
#endregion
#region Edit_Booking_WithRelatedData(Booking i_Booking,List<Coordinates> i_List_Coordinates,List<Feedback> i_List_Feedback)
public void Edit_Booking_WithRelatedData(Booking i_Booking,List<Coordinates> i_List_Coordinates,List<Feedback> i_List_Feedback)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Booking_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Booking(i_Booking);
if (i_List_Coordinates != null)
{
foreach(Coordinates oCoordinates in i_List_Coordinates)
{
oCoordinates.BOOKING_ID = i_Booking.BOOKING_ID;
Edit_Coordinates(oCoordinates);
}
}
if (i_List_Feedback != null)
{
foreach(Feedback oFeedback in i_List_Feedback)
{
oFeedback.BOOKING_ID = i_Booking.BOOKING_ID;
Edit_Feedback(oFeedback);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Booking_WithRelatedData");}
}
#endregion
#region Delete_Booking_With_Children(Booking i_Booking)
public void Delete_Booking_With_Children(Booking i_Booking)
{
 #region Declaration And Initialization Section.
Params_Delete_Booking oParams_Delete_Booking = new Params_Delete_Booking();
Params_Delete_Coordinates_By_BOOKING_ID oParams_Delete_Coordinates_By_BOOKING_ID = new Params_Delete_Coordinates_By_BOOKING_ID();
Params_Delete_Feedback_By_BOOKING_ID oParams_Delete_Feedback_By_BOOKING_ID = new Params_Delete_Feedback_By_BOOKING_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Booking_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Coordinates_By_BOOKING_ID.BOOKING_ID = i_Booking.BOOKING_ID;
Delete_Coordinates_By_BOOKING_ID(oParams_Delete_Coordinates_By_BOOKING_ID);
oParams_Delete_Feedback_By_BOOKING_ID.BOOKING_ID = i_Booking.BOOKING_ID;
Delete_Feedback_By_BOOKING_ID(oParams_Delete_Feedback_By_BOOKING_ID);
//-------------------------

//-------------------------
oParams_Delete_Booking.BOOKING_ID = i_Booking.BOOKING_ID;
Delete_Booking(oParams_Delete_Booking);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Booking_With_Children");}
}
#endregion
#region Reset_Booking_By_Business
public void Reset_Booking_By_Business(Business i_Business, List<Booking> i_Booking_List)
{
#region Declaration And Initialization Section.
Params_Delete_Booking_By_BUSINESS_ID oParams_Delete_Booking_By_BUSINESS_ID = new Params_Delete_Booking_By_BUSINESS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Business");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Booking
//---------------------------------
oParams_Delete_Booking_By_BUSINESS_ID.BUSINESS_ID = i_Business.BUSINESS_ID;
Delete_Booking_By_BUSINESS_ID(oParams_Delete_Booking_By_BUSINESS_ID);
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Business_WithBooking(i_Business, i_Booking_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Business");}
}
#endregion
#region Reset_Booking_By_Business
public void Reset_Booking_By_Business(Business i_Business, List<Booking> i_Booking_List_To_Delete,List<Booking> i_Booking_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Booking oParams_Delete_Booking = new Params_Delete_Booking();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Business");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Booking_List_To_Delete != null)
{
foreach (var oRow in i_Booking_List_To_Delete)
{
oParams_Delete_Booking.BOOKING_ID = oRow.BOOKING_ID;
Delete_Booking(oParams_Delete_Booking);
}
}
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Business_WithBooking(i_Business, i_Booking_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Business");}
}
#endregion
#region Edit_Business_With_Booking(Business i_Business,List<Booking> i_BookingList)
public void Edit_Business_WithBooking(Business i_Business,List<Booking> i_List_Booking)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Business_WithBooking");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Business(i_Business);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.BUSINESS_ID = i_Business.BUSINESS_ID;
Edit_Booking(oBooking);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Business_WithBooking");}
}
#endregion
#region Reset_Service_prod_By_Business
public void Reset_Service_prod_By_Business(Business i_Business, List<Service_prod> i_Service_prod_List)
{
#region Declaration And Initialization Section.
Params_Delete_Service_prod_By_BUSINESS_ID oParams_Delete_Service_prod_By_BUSINESS_ID = new Params_Delete_Service_prod_By_BUSINESS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Service_prod_By_Business");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Service_prod
//---------------------------------
oParams_Delete_Service_prod_By_BUSINESS_ID.BUSINESS_ID = i_Business.BUSINESS_ID;
Delete_Service_prod_By_BUSINESS_ID(oParams_Delete_Service_prod_By_BUSINESS_ID);
//---------------------------------
// Edit Service_prod
//---------------------------------
Edit_Business_WithService_prod(i_Business, i_Service_prod_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Service_prod_By_Business");}
}
#endregion
#region Reset_Service_prod_By_Business
public void Reset_Service_prod_By_Business(Business i_Business, List<Service_prod> i_Service_prod_List_To_Delete,List<Service_prod> i_Service_prod_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Service_prod oParams_Delete_Service_prod = new Params_Delete_Service_prod();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Service_prod_By_Business");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Service_prod_List_To_Delete != null)
{
foreach (var oRow in i_Service_prod_List_To_Delete)
{
oParams_Delete_Service_prod.SERVICE_PROD_ID = oRow.SERVICE_PROD_ID;
Delete_Service_prod(oParams_Delete_Service_prod);
}
}
//---------------------------------
// Edit Service_prod
//---------------------------------
Edit_Business_WithService_prod(i_Business, i_Service_prod_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Service_prod_By_Business");}
}
#endregion
#region Edit_Business_With_Service_prod(Business i_Business,List<Service_prod> i_Service_prodList)
public void Edit_Business_WithService_prod(Business i_Business,List<Service_prod> i_List_Service_prod)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Business_WithService_prod");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Business(i_Business);
if (i_List_Service_prod != null)
{
foreach(Service_prod oService_prod in i_List_Service_prod)
{
oService_prod.BUSINESS_ID = i_Business.BUSINESS_ID;
Edit_Service_prod(oService_prod);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Business_WithService_prod");}
}
#endregion
#region Reset_Work_list_By_Business
public void Reset_Work_list_By_Business(Business i_Business, List<Work_list> i_Work_list_List)
{
#region Declaration And Initialization Section.
Params_Delete_Work_list_By_BUSINESS_ID oParams_Delete_Work_list_By_BUSINESS_ID = new Params_Delete_Work_list_By_BUSINESS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Work_list_By_Business");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Work_list
//---------------------------------
oParams_Delete_Work_list_By_BUSINESS_ID.BUSINESS_ID = i_Business.BUSINESS_ID;
Delete_Work_list_By_BUSINESS_ID(oParams_Delete_Work_list_By_BUSINESS_ID);
//---------------------------------
// Edit Work_list
//---------------------------------
Edit_Business_WithWork_list(i_Business, i_Work_list_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Work_list_By_Business");}
}
#endregion
#region Reset_Work_list_By_Business
public void Reset_Work_list_By_Business(Business i_Business, List<Work_list> i_Work_list_List_To_Delete,List<Work_list> i_Work_list_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Work_list oParams_Delete_Work_list = new Params_Delete_Work_list();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Work_list_By_Business");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Work_list_List_To_Delete != null)
{
foreach (var oRow in i_Work_list_List_To_Delete)
{
oParams_Delete_Work_list.WORK_LIST_ID = oRow.WORK_LIST_ID;
Delete_Work_list(oParams_Delete_Work_list);
}
}
//---------------------------------
// Edit Work_list
//---------------------------------
Edit_Business_WithWork_list(i_Business, i_Work_list_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Work_list_By_Business");}
}
#endregion
#region Edit_Business_With_Work_list(Business i_Business,List<Work_list> i_Work_listList)
public void Edit_Business_WithWork_list(Business i_Business,List<Work_list> i_List_Work_list)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Business_WithWork_list");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Business(i_Business);
if (i_List_Work_list != null)
{
foreach(Work_list oWork_list in i_List_Work_list)
{
oWork_list.BUSINESS_ID = i_Business.BUSINESS_ID;
Edit_Work_list(oWork_list);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Business_WithWork_list");}
}
#endregion
#region Edit_Business_WithRelatedData(Business i_Business,List<Booking> i_List_Booking,List<Service_prod> i_List_Service_prod,List<Work_list> i_List_Work_list)
public void Edit_Business_WithRelatedData(Business i_Business,List<Booking> i_List_Booking,List<Service_prod> i_List_Service_prod,List<Work_list> i_List_Work_list)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Business_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Business(i_Business);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.BUSINESS_ID = i_Business.BUSINESS_ID;
Edit_Booking(oBooking);
}
}
if (i_List_Service_prod != null)
{
foreach(Service_prod oService_prod in i_List_Service_prod)
{
oService_prod.BUSINESS_ID = i_Business.BUSINESS_ID;
Edit_Service_prod(oService_prod);
}
}
if (i_List_Work_list != null)
{
foreach(Work_list oWork_list in i_List_Work_list)
{
oWork_list.BUSINESS_ID = i_Business.BUSINESS_ID;
Edit_Work_list(oWork_list);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Business_WithRelatedData");}
}
#endregion
#region Delete_Business_With_Children(Business i_Business)
public void Delete_Business_With_Children(Business i_Business)
{
 #region Declaration And Initialization Section.
Params_Delete_Business oParams_Delete_Business = new Params_Delete_Business();
Params_Delete_Booking_By_BUSINESS_ID oParams_Delete_Booking_By_BUSINESS_ID = new Params_Delete_Booking_By_BUSINESS_ID();
Params_Delete_Service_prod_By_BUSINESS_ID oParams_Delete_Service_prod_By_BUSINESS_ID = new Params_Delete_Service_prod_By_BUSINESS_ID();
Params_Delete_Work_list_By_BUSINESS_ID oParams_Delete_Work_list_By_BUSINESS_ID = new Params_Delete_Work_list_By_BUSINESS_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Business_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Booking_By_BUSINESS_ID.BUSINESS_ID = i_Business.BUSINESS_ID;
Delete_Booking_By_BUSINESS_ID(oParams_Delete_Booking_By_BUSINESS_ID);
oParams_Delete_Service_prod_By_BUSINESS_ID.BUSINESS_ID = i_Business.BUSINESS_ID;
Delete_Service_prod_By_BUSINESS_ID(oParams_Delete_Service_prod_By_BUSINESS_ID);
oParams_Delete_Work_list_By_BUSINESS_ID.BUSINESS_ID = i_Business.BUSINESS_ID;
Delete_Work_list_By_BUSINESS_ID(oParams_Delete_Work_list_By_BUSINESS_ID);
//-------------------------

//-------------------------
oParams_Delete_Business.BUSINESS_ID = i_Business.BUSINESS_ID;
Delete_Business(oParams_Delete_Business);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Business_With_Children");}
}
#endregion
#region Reset_Booking_By_Work_area
public void Reset_Booking_By_Work_area(Work_area i_Work_area, List<Booking> i_Booking_List)
{
#region Declaration And Initialization Section.
Params_Delete_Booking_By_WORK_AREA_ID oParams_Delete_Booking_By_WORK_AREA_ID = new Params_Delete_Booking_By_WORK_AREA_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Work_area");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Booking
//---------------------------------
oParams_Delete_Booking_By_WORK_AREA_ID.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
Delete_Booking_By_WORK_AREA_ID(oParams_Delete_Booking_By_WORK_AREA_ID);
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Work_area_WithBooking(i_Work_area, i_Booking_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Work_area");}
}
#endregion
#region Reset_Booking_By_Work_area
public void Reset_Booking_By_Work_area(Work_area i_Work_area, List<Booking> i_Booking_List_To_Delete,List<Booking> i_Booking_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Booking oParams_Delete_Booking = new Params_Delete_Booking();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Booking_By_Work_area");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Booking_List_To_Delete != null)
{
foreach (var oRow in i_Booking_List_To_Delete)
{
oParams_Delete_Booking.BOOKING_ID = oRow.BOOKING_ID;
Delete_Booking(oParams_Delete_Booking);
}
}
//---------------------------------
// Edit Booking
//---------------------------------
Edit_Work_area_WithBooking(i_Work_area, i_Booking_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Booking_By_Work_area");}
}
#endregion
#region Edit_Work_area_With_Booking(Work_area i_Work_area,List<Booking> i_BookingList)
public void Edit_Work_area_WithBooking(Work_area i_Work_area,List<Booking> i_List_Booking)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Work_area_WithBooking");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Work_area(i_Work_area);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
Edit_Booking(oBooking);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Work_area_WithBooking");}
}
#endregion
#region Reset_Work_list_By_Work_area
public void Reset_Work_list_By_Work_area(Work_area i_Work_area, List<Work_list> i_Work_list_List)
{
#region Declaration And Initialization Section.
Params_Delete_Work_list_By_WORK_AREA_ID oParams_Delete_Work_list_By_WORK_AREA_ID = new Params_Delete_Work_list_By_WORK_AREA_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Work_list_By_Work_area");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Work_list
//---------------------------------
oParams_Delete_Work_list_By_WORK_AREA_ID.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
Delete_Work_list_By_WORK_AREA_ID(oParams_Delete_Work_list_By_WORK_AREA_ID);
//---------------------------------
// Edit Work_list
//---------------------------------
Edit_Work_area_WithWork_list(i_Work_area, i_Work_list_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Work_list_By_Work_area");}
}
#endregion
#region Reset_Work_list_By_Work_area
public void Reset_Work_list_By_Work_area(Work_area i_Work_area, List<Work_list> i_Work_list_List_To_Delete,List<Work_list> i_Work_list_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Work_list oParams_Delete_Work_list = new Params_Delete_Work_list();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Work_list_By_Work_area");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Work_list_List_To_Delete != null)
{
foreach (var oRow in i_Work_list_List_To_Delete)
{
oParams_Delete_Work_list.WORK_LIST_ID = oRow.WORK_LIST_ID;
Delete_Work_list(oParams_Delete_Work_list);
}
}
//---------------------------------
// Edit Work_list
//---------------------------------
Edit_Work_area_WithWork_list(i_Work_area, i_Work_list_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Work_list_By_Work_area");}
}
#endregion
#region Edit_Work_area_With_Work_list(Work_area i_Work_area,List<Work_list> i_Work_listList)
public void Edit_Work_area_WithWork_list(Work_area i_Work_area,List<Work_list> i_List_Work_list)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Work_area_WithWork_list");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Work_area(i_Work_area);
if (i_List_Work_list != null)
{
foreach(Work_list oWork_list in i_List_Work_list)
{
oWork_list.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
Edit_Work_list(oWork_list);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Work_area_WithWork_list");}
}
#endregion
#region Edit_Work_area_WithRelatedData(Work_area i_Work_area,List<Booking> i_List_Booking,List<Work_list> i_List_Work_list)
public void Edit_Work_area_WithRelatedData(Work_area i_Work_area,List<Booking> i_List_Booking,List<Work_list> i_List_Work_list)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Work_area_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Work_area(i_Work_area);
if (i_List_Booking != null)
{
foreach(Booking oBooking in i_List_Booking)
{
oBooking.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
Edit_Booking(oBooking);
}
}
if (i_List_Work_list != null)
{
foreach(Work_list oWork_list in i_List_Work_list)
{
oWork_list.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
Edit_Work_list(oWork_list);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Work_area_WithRelatedData");}
}
#endregion
#region Delete_Work_area_With_Children(Work_area i_Work_area)
public void Delete_Work_area_With_Children(Work_area i_Work_area)
{
 #region Declaration And Initialization Section.
Params_Delete_Work_area oParams_Delete_Work_area = new Params_Delete_Work_area();
Params_Delete_Booking_By_WORK_AREA_ID oParams_Delete_Booking_By_WORK_AREA_ID = new Params_Delete_Booking_By_WORK_AREA_ID();
Params_Delete_Work_list_By_WORK_AREA_ID oParams_Delete_Work_list_By_WORK_AREA_ID = new Params_Delete_Work_list_By_WORK_AREA_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Work_area_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Booking_By_WORK_AREA_ID.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
Delete_Booking_By_WORK_AREA_ID(oParams_Delete_Booking_By_WORK_AREA_ID);
oParams_Delete_Work_list_By_WORK_AREA_ID.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
Delete_Work_list_By_WORK_AREA_ID(oParams_Delete_Work_list_By_WORK_AREA_ID);
//-------------------------

//-------------------------
oParams_Delete_Work_area.WORK_AREA_ID = i_Work_area.WORK_AREA_ID;
Delete_Work_area(oParams_Delete_Work_area);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Work_area_With_Children");}
}
#endregion
}
}
