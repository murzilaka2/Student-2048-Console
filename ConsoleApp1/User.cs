using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime DeletedOn { get; set; }


        public override string ToString()
        {
            return $"Id - {Id}, Name - {Name}, Address - {Address}.";
        }
    }
}
