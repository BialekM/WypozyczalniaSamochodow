using MichalBialekLab4ZadanieDomowe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichalBialekLab4ZadanieDomowe
{
    public class MichalBialekDbContext : DbContext
    {
        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Rent> Rents { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public MichalBialekDbContext() : base("name=MichalBialekDbContext")
        {
            Database.SetInitializer<MichalBialekDbContext>(new DropCreateDatabaseIfModelChanges<MichalBialekDbContext>());
        }
    }
}
