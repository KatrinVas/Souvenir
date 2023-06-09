using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Souvenir.Models
{


    public class Souvenir
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //M:1
        public DateTime RegisterOn{get;set;}
        public int SouvenirTypesId { get; set; }
        public SouvenirType SouvenirTypes{ get; set; }
        public int SouvenirTypeId { get; internal set; }

        public static implicit operator Souvenir(Souvenir v)
        {
            throw new NotImplementedException();
        }
    }
    
    
}