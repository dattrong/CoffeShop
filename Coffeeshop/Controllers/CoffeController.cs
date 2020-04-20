using Coffeeshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Coffeeshop.Controllers
{
    public class CoffeController : Controller
    {
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
        public List<MenuModel> MenuByMoney(int money)
        {
            //trả về 1 list món ăn theo giá tiền
            List<MenuModel> list = new List<MenuModel>();//lấy tất cả menu
            // int = bảng menu tên món giá tiền 
            //linq
            list = list.Where(e => e.money <= money).ToList();
            // select * from menu where Money <= money
            return list;
        }
        public MenuModel coffeByUser(int id)
        {
            List<MenuModel> list = new List<MenuModel>();
            MenuModel coffe = list.Where(e => e.id == id).FirstOrDefault();
            // tên và giá tiền
            List<nguyenlieu> tennguyenlieu = new List<nguyenlieu>();
            coffe.tennguyenlieu = tennguyenlieu.Where(e => e.menuId == id).ToList();
            //coffe đã có tên giá tiên + tên nguyên liệu
            return coffe;

        }
        public List<MenuModel> nhieuMon(List<int> id)
        {
            List<MenuModel> list = new List<MenuModel>();
            List<MenuModel> monan = new List<MenuModel>();
            List<nguyenlieu> tennguyenlieu = new List<nguyenlieu>();
            for (int i = 0; i < id.Count; i++)
            {
                MenuModel motmon = list.Where(e => e.id == id[i]).FirstOrDefault();
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