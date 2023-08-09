using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_Bank
{
    public class clsClient
    {
        
        // constructors
        public clsClient() { }
        public clsClient(string first_name, string last_name, DateTime birthday, List<clsTransaction> transactions, double balance)
        {
            
            this._id = get_new_id();
            this._first_name = first_name;
            this._last_name = last_name;
            this._birthday = birthday;
            this._transactions = transactions;
            this._balance = balance;

        }
        public clsClient(string id, string first_name, string last_name, DateTime birthday, List<clsTransaction> transactions, double balance)
        {
        
            this._id = id;
            this._first_name = first_name;
            this._last_name = last_name;
            this._birthday = birthday;
            this._transactions = transactions;
            this._balance = balance;
        
        }


        // Members

        private string _id;
        private string _first_name;
        private string _last_name;
        private DateTime _birthday;
        private List<clsTransaction> _transactions;
        private double _balance;

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
        public List<clsTransaction> transactions
        {
            get
            {
                return _transactions;
            }

            set
            {
                _transactions = value;
            }
        }
        public double balance
        {
            get
            {
                return _balance;
            }

            set
            {
                _balance = value;
            }
        }



        // public functions
        public clsClient find(string id)
        {
            // Here searching for the client on database , return null if it is not 
            return null;
        }
        public List<clsClient> find(string first_name,string last_name)
        {
            // Here searching for the client on database , return null if it is not found
            return null;
        }
        public bool add(clsClient new_client)
        {
            //Adding new client to the database
            return false;
        }
        public bool delete(clsClient client)
        {
            //Deleting client from the database
            return false;
        }
        public bool update(clsClient client)
        {
            //Updating client in the database
            return false;
        }


        // private functions
        private string get_new_id()
        {
            //Generating unique id
            return null;
        }

    }



    
}
