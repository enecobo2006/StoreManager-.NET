namespace Store.BLL.Entities
{
    public class ProductBLL
    {
        private string _name;
        private decimal _price;

        public int Id { get; internal set; }
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length > 200)
                    throw new ArgumentException("Emri i produktit, nuk mund te jete me shume se 200 karaktere i gjate!");
                _name = value;
            }
        }
        public string? Category { get; set; } = "Undefined";
        public decimal Price
        {
            get => _price; set
            {
                if (value < 0)
                    throw new ArgumentException("Cmimi i produktit, nuk mund te jete negativ!");
                _price = value;
            }
        }
        public decimal Stock { get; set; }
    }
}
