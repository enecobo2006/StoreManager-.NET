using Store.BLL.Entites;

namespace Store.BLL.Contracts
{
    public interface IClientManager
    {
        ClientBLL Add(ClientBLL client);
        ClientBLL GetById(int id);
        ClientBLL Update(int id, ClientBLL client);
        void Delete(int id);
        IEnumerable<ClientBLL> GetAll();
    }
}
