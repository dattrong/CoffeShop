using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffeeshop.Models
{
    public class nguyenlieu
    {
        public int nguyenlieuId { get; set; }//id 
        public string tenNguyenLieu { get; set; }//trứng và coffe
        public int menuId { get; set; }

        //1 , trứng, 1
        //2, coffe, 1
    }
}