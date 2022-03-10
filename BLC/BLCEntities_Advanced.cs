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
#region Boost_pricing
public partial class Boost_pricing
{
#region Advanced Properties
#endregion
}
#endregion
#region Client
public partial class Client
{
#region Advanced Properties
#endregion
}
#endregion
#region Service_prod
public partial class Service_prod
{
#region Advanced Properties
public Business My_Business {get;set;}
public Sub_category My_Sub_category {get;set;}
#endregion
}
#endregion
#region Admin
public partial class Admin
{
#region Advanced Properties
#endregion
}
#endregion
#region Category
public partial class Category
{
#region Advanced Properties
#endregion
}
#endregion
#region Sub_category
public partial class Sub_category
{
#region Advanced Properties
public Category My_Category {get;set;}
#endregion
}
#endregion
#region Coordinates
public partial class Coordinates
{
#region Advanced Properties
public Booking My_Booking {get;set;}
#endregion
}
#endregion
#region Currency
public partial class Currency
{
#region Advanced Properties
#endregion
}
#endregion
#region Status
public partial class Status
{
#region Advanced Properties
#endregion
}
#endregion
#region Owner
public partial class Owner
{
#region Advanced Properties
#endregion
}
#endregion
#region Feedback
public partial class Feedback
{
#region Advanced Properties
public Booking My_Booking {get;set;}
#endregion
}
#endregion
#region Booking
public partial class Booking
{
#region Advanced Properties
public Service_prod My_Service_prod {get;set;}
public Client My_Client {get;set;}
public Business My_Business {get;set;}
public Work_area My_Work_area {get;set;}
public Status My_Status {get;set;}
#endregion
}
#endregion
#region Business
public partial class Business
{
#region Advanced Properties
#endregion
}
#endregion
#region Work_list
public partial class Work_list
{
#region Advanced Properties
public Business My_Business {get;set;}
public Work_area My_Work_area {get;set;}
#endregion
}
#endregion
#region User
public partial class User
{
#region Advanced Properties
#endregion
}
#endregion
#region Work_area
public partial class Work_area
{
#region Advanced Properties
#endregion
}
#endregion
#region Boost_listing
public partial class Boost_listing
{
#region Advanced Properties
public Service_prod My_Service_prod {get;set;}
public Boost_pricing My_Boost_pricing {get;set;}
#endregion
}
#endregion
}
