using Latihan_Minggu_5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Minggu_5
{
    public class ItemController : IItem
    {
        private MyContext myContext = new MyContext();
        bool status = false;
        public bool DeleteItem(int Id)
        {
            Console.Write("Insert your Id : ");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.Find(Id);
            if (get != null)
            {
                myContext.Entry(get).State = EntityState.Deleted;
                var result = (myContext.SaveChanges());
                if (result > 0)
                {
                    Console.Write("Delete Succes");
                    status = true;
                }
                else
                {
                    Console.Write("Delete Failed");
                }
            }
            else
            {
                Console.Write("Data Not Found");
            }
            return status;
        }

        public TB_M_Items get(int Id)
        {
            Console.Write("Insert Your Id : ");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.SingleOrDefault(x => x.Id==Id);
            Console.Write("Id : ");
            Console.WriteLine(get.Id);
            Console.Write("Name :");
            Console.WriteLine(get.Name);
            Console.Write("Supplier Id");
            Console.WriteLine(get.TB_M_Suppliers_Id);
            Console.Write("Price");
            Console.WriteLine(get.Price);
            Console.Write("Stock");
            Console.WriteLine(get.Stock);
            Console.WriteLine("");
            return get;
        }

        public bool InsertItem(TB_M_Items items)
        { 
            Console.Write("Insert your name : ");
            String Name = Console.ReadLine();
            Console.Write("Insert Supplier ID :");
            int TB_M_Suppliers_Id = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Price :");
            int Price = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Stock : ");
            int Stock = Convert.ToInt16(Console.ReadLine());

            
            items.Name = Name;
            items.TB_M_Supplier_Id = TB_M_Suppliers_Id;
            items.Price = Price;
            items.Stock = Stock;
            myContext.TB_M_Items.Add(items);
            var result = (myContext.SaveChanges());
            if (result > 0)
            {
                status = true;
                Console.Write("Insert Successfully");
            }
            else
            {
                Console.Write("Insert Failed");
            }
            return status;
        }

        public bool UpdateItem(int Id, TB_M_Items item)
        {
            Console.Write("Insert your Id : ");
            Id = Convert.ToInt16(Console.ReadLine());
            var get = myContext.TB_M_Items.Find(Id);
            if (get != null)
            {
                Console.Write("Insert Your Name :");
                string Name = Console.ReadLine();
                get.Name = Name;
                myContext.Entry(get).State = EntityState.Modified;
                var result = (myContext.SaveChanges());
                if (result > 0)
                {
                    Console.Write("Update Succes");
                    status = true;
                }
                else
                {
                    Console.Write("Update Failed");
                }
            }
            else
            {
                Console.Write("Data Not Found");
            }
            return status;
        }

        public List<TB_M_Items> viewAllData()
        {
            var get = myContext.TB_M_Items.Where(x => x.IsDelete == false).ToList();
            Console.WriteLine("============================");
            Console.WriteLine("\t Data Item");
            Console.WriteLine("============================");
            foreach (var list in get)
            {
                Console.Write("Id : ");
                Console.WriteLine(list.Id);
                Console.Write("Name :");
                Console.WriteLine(list.Name);
                Console.Write("Supplier Id");
                Console.WriteLine(list.TB_M_Suppliers_Id);
                Console.Write("Price");
                Console.WriteLine(list.Price);
                Console.Write("Stock");
                Console.WriteLine(list.Stock);
                Console.WriteLine("");
            }
            return get;
        }
    }
}
