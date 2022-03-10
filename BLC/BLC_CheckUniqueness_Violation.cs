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
#region Check_Client_Uniqueness_Violation
public bool Check_Client_Uniqueness_Violation(Client i_Client)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_Client_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_Client.CLIENT_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_Client_By_OWNER_ID(this.OwnerID)
where (((oItem_Row.PHONE_NUMBER == i_Client.PHONE_NUMBER)) || (oItem_Row.USERNAME == i_Client.USERNAME))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_Client_By_OWNER_ID(this.OwnerID)
where (((oItem_Row.PHONE_NUMBER == i_Client.PHONE_NUMBER)) || (oItem_Row.USERNAME == i_Client.USERNAME)) && (oItem_Row.CLIENT_ID != i_Client.CLIENT_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
#region Check_Business_Uniqueness_Violation
public bool Check_Business_Uniqueness_Violation(Business i_Business)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_Business_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_Business.BUSINESS_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_Business_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.USERNAME == i_Business.USERNAME))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_Business_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.USERNAME == i_Business.USERNAME)) && (oItem_Row.BUSINESS_ID != i_Business.BUSINESS_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
#region Check_User_Uniqueness_Violation
public bool Check_User_Uniqueness_Violation(User i_User)
{
#region Declaration And Initialization Section.
bool Is_Exists = false;
var oQuery = from oItem_Row in _AppContext.Get_User_By_OWNER_ID(this.OwnerID)
select oItem_Row;
#endregion
#region Body Section.
// Creating New Record
if (i_User.USER_ID == -1)
{
oQuery = from oItem_Row in _AppContext.Get_User_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.USERNAME == i_User.USERNAME))
select oItem_Row;
}
else // Editing Already Existing Record.
{
oQuery = from oItem_Row in _AppContext.Get_User_By_OWNER_ID(this.OwnerID)
where ((oItem_Row.USERNAME == i_User.USERNAME)) && (oItem_Row.USER_ID != i_User.USER_ID)
select oItem_Row;
}
if (oQuery.Count() > 0)
{
Is_Exists = true;
}
#endregion
#region Return Section
return Is_Exists;
#endregion
}
#endregion
}
}
