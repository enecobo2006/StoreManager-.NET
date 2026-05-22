namespace Store.BLL.Entites
{
    public class ClientBLL
    {
        private string _name;
        
        public string Name
        {
            get => _name;
            set
            {
                if(value.Length > 200)
                    throw new ArgumentException("Name can not be more than 200 characters");
                _name = value;
            }
        }
    }
}
