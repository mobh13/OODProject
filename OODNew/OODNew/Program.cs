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
        [STAThread]
        static void Main()
        {
            connection = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\\users\\user\\documents\\visual studio 2013\\Projects\\OODNew\\OODNew\\RealEstate.mdf;Integrated Security=True");

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
