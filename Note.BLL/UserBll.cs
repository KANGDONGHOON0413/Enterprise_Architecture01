using EA.Model;
using Note.IDAL;
using Note.DAL;
using System;
using System.Collections.Generic;

namespace Note.BLL
{
    public class UserBll 
    {
        private UserDal _userDal = new UserDal();
        public User GetUser(int userNo)
        {
           _userDal.
        }

        public List<User> GetUserList()
        {
            throw new NotImplementedException();
        }
    }
}
