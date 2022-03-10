using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BLC;
[Route("api/[controller]")]
[ApiController]
public partial class DataController : ControllerBase
{
#region Members
#endregion
#region Extract_Ticket
private string Extract_Ticket()
{
#region Declaration And Initialization Section.
string str_Ticket = string.Empty;
#endregion
if(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null)
{
str_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
#region Return Section.
return str_Ticket;
#endregion
}
#endregion
#region IsValidWebTicket
private bool IsValidWebTicket(string i_Input)
{
#region Declaration And Initialization Section.
bool Is_Valid = false;
BLCInitializer oBLCInitializer = new BLCInitializer();
#endregion
#region Body Section.
BLC.BLC oBLC_Default = new BLC.BLC();
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
Is_Valid = oBLC.IsValidTicket(i_Input);
}
#endregion
#region Return Section.
return Is_Valid;
#endregion
}
#endregion
#region Authenticate
[HttpPost]
[Route("Authenticate")]
public Result_Authenticate Authenticate(Params_Authenticate i_Params_Authenticate)
{
#region Declaration And Initialization Section.
User oReturnValue = new User();
string i_Ticket = string.Empty;
Result_Authenticate oResult_Authenticate = new Result_Authenticate();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Authenticate(i_Params_Authenticate);
oResult_Authenticate.My_Result = oReturnValue;
oResult_Authenticate.My_Params_Authenticate = i_Params_Authenticate;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Authenticate.ExceptionMsg = string.Format("Authenticate : {0}", ex.Message);
}
else
{
oResult_Authenticate.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Authenticate;
#endregion
}
#endregion
#region Delete_Admin
[HttpPost]
[Route("Delete_Admin")]
public Result_Delete_Admin Delete_Admin(Params_Delete_Admin i_Params_Delete_Admin)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Admin oResult_Delete_Admin = new Result_Delete_Admin();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Admin);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Admin(i_Params_Delete_Admin);
oResult_Delete_Admin.My_Params_Delete_Admin = i_Params_Delete_Admin;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Admin.ExceptionMsg = string.Format("Delete_Admin : {0}", ex.Message);
}
else
{
oResult_Delete_Admin.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Admin;
#endregion
}
#endregion
#region Delete_Booking
[HttpPost]
[Route("Delete_Booking")]
public Result_Delete_Booking Delete_Booking(Params_Delete_Booking i_Params_Delete_Booking)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Booking oResult_Delete_Booking = new Result_Delete_Booking();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Booking);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Booking(i_Params_Delete_Booking);
oResult_Delete_Booking.My_Params_Delete_Booking = i_Params_Delete_Booking;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Booking.ExceptionMsg = string.Format("Delete_Booking : {0}", ex.Message);
}
else
{
oResult_Delete_Booking.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Booking;
#endregion
}
#endregion
#region Delete_Boost_listing
[HttpPost]
[Route("Delete_Boost_listing")]
public Result_Delete_Boost_listing Delete_Boost_listing(Params_Delete_Boost_listing i_Params_Delete_Boost_listing)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Boost_listing oResult_Delete_Boost_listing = new Result_Delete_Boost_listing();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Boost_listing);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Boost_listing(i_Params_Delete_Boost_listing);
oResult_Delete_Boost_listing.My_Params_Delete_Boost_listing = i_Params_Delete_Boost_listing;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Boost_listing.ExceptionMsg = string.Format("Delete_Boost_listing : {0}", ex.Message);
}
else
{
oResult_Delete_Boost_listing.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Boost_listing;
#endregion
}
#endregion
#region Delete_Boost_pricing
[HttpPost]
[Route("Delete_Boost_pricing")]
public Result_Delete_Boost_pricing Delete_Boost_pricing(Params_Delete_Boost_pricing i_Params_Delete_Boost_pricing)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Boost_pricing oResult_Delete_Boost_pricing = new Result_Delete_Boost_pricing();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Boost_pricing);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Boost_pricing(i_Params_Delete_Boost_pricing);
oResult_Delete_Boost_pricing.My_Params_Delete_Boost_pricing = i_Params_Delete_Boost_pricing;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Boost_pricing.ExceptionMsg = string.Format("Delete_Boost_pricing : {0}", ex.Message);
}
else
{
oResult_Delete_Boost_pricing.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Boost_pricing;
#endregion
}
#endregion
#region Delete_Business
[HttpPost]
[Route("Delete_Business")]
public Result_Delete_Business Delete_Business(Params_Delete_Business i_Params_Delete_Business)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Business oResult_Delete_Business = new Result_Delete_Business();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Business);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Business(i_Params_Delete_Business);
oResult_Delete_Business.My_Params_Delete_Business = i_Params_Delete_Business;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Business.ExceptionMsg = string.Format("Delete_Business : {0}", ex.Message);
}
else
{
oResult_Delete_Business.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Business;
#endregion
}
#endregion
#region Delete_Category
[HttpPost]
[Route("Delete_Category")]
public Result_Delete_Category Delete_Category(Params_Delete_Category i_Params_Delete_Category)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Category oResult_Delete_Category = new Result_Delete_Category();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Category);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Category(i_Params_Delete_Category);
oResult_Delete_Category.My_Params_Delete_Category = i_Params_Delete_Category;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Category.ExceptionMsg = string.Format("Delete_Category : {0}", ex.Message);
}
else
{
oResult_Delete_Category.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Category;
#endregion
}
#endregion
#region Delete_Client
[HttpPost]
[Route("Delete_Client")]
public Result_Delete_Client Delete_Client(Params_Delete_Client i_Params_Delete_Client)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Client oResult_Delete_Client = new Result_Delete_Client();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Client);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Client(i_Params_Delete_Client);
oResult_Delete_Client.My_Params_Delete_Client = i_Params_Delete_Client;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Client.ExceptionMsg = string.Format("Delete_Client : {0}", ex.Message);
}
else
{
oResult_Delete_Client.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Client;
#endregion
}
#endregion
#region Delete_Coordinates
[HttpPost]
[Route("Delete_Coordinates")]
public Result_Delete_Coordinates Delete_Coordinates(Params_Delete_Coordinates i_Params_Delete_Coordinates)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Coordinates oResult_Delete_Coordinates = new Result_Delete_Coordinates();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Coordinates);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Coordinates(i_Params_Delete_Coordinates);
oResult_Delete_Coordinates.My_Params_Delete_Coordinates = i_Params_Delete_Coordinates;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Coordinates.ExceptionMsg = string.Format("Delete_Coordinates : {0}", ex.Message);
}
else
{
oResult_Delete_Coordinates.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Coordinates;
#endregion
}
#endregion
#region Delete_Currency
[HttpPost]
[Route("Delete_Currency")]
public Result_Delete_Currency Delete_Currency(Params_Delete_Currency i_Params_Delete_Currency)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Currency oResult_Delete_Currency = new Result_Delete_Currency();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Currency);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Currency(i_Params_Delete_Currency);
oResult_Delete_Currency.My_Params_Delete_Currency = i_Params_Delete_Currency;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Currency.ExceptionMsg = string.Format("Delete_Currency : {0}", ex.Message);
}
else
{
oResult_Delete_Currency.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Currency;
#endregion
}
#endregion
#region Delete_Feedback
[HttpPost]
[Route("Delete_Feedback")]
public Result_Delete_Feedback Delete_Feedback(Params_Delete_Feedback i_Params_Delete_Feedback)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Feedback oResult_Delete_Feedback = new Result_Delete_Feedback();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Feedback);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Feedback(i_Params_Delete_Feedback);
oResult_Delete_Feedback.My_Params_Delete_Feedback = i_Params_Delete_Feedback;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Feedback.ExceptionMsg = string.Format("Delete_Feedback : {0}", ex.Message);
}
else
{
oResult_Delete_Feedback.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Feedback;
#endregion
}
#endregion
#region Delete_Service_prod
[HttpPost]
[Route("Delete_Service_prod")]
public Result_Delete_Service_prod Delete_Service_prod(Params_Delete_Service_prod i_Params_Delete_Service_prod)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Service_prod oResult_Delete_Service_prod = new Result_Delete_Service_prod();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Service_prod);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Service_prod(i_Params_Delete_Service_prod);
oResult_Delete_Service_prod.My_Params_Delete_Service_prod = i_Params_Delete_Service_prod;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Service_prod.ExceptionMsg = string.Format("Delete_Service_prod : {0}", ex.Message);
}
else
{
oResult_Delete_Service_prod.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Service_prod;
#endregion
}
#endregion
#region Delete_Status
[HttpPost]
[Route("Delete_Status")]
public Result_Delete_Status Delete_Status(Params_Delete_Status i_Params_Delete_Status)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Status oResult_Delete_Status = new Result_Delete_Status();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Status);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Status(i_Params_Delete_Status);
oResult_Delete_Status.My_Params_Delete_Status = i_Params_Delete_Status;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Status.ExceptionMsg = string.Format("Delete_Status : {0}", ex.Message);
}
else
{
oResult_Delete_Status.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Status;
#endregion
}
#endregion
#region Delete_Sub_category
[HttpPost]
[Route("Delete_Sub_category")]
public Result_Delete_Sub_category Delete_Sub_category(Params_Delete_Sub_category i_Params_Delete_Sub_category)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Sub_category oResult_Delete_Sub_category = new Result_Delete_Sub_category();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Sub_category);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Sub_category(i_Params_Delete_Sub_category);
oResult_Delete_Sub_category.My_Params_Delete_Sub_category = i_Params_Delete_Sub_category;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Sub_category.ExceptionMsg = string.Format("Delete_Sub_category : {0}", ex.Message);
}
else
{
oResult_Delete_Sub_category.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Sub_category;
#endregion
}
#endregion
#region Delete_User
[HttpPost]
[Route("Delete_User")]
public Result_Delete_User Delete_User(Params_Delete_User i_Params_Delete_User)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_User oResult_Delete_User = new Result_Delete_User();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_User);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_User(i_Params_Delete_User);
oResult_Delete_User.My_Params_Delete_User = i_Params_Delete_User;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_User.ExceptionMsg = string.Format("Delete_User : {0}", ex.Message);
}
else
{
oResult_Delete_User.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_User;
#endregion
}
#endregion
#region Delete_User_By_USERNAME
[HttpPost]
[Route("Delete_User_By_USERNAME")]
public Result_Delete_User_By_USERNAME Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_User_By_USERNAME oResult_Delete_User_By_USERNAME = new Result_Delete_User_By_USERNAME();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_User_By_USERNAME);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME);
oResult_Delete_User_By_USERNAME.My_Params_Delete_User_By_USERNAME = i_Params_Delete_User_By_USERNAME;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_User_By_USERNAME.ExceptionMsg = string.Format("Delete_User_By_USERNAME : {0}", ex.Message);
}
else
{
oResult_Delete_User_By_USERNAME.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_User_By_USERNAME;
#endregion
}
#endregion
#region Delete_Work_area
[HttpPost]
[Route("Delete_Work_area")]
public Result_Delete_Work_area Delete_Work_area(Params_Delete_Work_area i_Params_Delete_Work_area)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Work_area oResult_Delete_Work_area = new Result_Delete_Work_area();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Work_area);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Work_area(i_Params_Delete_Work_area);
oResult_Delete_Work_area.My_Params_Delete_Work_area = i_Params_Delete_Work_area;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Work_area.ExceptionMsg = string.Format("Delete_Work_area : {0}", ex.Message);
}
else
{
oResult_Delete_Work_area.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Work_area;
#endregion
}
#endregion
#region Delete_Work_list
[HttpPost]
[Route("Delete_Work_list")]
public Result_Delete_Work_list Delete_Work_list(Params_Delete_Work_list i_Params_Delete_Work_list)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Work_list oResult_Delete_Work_list = new Result_Delete_Work_list();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Work_list);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Work_list(i_Params_Delete_Work_list);
oResult_Delete_Work_list.My_Params_Delete_Work_list = i_Params_Delete_Work_list;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Work_list.ExceptionMsg = string.Format("Delete_Work_list : {0}", ex.Message);
}
else
{
oResult_Delete_Work_list.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Work_list;
#endregion
}
#endregion
#region Delete_Work_list_By_BUSINESS_ID
[HttpPost]
[Route("Delete_Work_list_By_BUSINESS_ID")]
public Result_Delete_Work_list_By_BUSINESS_ID Delete_Work_list_By_BUSINESS_ID(Params_Delete_Work_list_By_BUSINESS_ID i_Params_Delete_Work_list_By_BUSINESS_ID)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Work_list_By_BUSINESS_ID oResult_Delete_Work_list_By_BUSINESS_ID = new Result_Delete_Work_list_By_BUSINESS_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Work_list_By_BUSINESS_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Delete_Work_list_By_BUSINESS_ID(i_Params_Delete_Work_list_By_BUSINESS_ID);
oResult_Delete_Work_list_By_BUSINESS_ID.My_Params_Delete_Work_list_By_BUSINESS_ID = i_Params_Delete_Work_list_By_BUSINESS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Work_list_By_BUSINESS_ID.ExceptionMsg = string.Format("Delete_Work_list_By_BUSINESS_ID : {0}", ex.Message);
}
else
{
oResult_Delete_Work_list_By_BUSINESS_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Delete_Work_list_By_BUSINESS_ID;
#endregion
}
#endregion
#region Edit_Admin
[HttpPost]
[Route("Edit_Admin")]
public Result_Edit_Admin Edit_Admin(Admin i_Admin)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Admin oResult_Edit_Admin = new Result_Edit_Admin();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Admin);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Admin(i_Admin);
oResult_Edit_Admin.My_Admin = i_Admin;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Admin.ExceptionMsg = string.Format("Edit_Admin : {0}", ex.Message);
}
else
{
oResult_Edit_Admin.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Admin;
#endregion
}
#endregion
#region Edit_Booking
[HttpPost]
[Route("Edit_Booking")]
public Result_Edit_Booking Edit_Booking(Booking i_Booking)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Booking oResult_Edit_Booking = new Result_Edit_Booking();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Booking);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Booking(i_Booking);
oResult_Edit_Booking.My_Booking = i_Booking;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Booking.ExceptionMsg = string.Format("Edit_Booking : {0}", ex.Message);
}
else
{
oResult_Edit_Booking.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Booking;
#endregion
}
#endregion
#region Edit_Boost_listing
[HttpPost]
[Route("Edit_Boost_listing")]
public Result_Edit_Boost_listing Edit_Boost_listing(Boost_listing i_Boost_listing)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Boost_listing oResult_Edit_Boost_listing = new Result_Edit_Boost_listing();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Boost_listing);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Boost_listing(i_Boost_listing);
oResult_Edit_Boost_listing.My_Boost_listing = i_Boost_listing;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Boost_listing.ExceptionMsg = string.Format("Edit_Boost_listing : {0}", ex.Message);
}
else
{
oResult_Edit_Boost_listing.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Boost_listing;
#endregion
}
#endregion
#region Edit_Boost_pricing
[HttpPost]
[Route("Edit_Boost_pricing")]
public Result_Edit_Boost_pricing Edit_Boost_pricing(Boost_pricing i_Boost_pricing)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Boost_pricing oResult_Edit_Boost_pricing = new Result_Edit_Boost_pricing();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Boost_pricing);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Boost_pricing(i_Boost_pricing);
oResult_Edit_Boost_pricing.My_Boost_pricing = i_Boost_pricing;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Boost_pricing.ExceptionMsg = string.Format("Edit_Boost_pricing : {0}", ex.Message);
}
else
{
oResult_Edit_Boost_pricing.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Boost_pricing;
#endregion
}
#endregion
#region Edit_Business
[HttpPost]
[Route("Edit_Business")]
public Result_Edit_Business Edit_Business(Business i_Business)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Business oResult_Edit_Business = new Result_Edit_Business();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Business);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Business(i_Business);
oResult_Edit_Business.My_Business = i_Business;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Business.ExceptionMsg = string.Format("Edit_Business : {0}", ex.Message);
}
else
{
oResult_Edit_Business.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Business;
#endregion
}
#endregion
#region Edit_Category
[HttpPost]
[Route("Edit_Category")]
public Result_Edit_Category Edit_Category(Category i_Category)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Category oResult_Edit_Category = new Result_Edit_Category();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Category);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Category(i_Category);
oResult_Edit_Category.My_Category = i_Category;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Category.ExceptionMsg = string.Format("Edit_Category : {0}", ex.Message);
}
else
{
oResult_Edit_Category.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Category;
#endregion
}
#endregion
#region Edit_Client
[HttpPost]
[Route("Edit_Client")]
public Result_Edit_Client Edit_Client(Client i_Client)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Client oResult_Edit_Client = new Result_Edit_Client();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Client);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Client(i_Client);
oResult_Edit_Client.My_Client = i_Client;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Client.ExceptionMsg = string.Format("Edit_Client : {0}", ex.Message);
}
else
{
oResult_Edit_Client.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Client;
#endregion
}
#endregion
#region Edit_Coordinates
[HttpPost]
[Route("Edit_Coordinates")]
public Result_Edit_Coordinates Edit_Coordinates(Coordinates i_Coordinates)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Coordinates oResult_Edit_Coordinates = new Result_Edit_Coordinates();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Coordinates);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Coordinates(i_Coordinates);
oResult_Edit_Coordinates.My_Coordinates = i_Coordinates;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Coordinates.ExceptionMsg = string.Format("Edit_Coordinates : {0}", ex.Message);
}
else
{
oResult_Edit_Coordinates.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Coordinates;
#endregion
}
#endregion
#region Edit_Currency
[HttpPost]
[Route("Edit_Currency")]
public Result_Edit_Currency Edit_Currency(Currency i_Currency)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Currency oResult_Edit_Currency = new Result_Edit_Currency();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Currency);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Currency(i_Currency);
oResult_Edit_Currency.My_Currency = i_Currency;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Currency.ExceptionMsg = string.Format("Edit_Currency : {0}", ex.Message);
}
else
{
oResult_Edit_Currency.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Currency;
#endregion
}
#endregion
#region Edit_Feedback
[HttpPost]
[Route("Edit_Feedback")]
public Result_Edit_Feedback Edit_Feedback(Feedback i_Feedback)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Feedback oResult_Edit_Feedback = new Result_Edit_Feedback();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Feedback);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Feedback(i_Feedback);
oResult_Edit_Feedback.My_Feedback = i_Feedback;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Feedback.ExceptionMsg = string.Format("Edit_Feedback : {0}", ex.Message);
}
else
{
oResult_Edit_Feedback.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Feedback;
#endregion
}
#endregion
#region Edit_Service_prod
[HttpPost]
[Route("Edit_Service_prod")]
public Result_Edit_Service_prod Edit_Service_prod(Service_prod i_Service_prod)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Service_prod oResult_Edit_Service_prod = new Result_Edit_Service_prod();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Service_prod);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Service_prod(i_Service_prod);
oResult_Edit_Service_prod.My_Service_prod = i_Service_prod;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Service_prod.ExceptionMsg = string.Format("Edit_Service_prod : {0}", ex.Message);
}
else
{
oResult_Edit_Service_prod.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Service_prod;
#endregion
}
#endregion
#region Edit_Status
[HttpPost]
[Route("Edit_Status")]
public Result_Edit_Status Edit_Status(Status i_Status)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Status oResult_Edit_Status = new Result_Edit_Status();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Status);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Status(i_Status);
oResult_Edit_Status.My_Status = i_Status;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Status.ExceptionMsg = string.Format("Edit_Status : {0}", ex.Message);
}
else
{
oResult_Edit_Status.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Status;
#endregion
}
#endregion
#region Edit_Sub_category
[HttpPost]
[Route("Edit_Sub_category")]
public Result_Edit_Sub_category Edit_Sub_category(Sub_category i_Sub_category)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Sub_category oResult_Edit_Sub_category = new Result_Edit_Sub_category();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Sub_category);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Sub_category(i_Sub_category);
oResult_Edit_Sub_category.My_Sub_category = i_Sub_category;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Sub_category.ExceptionMsg = string.Format("Edit_Sub_category : {0}", ex.Message);
}
else
{
oResult_Edit_Sub_category.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Sub_category;
#endregion
}
#endregion
#region Edit_User
[HttpPost]
[Route("Edit_User")]
public Result_Edit_User Edit_User(User i_User)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_User oResult_Edit_User = new Result_Edit_User();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_User);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_User(i_User);
oResult_Edit_User.My_User = i_User;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_User.ExceptionMsg = string.Format("Edit_User : {0}", ex.Message);
}
else
{
oResult_Edit_User.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_User;
#endregion
}
#endregion
#region Edit_Work_area
[HttpPost]
[Route("Edit_Work_area")]
public Result_Edit_Work_area Edit_Work_area(Work_area i_Work_area)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Work_area oResult_Edit_Work_area = new Result_Edit_Work_area();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Work_area);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Work_area(i_Work_area);
oResult_Edit_Work_area.My_Work_area = i_Work_area;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Work_area.ExceptionMsg = string.Format("Edit_Work_area : {0}", ex.Message);
}
else
{
oResult_Edit_Work_area.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Work_area;
#endregion
}
#endregion
#region Edit_Work_list
[HttpPost]
[Route("Edit_Work_list")]
public Result_Edit_Work_list Edit_Work_list(Work_list i_Work_list)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Work_list oResult_Edit_Work_list = new Result_Edit_Work_list();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Work_list);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Edit_Work_list(i_Work_list);
oResult_Edit_Work_list.My_Work_list = i_Work_list;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Work_list.ExceptionMsg = string.Format("Edit_Work_list : {0}", ex.Message);
}
else
{
oResult_Edit_Work_list.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Edit_Work_list;
#endregion
}
#endregion
#region Get_Admin_By_ADMIN_ID
[HttpPost]
[Route("Get_Admin_By_ADMIN_ID")]
public Result_Get_Admin_By_ADMIN_ID Get_Admin_By_ADMIN_ID(Params_Get_Admin_By_ADMIN_ID i_Params_Get_Admin_By_ADMIN_ID)
{
#region Declaration And Initialization Section.
Admin oReturnValue = new Admin();
string i_Ticket = string.Empty;
Result_Get_Admin_By_ADMIN_ID oResult_Get_Admin_By_ADMIN_ID = new Result_Get_Admin_By_ADMIN_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Admin_By_ADMIN_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Admin_By_ADMIN_ID(i_Params_Get_Admin_By_ADMIN_ID);
oResult_Get_Admin_By_ADMIN_ID.My_Result = oReturnValue;
oResult_Get_Admin_By_ADMIN_ID.My_Params_Get_Admin_By_ADMIN_ID = i_Params_Get_Admin_By_ADMIN_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Admin_By_ADMIN_ID.ExceptionMsg = string.Format("Get_Admin_By_ADMIN_ID : {0}", ex.Message);
}
else
{
oResult_Get_Admin_By_ADMIN_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Admin_By_ADMIN_ID;
#endregion
}
#endregion
#region Get_Admin_By_Criteria
[HttpPost]
[Route("Get_Admin_By_Criteria")]
public Result_Get_Admin_By_Criteria Get_Admin_By_Criteria(Params_Get_Admin_By_Criteria i_Params_Get_Admin_By_Criteria)
{
#region Declaration And Initialization Section.
List<Admin>  oReturnValue = new List<Admin> ();
string i_Ticket = string.Empty;
Result_Get_Admin_By_Criteria oResult_Get_Admin_By_Criteria = new Result_Get_Admin_By_Criteria();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Admin_By_Criteria);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Admin_By_Criteria(i_Params_Get_Admin_By_Criteria);
oResult_Get_Admin_By_Criteria.My_Result = oReturnValue;
oResult_Get_Admin_By_Criteria.My_Params_Get_Admin_By_Criteria = i_Params_Get_Admin_By_Criteria;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Admin_By_Criteria.ExceptionMsg = string.Format("Get_Admin_By_Criteria : {0}", ex.Message);
}
else
{
oResult_Get_Admin_By_Criteria.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Admin_By_Criteria;
#endregion
}
#endregion
#region Get_Admin_By_OWNER_ID
[HttpPost]
[Route("Get_Admin_By_OWNER_ID")]
public Result_Get_Admin_By_OWNER_ID Get_Admin_By_OWNER_ID(Params_Get_Admin_By_OWNER_ID i_Params_Get_Admin_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Admin>  oReturnValue = new List<Admin> ();
string i_Ticket = string.Empty;
Result_Get_Admin_By_OWNER_ID oResult_Get_Admin_By_OWNER_ID = new Result_Get_Admin_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Admin_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Admin_By_OWNER_ID(i_Params_Get_Admin_By_OWNER_ID);
oResult_Get_Admin_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Admin_By_OWNER_ID.My_Params_Get_Admin_By_OWNER_ID = i_Params_Get_Admin_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Admin_By_OWNER_ID.ExceptionMsg = string.Format("Get_Admin_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Admin_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Admin_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Admin_By_USERNAME
[HttpPost]
[Route("Get_Admin_By_USERNAME")]
public Result_Get_Admin_By_USERNAME Get_Admin_By_USERNAME(Params_Get_Admin_By_USERNAME i_Params_Get_Admin_By_USERNAME)
{
#region Declaration And Initialization Section.
List<Admin>  oReturnValue = new List<Admin> ();
string i_Ticket = string.Empty;
Result_Get_Admin_By_USERNAME oResult_Get_Admin_By_USERNAME = new Result_Get_Admin_By_USERNAME();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Admin_By_USERNAME);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Admin_By_USERNAME(i_Params_Get_Admin_By_USERNAME);
oResult_Get_Admin_By_USERNAME.My_Result = oReturnValue;
oResult_Get_Admin_By_USERNAME.My_Params_Get_Admin_By_USERNAME = i_Params_Get_Admin_By_USERNAME;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Admin_By_USERNAME.ExceptionMsg = string.Format("Get_Admin_By_USERNAME : {0}", ex.Message);
}
else
{
oResult_Get_Admin_By_USERNAME.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Admin_By_USERNAME;
#endregion
}
#endregion
#region Get_Admin_By_Where
[HttpPost]
[Route("Get_Admin_By_Where")]
public Result_Get_Admin_By_Where Get_Admin_By_Where(Params_Get_Admin_By_Where i_Params_Get_Admin_By_Where)
{
#region Declaration And Initialization Section.
List<Admin>  oReturnValue = new List<Admin> ();
string i_Ticket = string.Empty;
Result_Get_Admin_By_Where oResult_Get_Admin_By_Where = new Result_Get_Admin_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Admin_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Admin_By_Where(i_Params_Get_Admin_By_Where);
oResult_Get_Admin_By_Where.My_Result = oReturnValue;
oResult_Get_Admin_By_Where.My_Params_Get_Admin_By_Where = i_Params_Get_Admin_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Admin_By_Where.ExceptionMsg = string.Format("Get_Admin_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Admin_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Admin_By_Where;
#endregion
}
#endregion
#region Get_Admin_By_Where_Adv
[HttpPost]
[Route("Get_Admin_By_Where_Adv")]
public Result_Get_Admin_By_Where_Adv Get_Admin_By_Where_Adv(Params_Get_Admin_By_Where i_Params_Get_Admin_By_Where)
{
#region Declaration And Initialization Section.
List<Admin>  oReturnValue = new List<Admin> ();
string i_Ticket = string.Empty;
Result_Get_Admin_By_Where_Adv oResult_Get_Admin_By_Where_Adv = new Result_Get_Admin_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Admin_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Admin_By_Where_Adv(i_Params_Get_Admin_By_Where);
oResult_Get_Admin_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Admin_By_Where_Adv.My_Params_Get_Admin_By_Where = i_Params_Get_Admin_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Admin_By_Where_Adv.ExceptionMsg = string.Format("Get_Admin_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Admin_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Admin_By_Where_Adv;
#endregion
}
#endregion
#region Get_Booking_By_BOOKING_ID
[HttpPost]
[Route("Get_Booking_By_BOOKING_ID")]
public Result_Get_Booking_By_BOOKING_ID Get_Booking_By_BOOKING_ID(Params_Get_Booking_By_BOOKING_ID i_Params_Get_Booking_By_BOOKING_ID)
{
#region Declaration And Initialization Section.
Booking oReturnValue = new Booking();
string i_Ticket = string.Empty;
Result_Get_Booking_By_BOOKING_ID oResult_Get_Booking_By_BOOKING_ID = new Result_Get_Booking_By_BOOKING_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_BOOKING_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_BOOKING_ID(i_Params_Get_Booking_By_BOOKING_ID);
oResult_Get_Booking_By_BOOKING_ID.My_Result = oReturnValue;
oResult_Get_Booking_By_BOOKING_ID.My_Params_Get_Booking_By_BOOKING_ID = i_Params_Get_Booking_By_BOOKING_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_BOOKING_ID.ExceptionMsg = string.Format("Get_Booking_By_BOOKING_ID : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_BOOKING_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_BOOKING_ID;
#endregion
}
#endregion
#region Get_Booking_By_BOOKING_ID_Adv
[HttpPost]
[Route("Get_Booking_By_BOOKING_ID_Adv")]
public Result_Get_Booking_By_BOOKING_ID_Adv Get_Booking_By_BOOKING_ID_Adv(Params_Get_Booking_By_BOOKING_ID i_Params_Get_Booking_By_BOOKING_ID)
{
#region Declaration And Initialization Section.
Booking oReturnValue = new Booking();
string i_Ticket = string.Empty;
Result_Get_Booking_By_BOOKING_ID_Adv oResult_Get_Booking_By_BOOKING_ID_Adv = new Result_Get_Booking_By_BOOKING_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_BOOKING_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_BOOKING_ID_Adv(i_Params_Get_Booking_By_BOOKING_ID);
oResult_Get_Booking_By_BOOKING_ID_Adv.My_Result = oReturnValue;
oResult_Get_Booking_By_BOOKING_ID_Adv.My_Params_Get_Booking_By_BOOKING_ID = i_Params_Get_Booking_By_BOOKING_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_BOOKING_ID_Adv.ExceptionMsg = string.Format("Get_Booking_By_BOOKING_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_BOOKING_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_BOOKING_ID_Adv;
#endregion
}
#endregion
#region Get_Booking_By_BUSINESS_ID
[HttpPost]
[Route("Get_Booking_By_BUSINESS_ID")]
public Result_Get_Booking_By_BUSINESS_ID Get_Booking_By_BUSINESS_ID(Params_Get_Booking_By_BUSINESS_ID i_Params_Get_Booking_By_BUSINESS_ID)
{
#region Declaration And Initialization Section.
List<Booking>  oReturnValue = new List<Booking> ();
string i_Ticket = string.Empty;
Result_Get_Booking_By_BUSINESS_ID oResult_Get_Booking_By_BUSINESS_ID = new Result_Get_Booking_By_BUSINESS_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_BUSINESS_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_BUSINESS_ID(i_Params_Get_Booking_By_BUSINESS_ID);
oResult_Get_Booking_By_BUSINESS_ID.My_Result = oReturnValue;
oResult_Get_Booking_By_BUSINESS_ID.My_Params_Get_Booking_By_BUSINESS_ID = i_Params_Get_Booking_By_BUSINESS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_BUSINESS_ID.ExceptionMsg = string.Format("Get_Booking_By_BUSINESS_ID : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_BUSINESS_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_BUSINESS_ID;
#endregion
}
#endregion
#region Get_Booking_By_BUSINESS_ID_Adv
[HttpPost]
[Route("Get_Booking_By_BUSINESS_ID_Adv")]
public Result_Get_Booking_By_BUSINESS_ID_Adv Get_Booking_By_BUSINESS_ID_Adv(Params_Get_Booking_By_BUSINESS_ID i_Params_Get_Booking_By_BUSINESS_ID)
{
#region Declaration And Initialization Section.
List<Booking>  oReturnValue = new List<Booking> ();
string i_Ticket = string.Empty;
Result_Get_Booking_By_BUSINESS_ID_Adv oResult_Get_Booking_By_BUSINESS_ID_Adv = new Result_Get_Booking_By_BUSINESS_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_BUSINESS_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_BUSINESS_ID_Adv(i_Params_Get_Booking_By_BUSINESS_ID);
oResult_Get_Booking_By_BUSINESS_ID_Adv.My_Result = oReturnValue;
oResult_Get_Booking_By_BUSINESS_ID_Adv.My_Params_Get_Booking_By_BUSINESS_ID = i_Params_Get_Booking_By_BUSINESS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_BUSINESS_ID_Adv.ExceptionMsg = string.Format("Get_Booking_By_BUSINESS_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_BUSINESS_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_BUSINESS_ID_Adv;
#endregion
}
#endregion
#region Get_Booking_By_CLIENT_ID
[HttpPost]
[Route("Get_Booking_By_CLIENT_ID")]
public Result_Get_Booking_By_CLIENT_ID Get_Booking_By_CLIENT_ID(Params_Get_Booking_By_CLIENT_ID i_Params_Get_Booking_By_CLIENT_ID)
{
#region Declaration And Initialization Section.
List<Booking>  oReturnValue = new List<Booking> ();
string i_Ticket = string.Empty;
Result_Get_Booking_By_CLIENT_ID oResult_Get_Booking_By_CLIENT_ID = new Result_Get_Booking_By_CLIENT_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_CLIENT_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_CLIENT_ID(i_Params_Get_Booking_By_CLIENT_ID);
oResult_Get_Booking_By_CLIENT_ID.My_Result = oReturnValue;
oResult_Get_Booking_By_CLIENT_ID.My_Params_Get_Booking_By_CLIENT_ID = i_Params_Get_Booking_By_CLIENT_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_CLIENT_ID.ExceptionMsg = string.Format("Get_Booking_By_CLIENT_ID : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_CLIENT_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_CLIENT_ID;
#endregion
}
#endregion
#region Get_Booking_By_CLIENT_ID_Adv
[HttpPost]
[Route("Get_Booking_By_CLIENT_ID_Adv")]
public Result_Get_Booking_By_CLIENT_ID_Adv Get_Booking_By_CLIENT_ID_Adv(Params_Get_Booking_By_CLIENT_ID i_Params_Get_Booking_By_CLIENT_ID)
{
#region Declaration And Initialization Section.
List<Booking>  oReturnValue = new List<Booking> ();
string i_Ticket = string.Empty;
Result_Get_Booking_By_CLIENT_ID_Adv oResult_Get_Booking_By_CLIENT_ID_Adv = new Result_Get_Booking_By_CLIENT_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_CLIENT_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_CLIENT_ID_Adv(i_Params_Get_Booking_By_CLIENT_ID);
oResult_Get_Booking_By_CLIENT_ID_Adv.My_Result = oReturnValue;
oResult_Get_Booking_By_CLIENT_ID_Adv.My_Params_Get_Booking_By_CLIENT_ID = i_Params_Get_Booking_By_CLIENT_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_CLIENT_ID_Adv.ExceptionMsg = string.Format("Get_Booking_By_CLIENT_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_CLIENT_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_CLIENT_ID_Adv;
#endregion
}
#endregion
#region Get_Booking_By_OWNER_ID
[HttpPost]
[Route("Get_Booking_By_OWNER_ID")]
public Result_Get_Booking_By_OWNER_ID Get_Booking_By_OWNER_ID(Params_Get_Booking_By_OWNER_ID i_Params_Get_Booking_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Booking>  oReturnValue = new List<Booking> ();
string i_Ticket = string.Empty;
Result_Get_Booking_By_OWNER_ID oResult_Get_Booking_By_OWNER_ID = new Result_Get_Booking_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_OWNER_ID(i_Params_Get_Booking_By_OWNER_ID);
oResult_Get_Booking_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Booking_By_OWNER_ID.My_Params_Get_Booking_By_OWNER_ID = i_Params_Get_Booking_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_OWNER_ID.ExceptionMsg = string.Format("Get_Booking_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Booking_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Booking_By_OWNER_ID_Adv")]
public Result_Get_Booking_By_OWNER_ID_Adv Get_Booking_By_OWNER_ID_Adv(Params_Get_Booking_By_OWNER_ID i_Params_Get_Booking_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Booking>  oReturnValue = new List<Booking> ();
string i_Ticket = string.Empty;
Result_Get_Booking_By_OWNER_ID_Adv oResult_Get_Booking_By_OWNER_ID_Adv = new Result_Get_Booking_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_OWNER_ID_Adv(i_Params_Get_Booking_By_OWNER_ID);
oResult_Get_Booking_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Booking_By_OWNER_ID_Adv.My_Params_Get_Booking_By_OWNER_ID = i_Params_Get_Booking_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Booking_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Booking_By_SERVICE_PROD_ID_Adv
[HttpPost]
[Route("Get_Booking_By_SERVICE_PROD_ID_Adv")]
public Result_Get_Booking_By_SERVICE_PROD_ID_Adv Get_Booking_By_SERVICE_PROD_ID_Adv(Params_Get_Booking_By_SERVICE_PROD_ID i_Params_Get_Booking_By_SERVICE_PROD_ID)
{
#region Declaration And Initialization Section.
List<Booking>  oReturnValue = new List<Booking> ();
string i_Ticket = string.Empty;
Result_Get_Booking_By_SERVICE_PROD_ID_Adv oResult_Get_Booking_By_SERVICE_PROD_ID_Adv = new Result_Get_Booking_By_SERVICE_PROD_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_SERVICE_PROD_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_SERVICE_PROD_ID_Adv(i_Params_Get_Booking_By_SERVICE_PROD_ID);
oResult_Get_Booking_By_SERVICE_PROD_ID_Adv.My_Result = oReturnValue;
oResult_Get_Booking_By_SERVICE_PROD_ID_Adv.My_Params_Get_Booking_By_SERVICE_PROD_ID = i_Params_Get_Booking_By_SERVICE_PROD_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_SERVICE_PROD_ID_Adv.ExceptionMsg = string.Format("Get_Booking_By_SERVICE_PROD_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_SERVICE_PROD_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_SERVICE_PROD_ID_Adv;
#endregion
}
#endregion
#region Get_Booking_By_Where
[HttpPost]
[Route("Get_Booking_By_Where")]
public Result_Get_Booking_By_Where Get_Booking_By_Where(Params_Get_Booking_By_Where i_Params_Get_Booking_By_Where)
{
#region Declaration And Initialization Section.
List<Booking>  oReturnValue = new List<Booking> ();
string i_Ticket = string.Empty;
Result_Get_Booking_By_Where oResult_Get_Booking_By_Where = new Result_Get_Booking_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_Where(i_Params_Get_Booking_By_Where);
oResult_Get_Booking_By_Where.My_Result = oReturnValue;
oResult_Get_Booking_By_Where.My_Params_Get_Booking_By_Where = i_Params_Get_Booking_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_Where.ExceptionMsg = string.Format("Get_Booking_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_Where;
#endregion
}
#endregion
#region Get_Booking_By_Where_Adv
[HttpPost]
[Route("Get_Booking_By_Where_Adv")]
public Result_Get_Booking_By_Where_Adv Get_Booking_By_Where_Adv(Params_Get_Booking_By_Where i_Params_Get_Booking_By_Where)
{
#region Declaration And Initialization Section.
List<Booking>  oReturnValue = new List<Booking> ();
string i_Ticket = string.Empty;
Result_Get_Booking_By_Where_Adv oResult_Get_Booking_By_Where_Adv = new Result_Get_Booking_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Booking_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Booking_By_Where_Adv(i_Params_Get_Booking_By_Where);
oResult_Get_Booking_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Booking_By_Where_Adv.My_Params_Get_Booking_By_Where = i_Params_Get_Booking_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Booking_By_Where_Adv.ExceptionMsg = string.Format("Get_Booking_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Booking_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Booking_By_Where_Adv;
#endregion
}
#endregion
#region Get_Boost_listing_By_BOOST_LISTING_ID
[HttpPost]
[Route("Get_Boost_listing_By_BOOST_LISTING_ID")]
public Result_Get_Boost_listing_By_BOOST_LISTING_ID Get_Boost_listing_By_BOOST_LISTING_ID(Params_Get_Boost_listing_By_BOOST_LISTING_ID i_Params_Get_Boost_listing_By_BOOST_LISTING_ID)
{
#region Declaration And Initialization Section.
Boost_listing oReturnValue = new Boost_listing();
string i_Ticket = string.Empty;
Result_Get_Boost_listing_By_BOOST_LISTING_ID oResult_Get_Boost_listing_By_BOOST_LISTING_ID = new Result_Get_Boost_listing_By_BOOST_LISTING_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_listing_By_BOOST_LISTING_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_listing_By_BOOST_LISTING_ID(i_Params_Get_Boost_listing_By_BOOST_LISTING_ID);
oResult_Get_Boost_listing_By_BOOST_LISTING_ID.My_Result = oReturnValue;
oResult_Get_Boost_listing_By_BOOST_LISTING_ID.My_Params_Get_Boost_listing_By_BOOST_LISTING_ID = i_Params_Get_Boost_listing_By_BOOST_LISTING_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_listing_By_BOOST_LISTING_ID.ExceptionMsg = string.Format("Get_Boost_listing_By_BOOST_LISTING_ID : {0}", ex.Message);
}
else
{
oResult_Get_Boost_listing_By_BOOST_LISTING_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_listing_By_BOOST_LISTING_ID;
#endregion
}
#endregion
#region Get_Boost_listing_By_BOOST_LISTING_ID_Adv
[HttpPost]
[Route("Get_Boost_listing_By_BOOST_LISTING_ID_Adv")]
public Result_Get_Boost_listing_By_BOOST_LISTING_ID_Adv Get_Boost_listing_By_BOOST_LISTING_ID_Adv(Params_Get_Boost_listing_By_BOOST_LISTING_ID i_Params_Get_Boost_listing_By_BOOST_LISTING_ID)
{
#region Declaration And Initialization Section.
Boost_listing oReturnValue = new Boost_listing();
string i_Ticket = string.Empty;
Result_Get_Boost_listing_By_BOOST_LISTING_ID_Adv oResult_Get_Boost_listing_By_BOOST_LISTING_ID_Adv = new Result_Get_Boost_listing_By_BOOST_LISTING_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_listing_By_BOOST_LISTING_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_listing_By_BOOST_LISTING_ID_Adv(i_Params_Get_Boost_listing_By_BOOST_LISTING_ID);
oResult_Get_Boost_listing_By_BOOST_LISTING_ID_Adv.My_Result = oReturnValue;
oResult_Get_Boost_listing_By_BOOST_LISTING_ID_Adv.My_Params_Get_Boost_listing_By_BOOST_LISTING_ID = i_Params_Get_Boost_listing_By_BOOST_LISTING_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_listing_By_BOOST_LISTING_ID_Adv.ExceptionMsg = string.Format("Get_Boost_listing_By_BOOST_LISTING_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Boost_listing_By_BOOST_LISTING_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_listing_By_BOOST_LISTING_ID_Adv;
#endregion
}
#endregion
#region Get_Boost_listing_By_OWNER_ID
[HttpPost]
[Route("Get_Boost_listing_By_OWNER_ID")]
public Result_Get_Boost_listing_By_OWNER_ID Get_Boost_listing_By_OWNER_ID(Params_Get_Boost_listing_By_OWNER_ID i_Params_Get_Boost_listing_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Boost_listing>  oReturnValue = new List<Boost_listing> ();
string i_Ticket = string.Empty;
Result_Get_Boost_listing_By_OWNER_ID oResult_Get_Boost_listing_By_OWNER_ID = new Result_Get_Boost_listing_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_listing_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_listing_By_OWNER_ID(i_Params_Get_Boost_listing_By_OWNER_ID);
oResult_Get_Boost_listing_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Boost_listing_By_OWNER_ID.My_Params_Get_Boost_listing_By_OWNER_ID = i_Params_Get_Boost_listing_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_listing_By_OWNER_ID.ExceptionMsg = string.Format("Get_Boost_listing_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Boost_listing_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_listing_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Boost_listing_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Boost_listing_By_OWNER_ID_Adv")]
public Result_Get_Boost_listing_By_OWNER_ID_Adv Get_Boost_listing_By_OWNER_ID_Adv(Params_Get_Boost_listing_By_OWNER_ID i_Params_Get_Boost_listing_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Boost_listing>  oReturnValue = new List<Boost_listing> ();
string i_Ticket = string.Empty;
Result_Get_Boost_listing_By_OWNER_ID_Adv oResult_Get_Boost_listing_By_OWNER_ID_Adv = new Result_Get_Boost_listing_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_listing_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_listing_By_OWNER_ID_Adv(i_Params_Get_Boost_listing_By_OWNER_ID);
oResult_Get_Boost_listing_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Boost_listing_By_OWNER_ID_Adv.My_Params_Get_Boost_listing_By_OWNER_ID = i_Params_Get_Boost_listing_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_listing_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Boost_listing_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Boost_listing_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_listing_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Boost_listing_By_Where
[HttpPost]
[Route("Get_Boost_listing_By_Where")]
public Result_Get_Boost_listing_By_Where Get_Boost_listing_By_Where(Params_Get_Boost_listing_By_Where i_Params_Get_Boost_listing_By_Where)
{
#region Declaration And Initialization Section.
List<Boost_listing>  oReturnValue = new List<Boost_listing> ();
string i_Ticket = string.Empty;
Result_Get_Boost_listing_By_Where oResult_Get_Boost_listing_By_Where = new Result_Get_Boost_listing_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_listing_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_listing_By_Where(i_Params_Get_Boost_listing_By_Where);
oResult_Get_Boost_listing_By_Where.My_Result = oReturnValue;
oResult_Get_Boost_listing_By_Where.My_Params_Get_Boost_listing_By_Where = i_Params_Get_Boost_listing_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_listing_By_Where.ExceptionMsg = string.Format("Get_Boost_listing_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Boost_listing_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_listing_By_Where;
#endregion
}
#endregion
#region Get_Boost_listing_By_Where_Adv
[HttpPost]
[Route("Get_Boost_listing_By_Where_Adv")]
public Result_Get_Boost_listing_By_Where_Adv Get_Boost_listing_By_Where_Adv(Params_Get_Boost_listing_By_Where i_Params_Get_Boost_listing_By_Where)
{
#region Declaration And Initialization Section.
List<Boost_listing>  oReturnValue = new List<Boost_listing> ();
string i_Ticket = string.Empty;
Result_Get_Boost_listing_By_Where_Adv oResult_Get_Boost_listing_By_Where_Adv = new Result_Get_Boost_listing_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_listing_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_listing_By_Where_Adv(i_Params_Get_Boost_listing_By_Where);
oResult_Get_Boost_listing_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Boost_listing_By_Where_Adv.My_Params_Get_Boost_listing_By_Where = i_Params_Get_Boost_listing_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_listing_By_Where_Adv.ExceptionMsg = string.Format("Get_Boost_listing_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Boost_listing_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_listing_By_Where_Adv;
#endregion
}
#endregion
#region Get_Boost_pricing_By_BOOST_PRICING_ID
[HttpPost]
[Route("Get_Boost_pricing_By_BOOST_PRICING_ID")]
public Result_Get_Boost_pricing_By_BOOST_PRICING_ID Get_Boost_pricing_By_BOOST_PRICING_ID(Params_Get_Boost_pricing_By_BOOST_PRICING_ID i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID)
{
#region Declaration And Initialization Section.
Boost_pricing oReturnValue = new Boost_pricing();
string i_Ticket = string.Empty;
Result_Get_Boost_pricing_By_BOOST_PRICING_ID oResult_Get_Boost_pricing_By_BOOST_PRICING_ID = new Result_Get_Boost_pricing_By_BOOST_PRICING_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_pricing_By_BOOST_PRICING_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_pricing_By_BOOST_PRICING_ID(i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID);
oResult_Get_Boost_pricing_By_BOOST_PRICING_ID.My_Result = oReturnValue;
oResult_Get_Boost_pricing_By_BOOST_PRICING_ID.My_Params_Get_Boost_pricing_By_BOOST_PRICING_ID = i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_pricing_By_BOOST_PRICING_ID.ExceptionMsg = string.Format("Get_Boost_pricing_By_BOOST_PRICING_ID : {0}", ex.Message);
}
else
{
oResult_Get_Boost_pricing_By_BOOST_PRICING_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_pricing_By_BOOST_PRICING_ID;
#endregion
}
#endregion
#region Get_Boost_pricing_By_BOOST_PRICING_ID_Adv
[HttpPost]
[Route("Get_Boost_pricing_By_BOOST_PRICING_ID_Adv")]
public Result_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv Get_Boost_pricing_By_BOOST_PRICING_ID_Adv(Params_Get_Boost_pricing_By_BOOST_PRICING_ID i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID)
{
#region Declaration And Initialization Section.
Boost_pricing oReturnValue = new Boost_pricing();
string i_Ticket = string.Empty;
Result_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv oResult_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv = new Result_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_pricing_By_BOOST_PRICING_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_pricing_By_BOOST_PRICING_ID_Adv(i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID);
oResult_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv.My_Result = oReturnValue;
oResult_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv.My_Params_Get_Boost_pricing_By_BOOST_PRICING_ID = i_Params_Get_Boost_pricing_By_BOOST_PRICING_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv.ExceptionMsg = string.Format("Get_Boost_pricing_By_BOOST_PRICING_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv;
#endregion
}
#endregion
#region Get_Boost_pricing_By_OWNER_ID
[HttpPost]
[Route("Get_Boost_pricing_By_OWNER_ID")]
public Result_Get_Boost_pricing_By_OWNER_ID Get_Boost_pricing_By_OWNER_ID(Params_Get_Boost_pricing_By_OWNER_ID i_Params_Get_Boost_pricing_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Boost_pricing>  oReturnValue = new List<Boost_pricing> ();
string i_Ticket = string.Empty;
Result_Get_Boost_pricing_By_OWNER_ID oResult_Get_Boost_pricing_By_OWNER_ID = new Result_Get_Boost_pricing_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_pricing_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_pricing_By_OWNER_ID(i_Params_Get_Boost_pricing_By_OWNER_ID);
oResult_Get_Boost_pricing_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Boost_pricing_By_OWNER_ID.My_Params_Get_Boost_pricing_By_OWNER_ID = i_Params_Get_Boost_pricing_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_pricing_By_OWNER_ID.ExceptionMsg = string.Format("Get_Boost_pricing_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Boost_pricing_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_pricing_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Boost_pricing_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Boost_pricing_By_OWNER_ID_Adv")]
public Result_Get_Boost_pricing_By_OWNER_ID_Adv Get_Boost_pricing_By_OWNER_ID_Adv(Params_Get_Boost_pricing_By_OWNER_ID i_Params_Get_Boost_pricing_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Boost_pricing>  oReturnValue = new List<Boost_pricing> ();
string i_Ticket = string.Empty;
Result_Get_Boost_pricing_By_OWNER_ID_Adv oResult_Get_Boost_pricing_By_OWNER_ID_Adv = new Result_Get_Boost_pricing_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_pricing_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_pricing_By_OWNER_ID_Adv(i_Params_Get_Boost_pricing_By_OWNER_ID);
oResult_Get_Boost_pricing_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Boost_pricing_By_OWNER_ID_Adv.My_Params_Get_Boost_pricing_By_OWNER_ID = i_Params_Get_Boost_pricing_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_pricing_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Boost_pricing_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Boost_pricing_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_pricing_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Boost_pricing_By_Where
[HttpPost]
[Route("Get_Boost_pricing_By_Where")]
public Result_Get_Boost_pricing_By_Where Get_Boost_pricing_By_Where(Params_Get_Boost_pricing_By_Where i_Params_Get_Boost_pricing_By_Where)
{
#region Declaration And Initialization Section.
List<Boost_pricing>  oReturnValue = new List<Boost_pricing> ();
string i_Ticket = string.Empty;
Result_Get_Boost_pricing_By_Where oResult_Get_Boost_pricing_By_Where = new Result_Get_Boost_pricing_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_pricing_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_pricing_By_Where(i_Params_Get_Boost_pricing_By_Where);
oResult_Get_Boost_pricing_By_Where.My_Result = oReturnValue;
oResult_Get_Boost_pricing_By_Where.My_Params_Get_Boost_pricing_By_Where = i_Params_Get_Boost_pricing_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_pricing_By_Where.ExceptionMsg = string.Format("Get_Boost_pricing_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Boost_pricing_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_pricing_By_Where;
#endregion
}
#endregion
#region Get_Boost_pricing_By_Where_Adv
[HttpPost]
[Route("Get_Boost_pricing_By_Where_Adv")]
public Result_Get_Boost_pricing_By_Where_Adv Get_Boost_pricing_By_Where_Adv(Params_Get_Boost_pricing_By_Where i_Params_Get_Boost_pricing_By_Where)
{
#region Declaration And Initialization Section.
List<Boost_pricing>  oReturnValue = new List<Boost_pricing> ();
string i_Ticket = string.Empty;
Result_Get_Boost_pricing_By_Where_Adv oResult_Get_Boost_pricing_By_Where_Adv = new Result_Get_Boost_pricing_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Boost_pricing_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Boost_pricing_By_Where_Adv(i_Params_Get_Boost_pricing_By_Where);
oResult_Get_Boost_pricing_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Boost_pricing_By_Where_Adv.My_Params_Get_Boost_pricing_By_Where = i_Params_Get_Boost_pricing_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Boost_pricing_By_Where_Adv.ExceptionMsg = string.Format("Get_Boost_pricing_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Boost_pricing_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Boost_pricing_By_Where_Adv;
#endregion
}
#endregion
#region Get_Business_By_BUSINESS_ID
[HttpPost]
[Route("Get_Business_By_BUSINESS_ID")]
public Result_Get_Business_By_BUSINESS_ID Get_Business_By_BUSINESS_ID(Params_Get_Business_By_BUSINESS_ID i_Params_Get_Business_By_BUSINESS_ID)
{
#region Declaration And Initialization Section.
Business oReturnValue = new Business();
string i_Ticket = string.Empty;
Result_Get_Business_By_BUSINESS_ID oResult_Get_Business_By_BUSINESS_ID = new Result_Get_Business_By_BUSINESS_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Business_By_BUSINESS_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Business_By_BUSINESS_ID(i_Params_Get_Business_By_BUSINESS_ID);
oResult_Get_Business_By_BUSINESS_ID.My_Result = oReturnValue;
oResult_Get_Business_By_BUSINESS_ID.My_Params_Get_Business_By_BUSINESS_ID = i_Params_Get_Business_By_BUSINESS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Business_By_BUSINESS_ID.ExceptionMsg = string.Format("Get_Business_By_BUSINESS_ID : {0}", ex.Message);
}
else
{
oResult_Get_Business_By_BUSINESS_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Business_By_BUSINESS_ID;
#endregion
}
#endregion
#region Get_Business_By_BUSINESS_ID_Adv
[HttpPost]
[Route("Get_Business_By_BUSINESS_ID_Adv")]
public Result_Get_Business_By_BUSINESS_ID_Adv Get_Business_By_BUSINESS_ID_Adv(Params_Get_Business_By_BUSINESS_ID i_Params_Get_Business_By_BUSINESS_ID)
{
#region Declaration And Initialization Section.
Business oReturnValue = new Business();
string i_Ticket = string.Empty;
Result_Get_Business_By_BUSINESS_ID_Adv oResult_Get_Business_By_BUSINESS_ID_Adv = new Result_Get_Business_By_BUSINESS_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Business_By_BUSINESS_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Business_By_BUSINESS_ID_Adv(i_Params_Get_Business_By_BUSINESS_ID);
oResult_Get_Business_By_BUSINESS_ID_Adv.My_Result = oReturnValue;
oResult_Get_Business_By_BUSINESS_ID_Adv.My_Params_Get_Business_By_BUSINESS_ID = i_Params_Get_Business_By_BUSINESS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Business_By_BUSINESS_ID_Adv.ExceptionMsg = string.Format("Get_Business_By_BUSINESS_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Business_By_BUSINESS_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Business_By_BUSINESS_ID_Adv;
#endregion
}
#endregion
#region Get_Business_By_OWNER_ID
[HttpPost]
[Route("Get_Business_By_OWNER_ID")]
public Result_Get_Business_By_OWNER_ID Get_Business_By_OWNER_ID(Params_Get_Business_By_OWNER_ID i_Params_Get_Business_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Business>  oReturnValue = new List<Business> ();
string i_Ticket = string.Empty;
Result_Get_Business_By_OWNER_ID oResult_Get_Business_By_OWNER_ID = new Result_Get_Business_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Business_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Business_By_OWNER_ID(i_Params_Get_Business_By_OWNER_ID);
oResult_Get_Business_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Business_By_OWNER_ID.My_Params_Get_Business_By_OWNER_ID = i_Params_Get_Business_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Business_By_OWNER_ID.ExceptionMsg = string.Format("Get_Business_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Business_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Business_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Business_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Business_By_OWNER_ID_Adv")]
public Result_Get_Business_By_OWNER_ID_Adv Get_Business_By_OWNER_ID_Adv(Params_Get_Business_By_OWNER_ID i_Params_Get_Business_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Business>  oReturnValue = new List<Business> ();
string i_Ticket = string.Empty;
Result_Get_Business_By_OWNER_ID_Adv oResult_Get_Business_By_OWNER_ID_Adv = new Result_Get_Business_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Business_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Business_By_OWNER_ID_Adv(i_Params_Get_Business_By_OWNER_ID);
oResult_Get_Business_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Business_By_OWNER_ID_Adv.My_Params_Get_Business_By_OWNER_ID = i_Params_Get_Business_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Business_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Business_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Business_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Business_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Business_By_USERNAME
[HttpPost]
[Route("Get_Business_By_USERNAME")]
public Result_Get_Business_By_USERNAME Get_Business_By_USERNAME(Params_Get_Business_By_USERNAME i_Params_Get_Business_By_USERNAME)
{
#region Declaration And Initialization Section.
List<Business>  oReturnValue = new List<Business> ();
string i_Ticket = string.Empty;
Result_Get_Business_By_USERNAME oResult_Get_Business_By_USERNAME = new Result_Get_Business_By_USERNAME();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Business_By_USERNAME);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Business_By_USERNAME(i_Params_Get_Business_By_USERNAME);
oResult_Get_Business_By_USERNAME.My_Result = oReturnValue;
oResult_Get_Business_By_USERNAME.My_Params_Get_Business_By_USERNAME = i_Params_Get_Business_By_USERNAME;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Business_By_USERNAME.ExceptionMsg = string.Format("Get_Business_By_USERNAME : {0}", ex.Message);
}
else
{
oResult_Get_Business_By_USERNAME.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Business_By_USERNAME;
#endregion
}
#endregion
#region Get_Business_By_USERNAME_Adv
[HttpPost]
[Route("Get_Business_By_USERNAME_Adv")]
public Result_Get_Business_By_USERNAME_Adv Get_Business_By_USERNAME_Adv(Params_Get_Business_By_USERNAME i_Params_Get_Business_By_USERNAME)
{
#region Declaration And Initialization Section.
List<Business>  oReturnValue = new List<Business> ();
string i_Ticket = string.Empty;
Result_Get_Business_By_USERNAME_Adv oResult_Get_Business_By_USERNAME_Adv = new Result_Get_Business_By_USERNAME_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Business_By_USERNAME_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Business_By_USERNAME_Adv(i_Params_Get_Business_By_USERNAME);
oResult_Get_Business_By_USERNAME_Adv.My_Result = oReturnValue;
oResult_Get_Business_By_USERNAME_Adv.My_Params_Get_Business_By_USERNAME = i_Params_Get_Business_By_USERNAME;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Business_By_USERNAME_Adv.ExceptionMsg = string.Format("Get_Business_By_USERNAME_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Business_By_USERNAME_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Business_By_USERNAME_Adv;
#endregion
}
#endregion
#region Get_Business_By_Where
[HttpPost]
[Route("Get_Business_By_Where")]
public Result_Get_Business_By_Where Get_Business_By_Where(Params_Get_Business_By_Where i_Params_Get_Business_By_Where)
{
#region Declaration And Initialization Section.
List<Business>  oReturnValue = new List<Business> ();
string i_Ticket = string.Empty;
Result_Get_Business_By_Where oResult_Get_Business_By_Where = new Result_Get_Business_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Business_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Business_By_Where(i_Params_Get_Business_By_Where);
oResult_Get_Business_By_Where.My_Result = oReturnValue;
oResult_Get_Business_By_Where.My_Params_Get_Business_By_Where = i_Params_Get_Business_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Business_By_Where.ExceptionMsg = string.Format("Get_Business_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Business_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Business_By_Where;
#endregion
}
#endregion
#region Get_Business_By_Where_Adv
[HttpPost]
[Route("Get_Business_By_Where_Adv")]
public Result_Get_Business_By_Where_Adv Get_Business_By_Where_Adv(Params_Get_Business_By_Where i_Params_Get_Business_By_Where)
{
#region Declaration And Initialization Section.
List<Business>  oReturnValue = new List<Business> ();
string i_Ticket = string.Empty;
Result_Get_Business_By_Where_Adv oResult_Get_Business_By_Where_Adv = new Result_Get_Business_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Business_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Business_By_Where_Adv(i_Params_Get_Business_By_Where);
oResult_Get_Business_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Business_By_Where_Adv.My_Params_Get_Business_By_Where = i_Params_Get_Business_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Business_By_Where_Adv.ExceptionMsg = string.Format("Get_Business_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Business_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Business_By_Where_Adv;
#endregion
}
#endregion
#region Get_Category_By_CATEGORY_ID
[HttpPost]
[Route("Get_Category_By_CATEGORY_ID")]
public Result_Get_Category_By_CATEGORY_ID Get_Category_By_CATEGORY_ID(Params_Get_Category_By_CATEGORY_ID i_Params_Get_Category_By_CATEGORY_ID)
{
#region Declaration And Initialization Section.
Category oReturnValue = new Category();
string i_Ticket = string.Empty;
Result_Get_Category_By_CATEGORY_ID oResult_Get_Category_By_CATEGORY_ID = new Result_Get_Category_By_CATEGORY_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Category_By_CATEGORY_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Category_By_CATEGORY_ID(i_Params_Get_Category_By_CATEGORY_ID);
oResult_Get_Category_By_CATEGORY_ID.My_Result = oReturnValue;
oResult_Get_Category_By_CATEGORY_ID.My_Params_Get_Category_By_CATEGORY_ID = i_Params_Get_Category_By_CATEGORY_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Category_By_CATEGORY_ID.ExceptionMsg = string.Format("Get_Category_By_CATEGORY_ID : {0}", ex.Message);
}
else
{
oResult_Get_Category_By_CATEGORY_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Category_By_CATEGORY_ID;
#endregion
}
#endregion
#region Get_Category_By_OWNER_ID
[HttpPost]
[Route("Get_Category_By_OWNER_ID")]
public Result_Get_Category_By_OWNER_ID Get_Category_By_OWNER_ID(Params_Get_Category_By_OWNER_ID i_Params_Get_Category_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Category>  oReturnValue = new List<Category> ();
string i_Ticket = string.Empty;
Result_Get_Category_By_OWNER_ID oResult_Get_Category_By_OWNER_ID = new Result_Get_Category_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Category_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Category_By_OWNER_ID(i_Params_Get_Category_By_OWNER_ID);
oResult_Get_Category_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Category_By_OWNER_ID.My_Params_Get_Category_By_OWNER_ID = i_Params_Get_Category_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Category_By_OWNER_ID.ExceptionMsg = string.Format("Get_Category_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Category_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Category_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Category_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Category_By_OWNER_ID_Adv")]
public Result_Get_Category_By_OWNER_ID_Adv Get_Category_By_OWNER_ID_Adv(Params_Get_Category_By_OWNER_ID i_Params_Get_Category_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Category>  oReturnValue = new List<Category> ();
string i_Ticket = string.Empty;
Result_Get_Category_By_OWNER_ID_Adv oResult_Get_Category_By_OWNER_ID_Adv = new Result_Get_Category_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Category_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Category_By_OWNER_ID_Adv(i_Params_Get_Category_By_OWNER_ID);
oResult_Get_Category_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Category_By_OWNER_ID_Adv.My_Params_Get_Category_By_OWNER_ID = i_Params_Get_Category_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Category_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Category_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Category_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Category_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Category_By_Where
[HttpPost]
[Route("Get_Category_By_Where")]
public Result_Get_Category_By_Where Get_Category_By_Where(Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
#region Declaration And Initialization Section.
List<Category>  oReturnValue = new List<Category> ();
string i_Ticket = string.Empty;
Result_Get_Category_By_Where oResult_Get_Category_By_Where = new Result_Get_Category_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Category_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Category_By_Where(i_Params_Get_Category_By_Where);
oResult_Get_Category_By_Where.My_Result = oReturnValue;
oResult_Get_Category_By_Where.My_Params_Get_Category_By_Where = i_Params_Get_Category_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Category_By_Where.ExceptionMsg = string.Format("Get_Category_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Category_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Category_By_Where;
#endregion
}
#endregion
#region Get_Category_By_Where_Adv
[HttpPost]
[Route("Get_Category_By_Where_Adv")]
public Result_Get_Category_By_Where_Adv Get_Category_By_Where_Adv(Params_Get_Category_By_Where i_Params_Get_Category_By_Where)
{
#region Declaration And Initialization Section.
List<Category>  oReturnValue = new List<Category> ();
string i_Ticket = string.Empty;
Result_Get_Category_By_Where_Adv oResult_Get_Category_By_Where_Adv = new Result_Get_Category_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Category_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Category_By_Where_Adv(i_Params_Get_Category_By_Where);
oResult_Get_Category_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Category_By_Where_Adv.My_Params_Get_Category_By_Where = i_Params_Get_Category_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Category_By_Where_Adv.ExceptionMsg = string.Format("Get_Category_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Category_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Category_By_Where_Adv;
#endregion
}
#endregion
#region Get_Client_By_CLIENT_ID
[HttpPost]
[Route("Get_Client_By_CLIENT_ID")]
public Result_Get_Client_By_CLIENT_ID Get_Client_By_CLIENT_ID(Params_Get_Client_By_CLIENT_ID i_Params_Get_Client_By_CLIENT_ID)
{
#region Declaration And Initialization Section.
Client oReturnValue = new Client();
string i_Ticket = string.Empty;
Result_Get_Client_By_CLIENT_ID oResult_Get_Client_By_CLIENT_ID = new Result_Get_Client_By_CLIENT_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_CLIENT_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Client_By_CLIENT_ID(i_Params_Get_Client_By_CLIENT_ID);
oResult_Get_Client_By_CLIENT_ID.My_Result = oReturnValue;
oResult_Get_Client_By_CLIENT_ID.My_Params_Get_Client_By_CLIENT_ID = i_Params_Get_Client_By_CLIENT_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_CLIENT_ID.ExceptionMsg = string.Format("Get_Client_By_CLIENT_ID : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_CLIENT_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_CLIENT_ID;
#endregion
}
#endregion
#region Get_Client_By_CLIENT_ID_Adv
[HttpPost]
[Route("Get_Client_By_CLIENT_ID_Adv")]
public Result_Get_Client_By_CLIENT_ID_Adv Get_Client_By_CLIENT_ID_Adv(Params_Get_Client_By_CLIENT_ID i_Params_Get_Client_By_CLIENT_ID)
{
#region Declaration And Initialization Section.
Client oReturnValue = new Client();
string i_Ticket = string.Empty;
Result_Get_Client_By_CLIENT_ID_Adv oResult_Get_Client_By_CLIENT_ID_Adv = new Result_Get_Client_By_CLIENT_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_CLIENT_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Client_By_CLIENT_ID_Adv(i_Params_Get_Client_By_CLIENT_ID);
oResult_Get_Client_By_CLIENT_ID_Adv.My_Result = oReturnValue;
oResult_Get_Client_By_CLIENT_ID_Adv.My_Params_Get_Client_By_CLIENT_ID = i_Params_Get_Client_By_CLIENT_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_CLIENT_ID_Adv.ExceptionMsg = string.Format("Get_Client_By_CLIENT_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_CLIENT_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_CLIENT_ID_Adv;
#endregion
}
#endregion
#region Get_Client_By_Criteria
[HttpPost]
[Route("Get_Client_By_Criteria")]
public Result_Get_Client_By_Criteria Get_Client_By_Criteria(Params_Get_Client_By_Criteria i_Params_Get_Client_By_Criteria)
{
#region Declaration And Initialization Section.
List<Client>  oReturnValue = new List<Client> ();
string i_Ticket = string.Empty;
Result_Get_Client_By_Criteria oResult_Get_Client_By_Criteria = new Result_Get_Client_By_Criteria();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_Criteria);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Client_By_Criteria(i_Params_Get_Client_By_Criteria);
oResult_Get_Client_By_Criteria.My_Result = oReturnValue;
oResult_Get_Client_By_Criteria.My_Params_Get_Client_By_Criteria = i_Params_Get_Client_By_Criteria;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_Criteria.ExceptionMsg = string.Format("Get_Client_By_Criteria : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_Criteria.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_Criteria;
#endregion
}
#endregion
#region Get_Client_By_OWNER_ID
[HttpPost]
[Route("Get_Client_By_OWNER_ID")]
public Result_Get_Client_By_OWNER_ID Get_Client_By_OWNER_ID(Params_Get_Client_By_OWNER_ID i_Params_Get_Client_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Client>  oReturnValue = new List<Client> ();
string i_Ticket = string.Empty;
Result_Get_Client_By_OWNER_ID oResult_Get_Client_By_OWNER_ID = new Result_Get_Client_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Client_By_OWNER_ID(i_Params_Get_Client_By_OWNER_ID);
oResult_Get_Client_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Client_By_OWNER_ID.My_Params_Get_Client_By_OWNER_ID = i_Params_Get_Client_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_OWNER_ID.ExceptionMsg = string.Format("Get_Client_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Client_By_USERNAME
[HttpPost]
[Route("Get_Client_By_USERNAME")]
public Result_Get_Client_By_USERNAME Get_Client_By_USERNAME(Params_Get_Client_By_USERNAME i_Params_Get_Client_By_USERNAME)
{
#region Declaration And Initialization Section.
List<Client>  oReturnValue = new List<Client> ();
string i_Ticket = string.Empty;
Result_Get_Client_By_USERNAME oResult_Get_Client_By_USERNAME = new Result_Get_Client_By_USERNAME();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_USERNAME);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Client_By_USERNAME(i_Params_Get_Client_By_USERNAME);
oResult_Get_Client_By_USERNAME.My_Result = oReturnValue;
oResult_Get_Client_By_USERNAME.My_Params_Get_Client_By_USERNAME = i_Params_Get_Client_By_USERNAME;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_USERNAME.ExceptionMsg = string.Format("Get_Client_By_USERNAME : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_USERNAME.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_USERNAME;
#endregion
}
#endregion
#region Get_Client_By_USERNAME_Adv
[HttpPost]
[Route("Get_Client_By_USERNAME_Adv")]
public Result_Get_Client_By_USERNAME_Adv Get_Client_By_USERNAME_Adv(Params_Get_Client_By_USERNAME i_Params_Get_Client_By_USERNAME)
{
#region Declaration And Initialization Section.
List<Client>  oReturnValue = new List<Client> ();
string i_Ticket = string.Empty;
Result_Get_Client_By_USERNAME_Adv oResult_Get_Client_By_USERNAME_Adv = new Result_Get_Client_By_USERNAME_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_USERNAME_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Client_By_USERNAME_Adv(i_Params_Get_Client_By_USERNAME);
oResult_Get_Client_By_USERNAME_Adv.My_Result = oReturnValue;
oResult_Get_Client_By_USERNAME_Adv.My_Params_Get_Client_By_USERNAME = i_Params_Get_Client_By_USERNAME;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_USERNAME_Adv.ExceptionMsg = string.Format("Get_Client_By_USERNAME_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_USERNAME_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_USERNAME_Adv;
#endregion
}
#endregion
#region Get_Client_By_Where
[HttpPost]
[Route("Get_Client_By_Where")]
public Result_Get_Client_By_Where Get_Client_By_Where(Params_Get_Client_By_Where i_Params_Get_Client_By_Where)
{
#region Declaration And Initialization Section.
List<Client>  oReturnValue = new List<Client> ();
string i_Ticket = string.Empty;
Result_Get_Client_By_Where oResult_Get_Client_By_Where = new Result_Get_Client_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Client_By_Where(i_Params_Get_Client_By_Where);
oResult_Get_Client_By_Where.My_Result = oReturnValue;
oResult_Get_Client_By_Where.My_Params_Get_Client_By_Where = i_Params_Get_Client_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_Where.ExceptionMsg = string.Format("Get_Client_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_Where;
#endregion
}
#endregion
#region Get_Client_By_Where_Adv
[HttpPost]
[Route("Get_Client_By_Where_Adv")]
public Result_Get_Client_By_Where_Adv Get_Client_By_Where_Adv(Params_Get_Client_By_Where i_Params_Get_Client_By_Where)
{
#region Declaration And Initialization Section.
List<Client>  oReturnValue = new List<Client> ();
string i_Ticket = string.Empty;
Result_Get_Client_By_Where_Adv oResult_Get_Client_By_Where_Adv = new Result_Get_Client_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Client_By_Where_Adv(i_Params_Get_Client_By_Where);
oResult_Get_Client_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Client_By_Where_Adv.My_Params_Get_Client_By_Where = i_Params_Get_Client_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_Where_Adv.ExceptionMsg = string.Format("Get_Client_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_Where_Adv;
#endregion
}
#endregion
#region Get_Coordinates_By_OWNER_ID
[HttpPost]
[Route("Get_Coordinates_By_OWNER_ID")]
public Result_Get_Coordinates_By_OWNER_ID Get_Coordinates_By_OWNER_ID(Params_Get_Coordinates_By_OWNER_ID i_Params_Get_Coordinates_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Coordinates>  oReturnValue = new List<Coordinates> ();
string i_Ticket = string.Empty;
Result_Get_Coordinates_By_OWNER_ID oResult_Get_Coordinates_By_OWNER_ID = new Result_Get_Coordinates_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Coordinates_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Coordinates_By_OWNER_ID(i_Params_Get_Coordinates_By_OWNER_ID);
oResult_Get_Coordinates_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Coordinates_By_OWNER_ID.My_Params_Get_Coordinates_By_OWNER_ID = i_Params_Get_Coordinates_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Coordinates_By_OWNER_ID.ExceptionMsg = string.Format("Get_Coordinates_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Coordinates_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Coordinates_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Coordinates_By_Where
[HttpPost]
[Route("Get_Coordinates_By_Where")]
public Result_Get_Coordinates_By_Where Get_Coordinates_By_Where(Params_Get_Coordinates_By_Where i_Params_Get_Coordinates_By_Where)
{
#region Declaration And Initialization Section.
List<Coordinates>  oReturnValue = new List<Coordinates> ();
string i_Ticket = string.Empty;
Result_Get_Coordinates_By_Where oResult_Get_Coordinates_By_Where = new Result_Get_Coordinates_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Coordinates_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Coordinates_By_Where(i_Params_Get_Coordinates_By_Where);
oResult_Get_Coordinates_By_Where.My_Result = oReturnValue;
oResult_Get_Coordinates_By_Where.My_Params_Get_Coordinates_By_Where = i_Params_Get_Coordinates_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Coordinates_By_Where.ExceptionMsg = string.Format("Get_Coordinates_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Coordinates_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Coordinates_By_Where;
#endregion
}
#endregion
#region Get_Coordinates_By_Where_Adv
[HttpPost]
[Route("Get_Coordinates_By_Where_Adv")]
public Result_Get_Coordinates_By_Where_Adv Get_Coordinates_By_Where_Adv(Params_Get_Coordinates_By_Where i_Params_Get_Coordinates_By_Where)
{
#region Declaration And Initialization Section.
List<Coordinates>  oReturnValue = new List<Coordinates> ();
string i_Ticket = string.Empty;
Result_Get_Coordinates_By_Where_Adv oResult_Get_Coordinates_By_Where_Adv = new Result_Get_Coordinates_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Coordinates_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Coordinates_By_Where_Adv(i_Params_Get_Coordinates_By_Where);
oResult_Get_Coordinates_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Coordinates_By_Where_Adv.My_Params_Get_Coordinates_By_Where = i_Params_Get_Coordinates_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Coordinates_By_Where_Adv.ExceptionMsg = string.Format("Get_Coordinates_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Coordinates_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Coordinates_By_Where_Adv;
#endregion
}
#endregion
#region Get_Currency_By_CURRENCY_ID
[HttpPost]
[Route("Get_Currency_By_CURRENCY_ID")]
public Result_Get_Currency_By_CURRENCY_ID Get_Currency_By_CURRENCY_ID(Params_Get_Currency_By_CURRENCY_ID i_Params_Get_Currency_By_CURRENCY_ID)
{
#region Declaration And Initialization Section.
Currency oReturnValue = new Currency();
string i_Ticket = string.Empty;
Result_Get_Currency_By_CURRENCY_ID oResult_Get_Currency_By_CURRENCY_ID = new Result_Get_Currency_By_CURRENCY_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Currency_By_CURRENCY_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Currency_By_CURRENCY_ID(i_Params_Get_Currency_By_CURRENCY_ID);
oResult_Get_Currency_By_CURRENCY_ID.My_Result = oReturnValue;
oResult_Get_Currency_By_CURRENCY_ID.My_Params_Get_Currency_By_CURRENCY_ID = i_Params_Get_Currency_By_CURRENCY_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Currency_By_CURRENCY_ID.ExceptionMsg = string.Format("Get_Currency_By_CURRENCY_ID : {0}", ex.Message);
}
else
{
oResult_Get_Currency_By_CURRENCY_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Currency_By_CURRENCY_ID;
#endregion
}
#endregion
#region Get_Currency_By_OWNER_ID
[HttpPost]
[Route("Get_Currency_By_OWNER_ID")]
public Result_Get_Currency_By_OWNER_ID Get_Currency_By_OWNER_ID(Params_Get_Currency_By_OWNER_ID i_Params_Get_Currency_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Currency>  oReturnValue = new List<Currency> ();
string i_Ticket = string.Empty;
Result_Get_Currency_By_OWNER_ID oResult_Get_Currency_By_OWNER_ID = new Result_Get_Currency_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Currency_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Currency_By_OWNER_ID(i_Params_Get_Currency_By_OWNER_ID);
oResult_Get_Currency_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Currency_By_OWNER_ID.My_Params_Get_Currency_By_OWNER_ID = i_Params_Get_Currency_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Currency_By_OWNER_ID.ExceptionMsg = string.Format("Get_Currency_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Currency_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Currency_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Currency_By_Where
[HttpPost]
[Route("Get_Currency_By_Where")]
public Result_Get_Currency_By_Where Get_Currency_By_Where(Params_Get_Currency_By_Where i_Params_Get_Currency_By_Where)
{
#region Declaration And Initialization Section.
List<Currency>  oReturnValue = new List<Currency> ();
string i_Ticket = string.Empty;
Result_Get_Currency_By_Where oResult_Get_Currency_By_Where = new Result_Get_Currency_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Currency_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Currency_By_Where(i_Params_Get_Currency_By_Where);
oResult_Get_Currency_By_Where.My_Result = oReturnValue;
oResult_Get_Currency_By_Where.My_Params_Get_Currency_By_Where = i_Params_Get_Currency_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Currency_By_Where.ExceptionMsg = string.Format("Get_Currency_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Currency_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Currency_By_Where;
#endregion
}
#endregion
#region Get_Feedback_By_BOOKING_ID
[HttpPost]
[Route("Get_Feedback_By_BOOKING_ID")]
public Result_Get_Feedback_By_BOOKING_ID Get_Feedback_By_BOOKING_ID(Params_Get_Feedback_By_BOOKING_ID i_Params_Get_Feedback_By_BOOKING_ID)
{
#region Declaration And Initialization Section.
List<Feedback>  oReturnValue = new List<Feedback> ();
string i_Ticket = string.Empty;
Result_Get_Feedback_By_BOOKING_ID oResult_Get_Feedback_By_BOOKING_ID = new Result_Get_Feedback_By_BOOKING_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Feedback_By_BOOKING_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Feedback_By_BOOKING_ID(i_Params_Get_Feedback_By_BOOKING_ID);
oResult_Get_Feedback_By_BOOKING_ID.My_Result = oReturnValue;
oResult_Get_Feedback_By_BOOKING_ID.My_Params_Get_Feedback_By_BOOKING_ID = i_Params_Get_Feedback_By_BOOKING_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Feedback_By_BOOKING_ID.ExceptionMsg = string.Format("Get_Feedback_By_BOOKING_ID : {0}", ex.Message);
}
else
{
oResult_Get_Feedback_By_BOOKING_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Feedback_By_BOOKING_ID;
#endregion
}
#endregion
#region Get_Feedback_By_FEEDBACK_ID
[HttpPost]
[Route("Get_Feedback_By_FEEDBACK_ID")]
public Result_Get_Feedback_By_FEEDBACK_ID Get_Feedback_By_FEEDBACK_ID(Params_Get_Feedback_By_FEEDBACK_ID i_Params_Get_Feedback_By_FEEDBACK_ID)
{
#region Declaration And Initialization Section.
Feedback oReturnValue = new Feedback();
string i_Ticket = string.Empty;
Result_Get_Feedback_By_FEEDBACK_ID oResult_Get_Feedback_By_FEEDBACK_ID = new Result_Get_Feedback_By_FEEDBACK_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Feedback_By_FEEDBACK_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Feedback_By_FEEDBACK_ID(i_Params_Get_Feedback_By_FEEDBACK_ID);
oResult_Get_Feedback_By_FEEDBACK_ID.My_Result = oReturnValue;
oResult_Get_Feedback_By_FEEDBACK_ID.My_Params_Get_Feedback_By_FEEDBACK_ID = i_Params_Get_Feedback_By_FEEDBACK_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Feedback_By_FEEDBACK_ID.ExceptionMsg = string.Format("Get_Feedback_By_FEEDBACK_ID : {0}", ex.Message);
}
else
{
oResult_Get_Feedback_By_FEEDBACK_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Feedback_By_FEEDBACK_ID;
#endregion
}
#endregion
#region Get_Feedback_By_OWNER_ID
[HttpPost]
[Route("Get_Feedback_By_OWNER_ID")]
public Result_Get_Feedback_By_OWNER_ID Get_Feedback_By_OWNER_ID(Params_Get_Feedback_By_OWNER_ID i_Params_Get_Feedback_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Feedback>  oReturnValue = new List<Feedback> ();
string i_Ticket = string.Empty;
Result_Get_Feedback_By_OWNER_ID oResult_Get_Feedback_By_OWNER_ID = new Result_Get_Feedback_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Feedback_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Feedback_By_OWNER_ID(i_Params_Get_Feedback_By_OWNER_ID);
oResult_Get_Feedback_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Feedback_By_OWNER_ID.My_Params_Get_Feedback_By_OWNER_ID = i_Params_Get_Feedback_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Feedback_By_OWNER_ID.ExceptionMsg = string.Format("Get_Feedback_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Feedback_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Feedback_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Feedback_By_Where
[HttpPost]
[Route("Get_Feedback_By_Where")]
public Result_Get_Feedback_By_Where Get_Feedback_By_Where(Params_Get_Feedback_By_Where i_Params_Get_Feedback_By_Where)
{
#region Declaration And Initialization Section.
List<Feedback>  oReturnValue = new List<Feedback> ();
string i_Ticket = string.Empty;
Result_Get_Feedback_By_Where oResult_Get_Feedback_By_Where = new Result_Get_Feedback_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Feedback_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Feedback_By_Where(i_Params_Get_Feedback_By_Where);
oResult_Get_Feedback_By_Where.My_Result = oReturnValue;
oResult_Get_Feedback_By_Where.My_Params_Get_Feedback_By_Where = i_Params_Get_Feedback_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Feedback_By_Where.ExceptionMsg = string.Format("Get_Feedback_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Feedback_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Feedback_By_Where;
#endregion
}
#endregion
#region Get_Feedback_By_Where_Adv
[HttpPost]
[Route("Get_Feedback_By_Where_Adv")]
public Result_Get_Feedback_By_Where_Adv Get_Feedback_By_Where_Adv(Params_Get_Feedback_By_Where i_Params_Get_Feedback_By_Where)
{
#region Declaration And Initialization Section.
List<Feedback>  oReturnValue = new List<Feedback> ();
string i_Ticket = string.Empty;
Result_Get_Feedback_By_Where_Adv oResult_Get_Feedback_By_Where_Adv = new Result_Get_Feedback_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Feedback_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Feedback_By_Where_Adv(i_Params_Get_Feedback_By_Where);
oResult_Get_Feedback_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Feedback_By_Where_Adv.My_Params_Get_Feedback_By_Where = i_Params_Get_Feedback_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Feedback_By_Where_Adv.ExceptionMsg = string.Format("Get_Feedback_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Feedback_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Feedback_By_Where_Adv;
#endregion
}
#endregion
#region Get_Service_prod_By_BUSINESS_ID
[HttpPost]
[Route("Get_Service_prod_By_BUSINESS_ID")]
public Result_Get_Service_prod_By_BUSINESS_ID Get_Service_prod_By_BUSINESS_ID(Params_Get_Service_prod_By_BUSINESS_ID i_Params_Get_Service_prod_By_BUSINESS_ID)
{
#region Declaration And Initialization Section.
List<Service_prod>  oReturnValue = new List<Service_prod> ();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_BUSINESS_ID oResult_Get_Service_prod_By_BUSINESS_ID = new Result_Get_Service_prod_By_BUSINESS_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_BUSINESS_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_BUSINESS_ID(i_Params_Get_Service_prod_By_BUSINESS_ID);
oResult_Get_Service_prod_By_BUSINESS_ID.My_Result = oReturnValue;
oResult_Get_Service_prod_By_BUSINESS_ID.My_Params_Get_Service_prod_By_BUSINESS_ID = i_Params_Get_Service_prod_By_BUSINESS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_BUSINESS_ID.ExceptionMsg = string.Format("Get_Service_prod_By_BUSINESS_ID : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_BUSINESS_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_BUSINESS_ID;
#endregion
}
#endregion
#region Get_Service_prod_By_BUSINESS_ID_Adv
[HttpPost]
[Route("Get_Service_prod_By_BUSINESS_ID_Adv")]
public Result_Get_Service_prod_By_BUSINESS_ID_Adv Get_Service_prod_By_BUSINESS_ID_Adv(Params_Get_Service_prod_By_BUSINESS_ID i_Params_Get_Service_prod_By_BUSINESS_ID)
{
#region Declaration And Initialization Section.
List<Service_prod>  oReturnValue = new List<Service_prod> ();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_BUSINESS_ID_Adv oResult_Get_Service_prod_By_BUSINESS_ID_Adv = new Result_Get_Service_prod_By_BUSINESS_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_BUSINESS_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_BUSINESS_ID_Adv(i_Params_Get_Service_prod_By_BUSINESS_ID);
oResult_Get_Service_prod_By_BUSINESS_ID_Adv.My_Result = oReturnValue;
oResult_Get_Service_prod_By_BUSINESS_ID_Adv.My_Params_Get_Service_prod_By_BUSINESS_ID = i_Params_Get_Service_prod_By_BUSINESS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_BUSINESS_ID_Adv.ExceptionMsg = string.Format("Get_Service_prod_By_BUSINESS_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_BUSINESS_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_BUSINESS_ID_Adv;
#endregion
}
#endregion
#region Get_Service_prod_By_OWNER_ID
[HttpPost]
[Route("Get_Service_prod_By_OWNER_ID")]
public Result_Get_Service_prod_By_OWNER_ID Get_Service_prod_By_OWNER_ID(Params_Get_Service_prod_By_OWNER_ID i_Params_Get_Service_prod_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Service_prod>  oReturnValue = new List<Service_prod> ();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_OWNER_ID oResult_Get_Service_prod_By_OWNER_ID = new Result_Get_Service_prod_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_OWNER_ID(i_Params_Get_Service_prod_By_OWNER_ID);
oResult_Get_Service_prod_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Service_prod_By_OWNER_ID.My_Params_Get_Service_prod_By_OWNER_ID = i_Params_Get_Service_prod_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_OWNER_ID.ExceptionMsg = string.Format("Get_Service_prod_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Service_prod_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Service_prod_By_OWNER_ID_Adv")]
public Result_Get_Service_prod_By_OWNER_ID_Adv Get_Service_prod_By_OWNER_ID_Adv(Params_Get_Service_prod_By_OWNER_ID i_Params_Get_Service_prod_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Service_prod>  oReturnValue = new List<Service_prod> ();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_OWNER_ID_Adv oResult_Get_Service_prod_By_OWNER_ID_Adv = new Result_Get_Service_prod_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_OWNER_ID_Adv(i_Params_Get_Service_prod_By_OWNER_ID);
oResult_Get_Service_prod_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Service_prod_By_OWNER_ID_Adv.My_Params_Get_Service_prod_By_OWNER_ID = i_Params_Get_Service_prod_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Service_prod_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Service_prod_By_SERVICE_PROD_ID
[HttpPost]
[Route("Get_Service_prod_By_SERVICE_PROD_ID")]
public Result_Get_Service_prod_By_SERVICE_PROD_ID Get_Service_prod_By_SERVICE_PROD_ID(Params_Get_Service_prod_By_SERVICE_PROD_ID i_Params_Get_Service_prod_By_SERVICE_PROD_ID)
{
#region Declaration And Initialization Section.
Service_prod oReturnValue = new Service_prod();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_SERVICE_PROD_ID oResult_Get_Service_prod_By_SERVICE_PROD_ID = new Result_Get_Service_prod_By_SERVICE_PROD_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_SERVICE_PROD_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_SERVICE_PROD_ID(i_Params_Get_Service_prod_By_SERVICE_PROD_ID);
oResult_Get_Service_prod_By_SERVICE_PROD_ID.My_Result = oReturnValue;
oResult_Get_Service_prod_By_SERVICE_PROD_ID.My_Params_Get_Service_prod_By_SERVICE_PROD_ID = i_Params_Get_Service_prod_By_SERVICE_PROD_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_SERVICE_PROD_ID.ExceptionMsg = string.Format("Get_Service_prod_By_SERVICE_PROD_ID : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_SERVICE_PROD_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_SERVICE_PROD_ID;
#endregion
}
#endregion
#region Get_Service_prod_By_SERVICE_PROD_ID_Adv
[HttpPost]
[Route("Get_Service_prod_By_SERVICE_PROD_ID_Adv")]
public Result_Get_Service_prod_By_SERVICE_PROD_ID_Adv Get_Service_prod_By_SERVICE_PROD_ID_Adv(Params_Get_Service_prod_By_SERVICE_PROD_ID i_Params_Get_Service_prod_By_SERVICE_PROD_ID)
{
#region Declaration And Initialization Section.
Service_prod oReturnValue = new Service_prod();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_SERVICE_PROD_ID_Adv oResult_Get_Service_prod_By_SERVICE_PROD_ID_Adv = new Result_Get_Service_prod_By_SERVICE_PROD_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_SERVICE_PROD_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_SERVICE_PROD_ID_Adv(i_Params_Get_Service_prod_By_SERVICE_PROD_ID);
oResult_Get_Service_prod_By_SERVICE_PROD_ID_Adv.My_Result = oReturnValue;
oResult_Get_Service_prod_By_SERVICE_PROD_ID_Adv.My_Params_Get_Service_prod_By_SERVICE_PROD_ID = i_Params_Get_Service_prod_By_SERVICE_PROD_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_SERVICE_PROD_ID_Adv.ExceptionMsg = string.Format("Get_Service_prod_By_SERVICE_PROD_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_SERVICE_PROD_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_SERVICE_PROD_ID_Adv;
#endregion
}
#endregion
#region Get_Service_prod_By_SUB_CATEGORY_ID
[HttpPost]
[Route("Get_Service_prod_By_SUB_CATEGORY_ID")]
public Result_Get_Service_prod_By_SUB_CATEGORY_ID Get_Service_prod_By_SUB_CATEGORY_ID(Params_Get_Service_prod_By_SUB_CATEGORY_ID i_Params_Get_Service_prod_By_SUB_CATEGORY_ID)
{
#region Declaration And Initialization Section.
List<Service_prod>  oReturnValue = new List<Service_prod> ();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_SUB_CATEGORY_ID oResult_Get_Service_prod_By_SUB_CATEGORY_ID = new Result_Get_Service_prod_By_SUB_CATEGORY_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_SUB_CATEGORY_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_SUB_CATEGORY_ID(i_Params_Get_Service_prod_By_SUB_CATEGORY_ID);
oResult_Get_Service_prod_By_SUB_CATEGORY_ID.My_Result = oReturnValue;
oResult_Get_Service_prod_By_SUB_CATEGORY_ID.My_Params_Get_Service_prod_By_SUB_CATEGORY_ID = i_Params_Get_Service_prod_By_SUB_CATEGORY_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_SUB_CATEGORY_ID.ExceptionMsg = string.Format("Get_Service_prod_By_SUB_CATEGORY_ID : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_SUB_CATEGORY_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_SUB_CATEGORY_ID;
#endregion
}
#endregion
#region Get_Service_prod_By_SUB_CATEGORY_ID_Adv
[HttpPost]
[Route("Get_Service_prod_By_SUB_CATEGORY_ID_Adv")]
public Result_Get_Service_prod_By_SUB_CATEGORY_ID_Adv Get_Service_prod_By_SUB_CATEGORY_ID_Adv(Params_Get_Service_prod_By_SUB_CATEGORY_ID i_Params_Get_Service_prod_By_SUB_CATEGORY_ID)
{
#region Declaration And Initialization Section.
List<Service_prod>  oReturnValue = new List<Service_prod> ();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_SUB_CATEGORY_ID_Adv oResult_Get_Service_prod_By_SUB_CATEGORY_ID_Adv = new Result_Get_Service_prod_By_SUB_CATEGORY_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_SUB_CATEGORY_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_SUB_CATEGORY_ID_Adv(i_Params_Get_Service_prod_By_SUB_CATEGORY_ID);
oResult_Get_Service_prod_By_SUB_CATEGORY_ID_Adv.My_Result = oReturnValue;
oResult_Get_Service_prod_By_SUB_CATEGORY_ID_Adv.My_Params_Get_Service_prod_By_SUB_CATEGORY_ID = i_Params_Get_Service_prod_By_SUB_CATEGORY_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_SUB_CATEGORY_ID_Adv.ExceptionMsg = string.Format("Get_Service_prod_By_SUB_CATEGORY_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_SUB_CATEGORY_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_SUB_CATEGORY_ID_Adv;
#endregion
}
#endregion
#region Get_Service_prod_By_Where
[HttpPost]
[Route("Get_Service_prod_By_Where")]
public Result_Get_Service_prod_By_Where Get_Service_prod_By_Where(Params_Get_Service_prod_By_Where i_Params_Get_Service_prod_By_Where)
{
#region Declaration And Initialization Section.
List<Service_prod>  oReturnValue = new List<Service_prod> ();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_Where oResult_Get_Service_prod_By_Where = new Result_Get_Service_prod_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_Where(i_Params_Get_Service_prod_By_Where);
oResult_Get_Service_prod_By_Where.My_Result = oReturnValue;
oResult_Get_Service_prod_By_Where.My_Params_Get_Service_prod_By_Where = i_Params_Get_Service_prod_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_Where.ExceptionMsg = string.Format("Get_Service_prod_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_Where;
#endregion
}
#endregion
#region Get_Service_prod_By_Where_Adv
[HttpPost]
[Route("Get_Service_prod_By_Where_Adv")]
public Result_Get_Service_prod_By_Where_Adv Get_Service_prod_By_Where_Adv(Params_Get_Service_prod_By_Where i_Params_Get_Service_prod_By_Where)
{
#region Declaration And Initialization Section.
List<Service_prod>  oReturnValue = new List<Service_prod> ();
string i_Ticket = string.Empty;
Result_Get_Service_prod_By_Where_Adv oResult_Get_Service_prod_By_Where_Adv = new Result_Get_Service_prod_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Service_prod_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Service_prod_By_Where_Adv(i_Params_Get_Service_prod_By_Where);
oResult_Get_Service_prod_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Service_prod_By_Where_Adv.My_Params_Get_Service_prod_By_Where = i_Params_Get_Service_prod_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Service_prod_By_Where_Adv.ExceptionMsg = string.Format("Get_Service_prod_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Service_prod_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Service_prod_By_Where_Adv;
#endregion
}
#endregion
#region Get_SetupEntries_Per_Table
[HttpPost]
[Route("Get_SetupEntries_Per_Table")]
public Result_Get_SetupEntries_Per_Table Get_SetupEntries_Per_Table(Params_Get_SetupEntries_Per_Table i_Params_Get_SetupEntries_Per_Table)
{
#region Declaration And Initialization Section.
List<SetupEntry>  oReturnValue = new List<SetupEntry> ();
string i_Ticket = string.Empty;
Result_Get_SetupEntries_Per_Table oResult_Get_SetupEntries_Per_Table = new Result_Get_SetupEntries_Per_Table();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_SetupEntries_Per_Table);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_SetupEntries_Per_Table(i_Params_Get_SetupEntries_Per_Table);
oResult_Get_SetupEntries_Per_Table.My_Result = oReturnValue;
oResult_Get_SetupEntries_Per_Table.My_Params_Get_SetupEntries_Per_Table = i_Params_Get_SetupEntries_Per_Table;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_SetupEntries_Per_Table.ExceptionMsg = string.Format("Get_SetupEntries_Per_Table : {0}", ex.Message);
}
else
{
oResult_Get_SetupEntries_Per_Table.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_SetupEntries_Per_Table;
#endregion
}
#endregion
#region Get_Status_By_OWNER_ID
[HttpPost]
[Route("Get_Status_By_OWNER_ID")]
public Result_Get_Status_By_OWNER_ID Get_Status_By_OWNER_ID(Params_Get_Status_By_OWNER_ID i_Params_Get_Status_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Status>  oReturnValue = new List<Status> ();
string i_Ticket = string.Empty;
Result_Get_Status_By_OWNER_ID oResult_Get_Status_By_OWNER_ID = new Result_Get_Status_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Status_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Status_By_OWNER_ID(i_Params_Get_Status_By_OWNER_ID);
oResult_Get_Status_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Status_By_OWNER_ID.My_Params_Get_Status_By_OWNER_ID = i_Params_Get_Status_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Status_By_OWNER_ID.ExceptionMsg = string.Format("Get_Status_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Status_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Status_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Status_By_STATUS_ID
[HttpPost]
[Route("Get_Status_By_STATUS_ID")]
public Result_Get_Status_By_STATUS_ID Get_Status_By_STATUS_ID(Params_Get_Status_By_STATUS_ID i_Params_Get_Status_By_STATUS_ID)
{
#region Declaration And Initialization Section.
Status oReturnValue = new Status();
string i_Ticket = string.Empty;
Result_Get_Status_By_STATUS_ID oResult_Get_Status_By_STATUS_ID = new Result_Get_Status_By_STATUS_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Status_By_STATUS_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Status_By_STATUS_ID(i_Params_Get_Status_By_STATUS_ID);
oResult_Get_Status_By_STATUS_ID.My_Result = oReturnValue;
oResult_Get_Status_By_STATUS_ID.My_Params_Get_Status_By_STATUS_ID = i_Params_Get_Status_By_STATUS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Status_By_STATUS_ID.ExceptionMsg = string.Format("Get_Status_By_STATUS_ID : {0}", ex.Message);
}
else
{
oResult_Get_Status_By_STATUS_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Status_By_STATUS_ID;
#endregion
}
#endregion
#region Get_Sub_category_By_CATEGORY_ID
[HttpPost]
[Route("Get_Sub_category_By_CATEGORY_ID")]
public Result_Get_Sub_category_By_CATEGORY_ID Get_Sub_category_By_CATEGORY_ID(Params_Get_Sub_category_By_CATEGORY_ID i_Params_Get_Sub_category_By_CATEGORY_ID)
{
#region Declaration And Initialization Section.
List<Sub_category>  oReturnValue = new List<Sub_category> ();
string i_Ticket = string.Empty;
Result_Get_Sub_category_By_CATEGORY_ID oResult_Get_Sub_category_By_CATEGORY_ID = new Result_Get_Sub_category_By_CATEGORY_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Sub_category_By_CATEGORY_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Sub_category_By_CATEGORY_ID(i_Params_Get_Sub_category_By_CATEGORY_ID);
oResult_Get_Sub_category_By_CATEGORY_ID.My_Result = oReturnValue;
oResult_Get_Sub_category_By_CATEGORY_ID.My_Params_Get_Sub_category_By_CATEGORY_ID = i_Params_Get_Sub_category_By_CATEGORY_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Sub_category_By_CATEGORY_ID.ExceptionMsg = string.Format("Get_Sub_category_By_CATEGORY_ID : {0}", ex.Message);
}
else
{
oResult_Get_Sub_category_By_CATEGORY_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Sub_category_By_CATEGORY_ID;
#endregion
}
#endregion
#region Get_Sub_category_By_OWNER_ID
[HttpPost]
[Route("Get_Sub_category_By_OWNER_ID")]
public Result_Get_Sub_category_By_OWNER_ID Get_Sub_category_By_OWNER_ID(Params_Get_Sub_category_By_OWNER_ID i_Params_Get_Sub_category_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Sub_category>  oReturnValue = new List<Sub_category> ();
string i_Ticket = string.Empty;
Result_Get_Sub_category_By_OWNER_ID oResult_Get_Sub_category_By_OWNER_ID = new Result_Get_Sub_category_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Sub_category_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Sub_category_By_OWNER_ID(i_Params_Get_Sub_category_By_OWNER_ID);
oResult_Get_Sub_category_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Sub_category_By_OWNER_ID.My_Params_Get_Sub_category_By_OWNER_ID = i_Params_Get_Sub_category_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Sub_category_By_OWNER_ID.ExceptionMsg = string.Format("Get_Sub_category_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Sub_category_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Sub_category_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Sub_category_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Sub_category_By_OWNER_ID_Adv")]
public Result_Get_Sub_category_By_OWNER_ID_Adv Get_Sub_category_By_OWNER_ID_Adv(Params_Get_Sub_category_By_OWNER_ID i_Params_Get_Sub_category_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Sub_category>  oReturnValue = new List<Sub_category> ();
string i_Ticket = string.Empty;
Result_Get_Sub_category_By_OWNER_ID_Adv oResult_Get_Sub_category_By_OWNER_ID_Adv = new Result_Get_Sub_category_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Sub_category_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Sub_category_By_OWNER_ID_Adv(i_Params_Get_Sub_category_By_OWNER_ID);
oResult_Get_Sub_category_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Sub_category_By_OWNER_ID_Adv.My_Params_Get_Sub_category_By_OWNER_ID = i_Params_Get_Sub_category_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Sub_category_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Sub_category_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Sub_category_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Sub_category_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Sub_category_By_Where
[HttpPost]
[Route("Get_Sub_category_By_Where")]
public Result_Get_Sub_category_By_Where Get_Sub_category_By_Where(Params_Get_Sub_category_By_Where i_Params_Get_Sub_category_By_Where)
{
#region Declaration And Initialization Section.
List<Sub_category>  oReturnValue = new List<Sub_category> ();
string i_Ticket = string.Empty;
Result_Get_Sub_category_By_Where oResult_Get_Sub_category_By_Where = new Result_Get_Sub_category_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Sub_category_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Sub_category_By_Where(i_Params_Get_Sub_category_By_Where);
oResult_Get_Sub_category_By_Where.My_Result = oReturnValue;
oResult_Get_Sub_category_By_Where.My_Params_Get_Sub_category_By_Where = i_Params_Get_Sub_category_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Sub_category_By_Where.ExceptionMsg = string.Format("Get_Sub_category_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Sub_category_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Sub_category_By_Where;
#endregion
}
#endregion
#region Get_Sub_category_By_Where_Adv
[HttpPost]
[Route("Get_Sub_category_By_Where_Adv")]
public Result_Get_Sub_category_By_Where_Adv Get_Sub_category_By_Where_Adv(Params_Get_Sub_category_By_Where i_Params_Get_Sub_category_By_Where)
{
#region Declaration And Initialization Section.
List<Sub_category>  oReturnValue = new List<Sub_category> ();
string i_Ticket = string.Empty;
Result_Get_Sub_category_By_Where_Adv oResult_Get_Sub_category_By_Where_Adv = new Result_Get_Sub_category_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Sub_category_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Sub_category_By_Where_Adv(i_Params_Get_Sub_category_By_Where);
oResult_Get_Sub_category_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Sub_category_By_Where_Adv.My_Params_Get_Sub_category_By_Where = i_Params_Get_Sub_category_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Sub_category_By_Where_Adv.ExceptionMsg = string.Format("Get_Sub_category_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Sub_category_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Sub_category_By_Where_Adv;
#endregion
}
#endregion
#region Get_User_By_Criteria
[HttpPost]
[Route("Get_User_By_Criteria")]
public Result_Get_User_By_Criteria Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
#region Declaration And Initialization Section.
List<User>  oReturnValue = new List<User> ();
string i_Ticket = string.Empty;
Result_Get_User_By_Criteria oResult_Get_User_By_Criteria = new Result_Get_User_By_Criteria();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_Criteria);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_Criteria(i_Params_Get_User_By_Criteria);
oResult_Get_User_By_Criteria.My_Result = oReturnValue;
oResult_Get_User_By_Criteria.My_Params_Get_User_By_Criteria = i_Params_Get_User_By_Criteria;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_Criteria.ExceptionMsg = string.Format("Get_User_By_Criteria : {0}", ex.Message);
}
else
{
oResult_Get_User_By_Criteria.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_Criteria;
#endregion
}
#endregion
#region Get_User_By_Criteria_Adv
[HttpPost]
[Route("Get_User_By_Criteria_Adv")]
public Result_Get_User_By_Criteria_Adv Get_User_By_Criteria_Adv(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
#region Declaration And Initialization Section.
List<User>  oReturnValue = new List<User> ();
string i_Ticket = string.Empty;
Result_Get_User_By_Criteria_Adv oResult_Get_User_By_Criteria_Adv = new Result_Get_User_By_Criteria_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_Criteria_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria);
oResult_Get_User_By_Criteria_Adv.My_Result = oReturnValue;
oResult_Get_User_By_Criteria_Adv.My_Params_Get_User_By_Criteria = i_Params_Get_User_By_Criteria;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_Criteria_Adv.ExceptionMsg = string.Format("Get_User_By_Criteria_Adv : {0}", ex.Message);
}
else
{
oResult_Get_User_By_Criteria_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_Criteria_Adv;
#endregion
}
#endregion
#region Get_User_By_OWNER_ID
[HttpPost]
[Route("Get_User_By_OWNER_ID")]
public Result_Get_User_By_OWNER_ID Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<User>  oReturnValue = new List<User> ();
string i_Ticket = string.Empty;
Result_Get_User_By_OWNER_ID oResult_Get_User_By_OWNER_ID = new Result_Get_User_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID);
oResult_Get_User_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_User_By_OWNER_ID.My_Params_Get_User_By_OWNER_ID = i_Params_Get_User_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_OWNER_ID.ExceptionMsg = string.Format("Get_User_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_User_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_OWNER_ID;
#endregion
}
#endregion
#region Get_User_By_USER_ID
[HttpPost]
[Route("Get_User_By_USER_ID")]
public Result_Get_User_By_USER_ID Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
#region Declaration And Initialization Section.
User oReturnValue = new User();
string i_Ticket = string.Empty;
Result_Get_User_By_USER_ID oResult_Get_User_By_USER_ID = new Result_Get_User_By_USER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_USER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID);
oResult_Get_User_By_USER_ID.My_Result = oReturnValue;
oResult_Get_User_By_USER_ID.My_Params_Get_User_By_USER_ID = i_Params_Get_User_By_USER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_USER_ID.ExceptionMsg = string.Format("Get_User_By_USER_ID : {0}", ex.Message);
}
else
{
oResult_Get_User_By_USER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_USER_ID;
#endregion
}
#endregion
#region Get_User_By_Where
[HttpPost]
[Route("Get_User_By_Where")]
public Result_Get_User_By_Where Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
#region Declaration And Initialization Section.
List<User>  oReturnValue = new List<User> ();
string i_Ticket = string.Empty;
Result_Get_User_By_Where oResult_Get_User_By_Where = new Result_Get_User_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_User_By_Where(i_Params_Get_User_By_Where);
oResult_Get_User_By_Where.My_Result = oReturnValue;
oResult_Get_User_By_Where.My_Params_Get_User_By_Where = i_Params_Get_User_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_Where.ExceptionMsg = string.Format("Get_User_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_User_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_Where;
#endregion
}
#endregion
#region Get_Work_area_By_OWNER_ID
[HttpPost]
[Route("Get_Work_area_By_OWNER_ID")]
public Result_Get_Work_area_By_OWNER_ID Get_Work_area_By_OWNER_ID(Params_Get_Work_area_By_OWNER_ID i_Params_Get_Work_area_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Work_area>  oReturnValue = new List<Work_area> ();
string i_Ticket = string.Empty;
Result_Get_Work_area_By_OWNER_ID oResult_Get_Work_area_By_OWNER_ID = new Result_Get_Work_area_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_area_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_area_By_OWNER_ID(i_Params_Get_Work_area_By_OWNER_ID);
oResult_Get_Work_area_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Work_area_By_OWNER_ID.My_Params_Get_Work_area_By_OWNER_ID = i_Params_Get_Work_area_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_area_By_OWNER_ID.ExceptionMsg = string.Format("Get_Work_area_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Work_area_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_area_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Work_area_By_Where
[HttpPost]
[Route("Get_Work_area_By_Where")]
public Result_Get_Work_area_By_Where Get_Work_area_By_Where(Params_Get_Work_area_By_Where i_Params_Get_Work_area_By_Where)
{
#region Declaration And Initialization Section.
List<Work_area>  oReturnValue = new List<Work_area> ();
string i_Ticket = string.Empty;
Result_Get_Work_area_By_Where oResult_Get_Work_area_By_Where = new Result_Get_Work_area_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_area_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_area_By_Where(i_Params_Get_Work_area_By_Where);
oResult_Get_Work_area_By_Where.My_Result = oReturnValue;
oResult_Get_Work_area_By_Where.My_Params_Get_Work_area_By_Where = i_Params_Get_Work_area_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_area_By_Where.ExceptionMsg = string.Format("Get_Work_area_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_Work_area_By_Where.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_area_By_Where;
#endregion
}
#endregion
#region Get_Work_area_By_Where_Adv
[HttpPost]
[Route("Get_Work_area_By_Where_Adv")]
public Result_Get_Work_area_By_Where_Adv Get_Work_area_By_Where_Adv(Params_Get_Work_area_By_Where i_Params_Get_Work_area_By_Where)
{
#region Declaration And Initialization Section.
List<Work_area>  oReturnValue = new List<Work_area> ();
string i_Ticket = string.Empty;
Result_Get_Work_area_By_Where_Adv oResult_Get_Work_area_By_Where_Adv = new Result_Get_Work_area_By_Where_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_area_By_Where_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_area_By_Where_Adv(i_Params_Get_Work_area_By_Where);
oResult_Get_Work_area_By_Where_Adv.My_Result = oReturnValue;
oResult_Get_Work_area_By_Where_Adv.My_Params_Get_Work_area_By_Where = i_Params_Get_Work_area_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_area_By_Where_Adv.ExceptionMsg = string.Format("Get_Work_area_By_Where_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Work_area_By_Where_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_area_By_Where_Adv;
#endregion
}
#endregion
#region Get_Work_list_By_BUSINESS_ID
[HttpPost]
[Route("Get_Work_list_By_BUSINESS_ID")]
public Result_Get_Work_list_By_BUSINESS_ID Get_Work_list_By_BUSINESS_ID(Params_Get_Work_list_By_BUSINESS_ID i_Params_Get_Work_list_By_BUSINESS_ID)
{
#region Declaration And Initialization Section.
List<Work_list>  oReturnValue = new List<Work_list> ();
string i_Ticket = string.Empty;
Result_Get_Work_list_By_BUSINESS_ID oResult_Get_Work_list_By_BUSINESS_ID = new Result_Get_Work_list_By_BUSINESS_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_list_By_BUSINESS_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_list_By_BUSINESS_ID(i_Params_Get_Work_list_By_BUSINESS_ID);
oResult_Get_Work_list_By_BUSINESS_ID.My_Result = oReturnValue;
oResult_Get_Work_list_By_BUSINESS_ID.My_Params_Get_Work_list_By_BUSINESS_ID = i_Params_Get_Work_list_By_BUSINESS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_list_By_BUSINESS_ID.ExceptionMsg = string.Format("Get_Work_list_By_BUSINESS_ID : {0}", ex.Message);
}
else
{
oResult_Get_Work_list_By_BUSINESS_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_list_By_BUSINESS_ID;
#endregion
}
#endregion
#region Get_Work_list_By_BUSINESS_ID_Adv
[HttpPost]
[Route("Get_Work_list_By_BUSINESS_ID_Adv")]
public Result_Get_Work_list_By_BUSINESS_ID_Adv Get_Work_list_By_BUSINESS_ID_Adv(Params_Get_Work_list_By_BUSINESS_ID i_Params_Get_Work_list_By_BUSINESS_ID)
{
#region Declaration And Initialization Section.
List<Work_list>  oReturnValue = new List<Work_list> ();
string i_Ticket = string.Empty;
Result_Get_Work_list_By_BUSINESS_ID_Adv oResult_Get_Work_list_By_BUSINESS_ID_Adv = new Result_Get_Work_list_By_BUSINESS_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_list_By_BUSINESS_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_list_By_BUSINESS_ID_Adv(i_Params_Get_Work_list_By_BUSINESS_ID);
oResult_Get_Work_list_By_BUSINESS_ID_Adv.My_Result = oReturnValue;
oResult_Get_Work_list_By_BUSINESS_ID_Adv.My_Params_Get_Work_list_By_BUSINESS_ID = i_Params_Get_Work_list_By_BUSINESS_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_list_By_BUSINESS_ID_Adv.ExceptionMsg = string.Format("Get_Work_list_By_BUSINESS_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Work_list_By_BUSINESS_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_list_By_BUSINESS_ID_Adv;
#endregion
}
#endregion
#region Get_Work_list_By_OWNER_ID
[HttpPost]
[Route("Get_Work_list_By_OWNER_ID")]
public Result_Get_Work_list_By_OWNER_ID Get_Work_list_By_OWNER_ID(Params_Get_Work_list_By_OWNER_ID i_Params_Get_Work_list_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Work_list>  oReturnValue = new List<Work_list> ();
string i_Ticket = string.Empty;
Result_Get_Work_list_By_OWNER_ID oResult_Get_Work_list_By_OWNER_ID = new Result_Get_Work_list_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_list_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_list_By_OWNER_ID(i_Params_Get_Work_list_By_OWNER_ID);
oResult_Get_Work_list_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Work_list_By_OWNER_ID.My_Params_Get_Work_list_By_OWNER_ID = i_Params_Get_Work_list_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_list_By_OWNER_ID.ExceptionMsg = string.Format("Get_Work_list_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Work_list_By_OWNER_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_list_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Work_list_By_WORK_AREA_ID
[HttpPost]
[Route("Get_Work_list_By_WORK_AREA_ID")]
public Result_Get_Work_list_By_WORK_AREA_ID Get_Work_list_By_WORK_AREA_ID(Params_Get_Work_list_By_WORK_AREA_ID i_Params_Get_Work_list_By_WORK_AREA_ID)
{
#region Declaration And Initialization Section.
List<Work_list>  oReturnValue = new List<Work_list> ();
string i_Ticket = string.Empty;
Result_Get_Work_list_By_WORK_AREA_ID oResult_Get_Work_list_By_WORK_AREA_ID = new Result_Get_Work_list_By_WORK_AREA_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_list_By_WORK_AREA_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_list_By_WORK_AREA_ID(i_Params_Get_Work_list_By_WORK_AREA_ID);
oResult_Get_Work_list_By_WORK_AREA_ID.My_Result = oReturnValue;
oResult_Get_Work_list_By_WORK_AREA_ID.My_Params_Get_Work_list_By_WORK_AREA_ID = i_Params_Get_Work_list_By_WORK_AREA_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_list_By_WORK_AREA_ID.ExceptionMsg = string.Format("Get_Work_list_By_WORK_AREA_ID : {0}", ex.Message);
}
else
{
oResult_Get_Work_list_By_WORK_AREA_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_list_By_WORK_AREA_ID;
#endregion
}
#endregion
#region Get_Work_list_By_WORK_AREA_ID_Adv
[HttpPost]
[Route("Get_Work_list_By_WORK_AREA_ID_Adv")]
public Result_Get_Work_list_By_WORK_AREA_ID_Adv Get_Work_list_By_WORK_AREA_ID_Adv(Params_Get_Work_list_By_WORK_AREA_ID i_Params_Get_Work_list_By_WORK_AREA_ID)
{
#region Declaration And Initialization Section.
List<Work_list>  oReturnValue = new List<Work_list> ();
string i_Ticket = string.Empty;
Result_Get_Work_list_By_WORK_AREA_ID_Adv oResult_Get_Work_list_By_WORK_AREA_ID_Adv = new Result_Get_Work_list_By_WORK_AREA_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_list_By_WORK_AREA_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_list_By_WORK_AREA_ID_Adv(i_Params_Get_Work_list_By_WORK_AREA_ID);
oResult_Get_Work_list_By_WORK_AREA_ID_Adv.My_Result = oReturnValue;
oResult_Get_Work_list_By_WORK_AREA_ID_Adv.My_Params_Get_Work_list_By_WORK_AREA_ID = i_Params_Get_Work_list_By_WORK_AREA_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_list_By_WORK_AREA_ID_Adv.ExceptionMsg = string.Format("Get_Work_list_By_WORK_AREA_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Work_list_By_WORK_AREA_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_list_By_WORK_AREA_ID_Adv;
#endregion
}
#endregion
#region Get_Work_list_By_WORK_LIST_ID
[HttpPost]
[Route("Get_Work_list_By_WORK_LIST_ID")]
public Result_Get_Work_list_By_WORK_LIST_ID Get_Work_list_By_WORK_LIST_ID(Params_Get_Work_list_By_WORK_LIST_ID i_Params_Get_Work_list_By_WORK_LIST_ID)
{
#region Declaration And Initialization Section.
Work_list oReturnValue = new Work_list();
string i_Ticket = string.Empty;
Result_Get_Work_list_By_WORK_LIST_ID oResult_Get_Work_list_By_WORK_LIST_ID = new Result_Get_Work_list_By_WORK_LIST_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_list_By_WORK_LIST_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_list_By_WORK_LIST_ID(i_Params_Get_Work_list_By_WORK_LIST_ID);
oResult_Get_Work_list_By_WORK_LIST_ID.My_Result = oReturnValue;
oResult_Get_Work_list_By_WORK_LIST_ID.My_Params_Get_Work_list_By_WORK_LIST_ID = i_Params_Get_Work_list_By_WORK_LIST_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_list_By_WORK_LIST_ID.ExceptionMsg = string.Format("Get_Work_list_By_WORK_LIST_ID : {0}", ex.Message);
}
else
{
oResult_Get_Work_list_By_WORK_LIST_ID.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_list_By_WORK_LIST_ID;
#endregion
}
#endregion
#region Get_Work_list_By_WORK_LIST_ID_Adv
[HttpPost]
[Route("Get_Work_list_By_WORK_LIST_ID_Adv")]
public Result_Get_Work_list_By_WORK_LIST_ID_Adv Get_Work_list_By_WORK_LIST_ID_Adv(Params_Get_Work_list_By_WORK_LIST_ID i_Params_Get_Work_list_By_WORK_LIST_ID)
{
#region Declaration And Initialization Section.
Work_list oReturnValue = new Work_list();
string i_Ticket = string.Empty;
Result_Get_Work_list_By_WORK_LIST_ID_Adv oResult_Get_Work_list_By_WORK_LIST_ID_Adv = new Result_Get_Work_list_By_WORK_LIST_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
{
i_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Work_list_By_WORK_LIST_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oReturnValue = oBLC.Get_Work_list_By_WORK_LIST_ID_Adv(i_Params_Get_Work_list_By_WORK_LIST_ID);
oResult_Get_Work_list_By_WORK_LIST_ID_Adv.My_Result = oReturnValue;
oResult_Get_Work_list_By_WORK_LIST_ID_Adv.My_Params_Get_Work_list_By_WORK_LIST_ID = i_Params_Get_Work_list_By_WORK_LIST_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Work_list_By_WORK_LIST_ID_Adv.ExceptionMsg = string.Format("Get_Work_list_By_WORK_LIST_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Work_list_By_WORK_LIST_ID_Adv.ExceptionMsg = ex.Message;
}
}
#endregion
#region Return Section
return oResult_Get_Work_list_By_WORK_LIST_ID_Adv;
#endregion
}
#endregion
}

#region Action_Result
public partial class Action_Result
{
#region Properties.
public string ExceptionCode { get; set; }
public string ExceptionMsg { get; set; }
#endregion
#region Constructor
public Action_Result()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.ExceptionMsg = string.Empty;
#endregion
}
#endregion
}
#endregion
#region Result_Authenticate
public partial class Result_Authenticate : Action_Result
{
#region Properties.
public User My_Result { get; set; }
public Params_Authenticate My_Params_Authenticate { get; set; }
#endregion
}
#endregion
#region Result_Delete_Admin
public partial class Result_Delete_Admin : Action_Result
{
#region Properties.
public Params_Delete_Admin My_Params_Delete_Admin { get; set; }
#endregion
}
#endregion
#region Result_Delete_Booking
public partial class Result_Delete_Booking : Action_Result
{
#region Properties.
public Params_Delete_Booking My_Params_Delete_Booking { get; set; }
#endregion
}
#endregion
#region Result_Delete_Boost_listing
public partial class Result_Delete_Boost_listing : Action_Result
{
#region Properties.
public Params_Delete_Boost_listing My_Params_Delete_Boost_listing { get; set; }
#endregion
}
#endregion
#region Result_Delete_Boost_pricing
public partial class Result_Delete_Boost_pricing : Action_Result
{
#region Properties.
public Params_Delete_Boost_pricing My_Params_Delete_Boost_pricing { get; set; }
#endregion
}
#endregion
#region Result_Delete_Business
public partial class Result_Delete_Business : Action_Result
{
#region Properties.
public Params_Delete_Business My_Params_Delete_Business { get; set; }
#endregion
}
#endregion
#region Result_Delete_Category
public partial class Result_Delete_Category : Action_Result
{
#region Properties.
public Params_Delete_Category My_Params_Delete_Category { get; set; }
#endregion
}
#endregion
#region Result_Delete_Client
public partial class Result_Delete_Client : Action_Result
{
#region Properties.
public Params_Delete_Client My_Params_Delete_Client { get; set; }
#endregion
}
#endregion
#region Result_Delete_Coordinates
public partial class Result_Delete_Coordinates : Action_Result
{
#region Properties.
public Params_Delete_Coordinates My_Params_Delete_Coordinates { get; set; }
#endregion
}
#endregion
#region Result_Delete_Currency
public partial class Result_Delete_Currency : Action_Result
{
#region Properties.
public Params_Delete_Currency My_Params_Delete_Currency { get; set; }
#endregion
}
#endregion
#region Result_Delete_Feedback
public partial class Result_Delete_Feedback : Action_Result
{
#region Properties.
public Params_Delete_Feedback My_Params_Delete_Feedback { get; set; }
#endregion
}
#endregion
#region Result_Delete_Service_prod
public partial class Result_Delete_Service_prod : Action_Result
{
#region Properties.
public Params_Delete_Service_prod My_Params_Delete_Service_prod { get; set; }
#endregion
}
#endregion
#region Result_Delete_Status
public partial class Result_Delete_Status : Action_Result
{
#region Properties.
public Params_Delete_Status My_Params_Delete_Status { get; set; }
#endregion
}
#endregion
#region Result_Delete_Sub_category
public partial class Result_Delete_Sub_category : Action_Result
{
#region Properties.
public Params_Delete_Sub_category My_Params_Delete_Sub_category { get; set; }
#endregion
}
#endregion
#region Result_Delete_User
public partial class Result_Delete_User : Action_Result
{
#region Properties.
public Params_Delete_User My_Params_Delete_User { get; set; }
#endregion
}
#endregion
#region Result_Delete_User_By_USERNAME
public partial class Result_Delete_User_By_USERNAME : Action_Result
{
#region Properties.
public Params_Delete_User_By_USERNAME My_Params_Delete_User_By_USERNAME { get; set; }
#endregion
}
#endregion
#region Result_Delete_Work_area
public partial class Result_Delete_Work_area : Action_Result
{
#region Properties.
public Params_Delete_Work_area My_Params_Delete_Work_area { get; set; }
#endregion
}
#endregion
#region Result_Delete_Work_list
public partial class Result_Delete_Work_list : Action_Result
{
#region Properties.
public Params_Delete_Work_list My_Params_Delete_Work_list { get; set; }
#endregion
}
#endregion
#region Result_Delete_Work_list_By_BUSINESS_ID
public partial class Result_Delete_Work_list_By_BUSINESS_ID : Action_Result
{
#region Properties.
public Params_Delete_Work_list_By_BUSINESS_ID My_Params_Delete_Work_list_By_BUSINESS_ID { get; set; }
#endregion
}
#endregion
#region Result_Edit_Admin
public partial class Result_Edit_Admin : Action_Result
{
#region Properties.
public Admin My_Admin { get; set; }
#endregion
}
#endregion
#region Result_Edit_Booking
public partial class Result_Edit_Booking : Action_Result
{
#region Properties.
public Booking My_Booking { get; set; }
#endregion
}
#endregion
#region Result_Edit_Boost_listing
public partial class Result_Edit_Boost_listing : Action_Result
{
#region Properties.
public Boost_listing My_Boost_listing { get; set; }
#endregion
}
#endregion
#region Result_Edit_Boost_pricing
public partial class Result_Edit_Boost_pricing : Action_Result
{
#region Properties.
public Boost_pricing My_Boost_pricing { get; set; }
#endregion
}
#endregion
#region Result_Edit_Business
public partial class Result_Edit_Business : Action_Result
{
#region Properties.
public Business My_Business { get; set; }
#endregion
}
#endregion
#region Result_Edit_Category
public partial class Result_Edit_Category : Action_Result
{
#region Properties.
public Category My_Category { get; set; }
#endregion
}
#endregion
#region Result_Edit_Client
public partial class Result_Edit_Client : Action_Result
{
#region Properties.
public Client My_Client { get; set; }
#endregion
}
#endregion
#region Result_Edit_Coordinates
public partial class Result_Edit_Coordinates : Action_Result
{
#region Properties.
public Coordinates My_Coordinates { get; set; }
#endregion
}
#endregion
#region Result_Edit_Currency
public partial class Result_Edit_Currency : Action_Result
{
#region Properties.
public Currency My_Currency { get; set; }
#endregion
}
#endregion
#region Result_Edit_Feedback
public partial class Result_Edit_Feedback : Action_Result
{
#region Properties.
public Feedback My_Feedback { get; set; }
#endregion
}
#endregion
#region Result_Edit_Service_prod
public partial class Result_Edit_Service_prod : Action_Result
{
#region Properties.
public Service_prod My_Service_prod { get; set; }
#endregion
}
#endregion
#region Result_Edit_Status
public partial class Result_Edit_Status : Action_Result
{
#region Properties.
public Status My_Status { get; set; }
#endregion
}
#endregion
#region Result_Edit_Sub_category
public partial class Result_Edit_Sub_category : Action_Result
{
#region Properties.
public Sub_category My_Sub_category { get; set; }
#endregion
}
#endregion
#region Result_Edit_User
public partial class Result_Edit_User : Action_Result
{
#region Properties.
public User My_User { get; set; }
#endregion
}
#endregion
#region Result_Edit_Work_area
public partial class Result_Edit_Work_area : Action_Result
{
#region Properties.
public Work_area My_Work_area { get; set; }
#endregion
}
#endregion
#region Result_Edit_Work_list
public partial class Result_Edit_Work_list : Action_Result
{
#region Properties.
public Work_list My_Work_list { get; set; }
#endregion
}
#endregion
#region Result_Get_Admin_By_ADMIN_ID
public partial class Result_Get_Admin_By_ADMIN_ID : Action_Result
{
#region Properties.
public Admin My_Result { get; set; }
public Params_Get_Admin_By_ADMIN_ID My_Params_Get_Admin_By_ADMIN_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Admin_By_Criteria
public partial class Result_Get_Admin_By_Criteria : Action_Result
{
#region Properties.
public List<Admin>  My_Result { get; set; }
public Params_Get_Admin_By_Criteria My_Params_Get_Admin_By_Criteria { get; set; }
#endregion
}
#endregion
#region Result_Get_Admin_By_OWNER_ID
public partial class Result_Get_Admin_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Admin>  My_Result { get; set; }
public Params_Get_Admin_By_OWNER_ID My_Params_Get_Admin_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Admin_By_USERNAME
public partial class Result_Get_Admin_By_USERNAME : Action_Result
{
#region Properties.
public List<Admin>  My_Result { get; set; }
public Params_Get_Admin_By_USERNAME My_Params_Get_Admin_By_USERNAME { get; set; }
#endregion
}
#endregion
#region Result_Get_Admin_By_Where
public partial class Result_Get_Admin_By_Where : Action_Result
{
#region Properties.
public List<Admin>  My_Result { get; set; }
public Params_Get_Admin_By_Where My_Params_Get_Admin_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Admin_By_Where_Adv
public partial class Result_Get_Admin_By_Where_Adv : Action_Result
{
#region Properties.
public List<Admin>  My_Result { get; set; }
public Params_Get_Admin_By_Where My_Params_Get_Admin_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_BOOKING_ID
public partial class Result_Get_Booking_By_BOOKING_ID : Action_Result
{
#region Properties.
public Booking My_Result { get; set; }
public Params_Get_Booking_By_BOOKING_ID My_Params_Get_Booking_By_BOOKING_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_BOOKING_ID_Adv
public partial class Result_Get_Booking_By_BOOKING_ID_Adv : Action_Result
{
#region Properties.
public Booking My_Result { get; set; }
public Params_Get_Booking_By_BOOKING_ID My_Params_Get_Booking_By_BOOKING_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_BUSINESS_ID
public partial class Result_Get_Booking_By_BUSINESS_ID : Action_Result
{
#region Properties.
public List<Booking>  My_Result { get; set; }
public Params_Get_Booking_By_BUSINESS_ID My_Params_Get_Booking_By_BUSINESS_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_BUSINESS_ID_Adv
public partial class Result_Get_Booking_By_BUSINESS_ID_Adv : Action_Result
{
#region Properties.
public List<Booking>  My_Result { get; set; }
public Params_Get_Booking_By_BUSINESS_ID My_Params_Get_Booking_By_BUSINESS_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_CLIENT_ID
public partial class Result_Get_Booking_By_CLIENT_ID : Action_Result
{
#region Properties.
public List<Booking>  My_Result { get; set; }
public Params_Get_Booking_By_CLIENT_ID My_Params_Get_Booking_By_CLIENT_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_CLIENT_ID_Adv
public partial class Result_Get_Booking_By_CLIENT_ID_Adv : Action_Result
{
#region Properties.
public List<Booking>  My_Result { get; set; }
public Params_Get_Booking_By_CLIENT_ID My_Params_Get_Booking_By_CLIENT_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_OWNER_ID
public partial class Result_Get_Booking_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Booking>  My_Result { get; set; }
public Params_Get_Booking_By_OWNER_ID My_Params_Get_Booking_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_OWNER_ID_Adv
public partial class Result_Get_Booking_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Booking>  My_Result { get; set; }
public Params_Get_Booking_By_OWNER_ID My_Params_Get_Booking_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_SERVICE_PROD_ID_Adv
public partial class Result_Get_Booking_By_SERVICE_PROD_ID_Adv : Action_Result
{
#region Properties.
public List<Booking>  My_Result { get; set; }
public Params_Get_Booking_By_SERVICE_PROD_ID My_Params_Get_Booking_By_SERVICE_PROD_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_Where
public partial class Result_Get_Booking_By_Where : Action_Result
{
#region Properties.
public List<Booking>  My_Result { get; set; }
public Params_Get_Booking_By_Where My_Params_Get_Booking_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Booking_By_Where_Adv
public partial class Result_Get_Booking_By_Where_Adv : Action_Result
{
#region Properties.
public List<Booking>  My_Result { get; set; }
public Params_Get_Booking_By_Where My_Params_Get_Booking_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_listing_By_BOOST_LISTING_ID
public partial class Result_Get_Boost_listing_By_BOOST_LISTING_ID : Action_Result
{
#region Properties.
public Boost_listing My_Result { get; set; }
public Params_Get_Boost_listing_By_BOOST_LISTING_ID My_Params_Get_Boost_listing_By_BOOST_LISTING_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_listing_By_BOOST_LISTING_ID_Adv
public partial class Result_Get_Boost_listing_By_BOOST_LISTING_ID_Adv : Action_Result
{
#region Properties.
public Boost_listing My_Result { get; set; }
public Params_Get_Boost_listing_By_BOOST_LISTING_ID My_Params_Get_Boost_listing_By_BOOST_LISTING_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_listing_By_OWNER_ID
public partial class Result_Get_Boost_listing_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Boost_listing>  My_Result { get; set; }
public Params_Get_Boost_listing_By_OWNER_ID My_Params_Get_Boost_listing_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_listing_By_OWNER_ID_Adv
public partial class Result_Get_Boost_listing_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Boost_listing>  My_Result { get; set; }
public Params_Get_Boost_listing_By_OWNER_ID My_Params_Get_Boost_listing_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_listing_By_Where
public partial class Result_Get_Boost_listing_By_Where : Action_Result
{
#region Properties.
public List<Boost_listing>  My_Result { get; set; }
public Params_Get_Boost_listing_By_Where My_Params_Get_Boost_listing_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_listing_By_Where_Adv
public partial class Result_Get_Boost_listing_By_Where_Adv : Action_Result
{
#region Properties.
public List<Boost_listing>  My_Result { get; set; }
public Params_Get_Boost_listing_By_Where My_Params_Get_Boost_listing_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_pricing_By_BOOST_PRICING_ID
public partial class Result_Get_Boost_pricing_By_BOOST_PRICING_ID : Action_Result
{
#region Properties.
public Boost_pricing My_Result { get; set; }
public Params_Get_Boost_pricing_By_BOOST_PRICING_ID My_Params_Get_Boost_pricing_By_BOOST_PRICING_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv
public partial class Result_Get_Boost_pricing_By_BOOST_PRICING_ID_Adv : Action_Result
{
#region Properties.
public Boost_pricing My_Result { get; set; }
public Params_Get_Boost_pricing_By_BOOST_PRICING_ID My_Params_Get_Boost_pricing_By_BOOST_PRICING_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_pricing_By_OWNER_ID
public partial class Result_Get_Boost_pricing_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Boost_pricing>  My_Result { get; set; }
public Params_Get_Boost_pricing_By_OWNER_ID My_Params_Get_Boost_pricing_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_pricing_By_OWNER_ID_Adv
public partial class Result_Get_Boost_pricing_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Boost_pricing>  My_Result { get; set; }
public Params_Get_Boost_pricing_By_OWNER_ID My_Params_Get_Boost_pricing_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_pricing_By_Where
public partial class Result_Get_Boost_pricing_By_Where : Action_Result
{
#region Properties.
public List<Boost_pricing>  My_Result { get; set; }
public Params_Get_Boost_pricing_By_Where My_Params_Get_Boost_pricing_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Boost_pricing_By_Where_Adv
public partial class Result_Get_Boost_pricing_By_Where_Adv : Action_Result
{
#region Properties.
public List<Boost_pricing>  My_Result { get; set; }
public Params_Get_Boost_pricing_By_Where My_Params_Get_Boost_pricing_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Business_By_BUSINESS_ID
public partial class Result_Get_Business_By_BUSINESS_ID : Action_Result
{
#region Properties.
public Business My_Result { get; set; }
public Params_Get_Business_By_BUSINESS_ID My_Params_Get_Business_By_BUSINESS_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Business_By_BUSINESS_ID_Adv
public partial class Result_Get_Business_By_BUSINESS_ID_Adv : Action_Result
{
#region Properties.
public Business My_Result { get; set; }
public Params_Get_Business_By_BUSINESS_ID My_Params_Get_Business_By_BUSINESS_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Business_By_OWNER_ID
public partial class Result_Get_Business_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Business>  My_Result { get; set; }
public Params_Get_Business_By_OWNER_ID My_Params_Get_Business_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Business_By_OWNER_ID_Adv
public partial class Result_Get_Business_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Business>  My_Result { get; set; }
public Params_Get_Business_By_OWNER_ID My_Params_Get_Business_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Business_By_USERNAME
public partial class Result_Get_Business_By_USERNAME : Action_Result
{
#region Properties.
public List<Business>  My_Result { get; set; }
public Params_Get_Business_By_USERNAME My_Params_Get_Business_By_USERNAME { get; set; }
#endregion
}
#endregion
#region Result_Get_Business_By_USERNAME_Adv
public partial class Result_Get_Business_By_USERNAME_Adv : Action_Result
{
#region Properties.
public List<Business>  My_Result { get; set; }
public Params_Get_Business_By_USERNAME My_Params_Get_Business_By_USERNAME { get; set; }
#endregion
}
#endregion
#region Result_Get_Business_By_Where
public partial class Result_Get_Business_By_Where : Action_Result
{
#region Properties.
public List<Business>  My_Result { get; set; }
public Params_Get_Business_By_Where My_Params_Get_Business_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Business_By_Where_Adv
public partial class Result_Get_Business_By_Where_Adv : Action_Result
{
#region Properties.
public List<Business>  My_Result { get; set; }
public Params_Get_Business_By_Where My_Params_Get_Business_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Category_By_CATEGORY_ID
public partial class Result_Get_Category_By_CATEGORY_ID : Action_Result
{
#region Properties.
public Category My_Result { get; set; }
public Params_Get_Category_By_CATEGORY_ID My_Params_Get_Category_By_CATEGORY_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Category_By_OWNER_ID
public partial class Result_Get_Category_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Category>  My_Result { get; set; }
public Params_Get_Category_By_OWNER_ID My_Params_Get_Category_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Category_By_OWNER_ID_Adv
public partial class Result_Get_Category_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Category>  My_Result { get; set; }
public Params_Get_Category_By_OWNER_ID My_Params_Get_Category_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Category_By_Where
public partial class Result_Get_Category_By_Where : Action_Result
{
#region Properties.
public List<Category>  My_Result { get; set; }
public Params_Get_Category_By_Where My_Params_Get_Category_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Category_By_Where_Adv
public partial class Result_Get_Category_By_Where_Adv : Action_Result
{
#region Properties.
public List<Category>  My_Result { get; set; }
public Params_Get_Category_By_Where My_Params_Get_Category_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_By_CLIENT_ID
public partial class Result_Get_Client_By_CLIENT_ID : Action_Result
{
#region Properties.
public Client My_Result { get; set; }
public Params_Get_Client_By_CLIENT_ID My_Params_Get_Client_By_CLIENT_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_By_CLIENT_ID_Adv
public partial class Result_Get_Client_By_CLIENT_ID_Adv : Action_Result
{
#region Properties.
public Client My_Result { get; set; }
public Params_Get_Client_By_CLIENT_ID My_Params_Get_Client_By_CLIENT_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_By_Criteria
public partial class Result_Get_Client_By_Criteria : Action_Result
{
#region Properties.
public List<Client>  My_Result { get; set; }
public Params_Get_Client_By_Criteria My_Params_Get_Client_By_Criteria { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_By_OWNER_ID
public partial class Result_Get_Client_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Client>  My_Result { get; set; }
public Params_Get_Client_By_OWNER_ID My_Params_Get_Client_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_By_USERNAME
public partial class Result_Get_Client_By_USERNAME : Action_Result
{
#region Properties.
public List<Client>  My_Result { get; set; }
public Params_Get_Client_By_USERNAME My_Params_Get_Client_By_USERNAME { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_By_USERNAME_Adv
public partial class Result_Get_Client_By_USERNAME_Adv : Action_Result
{
#region Properties.
public List<Client>  My_Result { get; set; }
public Params_Get_Client_By_USERNAME My_Params_Get_Client_By_USERNAME { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_By_Where
public partial class Result_Get_Client_By_Where : Action_Result
{
#region Properties.
public List<Client>  My_Result { get; set; }
public Params_Get_Client_By_Where My_Params_Get_Client_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_By_Where_Adv
public partial class Result_Get_Client_By_Where_Adv : Action_Result
{
#region Properties.
public List<Client>  My_Result { get; set; }
public Params_Get_Client_By_Where My_Params_Get_Client_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Coordinates_By_OWNER_ID
public partial class Result_Get_Coordinates_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Coordinates>  My_Result { get; set; }
public Params_Get_Coordinates_By_OWNER_ID My_Params_Get_Coordinates_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Coordinates_By_Where
public partial class Result_Get_Coordinates_By_Where : Action_Result
{
#region Properties.
public List<Coordinates>  My_Result { get; set; }
public Params_Get_Coordinates_By_Where My_Params_Get_Coordinates_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Coordinates_By_Where_Adv
public partial class Result_Get_Coordinates_By_Where_Adv : Action_Result
{
#region Properties.
public List<Coordinates>  My_Result { get; set; }
public Params_Get_Coordinates_By_Where My_Params_Get_Coordinates_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Currency_By_CURRENCY_ID
public partial class Result_Get_Currency_By_CURRENCY_ID : Action_Result
{
#region Properties.
public Currency My_Result { get; set; }
public Params_Get_Currency_By_CURRENCY_ID My_Params_Get_Currency_By_CURRENCY_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Currency_By_OWNER_ID
public partial class Result_Get_Currency_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Currency>  My_Result { get; set; }
public Params_Get_Currency_By_OWNER_ID My_Params_Get_Currency_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Currency_By_Where
public partial class Result_Get_Currency_By_Where : Action_Result
{
#region Properties.
public List<Currency>  My_Result { get; set; }
public Params_Get_Currency_By_Where My_Params_Get_Currency_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Feedback_By_BOOKING_ID
public partial class Result_Get_Feedback_By_BOOKING_ID : Action_Result
{
#region Properties.
public List<Feedback>  My_Result { get; set; }
public Params_Get_Feedback_By_BOOKING_ID My_Params_Get_Feedback_By_BOOKING_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Feedback_By_FEEDBACK_ID
public partial class Result_Get_Feedback_By_FEEDBACK_ID : Action_Result
{
#region Properties.
public Feedback My_Result { get; set; }
public Params_Get_Feedback_By_FEEDBACK_ID My_Params_Get_Feedback_By_FEEDBACK_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Feedback_By_OWNER_ID
public partial class Result_Get_Feedback_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Feedback>  My_Result { get; set; }
public Params_Get_Feedback_By_OWNER_ID My_Params_Get_Feedback_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Feedback_By_Where
public partial class Result_Get_Feedback_By_Where : Action_Result
{
#region Properties.
public List<Feedback>  My_Result { get; set; }
public Params_Get_Feedback_By_Where My_Params_Get_Feedback_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Feedback_By_Where_Adv
public partial class Result_Get_Feedback_By_Where_Adv : Action_Result
{
#region Properties.
public List<Feedback>  My_Result { get; set; }
public Params_Get_Feedback_By_Where My_Params_Get_Feedback_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_BUSINESS_ID
public partial class Result_Get_Service_prod_By_BUSINESS_ID : Action_Result
{
#region Properties.
public List<Service_prod>  My_Result { get; set; }
public Params_Get_Service_prod_By_BUSINESS_ID My_Params_Get_Service_prod_By_BUSINESS_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_BUSINESS_ID_Adv
public partial class Result_Get_Service_prod_By_BUSINESS_ID_Adv : Action_Result
{
#region Properties.
public List<Service_prod>  My_Result { get; set; }
public Params_Get_Service_prod_By_BUSINESS_ID My_Params_Get_Service_prod_By_BUSINESS_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_OWNER_ID
public partial class Result_Get_Service_prod_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Service_prod>  My_Result { get; set; }
public Params_Get_Service_prod_By_OWNER_ID My_Params_Get_Service_prod_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_OWNER_ID_Adv
public partial class Result_Get_Service_prod_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Service_prod>  My_Result { get; set; }
public Params_Get_Service_prod_By_OWNER_ID My_Params_Get_Service_prod_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_SERVICE_PROD_ID
public partial class Result_Get_Service_prod_By_SERVICE_PROD_ID : Action_Result
{
#region Properties.
public Service_prod My_Result { get; set; }
public Params_Get_Service_prod_By_SERVICE_PROD_ID My_Params_Get_Service_prod_By_SERVICE_PROD_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_SERVICE_PROD_ID_Adv
public partial class Result_Get_Service_prod_By_SERVICE_PROD_ID_Adv : Action_Result
{
#region Properties.
public Service_prod My_Result { get; set; }
public Params_Get_Service_prod_By_SERVICE_PROD_ID My_Params_Get_Service_prod_By_SERVICE_PROD_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_SUB_CATEGORY_ID
public partial class Result_Get_Service_prod_By_SUB_CATEGORY_ID : Action_Result
{
#region Properties.
public List<Service_prod>  My_Result { get; set; }
public Params_Get_Service_prod_By_SUB_CATEGORY_ID My_Params_Get_Service_prod_By_SUB_CATEGORY_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_SUB_CATEGORY_ID_Adv
public partial class Result_Get_Service_prod_By_SUB_CATEGORY_ID_Adv : Action_Result
{
#region Properties.
public List<Service_prod>  My_Result { get; set; }
public Params_Get_Service_prod_By_SUB_CATEGORY_ID My_Params_Get_Service_prod_By_SUB_CATEGORY_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_Where
public partial class Result_Get_Service_prod_By_Where : Action_Result
{
#region Properties.
public List<Service_prod>  My_Result { get; set; }
public Params_Get_Service_prod_By_Where My_Params_Get_Service_prod_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Service_prod_By_Where_Adv
public partial class Result_Get_Service_prod_By_Where_Adv : Action_Result
{
#region Properties.
public List<Service_prod>  My_Result { get; set; }
public Params_Get_Service_prod_By_Where My_Params_Get_Service_prod_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_SetupEntries_Per_Table
public partial class Result_Get_SetupEntries_Per_Table : Action_Result
{
#region Properties.
public List<SetupEntry>  My_Result { get; set; }
public Params_Get_SetupEntries_Per_Table My_Params_Get_SetupEntries_Per_Table { get; set; }
#endregion
}
#endregion
#region Result_Get_Status_By_OWNER_ID
public partial class Result_Get_Status_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Status>  My_Result { get; set; }
public Params_Get_Status_By_OWNER_ID My_Params_Get_Status_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Status_By_STATUS_ID
public partial class Result_Get_Status_By_STATUS_ID : Action_Result
{
#region Properties.
public Status My_Result { get; set; }
public Params_Get_Status_By_STATUS_ID My_Params_Get_Status_By_STATUS_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Sub_category_By_CATEGORY_ID
public partial class Result_Get_Sub_category_By_CATEGORY_ID : Action_Result
{
#region Properties.
public List<Sub_category>  My_Result { get; set; }
public Params_Get_Sub_category_By_CATEGORY_ID My_Params_Get_Sub_category_By_CATEGORY_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Sub_category_By_OWNER_ID
public partial class Result_Get_Sub_category_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Sub_category>  My_Result { get; set; }
public Params_Get_Sub_category_By_OWNER_ID My_Params_Get_Sub_category_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Sub_category_By_OWNER_ID_Adv
public partial class Result_Get_Sub_category_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Sub_category>  My_Result { get; set; }
public Params_Get_Sub_category_By_OWNER_ID My_Params_Get_Sub_category_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Sub_category_By_Where
public partial class Result_Get_Sub_category_By_Where : Action_Result
{
#region Properties.
public List<Sub_category>  My_Result { get; set; }
public Params_Get_Sub_category_By_Where My_Params_Get_Sub_category_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Sub_category_By_Where_Adv
public partial class Result_Get_Sub_category_By_Where_Adv : Action_Result
{
#region Properties.
public List<Sub_category>  My_Result { get; set; }
public Params_Get_Sub_category_By_Where My_Params_Get_Sub_category_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_Criteria
public partial class Result_Get_User_By_Criteria : Action_Result
{
#region Properties.
public List<User>  My_Result { get; set; }
public Params_Get_User_By_Criteria My_Params_Get_User_By_Criteria { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_Criteria_Adv
public partial class Result_Get_User_By_Criteria_Adv : Action_Result
{
#region Properties.
public List<User>  My_Result { get; set; }
public Params_Get_User_By_Criteria My_Params_Get_User_By_Criteria { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_OWNER_ID
public partial class Result_Get_User_By_OWNER_ID : Action_Result
{
#region Properties.
public List<User>  My_Result { get; set; }
public Params_Get_User_By_OWNER_ID My_Params_Get_User_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_USER_ID
public partial class Result_Get_User_By_USER_ID : Action_Result
{
#region Properties.
public User My_Result { get; set; }
public Params_Get_User_By_USER_ID My_Params_Get_User_By_USER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_Where
public partial class Result_Get_User_By_Where : Action_Result
{
#region Properties.
public List<User>  My_Result { get; set; }
public Params_Get_User_By_Where My_Params_Get_User_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_area_By_OWNER_ID
public partial class Result_Get_Work_area_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Work_area>  My_Result { get; set; }
public Params_Get_Work_area_By_OWNER_ID My_Params_Get_Work_area_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_area_By_Where
public partial class Result_Get_Work_area_By_Where : Action_Result
{
#region Properties.
public List<Work_area>  My_Result { get; set; }
public Params_Get_Work_area_By_Where My_Params_Get_Work_area_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_area_By_Where_Adv
public partial class Result_Get_Work_area_By_Where_Adv : Action_Result
{
#region Properties.
public List<Work_area>  My_Result { get; set; }
public Params_Get_Work_area_By_Where My_Params_Get_Work_area_By_Where { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_list_By_BUSINESS_ID
public partial class Result_Get_Work_list_By_BUSINESS_ID : Action_Result
{
#region Properties.
public List<Work_list>  My_Result { get; set; }
public Params_Get_Work_list_By_BUSINESS_ID My_Params_Get_Work_list_By_BUSINESS_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_list_By_BUSINESS_ID_Adv
public partial class Result_Get_Work_list_By_BUSINESS_ID_Adv : Action_Result
{
#region Properties.
public List<Work_list>  My_Result { get; set; }
public Params_Get_Work_list_By_BUSINESS_ID My_Params_Get_Work_list_By_BUSINESS_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_list_By_OWNER_ID
public partial class Result_Get_Work_list_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Work_list>  My_Result { get; set; }
public Params_Get_Work_list_By_OWNER_ID My_Params_Get_Work_list_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_list_By_WORK_AREA_ID
public partial class Result_Get_Work_list_By_WORK_AREA_ID : Action_Result
{
#region Properties.
public List<Work_list>  My_Result { get; set; }
public Params_Get_Work_list_By_WORK_AREA_ID My_Params_Get_Work_list_By_WORK_AREA_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_list_By_WORK_AREA_ID_Adv
public partial class Result_Get_Work_list_By_WORK_AREA_ID_Adv : Action_Result
{
#region Properties.
public List<Work_list>  My_Result { get; set; }
public Params_Get_Work_list_By_WORK_AREA_ID My_Params_Get_Work_list_By_WORK_AREA_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_list_By_WORK_LIST_ID
public partial class Result_Get_Work_list_By_WORK_LIST_ID : Action_Result
{
#region Properties.
public Work_list My_Result { get; set; }
public Params_Get_Work_list_By_WORK_LIST_ID My_Params_Get_Work_list_By_WORK_LIST_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Work_list_By_WORK_LIST_ID_Adv
public partial class Result_Get_Work_list_By_WORK_LIST_ID_Adv : Action_Result
{
#region Properties.
public Work_list My_Result { get; set; }
public Params_Get_Work_list_By_WORK_LIST_ID My_Params_Get_Work_list_By_WORK_LIST_ID { get; set; }
#endregion
}
#endregion
