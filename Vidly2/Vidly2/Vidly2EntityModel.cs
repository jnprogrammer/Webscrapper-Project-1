namespace Vidly2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Vidly2EntityModel : DbContext
    {
        public Vidly2EntityModel()
            : base("name=Vidly2EntityModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
