using Coffeeshop.Models;
using Coffeeshop.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffeeshop.Controllers
{
    public class CoffeController : Controller
    {
        CafeModel cf = new CafeModel();
        // GET: Coffe
        public ActionResult Index()
        {
            return View();
        }
        public List<int> Menu()
        {
            List<int> list = new List<int>();
            // hiển thị hết menu
            return list;
        }
        public List<MENU> MenuByMoney(int money)
        {
            //trả về 1 list món ăn theo giá tiền
            List<MENU> list = new List<MENU>();//lấy tất cả menu
            // int = bảng menu tên món giá tiền 
            //linq
            list = list.Where(e => e.money <= money).ToList();
            // select * from menu where Money <= money
            return list;
        }
        public MENU coffeByUser(int id)
        {
            List<MENU> list = new List<MENU>();
            MENU menu = list.Where(e => e.id == id).FirstOrDefault();
            // tên và giá tiền
            List<nguyenlieu> tennguyenlieu = new List<nguyenlieu>();
            menu.tennguyenlieu = tennguyenlieu.Where(e => e.menuId == id).ToList();
            //coffe đã có tên giá tiên + tên nguyên liệu
            return menu;

        }
        public List<MENU> nhieuMon(List<int> id)
        {
            List<MENU> list = new List<MENU>();
            List<MENU> monan = new List<MENU>();
            List<nguyenlieu> tennguyenlieu = new List<nguyenlieu>();
            for (int i = 0; i < id.Count; i++)
            {
                MENU motmon = list.Where(e => e.id == id[i]).FirstOrDefault();
                if (tennguyenlieu.Exists(e => e.menuId == id[i]))
                {
                    motmon.tennguyenlieu = tennguyenlieu.Where(e => e.menuId == id[i]).ToList();
                }
                monan.Add(motmon);
            }
            return monan;

        }

    }
}