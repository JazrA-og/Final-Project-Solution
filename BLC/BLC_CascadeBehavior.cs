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
#region BLC_OnPreEvent_Delete_Business_Cascade
void BLC_OnPreEvent_Delete_Business_Cascade(Params_Delete_Business i_Params_Delete_Business)
{
#region Declaration And Initialization Section.
Params_Delete_Service_prod_By_BUSINESS_ID oParams_Delete_Service_prod_By_BUSINESS_ID = new Params_Delete_Service_prod_By_BUSINESS_ID();
Params_Delete_Work_list_By_BUSINESS_ID oParams_Delete_Work_list_By_BUSINESS_ID = new Params_Delete_Work_list_By_BUSINESS_ID();
#endregion
#region Body Section.
// Delete related Service_prod entries
// -----------------
oParams_Delete_Service_prod_By_BUSINESS_ID = new Params_Delete_Service_prod_By_BUSINESS_ID();
oParams_Delete_Service_prod_By_BUSINESS_ID.BUSINESS_ID = i_Params_Delete_Business.BUSINESS_ID;
Delete_Service_prod_By_BUSINESS_ID(oParams_Delete_Service_prod_By_BUSINESS_ID);
// -----------------
// Delete related Work_list entries
// -----------------
oParams_Delete_Work_list_By_BUSINESS_ID = new Params_Delete_Work_list_By_BUSINESS_ID();
oParams_Delete_Work_list_By_BUSINESS_ID.BUSINESS_ID = i_Params_Delete_Business.BUSINESS_ID;
Delete_Work_list_By_BUSINESS_ID(oParams_Delete_Work_list_By_BUSINESS_ID);
// -----------------
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Booking_Cascade
void BLC_OnPreEvent_Delete_Booking_Cascade(Params_Delete_Booking i_Params_Delete_Booking)
{
#region Declaration And Initialization Section.
Params_Delete_Feedback_By_BOOKING_ID oParams_Delete_Feedback_By_BOOKING_ID = new Params_Delete_Feedback_By_BOOKING_ID();
#endregion
#region Body Section.
// Delete related Feedback entries
// -----------------
oParams_Delete_Feedback_By_BOOKING_ID = new Params_Delete_Feedback_By_BOOKING_ID();
oParams_Delete_Feedback_By_BOOKING_ID.BOOKING_ID = i_Params_Delete_Booking.BOOKING_ID;
Delete_Feedback_By_BOOKING_ID(oParams_Delete_Feedback_By_BOOKING_ID);
// -----------------
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Service_prod_Cascade
void BLC_OnPreEvent_Delete_Service_prod_Cascade(Params_Delete_Service_prod i_Params_Delete_Service_prod)
{
#region Declaration And Initialization Section.
Params_Delete_Booking_By_SERVICE_PROD_ID oParams_Delete_Booking_By_SERVICE_PROD_ID = new Params_Delete_Booking_By_SERVICE_PROD_ID();
Params_Delete_Boost_listing_By_SERVICE_PROD_ID oParams_Delete_Boost_listing_By_SERVICE_PROD_ID = new Params_Delete_Boost_listing_By_SERVICE_PROD_ID();
#endregion
#region Body Section.
// Delete related Booking entries
// -----------------
oParams_Delete_Booking_By_SERVICE_PROD_ID = new Params_Delete_Booking_By_SERVICE_PROD_ID();
oParams_Delete_Booking_By_SERVICE_PROD_ID.SERVICE_PROD_ID = i_Params_Delete_Service_prod.SERVICE_PROD_ID;
Delete_Booking_By_SERVICE_PROD_ID(oParams_Delete_Booking_By_SERVICE_PROD_ID);
// -----------------
// Delete related Boost_listing entries
// -----------------
oParams_Delete_Boost_listing_By_SERVICE_PROD_ID = new Params_Delete_Boost_listing_By_SERVICE_PROD_ID();
oParams_Delete_Boost_listing_By_SERVICE_PROD_ID.SERVICE_PROD_ID = i_Params_Delete_Service_prod.SERVICE_PROD_ID;
Delete_Boost_listing_By_SERVICE_PROD_ID(oParams_Delete_Boost_listing_By_SERVICE_PROD_ID);
// -----------------
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Boost_pricing_Cascade
void BLC_OnPreEvent_Delete_Boost_pricing_Cascade(Params_Delete_Boost_pricing i_Params_Delete_Boost_pricing)
{
#region Declaration And Initialization Section.
Params_Delete_Boost_listing_By_BOOST_PRICING_ID oParams_Delete_Boost_listing_By_BOOST_PRICING_ID = new Params_Delete_Boost_listing_By_BOOST_PRICING_ID();
#endregion
#region Body Section.
// Delete related Boost_listing entries
// -----------------
oParams_Delete_Boost_listing_By_BOOST_PRICING_ID = new Params_Delete_Boost_listing_By_BOOST_PRICING_ID();
oParams_Delete_Boost_listing_By_BOOST_PRICING_ID.BOOST_PRICING_ID = i_Params_Delete_Boost_pricing.BOOST_PRICING_ID;
Delete_Boost_listing_By_BOOST_PRICING_ID(oParams_Delete_Boost_listing_By_BOOST_PRICING_ID);
// -----------------
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Category_Cascade
void BLC_OnPreEvent_Delete_Category_Cascade(Params_Delete_Category i_Params_Delete_Category)
{
#region Declaration And Initialization Section.
Params_Delete_Sub_category_By_CATEGORY_ID oParams_Delete_Sub_category_By_CATEGORY_ID = new Params_Delete_Sub_category_By_CATEGORY_ID();
#endregion
#region Body Section.
// Delete related Sub_category entries
// -----------------
oParams_Delete_Sub_category_By_CATEGORY_ID = new Params_Delete_Sub_category_By_CATEGORY_ID();
oParams_Delete_Sub_category_By_CATEGORY_ID.CATEGORY_ID = i_Params_Delete_Category.CATEGORY_ID;
Delete_Sub_category_By_CATEGORY_ID(oParams_Delete_Sub_category_By_CATEGORY_ID);
// -----------------
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Client_Cascade
void BLC_OnPreEvent_Delete_Client_Cascade(Params_Delete_Client i_Params_Delete_Client)
{
#region Declaration And Initialization Section.
Params_Delete_Booking_By_CLIENT_ID oParams_Delete_Booking_By_CLIENT_ID = new Params_Delete_Booking_By_CLIENT_ID();
#endregion
#region Body Section.
// Delete related Booking entries
// -----------------
oParams_Delete_Booking_By_CLIENT_ID = new Params_Delete_Booking_By_CLIENT_ID();
oParams_Delete_Booking_By_CLIENT_ID.CLIENT_ID = i_Params_Delete_Client.CLIENT_ID;
Delete_Booking_By_CLIENT_ID(oParams_Delete_Booking_By_CLIENT_ID);
// -----------------
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Status_Cascade
void BLC_OnPreEvent_Delete_Status_Cascade(Params_Delete_Status i_Params_Delete_Status)
{
#region Declaration And Initialization Section.
Params_Delete_Booking_By_STATUS_ID oParams_Delete_Booking_By_STATUS_ID = new Params_Delete_Booking_By_STATUS_ID();
#endregion
#region Body Section.
// Delete related Booking entries
// -----------------
oParams_Delete_Booking_By_STATUS_ID = new Params_Delete_Booking_By_STATUS_ID();
oParams_Delete_Booking_By_STATUS_ID.STATUS_ID = i_Params_Delete_Status.STATUS_ID;
Delete_Booking_By_STATUS_ID(oParams_Delete_Booking_By_STATUS_ID);
// -----------------
#endregion
}
#endregion
#region BLC_OnPreEvent_Delete_Work_area_Cascade
void BLC_OnPreEvent_Delete_Work_area_Cascade(Params_Delete_Work_area i_Params_Delete_Work_area)
{
#region Declaration And Initialization Section.
Params_Delete_Booking_By_WORK_AREA_ID oParams_Delete_Booking_By_WORK_AREA_ID = new Params_Delete_Booking_By_WORK_AREA_ID();
Params_Delete_Work_list_By_WORK_AREA_ID oParams_Delete_Work_list_By_WORK_AREA_ID = new Params_Delete_Work_list_By_WORK_AREA_ID();
#endregion
#region Body Section.
// Delete related Booking entries
// -----------------
oParams_Delete_Booking_By_WORK_AREA_ID = new Params_Delete_Booking_By_WORK_AREA_ID();
oParams_Delete_Booking_By_WORK_AREA_ID.WORK_AREA_ID = i_Params_Delete_Work_area.WORK_AREA_ID;
Delete_Booking_By_WORK_AREA_ID(oParams_Delete_Booking_By_WORK_AREA_ID);
// -----------------
// Delete related Work_list entries
// -----------------
oParams_Delete_Work_list_By_WORK_AREA_ID = new Params_Delete_Work_list_By_WORK_AREA_ID();
oParams_Delete_Work_list_By_WORK_AREA_ID.WORK_AREA_ID = i_Params_Delete_Work_area.WORK_AREA_ID;
Delete_Work_list_By_WORK_AREA_ID(oParams_Delete_Work_list_By_WORK_AREA_ID);
// -----------------
#endregion
}
#endregion
#region Initialize_Cascade_Mechanism
public void Initialize_Cascade_Mechanism()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.OnPreEvent_Delete_Business +=new PreEvent_Handler_Delete_Business(BLC_OnPreEvent_Delete_Business_Cascade);
this.OnPreEvent_Delete_Booking +=new PreEvent_Handler_Delete_Booking(BLC_OnPreEvent_Delete_Booking_Cascade);
this.OnPreEvent_Delete_Service_prod +=new PreEvent_Handler_Delete_Service_prod(BLC_OnPreEvent_Delete_Service_prod_Cascade);
this.OnPreEvent_Delete_Boost_pricing +=new PreEvent_Handler_Delete_Boost_pricing(BLC_OnPreEvent_Delete_Boost_pricing_Cascade);
this.OnPreEvent_Delete_Category +=new PreEvent_Handler_Delete_Category(BLC_OnPreEvent_Delete_Category_Cascade);
this.OnPreEvent_Delete_Client +=new PreEvent_Handler_Delete_Client(BLC_OnPreEvent_Delete_Client_Cascade);
this.OnPreEvent_Delete_Status +=new PreEvent_Handler_Delete_Status(BLC_OnPreEvent_Delete_Status_Cascade);
this.OnPreEvent_Delete_Work_area +=new PreEvent_Handler_Delete_Work_area(BLC_OnPreEvent_Delete_Work_area_Cascade);

#endregion
}
#endregion
}
}
