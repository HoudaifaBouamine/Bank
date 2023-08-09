using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_Bank
{
    public class clsUser
    {

        // Constructor
        public clsUser() { }
        public clsUser(string first_name, string last_name, DateTime birthday, List<clsTransaction> transactions, int permition)
        {

            this._id = get_new_id();
            this._first_name = first_name;
            this._last_name = last_name;
            this._birthday = birthday;
            this._permition = permition;

        }
        public clsUser(string id, string first_name, string last_name, DateTime birthday, List<clsTransaction> transactions, int permition)
        {

            this._id = id;
            this._first_name = first_name;
            this._last_name = last_name;
            this._birthday = birthday;
            this._permition = permition;

        }

        // Members

        private string _id;
        private string _first_name;
        private string _last_name;
        private DateTime _birthday;
        private int _permition;


        // Properties
        public string id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
        public string first_name
        {
            get
            {
                return _first_name;
            }

            set
            {
                _first_name = value;
            }
        }
        public string last_name
        {
            get
            {
                return _last_name;
            }

            set
            {
                _last_name = value;
            }
        }
        public DateTime birthday
        {
            get
            {
                return _birthday;
            }

            set
            {
                _birthday = value;
            }
        }
        public int permition
        {
            get
            {
                return _permition;
            }

            set
            {
                _permition = value;
            }
        }


        // Public functions
        public clsUser find(string id)
        {
            // Here searching for the user on database , return null if it is not 
            return null;
        }
        public List<clsUser> find(string first_name, string last_name)
        {
            // Here searching for the user on database , return null if it is not found
            return null;
        }
        public bool add(clsUser new_user)
        {
            //Adding new user to the database
            return false;
        }
        public bool delete(clsUser user)
        {
            //Deleting user from the database
            return false;
        }
        public bool update(clsUser user)
        {
            //Updating user in the database
            return false;
        }


        // Private functions
        private string get_new_id()
        {
            //Generating unique id
            return null;
        }

    }
}

