global using DapperAndEFcore.Data;
global using DapperAndEFcore.Models;

namespace DapperAndEFcore.Service.EFcore
{
    public class ClientService
    {
        private ShopDB _db=new ShopDB();
        public void Add(Client newclient)
        {
            _db.Add(newclient);
            _db.SaveChanges();
        }
        public void Update(Client newclient)
        {
            _db.Update(newclient);
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _db.Remove(entity);
            }
            _db.SaveChanges();
        }
        public Client GetById(int id) 
        {
            var cl=_db.Clients.FirstOrDefault(x => x.Id == id);
            return cl;
        }
        public List<Client> GetAllClients()
        {
            return _db.Clients.ToList();
        }
    }
}
