using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODNew
{
    class User
    {
        private string id;
        private string name;
        private string email;
        private string password;
        private string username;
        private string role_id;
        private string address;
        private string commission;
        private string cpr;
        private string dob; 
        private string phone;

        public string Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Email
        {
            set
            {
                this.email = value;
            }
            get
            {
                return this.email;
            }
        }
        public string Username
        {
            set
            {
                this.username = value;
            }
            get
            {
                return this.username;
            }
        }
        public string Password
        {
            set
            {
                this.password = value;
            }
            get
            {
                return this.password;
            }
        }
        public string Role_id
        {
            set
            {
                this.role_id = value;
            }
            get
            {
                return this.role_id;
            }
        }
        public string Address
        {
            set
            {
                this.address = value;
            }
            get
            {
                return this.address;
            }
        }
        public string Commision
        {
            set
            {
                this.commission = value;
            }
            get
            {
                return this.commission;
            }
        }
           public string CPR
        {
            set
            {
                this.cpr = value;
            }
            get
            {
                return this.cpr;
            }}
           public string Dob
        {
            set
            {
                this.dob = value;
            }
            get
            {
                return this.dob;
            }}
           public string Phone
        {
            set
            {
                this.phone = value;
            }
            get
            {
                return this.phone;
            }}
    }
}
