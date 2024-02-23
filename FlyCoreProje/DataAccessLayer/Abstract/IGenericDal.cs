using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        //Yapılmak istenen her crud işlemi için bütün Interfacelere ayrı ayrı atama yapmak yerine tek parametre ve metot tanımlayarak bütün Interfacelerde bu işlem miras alma yöntemi ile atanır
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);
    }
}
