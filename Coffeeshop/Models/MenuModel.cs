using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coffeeshop.Models
{
    public class MenuModel
    {
        public int id { get; set; }//id = 1
        public string name { get; set; }//coffe trung
        public int money { get; set; }//200
        public List<nguyenlieu> tennguyenlieu { get; set; }
    }
}