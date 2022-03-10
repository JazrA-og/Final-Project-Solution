using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net;
using System.Data.Linq;

namespace CodeGenerator
{
    class Program
    {
        #region Members
        private static string _ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
        private static DataContext oDataContext = new DataContext(_ConnectionString);
        private static CodeBoosterClientNS.CodeBoosterClient oCodeBoosterClient = new CodeBoosterClientNS.CodeBoosterClient(oDataContext);
        private static CodeBooster oCodeBooster = oCodeBoosterClient.My_CodeBooster;
        #endregion
        #region Main
        static void Main(string[] args)
        {
            #region Declaration And Initialization Section.
            string str_Option = string.Empty;
            string str_TableName = string.Empty;
            string str_FolderPath = string.Empty;
            Tools.Tools oTools = new Tools.Tools();

            Hierarchy oHierarchy = new Hierarchy();
            OneToMany oOneToMany = new OneToMany();
            List<String> oList_ChildTables = new List<string>();

            Hierarchy oApplicationHierarchy = new Hierarchy();


            // Initialization.
            // ---------------------------------------------------------------------   
            oCodeBooster.Tables_Excluded_From_Generatrion_Process = new List<string>();
            oCodeBooster.KeysMapper = new Dictionary<string, string>();
            oCodeBooster.APIMethodsGenerationMode = Enum_APIMethodsGenerationMode.Selection;
            oCodeBooster.APIMethodsSelection = new List<string>();
            oCodeBooster.Methods_With_Events = new List<string>();
            oCodeBooster.DefaultRecordsToCreate = new Dictionary<string, string>();
            oCodeBooster.Tables_Static_Data = new List<string>();
            oCodeBooster.NonSetup_Fields = new List<string>();
            oCodeBooster.Tables_To_Create_Get_By_Hierarchy = new List<HierarchyBracket>();
            oCodeBooster.Tables_Exluded_From_12M_Hanlder = new List<string>();
            oCodeBooster.ByPassed_PreCheck_Notifications = new List<Notification_ByPassing>();
            oCodeBooster.AssemblyPath = ConfigurationManager.AppSettings["BLC_PATH"];
            oCodeBooster.Is_Generate_API_Caller = true;
            oCodeBooster.Is_Generate_Kotlin_API_Caller = true;
            oCodeBooster.Is_Generate_Swift_API_Caller = true;
            oCodeBooster.Android_Package_Name = "com.example.roni.myapplication";
            oCodeBooster.Is_Apply_Minification = false;
            oCodeBooster.Is_Show_Notifications_In_Console = true;
            oCodeBooster.Is_Create_DB_Demo = false;
            oCodeBoosterClient.Authenticate_User();


            Params_ConvertTypeSchemaToUIFields oParams_ConvertTypeSchemaToUIFields = new Params_ConvertTypeSchemaToUIFields();
            Search_AdvancedProp oSearch_AdvancedProp = new Search_AdvancedProp();
            WebClient oWebClient = new WebClient();
            UIFields oUIFields = new UIFields();
            // ---------------------------------------------------------------------   


            #region Exluded Tables From Generation Process
            oCodeBooster.Tables_Excluded_From_Generatrion_Process = new List<string>();
            //oCodeBooster.Tables_Excluded_From_Generatrion_Process.Add("[TBL_MENU]");
            //oCodeGenerator.Tables_Excluded_From_Generatrion_Process.Add("[TBL_ACCOUNT]");
            #endregion
            #region Excluded Properties From Generation Process
            oCodeBooster.Properties_Excluded_From_Generation_Process = new List<string>();
            //oCodeBooster.Properties_Excluded_From_Generation_Process.Add("[TBL_LEG_PRODUCT]");
            //oCodeBooster.Properties_Excluded_From_Generation_Process.Add("[TBL_LEG_PRODUCT_EINFO]");
            #endregion
            #region Keys Mapper
            //oCodeBooster.KeysMapper.Add("[MAIN_ID]", "[PERSON_ID]");
            //oCodeBooster.KeysMapper.Add("[REL_ID]", "[PERSON_ID]");                        
            #endregion
            #region Events
            //oCodeBooster.Methods_With_Events.Add("Edit_Person");
            //oCodeBooster.Methods_With_Events.Add("Delete_Person");
            oCodeBooster.Methods_With_Events.Add("Edit_Admin");
            oCodeBooster.Methods_With_Events.Add("Delete_Admin");
            oCodeBooster.Methods_With_Events.Add("Edit_Business");
            oCodeBooster.Methods_With_Events.Add("Delete_Business");
            oCodeBooster.Methods_With_Events.Add("Edit_Client");
            oCodeBooster.Methods_With_Events.Add("Delete_Client");
            oCodeBooster.Methods_With_Events.Add("Edit_Service_prod");
            oCodeBooster.Methods_With_Events.Add("Edit_Feedback");
            oCodeBooster.Methods_With_Events.Add("Edit_Booking");
            oCodeBooster.Methods_With_Events.Add("Edit_Boost_listing");
            oCodeBooster.Methods_With_Events.Add("Delete_Boost_listing");
            oCodeBooster.Methods_With_Events.Add("Edit_Boost_pricing");
            oCodeBooster.Methods_With_Events.Add("Edit_Work_area");
            oCodeBooster.Methods_With_Events.Add("Edit_Work_list");
            #endregion
            #region Excluding Tables From 12M Hanlder
            oCodeBooster.Tables_Exluded_From_12M_Hanlder = new List<string>();
            oCodeBooster.Tables_Exluded_From_12M_Hanlder.Add("[TBL_OWNER]");
            oCodeBooster.Tables_Exluded_From_12M_Hanlder.Add("[TBL_USER]");
            oCodeBooster.Tables_Exluded_From_12M_Hanlder.Add("[TBL_INC]");
            oCodeBooster.Tables_Exluded_From_12M_Hanlder.Add("[TBL_SETUP]");
            #endregion
            #region Handling Static Data            
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L1]");
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L2]");
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L3]");
            //oCodeBooster.Tables_Static_Data.Add("[TBL_LOC_L4]");
            #endregion
            #region Defining Non Setup Fields [Fields That ends with CODE by they are not Setup Fields]
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L1_CODE]");
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L2_CODE]");
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L3_CODE]");
            //oCodeBooster.NonSetup_Fields.Add("[LOC_L4_CODE]");
            #endregion
            #region Audit
            oCodeBooster.List_Tables_To_Audit = new List<string>();
            //oCodeBooster.List_Tables_To_Audit.Add("[TBL_PERSON]");
            #endregion
            #region Custom Procedures / Queries
            oCodeBoosterClient.Is_Handle_Custom_Procedures = true;
            //oCodeBooster.List_Procedure_Info = new List<Procedure_Info>();
            //oCodeBooster.List_Procedure_Info.Add
            //        (
            //            new Procedure_Info()
            //            {
            //                Alias = "Get_Person_Test",
            //                Procedure_Name = "UP_GET_TEST",
            //                Result_CLR_Type = "Person",
            //                Result_Mode = Enum_Procedure_Result_Mode.List
            //            }
            //        );

            //oCodeBooster.List_Procedure_Info.Add
            //       (
            //           new Procedure_Info()
            //           {
            //               Alias = "Get_Stats",
            //               Procedure_Name = "GET_STATS",
            //               Result_CLR_Type = "dynamic",
            //               Result_Mode = Enum_Procedure_Result_Mode.List,
            //               Fields = "METHOD_NAME|AVG|NBR|TOTAL_EXECUTE_TIME"
            //           }
            //       );

            //oCodeBooster.List_Procedure_Info.Add
            //      (
            //          new Procedure_Info()
            //          {
            //              Alias = "Get_Stats_2",
            //              Procedure_Name = "GET_STATS_WITH_PARAM",
            //              Result_CLR_Type = "dynamic",
            //              Result_Mode = Enum_Procedure_Result_Mode.List,
            //              Fields = "METHOD_NAME|AVG|NBR|TOTAL_EXECUTE_TIME"
            //          }
            //      );
            #endregion
            #region ByPassing Notification
            oCodeBooster.ByPassed_PreCheck_Notifications = new List<Notification_ByPassing>();
            oCodeBooster.ByPassed_PreCheck_Notifications.Add(new Notification_ByPassing() { TABLE_NAME = "[TBL_USER_TYPE]", COLUMN_NAME = "[USER_TYPE_CODE]", My_PreCheck_To_ByPass = Enum_Precheck_Enum.INVALID_CODE_FIELD });
            oCodeBooster.ByPassed_PreCheck_Notifications.Add(new Notification_ByPassing() { TABLE_NAME = "[TBL_PERSON]", COLUMN_NAME = "[CHILD_PERSON_ID]", My_PreCheck_To_ByPass = Enum_Precheck_Enum.MAPPED_KEY });
            #endregion
            #region Caching
            //oCodeBooster.Is_Caching_Enabled = true;
            //oCodeBooster.Methods_With_Caching = new List<Caching_Topology>();
            //oCodeBooster.Methods_With_Caching.Add(new Caching_Topology() { Method_Name = "Get_Person_By_PERSON_ID", Caching_Level = Enum_Caching_Level.Application });

            oCodeBooster.Cash_Dropper_Collection = new List<string>();
            //oCodeBooster.Cash_Dropper_Collection.Add("[TBL_PERSON]");


            #region System
            //oCodeBooster.Methods_With_Caching.Add(new Caching_Topology() { Method_Name = "Get_City_By_COUNTRY_ID_Adv", Caching_Level = Enum_Caching_Level.Application });
            #endregion


            #endregion
            #region Cascade
            oCodeBooster.List_Cascade_Tables = new List<Cascade>();
            //oCodeBooster.List_Cascade_Tables.Add(new Cascade() { ParentTable = "[TBL_AC_IMAGE]", ChildTables = new List<string>() { "[TBL_AC_IMAGE_RC]" } });
            oCodeBooster.List_Cascade_Tables.Add(
                new Cascade()
                {
                    ParentTable = "[TBL_BUSINESS]",
                    ChildTables = new List<string>()
                    {
                        //"[TBL_BOOST_LISTING]",
                        "[TBL_SERVICE_PROD]",
                        "[TBL_WORK_LIST]"
                    }
                }
                ); 
            oCodeBooster.List_Cascade_Tables.Add(
               new Cascade()
               {
                   ParentTable = "[TBL_BOOKING]",
                   ChildTables = new List<string>()
                   {
                        "[TBL_FEEDBACK]",
                   }
               }
               );
            oCodeBooster.List_Cascade_Tables.Add(
               new Cascade()
               {
                   ParentTable = "[TBL_SERVICE_PROD]",
                   ChildTables = new List<string>()
                   {
                        "[TBL_BOOKING]",
                        "[TBL_BOOST_LISTING]",
                   }
               }
               ); 
            oCodeBooster.List_Cascade_Tables.Add(
                new Cascade()
                {
                    ParentTable = "[TBL_BOOST_PRICING]",
                    ChildTables = new List<string>()
                    {
                        "[TBL_BOOST_LISTING]",
                    }
                }
                );
            oCodeBooster.List_Cascade_Tables.Add(
               new Cascade()
               {
                   ParentTable = "[TBL_CATEGORY]",
                   ChildTables = new List<string>()
                   {
                        "[TBL_SUB_CATEGORY]",
                   }
               }
               );
            oCodeBooster.List_Cascade_Tables.Add(
               new Cascade()
               {
                   ParentTable = "[TBL_CLIENT]",
                   ChildTables = new List<string>()
                   {
                        "[TBL_BOOKING]",
                   }
               }
               );
            oCodeBooster.List_Cascade_Tables.Add(
               new Cascade()
               {
                   ParentTable = "[TBL_STATUS]",
                   ChildTables = new List<string>()
                   {
                        "[TBL_BOOKING]",
                   }
               }
               );
            oCodeBooster.List_Cascade_Tables.Add(
               new Cascade()
               {
                   ParentTable = "[TBL_WORK_AREA]",
                   ChildTables = new List<string>()
                   {
                        "[TBL_BOOKING]",
                        "[TBL_WORK_LIST]",
                   }
               }
               );
            #endregion

            #endregion
            #region Body Section
            Console.WriteLine("Enter An Option:");
            Console.WriteLine("001 --> Create SP's & BLC Layer");
            Console.WriteLine("002 --> Generate API / JSON Code");
            Console.WriteLine("003 --> Generate UI");
            Console.WriteLine("051 --> Generate Mobile Native UI");

            str_Option = Console.ReadLine();


            #region API

            #region Authenticate
            // Authenticate
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Authenticate");
            //----------------------------
            #endregion
            #region Admin
            // Admin
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Admin");
            oCodeBooster.APIMethodsSelection.Add("Delete_Admin");
            oCodeBooster.APIMethodsSelection.Add("Get_Admin_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Admin_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Admin_By_Where_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Admin_By_Criteria");
            oCodeBooster.APIMethodsSelection.Add("Get_Admin_By_ADMIN_ID");
            //oCodeBooster.APIMethodsSelection.Add("Get_Admin_By_OWNER_ID_Adv");
            //oCodeBooster.APIMethodsSelection.Add("Get_Admin_By_ADMIN_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Admin_By_USERNAME");
            //----------------------------
            #endregion
            #region Booking
            // Booking
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Booking");
            oCodeBooster.APIMethodsSelection.Add("Delete_Booking");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_OWNER_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_BOOKING_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_BOOKING_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_Where_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_CLIENT_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_CLIENT_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_BUSINESS_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_BUSINESS_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Booking_By_SERVICE_PROD_ID_Adv");

            //----------------------------
            #endregion
            #region Boost_Listing
            // Boost_listing
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Boost_listing");
            oCodeBooster.APIMethodsSelection.Add("Delete_Boost_listing");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_listing_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_listing_By_OWNER_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_listing_By_BOOST_LISTING_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_listing_By_BOOST_LISTING_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_listing_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_listing_By_Where_Adv");

            //----------------------------
            #endregion
            #region Boost_Pricing
            // Boost_Pricing
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Boost_pricing");
            oCodeBooster.APIMethodsSelection.Add("Delete_Boost_pricing");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_pricing_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_pricing_By_OWNER_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_pricing_By_BOOST_PRICING_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_pricing_By_BOOST_PRICING_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_pricing_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Boost_pricing_By_Where_Adv");

            //----------------------------
            #endregion
            #region Business
            // Business
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Business");
            oCodeBooster.APIMethodsSelection.Add("Delete_Business");
            oCodeBooster.APIMethodsSelection.Add("Get_Business_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Business_By_OWNER_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Business_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Business_By_Where_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Business_By_BUSINESS_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Business_By_BUSINESS_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Business_By_USERNAME");
            oCodeBooster.APIMethodsSelection.Add("Get_Business_By_USERNAME_Adv");
            //----------------------------
            #endregion
            #region Category
            // Category
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Category");
            oCodeBooster.APIMethodsSelection.Add("Delete_Category");
            oCodeBooster.APIMethodsSelection.Add("Get_Category_By_CATEGORY_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Category_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Category_By_Where_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Category_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Category_By_OWNER_ID_Adv");
            //----------------------------
            #endregion
            #region Client
            // Client
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Client");
            oCodeBooster.APIMethodsSelection.Add("Delete_Client");
            oCodeBooster.APIMethodsSelection.Add("Get_Client_By_Criteria");
            oCodeBooster.APIMethodsSelection.Add("Get_Client_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Client_By_Where_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Client_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Client_By_CLIENT_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Client_By_CLIENT_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Client_By_USERNAME");
            oCodeBooster.APIMethodsSelection.Add("Get_Client_By_USERNAME_Adv");

            //----------------------------
            #endregion
            #region Coordinates

            //// // Coordinates
            //// //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Coordinates");
            oCodeBooster.APIMethodsSelection.Add("Delete_Coordinates");
            oCodeBooster.APIMethodsSelection.Add("Get_Coordinates_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Coordinates_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Coordinates_By_Where_Adv");
            //oCodeBooster.APIMethodsSelection.Add("Get_Coordinates_By_BUSINESS_ID");
            //////----------------------------
            #endregion
            #region Currency
            // Currency
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Currency");
            oCodeBooster.APIMethodsSelection.Add("Delete_Currency");
            oCodeBooster.APIMethodsSelection.Add("Get_Currency_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Currency_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Currency_By_CURRENCY_ID");
            //----------------------------
            #endregion
            #region Feedback
            // Feedback
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Feedback");
            oCodeBooster.APIMethodsSelection.Add("Delete_Feedback");
            oCodeBooster.APIMethodsSelection.Add("Get_Feedback_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Feedback_By_Where_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Feedback_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Feedback_By_FEEDBACK_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Feedback_By_BOOKING_ID");
            //----------------------------
            #endregion
            #region Service_Prod
            // Service_Prod
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Service_prod");
            oCodeBooster.APIMethodsSelection.Add("Delete_Service_prod");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_Where_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_SERVICE_PROD_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_OWNER_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_SERVICE_PROD_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_BUSINESS_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_BUSINESS_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_SUB_CATEGORY_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Service_prod_By_SUB_CATEGORY_ID_Adv");
            //----------------------------
            #endregion
            #region Status
            // Status
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Status");
            oCodeBooster.APIMethodsSelection.Add("Delete_Status");
            oCodeBooster.APIMethodsSelection.Add("Get_Status_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Status_By_STATUS_ID");
            //----------------------------
            #endregion
            #region Sub_Category
            // Sub_Category
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Sub_category");
            oCodeBooster.APIMethodsSelection.Add("Delete_Sub_category");
            oCodeBooster.APIMethodsSelection.Add("Get_Sub_category_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Sub_category_By_Where_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Sub_category_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Sub_category_By_OWNER_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Sub_category_By_CATEGORY_ID");
            //----------------------------
            #endregion
            #region Work_Area
            // Work_Area
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Work_area");
            oCodeBooster.APIMethodsSelection.Add("Delete_Work_area");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_area_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_area_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_area_By_Where_Adv");
            //----------------------------
            #endregion
            #region Work_List
            // Work_List
            //----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_Work_list");
            oCodeBooster.APIMethodsSelection.Add("Delete_Work_list");
            oCodeBooster.APIMethodsSelection.Add("Delete_Work_list_By_BUSINESS_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_list_By_WORK_LIST_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_list_By_BUSINESS_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_list_By_WORK_AREA_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_list_By_BUSINESS_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_list_By_WORK_AREA_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_list_By_WORK_LIST_ID_Adv");
            oCodeBooster.APIMethodsSelection.Add("Get_Work_list_By_OWNER_ID");
            //oCodeBooster.APIMethodsSelection.Add("Get_Work_list_By_Where");
            //oCodeBooster.APIMethodsSelection.Add("Get_Work_list_By_Where_Adv");
            //----------------------------
            #endregion
            #region Person
            //// Person
            ////----------------------------
            //oCodeBooster.APIMethodsSelection.Add("Edit_Person");
            //oCodeBooster.APIMethodsSelection.Add("Delete_Person");
            //oCodeBooster.APIMethodsSelection.Add("Get_Person_By_OWNER_ID");
            //oCodeBooster.APIMethodsSelection.Add("Get_Person_By_Where");
            //oCodeBooster.APIMethodsSelection.Add("Get_Person_By_PERSON_ID");
            //oCodeBooster.APIMethodsSelection.Add("Get_Person_By_OWNER_ID_Adv");
            //oCodeBooster.APIMethodsSelection.Add("Get_Person_By_PERSON_ID_Adv");
            ////----------------------------
            #endregion
            #region User
            //// User
            ////----------------------------
            oCodeBooster.APIMethodsSelection.Add("Edit_User");
            oCodeBooster.APIMethodsSelection.Add("Delete_User");
            oCodeBooster.APIMethodsSelection.Add("Get_User_By_Criteria");
            oCodeBooster.APIMethodsSelection.Add("Get_User_By_Where");
            oCodeBooster.APIMethodsSelection.Add("Get_User_By_OWNER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_User_By_USER_ID");
            oCodeBooster.APIMethodsSelection.Add("Get_SetupEntries_Per_Table");
            oCodeBooster.APIMethodsSelection.Add("Get_User_By_Criteria");
            oCodeBooster.APIMethodsSelection.Add("Get_User_By_Criteria_Adv");
            oCodeBooster.APIMethodsSelection.Add("Delete_User_By_USERNAME");
            ////----------------------------
            #endregion

            #endregion


            #region Advanced Options
            oCodeBooster.Is_By_Criteria_Shadowed = true;
            oCodeBooster.Is_Generate_By_RelatedID_List = true;
            oCodeBooster.By_Related_ID_List_GenerationMode = Enum_By_Related_ID_List_GenerationMode.All;
            oCodeBooster.Is_OnDemand_DALC = true;
            #endregion
            #region AZURE
            //oCodeBooster.Is_AZURE_Enabled = false;
            #endregion
            #region MemCached
            //oCodeBooster.Is_MemCached_Enabled = true;
            #endregion

            oCodeBoosterClient.Local_Patch_Folder = @"D:\New_Project\Patches";
            oCodeBoosterClient.Is_Apply_CB_Rules = true;
            oCodeBoosterClient.Show_Embedded_TSql_Exceptions = false;
            oCodeBooster.Is_Profiling_Enabled = false;
            oCodeBooster.Is_Multilingual_Enabled = false;
            oCodeBooster.Is_BackOffice_Enabled = false;
            oCodeBooster.Is_Offline_Enabled = false;
            oCodeBooster.Is_Summary_Enabled = false;
            oCodeBooster.Is_EnvCode_Enabled = false;
            oCodeBooster.Is_Generate_API_Caller = true;
            oCodeBooster.Is_Generate_Kotlin_API_Caller = true;
            oCodeBooster.Is_Generate_Swift_API_Caller = true;
            oCodeBooster.Is_Embed_USE_DB = true;
            oCodeBooster.UI_Root_Folder = @"C:\inetpub\wwwroot\ClinicPlusWeb\Content";
            oCodeBooster.Is_By_Criteria_Shadowed = true;
            #region Inheritance
            #endregion
            switch (str_Option)
            {
                #region case "001":
                case "001":
                    oCodeBooster.Is_Method_Monitoring_Enabled = false;
                    oCodeBooster.Is_Renamed_Routines_Generation_Stopped = true;
                    oCodeBooster.Is_Count_UDF_Generation_Stopped = true;
                    oCodeBooster.Is_Create_Default_Record_Generation_Stopped = true;
                    oCodeBooster.Is_Get_Rows_Generations_Stopped = true;
                    oCodeBooster.Methods_With_Events_By_Ref = new List<string>();
                    //oCodeBooster.Methods_With_Events_By_Ref.Add("Edit_PersoN");
                    oCodeBooster.List_Reset_Topology = new List<Reset_Topology>();
                    //oCodeBooster.List_Reset_Topology.Add(new Reset_Topology() { ParentTable = "[TBL_PERSONS]", ChildTables = new List<string>() { "[TBL_ADDRES]", "[TBL_CONTACT]" } });

                    oCodeBooster.List_Eager_Loading = new List<Eager_Loading>();
                    //oCodeBooster.List_Eager_Loading.Add(new Eager_Loading() { Method_Name = "Get_Ac_By_AC_ID_Adv", ParentTable = "[TBL_AC]", ChildTables = new List<string>() { "[TBL_AC_AMENITY]", "[TBL_AC_CARD]", "[TBL_AC_CONTACT]", "[TBL_AC_IMAGE]", "[TBL_AC_SLIDE]","[TBL_AC_SOCIAL]", "[TBL_AC_HWS_INFO]", "[TBL_AC_HWS_XPAGE]", "[TBL_AC_PICKUP]", "[TBL_AC_THEME]", "[TBL_AC_DESCRIPTION]", "[TBL_AC_GW]" } });

                    #region One2Many
                    oCodeBooster.List_Inheritance = new List<Inheritance>();
                    //oCodeBooster.List_Inheritance.Add(new Inheritance() { ParentTable = "[TBL_PERSON]", ChildTable = "[TBL_ADDRESS]", RelationField = "[PERSON_ID]", RelationType = "12M" });                    
                    #endregion
                    #region Generate SP's & BLC Layer
                    oCodeBoosterClient.GenerateAllSPAndBLCLayer();
                    #endregion
                    break;
                #endregion
                #region case "002":
                case "002":

                    oCodeBooster.My_Enum_API_Target = Enum_API_Target.WebAPI;
                    oCodeBooster.My_Enum_API_Accessibility = Enum_API_Accessibility.Same_Domain;

                    oCodeBooster.List_ByPass_Ticketing = new List<string>();
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_Front_Data");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_NearBy_Ac_List");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_By_OWNER_ID_Adv");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Currency_By_OWNER_ID");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Language_By_OWNER_ID");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_By_AC_ID_Adv");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Rate_Matrix");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_Front_Data");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Application_Cached_Entry");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Delete_Fictitious_Bookings");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Startup_Data_Signature");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Startup_Data");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Person_By_Email");
                    //oCodeBooster.List_ByPass_Ticketing.Add("CheckUserExistence");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Edit_Person");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Application_Cached_Entry");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Gate_Rate_Matrix_Cached_Entry");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Get_Ac_Front_Data_Application_Cached_Entry_By_Ac");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Clear_Cached_Hotel_Page");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Issue_Booking");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Seriliaze_Booking_02");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Send_Email");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Request_Booking_Cancelation");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Convert_Booking_Data_URI_To_Image");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Guest_Specific_Booking");
                    ////oCodeBooster.List_ByPass_Ticketing.Add("Send_HWS_ContactUs_Email");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_pickup_By_AC_ID_Adv");
                    ////oCodeBooster.List_ByPass_Ticketing.Add("Chm_Booking_Handler");
                    //oCodeBooster.List_ByPass_Ticketing.Add("Get_Ac_Lowest_Price_PerCountry");



                    // --------------                                        
                    oCodeBoosterClient.GenerateAPILayer();
                    // --------------

                    break;
                #endregion
                #region case "003":
                case "003":

                    // --------------
                    UIFields oUIFields_EditUI = new UIFields();
                    UIFields oUIFields_Criteria = new UIFields();
                    UIFields oUIFields_Result = new UIFields();
                    // --------------

                    // --------------
                    oCodeBooster.My_Enum_UI_Target = Enum_UI_Target.HTML5;
                    oCodeBooster.My_Enum_HTML5_Target = Enum_HTML5_Target.NG;
                    // --------------


                    // Gather Required Data.
                    // --------------
                    oCodeBoosterClient.Gather_Required_Data();
                    // --------------

                    // Cleans UI Folder
                    // --------------
                    oCodeBoosterClient.Cleanse_UI_Patch_Folder();
                    // --------------


                    #region UI

                    #region Commented UI

                    #region Admin
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_ADMIN]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Admin_By_Where";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_ADMIN]";
                    //oUIFields_Result.Based_On_Type = "BLC.Admin";
                    //oUIFields_Result.GetMethodName = "Get_Admin_By_Where";
                    //oUIFields_Result.GridFields = new List<GridField>();



                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Admin";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Booking
                    #region Search Screen
                    oUIFields_Criteria = new UIFields();
                    oUIFields_Criteria.MainTableName = "[TBL_BOOKING]";
                    oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Booking_By_Where";

                    oUIFields_Result = new UIFields();
                    oUIFields_Result.MainTableName = "[TBL_BOOKING]";
                    oUIFields_Result.Based_On_Type = "BLC.Booking";
                    oUIFields_Result.GetMethodName = "Get_Booking_By_Where";
                    oUIFields_Result.GridFields = new List<GridField>();

                    //oUIFields_Result.Has_Related_Data = true;
                    //oUIFields_Result.Related_Tables = new List<string>();
                    //oUIFields_Result.Related_Tables.Add("[TBL_FEEDBACK]");

                    oSearch_AdvancedProp = new Search_AdvancedProp();
                    oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    oCodeBooster.Entity_FriendlyName = "Booking";
                    oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    #endregion
                    #endregion
                    #region Boost_listing
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_BOOST_LISTING]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Boost_listing_By_Where";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_BOOST_LISTING]";
                    //oUIFields_Result.Based_On_Type = "BLC.Boost_listing";
                    //oUIFields_Result.GetMethodName = "Get_Boost_listing_By_Where";
                    //oUIFields_Result.GridFields = new List<GridField>();



                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Boost_listing";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Boost_pricing
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_BOOST_PRICING]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Boost_pricing_By_OWNER_ID";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_BOOST_PRICING]";
                    //oUIFields_Result.Based_On_Type = "BLC.Boost_pricing";
                    //oUIFields_Result.GetMethodName = "Get_Boost_pricing_By_OWNER_ID";
                    //oUIFields_Result.GridFields = new List<GridField>();



                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Boost_pricing";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.Without_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Business
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_BUSINESS]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Business_By_OWNER_ID";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_BUSINESS]";
                    //oUIFields_Result.Based_On_Type = "BLC.Business";
                    //oUIFields_Result.GetMethodName = "Get_Business_By_OWNER_ID";
                    //oUIFields_Result.GridFields = new List<GridField>();

                    ////oUIFields_Result.Has_Related_Data = true;
                    ////oUIFields_Result.Related_Tables = new List<string>();
                    ////oUIFields_Result.Related_Tables.Add("[TBL_WORK_AREA]");

                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Business";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Category
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_CATEGORY]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Category_By_Where";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_CATEGORY]";
                    //oUIFields_Result.Based_On_Type = "BLC.Category";
                    //oUIFields_Result.GetMethodName = "Get_Category_By_Where";
                    //oUIFields_Result.GridFields = new List<GridField>();

                    //oUIFields_Result.Has_Related_Data = true;
                    //oUIFields_Result.Related_Tables = new List<string>();
                    //oUIFields_Result.Related_Tables.Add("[TBL_SUB_CATEGORY]");

                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "category";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Client
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_CLIENT]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Client_By_Where";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_CLIENT]";
                    //oUIFields_Result.Based_On_Type = "BLC.Client";
                    //oUIFields_Result.GetMethodName = "Get_Client_By_Where";
                    //oUIFields_Result.GridFields = new List<GridField>();



                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Client";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Coordinates
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_COORDINATES]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Coordinates_By_OWNER_ID";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_COORDINATES]";
                    //oUIFields_Result.Based_On_Type = "BLC.Coordinates";
                    //oUIFields_Result.GetMethodName = "Get_Coordinates_By_OWNER_ID";
                    //oUIFields_Result.GridFields = new List<GridField>();

                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Coordinates";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.Without_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Currency
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_CURRENCY]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Currency_By_OWNER_ID";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_CURRENCY]";
                    //oUIFields_Result.Based_On_Type = "BLC.Currency";
                    //oUIFields_Result.GetMethodName = "Get_Currency_By_OWNER_ID";
                    //oUIFields_Result.GridFields = new List<GridField>();
                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Currency";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.Without_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Feedback
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_FEEDBACK]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Feedback_By_Where";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_FEEDBACK]";
                    //oUIFields_Result.Based_On_Type = "BLC.Feedback";
                    //oUIFields_Result.GetMethodName = "Get_Feedback_By_Where";
                    //oUIFields_Result.GridFields = new List<GridField>();
                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Feedback";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.Without_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Service_prod
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_SERVICE_PROD]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Service_prod_By_Where";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_SERVICE_PROD]";
                    //oUIFields_Result.Based_On_Type = "BLC.Service_prod";
                    //oUIFields_Result.GetMethodName = "Get_Service_prod_By_Where";
                    //oUIFields_Result.GridFields = new List<GridField>();

                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Service_prod";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Status
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_STATUS]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Status_By_OWNER_ID";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_STATUS]";
                    //oUIFields_Result.Based_On_Type = "BLC.Status";
                    //oUIFields_Result.GetMethodName = "Get_Status_By_OWNER_ID";
                    //oUIFields_Result.GridFields = new List<GridField>();



                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Status";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.Without_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Sub_category
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_SUB_CATEGORY]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Sub_category_By_OWNER_ID";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_SUB_CATEGORY]";
                    //oUIFields_Result.Based_On_Type = "BLC.Sub_category";
                    //oUIFields_Result.GetMethodName = "Get_Sub_category_By_OWNER_ID";
                    //oUIFields_Result.GridFields = new List<GridField>();



                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "sub-category";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.Without_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Work_area
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_WORK_AREA]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Work_area_By_OWNER_ID";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_WORK_AREA]";
                    //oUIFields_Result.Based_On_Type = "BLC.Work_area";
                    //oUIFields_Result.GetMethodName = "Get_Work_area_By_OWNER_ID";
                    //oUIFields_Result.GridFields = new List<GridField>();



                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Work_area";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.Without_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Work_list
                    #region Search Screen
                    oUIFields_Criteria = new UIFields();
                    oUIFields_Criteria.MainTableName = "[TBL_WORK_LIST]";
                    oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Work_list_By_OWNER_ID";

                    oUIFields_Result = new UIFields();
                    oUIFields_Result.MainTableName = "[TBL_WORK_LIST]";
                    oUIFields_Result.Based_On_Type = "BLC.Work_list";
                    oUIFields_Result.GetMethodName = "Get_Work_list_By_OWNER_ID";
                    oUIFields_Result.GridFields = new List<GridField>();



                    oSearch_AdvancedProp = new Search_AdvancedProp();
                    oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    oCodeBooster.Entity_FriendlyName = "Work_list";
                    oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.Without_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    #endregion
                    #endregion

                    #region Person
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_PERSON]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Person_By_Where";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_PERSON]";
                    //oUIFields_Result.Based_On_Type = "BLC.Person";
                    //oUIFields_Result.GetMethodName = "Get_Person_By_Where";
                    //oUIFields_Result.GridFields = new List<GridField>();



                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Person";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.Without_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region Product
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_PRODUCT]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Params_Get_Product_By_Where";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_PRODUCT]";
                    //oUIFields_Result.Based_On_Type = "BLC.Product";
                    //oUIFields_Result.GetMethodName = "Get_Product_By_Where";
                    //oUIFields_Result.GridFields = new List<GridField>();

                    ////oUIFields_Result.Has_Related_Data = true;
                    ////oUIFields_Result.Has_Related_Files = true;
                    ////oUIFields_Result.Related_Tables = new List<string>();
                    ////oUIFields_Result.Related_Tables.Add("[TBL_CART]");
                    ////oUIFields_Result.Related_Tables.Add("[TBL_ORDER]");


                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "Product";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion
                    #region User
                    //#region Search Screen
                    //oUIFields_Criteria = new UIFields();
                    //oUIFields_Criteria.MainTableName = "[TBL_USER]";
                    //oUIFields_Criteria.Based_On_Type = "BLC.Get_User_By_Criteria";

                    //oUIFields_Result = new UIFields();
                    //oUIFields_Result.MainTableName = "[TBL_USER]";
                    //oUIFields_Result.Based_On_Type = "BLC.User";
                    //oUIFields_Result.GetMethodName = "Get_User_By_Criteria";
                    //oUIFields_Result.GridFields = new List<GridField>();



                    //oSearch_AdvancedProp = new Search_AdvancedProp();
                    //oSearch_AdvancedProp.ContainerMargins = "0,5,0,5";
                    //oCodeBooster.Entity_FriendlyName = "User";
                    //oCodeBoosterClient.Generate_ListUI(Enum_SearchMethod.With_Criteria_Section, oUIFields_Criteria, oUIFields_Result, oSearch_AdvancedProp);
                    //#endregion
                    #endregion

                    #endregion

                    #region Active UI

                    #endregion





                    #endregion


                    // Send UI Patch
                    // -------------
                    oCodeBoosterClient.Send_UI_Patch();
                    // --------------

                    break;
                #endregion
                #region Case "051":
                case "051":
                    Params_Generate_Mobile_Native_UI oParams_Generate_Mobile_Native_UI = new Params_Generate_Mobile_Native_UI();
                    oParams_Generate_Mobile_Native_UI.MOBILE_PLATFORM = "ANDROID";
                    oParams_Generate_Mobile_Native_UI.VIEW_TYPE = "001";
                    oParams_Generate_Mobile_Native_UI.TABLE_NAME = "[TBL_AC]";
                    oParams_Generate_Mobile_Native_UI.GET_METHOD_NAME = "Get_Ac_By_Where";
                    oParams_Generate_Mobile_Native_UI.TITLE = "Hotels";
                    oParams_Generate_Mobile_Native_UI.BAR_BUTTON_ITEM_TITLE = "Bla Bla";
                    oParams_Generate_Mobile_Native_UI.IMAGE_BASE_URL = @"https://www.igloorooms.com/irimages/aclogo/AcLogo_\(myData[indexPath.row].AC_ID!).jpg";
                    //oCodeBoosterClient.Generate_Mobile_Native_UI(oParams_Generate_Mobile_Native_UI);

                    oParams_Generate_Mobile_Native_UI = new Params_Generate_Mobile_Native_UI();
                    oParams_Generate_Mobile_Native_UI.MOBILE_PLATFORM = "IOS";
                    oParams_Generate_Mobile_Native_UI.VIEW_TYPE = "001";
                    oParams_Generate_Mobile_Native_UI.TABLE_NAME = "[TBL_AC]";
                    oParams_Generate_Mobile_Native_UI.GET_METHOD_NAME = "Get_Ac_By_Where";
                    oParams_Generate_Mobile_Native_UI.TITLE = "Hotels";
                    oParams_Generate_Mobile_Native_UI.BAR_BUTTON_ITEM_TITLE = "Bla Bla";
                    oParams_Generate_Mobile_Native_UI.IMAGE_BASE_URL = @"https://www.igloorooms.com/irimages/aclogo/AcLogo_\(myData[indexPath.row].AC_ID!).jpg";
                    //oCodeBoosterClient.Generate_Mobile_Native_UI(oParams_Generate_Mobile_Native_UI);

                    break;
                    #endregion
            }
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadLine();
            #endregion
        }
        #endregion
    }
}




