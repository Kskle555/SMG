using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }
        public int StockCode { get; set; }
        public string StockName { get; set; }
        public int KDV { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Registerdate { get; set; }
        public ICollection<WareHouse> WareHouse { get; set; }
        public ICollection<Admin> Admin { get; set; }
    }
}
