using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace OOD_Forms_Application
{
    static class Program
    {
        private static SqlConnection connection ;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            connection = new SqlConnection("Data Source=.;AttachDbFilename=|DataDirectory|\\RealEstate.mdf;Integrated Security=True;Connect Timeout=30");

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
    }
}
