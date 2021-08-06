using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBussinesLogic.Models
{
    class Check
    {
        public int CheckID { get; set; }

        public int CustomerID { get; set; }

        public virtual  Customer Customer { get; set; }

        public int SellerID { get; set; }

        public virtual Seller Seller { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Sell> Sells { get; set; } // Связываем Check с промежуточной сущностью Sells

        public override string ToString()
        {
            return $"№{CheckID} от {Created.ToString("dd..MM.yy HH.mm.ss")}";
        }
    }
}
