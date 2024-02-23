using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //IGeneriicDal da tanımlı crud işlemlerini miras alır <hangi tablo için olduğunu belirtiriz>
    public interface IGuideDal : IGenericDal<Guide>
    {
        
        void ChangeToTrueByGuide(int id);
        void ChangeToFalseByGuide(int id);
    }
}
