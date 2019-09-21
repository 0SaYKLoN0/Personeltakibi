namespace WFAPersonelTakibi.Dal
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WFAPersonelTakibi.Models;

    public class Model1 : DbContext
    {

        public Model1()
            : base("name=Model1")
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }

    }


}