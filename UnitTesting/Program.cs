using BLC;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace UnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Declaration And Initialization Section.
            string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
            BLC.BLCInitializer oBLCInitializer = new BLC.BLCInitializer();
            oBLCInitializer.ConnectionString = _ConnectionString;
            oBLCInitializer.OwnerID = 1;
            oBLCInitializer.UserID = 1;
            oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
            BLC.BLC oBLC = new BLC.BLC(oBLCInitializer);
            string str_Option = string.Empty;
            string str_BH_ID = string.Empty;
            string str_AC_ID = string.Empty;
            string str_Bucket_Name = string.Empty;
            string str_Main_Folder_Path = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            #endregion

            #region Get Admin
            List<Admin> oList_Admin = new List<Admin>();
            Params_Get_Admin_By_USERNAME i_Params_Get_Admin_By_USERNAME = new Params_Get_Admin_By_USERNAME();
            Console.WriteLine("Enter Admin Username:");
            i_Params_Get_Admin_By_USERNAME.USERNAME = Console.ReadLine();
            oList_Admin = oBLC.Get_Admin_By_USERNAME(i_Params_Get_Admin_By_USERNAME);
            if (oList_Admin != null && oList_Admin.Count > 0)
            {
                Console.WriteLine("Admin :");
                Console.WriteLine(oList_Admin[0].USERNAME);
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No result is available");
                //Console.ReadLine();

            }
            Console.WriteLine("--------------");
            #endregion
            #region Get Client
            List<Client> oList_Client = new List<Client>();
            Params_Get_Client_By_USERNAME i_Params_Get_Client_By_USERNAME = new Params_Get_Client_By_USERNAME();
            Console.WriteLine("Enter Client Username:");
            i_Params_Get_Client_By_USERNAME.USERNAME = Console.ReadLine();
            oList_Client = oBLC.Get_Client_By_USERNAME(i_Params_Get_Client_By_USERNAME);
            if (oList_Client != null && oList_Client.Count > 0)
            {
                Console.WriteLine("Client :");
                Console.WriteLine(oList_Client[0].USERNAME);
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No result is available");
                //Console.ReadLine();

            }
            Console.WriteLine("--------------");
            #endregion
            #region Get Business
            List<Business> oList_Business = new List<Business>();
            Params_Get_Business_By_USERNAME i_Params_Get_Business_By_USERNAME = new Params_Get_Business_By_USERNAME();
            Console.WriteLine("Enter Business Username: ");
            i_Params_Get_Business_By_USERNAME.USERNAME = Console.ReadLine();
            oList_Business = oBLC.Get_Business_By_USERNAME(i_Params_Get_Business_By_USERNAME);
            if (oList_Business != null && oList_Business.Count > 0)
            {
                Console.WriteLine("Business :");
                Console.WriteLine(oList_Business[0].USERNAME);
                //Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No result is available");
                //Console.ReadLine();

            }
            Console.WriteLine("--------------");
            #endregion
        }

    }
}
