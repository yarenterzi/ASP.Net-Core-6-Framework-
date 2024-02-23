using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Antiforgery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //Dependency Injection(Bağımlılık Enjeksiyonu) bileşenin dışarıdan yönetilmesi
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            //crud metotları _.... atanarak istenen işlemin altında çağırılarak atanır
            _announcementDal = announcementDal;
        }

        public void TAdd(Announcement t)
        {
          _announcementDal.Insert(t);
        }

        public void TDelete(Announcement t)
        {
         _announcementDal.Delete(t);
        }

        public Announcement TGetByID(int id)
        {
          return _announcementDal.GetByID(id);
        }

        public List<Announcement> TGetList()
        {
          return _announcementDal.GetList();
        }

        public void TUpdate(Announcement t)
        {
         _announcementDal.Update(t);
        }
    }
}
