using Store.BLL.Contracts;
using Store.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.BLL.Services
{
    internal class UserManager : IUserManager
    {
        public void EditUser(int userId, string text1, string text2)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public Person GetById(int userId)
        {
            throw new NotImplementedException();
        }

        public void SignUp(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
