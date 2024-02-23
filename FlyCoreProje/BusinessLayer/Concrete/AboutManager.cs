using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        //Dependency Injection(Bağımlılık Enjeksiyonu) bileşenin dışarıdan yönetilmesi
        IAboutDal _aboutdal;
        public AboutManager(IAboutDal aboutdal)
        {
            //crud metotları _.... atanarak istenen işlemin altında çağırılarak atanır
            _aboutdal = aboutdal;
        }
        public void TAdd(About t)
        {
           _aboutdal.Insert(t);
        }
        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }
        public void TDelete(About t)
        {
            _aboutdal.Delete(t);
        }

        public List<About> TGetList()
        {
        return  _aboutdal.GetList();
        }

        public void TUpdate(About t)
        {
           _aboutdal.Update(t);
        }
    }
}
