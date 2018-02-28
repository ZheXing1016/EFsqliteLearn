using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_sqliteLearn
{

    public class DBContext:DbContext
    {
        public DbSet<students> Students { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={System.IO.Directory.GetCurrentDirectory()}\\db.db;");
            //optionsBuilder.UseSqlite($"Data Source=db.db;");
        }
    }
    [Table("students")]
    public class students
    {
        [Key]
        public int SID { set; get; }
        public string SNAME { set; get; }
        public string SEX { set; get; }
        public int AGE { set; get; }
    }
    class dbmodule
    {
    }
}
