using CsvExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmct.own.CsvExtension.csv.test
{
    public class Person
    {
        [CsvAttribute]
        public string Name { get; set; }
        [CsvAttribute]
        public string Email { get; set; }
        [CsvAttribute]
        public string Address { get; set; }
        [CsvAttribute]
        public int Phone { get; set; }

        public string Extra { get; set; }

        public Person(string name, string email, string address, int phone)
        {
            this.Name = name;
            this.Email = email;
            this.Address = address;
            this.Phone = phone;
        }
    }
}
