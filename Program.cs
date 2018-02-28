using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_sqliteLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DBContext();
            //db.Students.Add(new students { SNAME = "姚", SEX = "女", AGE = 21 });
            //var count = db.SaveChanges();

            foreach(var table in db.Students)
            {
                Console.WriteLine($"SID={table.SID}|SNAME={table.SNAME}|SEX={table.SEX}|AGE={table.AGE}|");
            }



            Console.Read();
        }
    }
}
