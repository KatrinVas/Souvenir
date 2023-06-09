using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Souvenir.Models
{
    public class SouvenirContext:DbContext
    {
        public SouvenirContext() : base("SouvenirContext")
        {

        }
        public DbSet<Souvenir> Souvenirs { get; set; }
       public DbSet<SouvenirType> SouvenirTypes { get; set; }
        public object Souvenir { get; internal set; }
    }
}
