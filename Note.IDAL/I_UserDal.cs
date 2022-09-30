using EA.Model;
using System;
using System.Collections.Generic;

//Interface 만 모아놓은 폴더
namespace Note.IDAL
{
    public interface I_UserDal
    {
        List<User> GetUserList();
        User GetUser(int userNo);
    }
}
