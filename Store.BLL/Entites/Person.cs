using Store.BLL.Entites;

namespace Store.BLL.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private string _password;

        public string Password 
        { 
            get => _password;
            set => _password = Utils.GetValidPassword(value);

        }
    }
}
