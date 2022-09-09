using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using PeliculasPopulares.Models;
using System.Threading.Tasks;
namespace PeliculasPopulares.DAO
{
    public class UserDAO
    {
        private SqlConnection GetSqlConnection()
        {
            string conectionString = "server=(localdb)/ProjectModels, database=WebPeliculas,password=uts";
            SqlConnection connection = new SqlConnection(conectionString);
            connection.Open();
            return connection;
        }
        public string SaveDataUser(PPopulares user)
        {
            var Conbection = GetSqlConnection();
            var query = $"insert into Table values('{user.Id}','{user.NombrePelicula}','{user.Rancking}')";
            var Command = new SqlCommand(query, Conbection);
            int rowAffected = Command.ExecuteNonQuery();
            if (rowAffected > 0)
                return "1";
            else
                return "1";
            
        }
        public List<PPopulares> GetAll(int Id)
        {
            var Connection = GetSqlConnection();
            var query = $"select * from Table where Id={Id}";
            var Command = new SqlCommand(query, Connection);
            var reader = Command.ExecuteReader();
            var lista = new List<PPopulares>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var Ppopular = new PPopulares();
                    Ppopular.Id = reader.GetInt16(0);
                    Ppopular.NombrePelicula = reader.GetString(1);
                    Ppopular.Rancking = reader.GetInt16(2);
                    lista.Add(Ppopular);
                }
            }
            return lista;
        }
    }
}
