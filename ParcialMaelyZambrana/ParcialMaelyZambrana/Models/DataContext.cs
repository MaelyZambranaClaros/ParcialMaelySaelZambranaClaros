using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParcialMaelyZambrana.Models
{
    public class DataContext:DbContext
    {
        public DataContext(): base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialMaelyZambrana.Models.Parcial1> Parcial1 { get; set; }
    }
}