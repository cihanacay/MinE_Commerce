using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class UserService : IUserService
    {
        IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }


        public List<User> GetListAll()
        {
            var list = _userDal.GetListAll();

            return list;
        }

        public List<User> GetListAll(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TAdd(User t)
        {
            _userDal.Insert(t);
        }

        public void TDelete(User t)
        {
            _userDal.Delete(t);
        }

        public User TGetById(int id)
        {
            var model = _userDal.GetById(id);
            return model;
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
