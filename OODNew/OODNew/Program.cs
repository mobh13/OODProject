using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace OODNew
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static SqlConnection connection;
        private static User user;
        [STAThread]
        static void Main()
        {
            user = new User(); 
            connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.RealEstateConnectionString;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Logincs());
        }
        public static SqlConnection Connection
        {
            set
            {
                connection = value;

            }
            get
            {
                return connection;
            }
        }
        public static User UserInfo
        {
            set
            {
                user = value;

            }
            get
            {
                return user;
            }
        }
    }
}
