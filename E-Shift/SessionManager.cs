using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Shift
{
    internal class SessionManager
    {
        public static int LoggedInCustomerID { get; private set; }
        public static string LoggedInCustomerUsername { get; private set; }
        public static string LoggedInCustomerName { get; private set; }
        // Add other customer details if you want them easily accessible throughout the app
        // public static string LoggedInCustomerEmail { get; private set; }
        // public static string LoggedInCustomerContact { get; private set; }
        // public static string LoggedInCustomerAddress { get; private set; }
        // public static string LoggedInCustomerPhotoPath { get; private set; }


        public static void SetCustomerSession(int customerId, string username, string name)
        {
            LoggedInCustomerID = customerId;
            LoggedInCustomerUsername = username;
            LoggedInCustomerName = name;
            // Set other properties here if added above
        }

        public static void ClearSession()
        {
            LoggedInCustomerID = 0; // Or some default invalid ID
            LoggedInCustomerUsername = null;
            LoggedInCustomerName = null;
            // Clear other properties
        }

        public static bool IsCustomerLoggedIn()
        {
            return LoggedInCustomerID > 0;
        }
    }
}
