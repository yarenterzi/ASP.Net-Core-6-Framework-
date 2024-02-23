using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    //Temel olarak atanan crud işlemleri harici metot atanmak istendiğinde yapılacak işlemler bu öznel servicelere atanır

    public interface IGuideService:IGenericService<Guide>
    {
        //burada oluşturulan isimler EntityFramework de çağırılarak işlemlerin içi doldurulur
        void TChangeToTrueByGuide(int id);
        void TChangeToFalseByGuide(int id);
    }
}
