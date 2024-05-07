using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MyOODProject
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelContainer")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
