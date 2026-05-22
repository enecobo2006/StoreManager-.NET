namespace Store.BLL.Entites
{
    public class Client
    {
        public string Name { get; set; }
        private string _id;

        public string Id
        {
            get => _id;
            set => _id = value;
        }
    }
}
