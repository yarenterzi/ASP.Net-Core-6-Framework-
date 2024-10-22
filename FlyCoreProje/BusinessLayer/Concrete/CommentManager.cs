﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Migrations;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //Dependency Injection(Bağımlılık Enjeksiyonu) bileşenin dışarıdan yönetilmesi
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public object RedirectToAction { get; private set; }

        public CommentManager(ICommentDal commentDal)
        {
            //crud metotları _.... atanarak istenen işlemin altında çağırılarak atanır
            _commentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
           _commentDal.Delete(t);
          
        }

        public Comment TGetByID(int id)
        {
          return _commentDal.GetByID(id);
        }

        public List<Comment> TGetList()
        {
           return _commentDal.GetList();
        }
        public List<Comment> TGetDestinationByID(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationID == id);
        }
        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListCommentWithDestination()
        {
          return _commentDal.GetListCommentWithDestination();
        }

        public List<Comment> TGetListCommentWithDestinationAndUser(int id)
        {
          return _commentDal.GetListCommentWithDestinationAndUser(id);
        }
    }
}
