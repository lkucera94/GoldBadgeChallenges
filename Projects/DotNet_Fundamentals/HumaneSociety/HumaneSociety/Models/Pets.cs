using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HumaneSociety.Models
{
    public class Pets
    {
        public int PetID { get; set; }
        public string Name { get; set; }
        public string AnimalType { get; set; }
    }
    public class PetDBContext : DbContext
    {
        public DbSet<Pets> Pets { get; set; }
    }
}