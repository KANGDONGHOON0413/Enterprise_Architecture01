using EA.Model;
using Note.IDAL;
using System;
using System.Collections.Generic;

namespace noteBll
{
    public class userBll
    {
       //private UserDal _userDal = new UserDal(); // 강한 결합 방식

       private I_UserDal _userDal;    // 약한 결합 방식

        public User GetUser(int userNo)
        {
            return _userDal.GetUser(userNo);
        }

        public List<User> GetUserList()
        {
            throw new NotImplementedException();
        }
    }
}
