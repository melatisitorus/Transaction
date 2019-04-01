using Latihan_Minggu_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Minggu_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //SupplierController suppliercontroller = new SupplierController();
            //ISupplier SupplierController = new ControllerSupplier();
            //SupplierController.viewAllData();
            //Console.Read();
            //ControllerSupplier.insertdata();
            //Console.Read();

            IItem iitem;
            TB_M_Items item= new TB_M_Items();
            Console.WriteLine("======================");
            Console.WriteLine("Action");
            Console.WriteLine("======================");
            Console.WriteLine("1. View Data");
            Console.WriteLine("2. Insert");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Upadate");
            Console.WriteLine("======================");
            Console.Write("Input Pilihan : ");

            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number == 1)
            //{
            //    controlleritem.viewAllData();
            //}
            //else if (number == 2)
            //{
            //    iitem = new ControllerSupplier();
            //    iitem.InsertItem(TB_M_Items);
            //}
            //else if (number == 3)
            //{
            //    iitem = new ControllerSupplier();
            //    iitem.DeleteItem(TB_M_Items);
            //}
            //else if (number == 4)
            //{
            //    iitem = new ControllerSupplier();
            //    iitem.UpdateItem(TB_M_Items);
            //}
            //else
            //{
            //    Console.WriteLine("Not Data Found");
            //}
            //Console.Read();
        }
    }
}
