using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppMVC.Models;

namespace WebAppMVC.Context
{
    public class EmpContext:DbContext
    {
        public DbSet<Emp> Emps { get; set; }
    }
}