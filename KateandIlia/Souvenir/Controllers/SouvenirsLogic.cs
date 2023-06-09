using Souvenir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Souvenir.Controllers
{
    public class SouvenirsLogic
    {   
        private SouvenirContext _souvenirDbContext = new SouvenirContext(); //Database
        public List<Models.Souvenir> GetAll()
        {
            using (_souvenirDbContext = new SouvenirContext())
            {
                List<Models.Souvenir> listSouvenirs = _souvenirDbContext.Souvenir.ToList();
                return listSouvenirs;

            }
        }
        
        public SouvenirType Get(int id)
        {
            using (_souvenirDbContext = new SouvenirContext())
            {
                SouvenirType findedSouvenirs=_souvenirDbContext.Souvenir.Find(id);
                if (findedSouvenirs !=null)
                {
                    _souvenirDbContext.Entry(findedSouvenirs).Reference(x => x.SouvenirType).Load();
                }
                return findedSouvenirs;
            }
        }
       public void Update(int id,Models.Souvenir souvenirs)
        {
            using (_souvenirDbContext=new SouvenirContext())
            {
                Models.Souvenir findedSouvenirs = _souvenirDbContext.Souvenir.Find(id);
                if (findedSouvenirs==null)
                {
                    return;
                }
                findedSouvenirs.SouvenirTypeId = id;
                _souvenirDbContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (_souvenirDbContext=new SouvenirContext())
            {
                Models.Souvenir findedSouvenirs = _souvenirDbContext.Souvenir.Find();
                _souvenirDbContext.Souvenir.Remove(findedSouvenirs);
                _souvenirDbContext.SaveChanges();
            }
        }
    }
}
