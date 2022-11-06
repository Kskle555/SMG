using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WareHouse
    {
        [Key]
        public int WareHouseID { get; set; }
        public int ReceiptNumber { get; set; }
        public int WareHouseCode { get; set; }
        public int İncomePrice { get; set; }    
        public int OutPrice { get; set; }    
        public string User { get; set; }    
        public DateTime Registerdate { get; set; }
       public ICollection<Admin> Admin { get; set;} 
    }
}
