using Dapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DapperAndEFcore.Service.DapperFolder
{
    public class ClientServiceDapper
    {
        private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=root; Database=ShopDb_04_09_2003hometask";
        public Client GetById(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                return conn.Query<Client>("""Select * from public."Clients" Where "Id"=@id""", new {id}).FirstOrDefault();
            };
        }
        public void AddClient(Client client)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = """INSERT INTO public."Clients"("Id", "FirstName", "LastName", "Address") VALUES(@Id, @FirstName, @LastName, @Address)""";
                conn.Execute(sqlQuery, client);
            }
  
        }
        public void DeleteClient(int id)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                var query = """DELETE FROM public."Clients" WHERE "Id" = @id""";
                conn.Execute(query, new {id});
            }
        }
        public List<Client> GetAllClients()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                return conn.Query<Client>("""Select * from public."Clients" """).ToList();
            };
        }
        public void Update(Client client)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = """UPDATE public."Clients" SET "FirstName" = @FirstName, "LastName" = @LastName, "Address"=@Address WHERE "Id" = @Id""";
                conn.Execute(sqlQuery, client);
            }
                
        }
    }
}
