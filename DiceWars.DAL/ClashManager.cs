using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace DiceWars.DAL
{
    public class ClashManager : DbManager
    {
        public void Create(Clash c)
        {
            using var connection = Connection;
            try
            {

                var sql = $"INSERT INTO cl_clash_16096 (cl_player1_16096" +
                    $", cl_player2_16096" +
                    $", cl_date_16096" +
                    $", cl_outcome_16096) " +
                    $"VALUES ('{c.Player1}'" +
                    $", {c.Player2}" +
                    $", {DateTime.Today}" +
                    $", {c.Outcome})";

                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }
        }


        public List<Clash> GetAll()
        {
            var allPlayers = new PlayerManager().GetAll().ToDictionary(t => t.Id, t => t);
            using var connection = Connection;
            var result = new List<Clash>();
            try
            {
                var sql = "SELECT cl_id_16096" +
                    ",cl_player1_16096" +
                    ",cl_player2_16096" +
                    ",cl_date_16096" +
                    ",cl_outcome_16096 " +
                    "FROM cl_clash_16096";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Clash
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Player1 = allPlayers[Convert.ToInt32(reader.GetValue(1))],
                        Player2 = allPlayers[Convert.ToInt32(reader.GetValue(2))],
                        Date = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        Outcome = Convert.ToInt32(reader.GetValue(4))

                    };
                    result.Add(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }

            return result;
        }

        public Clash GetById(int id)
        {
            using var connection = Connection;
            try
            {
                var sql = "SELECT cl_id_16096" +
                    ",cl_player1_16096," +
                    "cl_player2_16096" +
                    ",cl_date_16096" +
                    ",cl_outcome_16096 " +
                    "FROM cl_clash_16096" +
                    $"WHERE Id = {id}";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Clash
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Player1 = new PlayerManager().GetById(Convert.ToInt32(reader.GetValue(1))),
                        Player2 = new PlayerManager().GetById(Convert.ToInt32(reader.GetValue(2))),
                        Date = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        Outcome = Convert.ToInt32(reader.GetValue(4))
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    connection.Close();
            }

            return null;
        }

    }
}
