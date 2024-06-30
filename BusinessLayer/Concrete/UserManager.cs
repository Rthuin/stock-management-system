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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAllUsers()
        {
            return _userDal.GetAll();
        }

        public User GetUser(int id)
        {
            return _userDal.GetById(id);
        }

        public void UserAdd(User user)
        {
            _userDal.Insert(user);
        }

        public void UserRemove(User user)
        {
            _userDal.Delete(user);
        }

        public void UserUpdate(User user)
        {
            _userDal.Update(user);
        }
    }
}
