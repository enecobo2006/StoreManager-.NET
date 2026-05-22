using Store.BLL.Entities;

namespace Store.BLL.Contracts
{
    public interface IUserManager
    {
        void EditUser(int userId, string text1, string text2);
        List<Person> GetAll();
        Person GetById(int userId);
        void SignUp(string email, string password);
    }
}
