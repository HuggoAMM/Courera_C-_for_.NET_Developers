using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_indexer_exceptions
{
    internal class User
    {
        private string name;
        private string companyName;
        private int age;
        private string City { get; set; }

        public User()
        {
            companyName = "ABCD";
        }

        //Read and Write
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Read
        public string CompanyName
        {
            get { return companyName; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new ArithmeticException("Invalid Age");
                }

                age = value;
            }
        }
    }
}
