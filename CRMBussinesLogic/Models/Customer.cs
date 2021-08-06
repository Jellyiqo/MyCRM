using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBussinesLogic.Models
{
    class Customer
    {
        public int CustomerID{ get; set; }

        public string Name { get; set; }

        public virtual ICollection<Check> Checks { get; set; }  // Связываем с Check

        public override string ToString()
        {
            return Name;
        }
    }
}
