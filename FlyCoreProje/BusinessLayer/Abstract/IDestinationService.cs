using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    //Temel olarak atanan crud işlemleri harici metot atanmak istendiğinde yapılacak işlemler bu öznel servicelere atanır
    public interface IDestinationService:IGenericService<Destination>
    {
        public Destination TGetDestinationsWithGuide(int id);
        public List<Destination> TGetLast4Destinations();
    }
}
