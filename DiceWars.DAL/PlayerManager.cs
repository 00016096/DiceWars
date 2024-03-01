using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using DiceWars;
using System.Windows.Forms;

namespace DiceWars.DAL
{
    public class PlayerManager
    {
        public void Create(Player p)
        {
            using var connection = new SQLiteConnection();
            try
            {
                
                var sql = $"INSERT INTO pl_player_16096 (pl_name_16096" +
                    $", pl_is_pvp_enabled_16096" +
                    $", pl_last_game_date_16096" +
                    $", pl_score_16096) " +
                    $"VALUES ('{p.Name}'" +
                    $", {p.IsPvPEnabled}" +
                    $", {p.LastGameDate}" +
                    $", {p.Score})";

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

        public void Update(Player p)
        {
            using var connection = new SQLiteConnection();
            try
            {
                var sql = $"UPDATE pl_player_16096" +
                    $" SET pl_name_16096 = {p.Name}" +
                    $", pl_is_pvp_enabled_16096 = {p.IsPvPEnabled}" +
                    $", pl_last_game_date_16096 = {p.LastGameDate}" +
                    $", pl_score_16096 = {p.Score})" +
                    $"WHERE Id = {p.Id}";

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

        public void Delete(int id)
        {
            using var connection = new SQLiteConnection();
            try
            {
                var sql = $"DELETE FROM pl_player_16096 WHERE Id = {id}";
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



        public List<Player> GetAll()
        {
            
            var allPlayers = new PlayerManager().GetAll().ToDictionary(t => t.Id, t => t);
            using var connection = new SQLiteConnection();
            var result = new List<Player>();
            try
            {
                var sql = "SELECT pl_id_16096" +
                    ",pl_name_16096," +
                    "pl_is_pvp_enabled_16096" +
                    ",pl_last_game_date_16096" +
                    ",pl_score_16096 " +
                    "FROM pl_player_16096";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var p = new Player
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        IsPvPEnabled = Convert.ToInt32(reader.GetValue(2)),
                        LastGameDate = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        Score = Convert.ToInt32(reader.GetValue(4))

                    };
                    result.Add(p);
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

        public Player GetById(int id)
        {
            using var connection = new SQLiteConnection();
            try
            {
                var sql = "SELECT pl_id_16096" +
                    ",pl_name_16096," +
                    "pl_is_pvp_enabled_16096" +
                    ",pl_last_game_date_16096" +
                    ",pl_score_16096 " +
                    "FROM pl_player_16096" +
                    $"WHERE Id = {id}";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Player
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1)),
                        IsPvPEnabled = Convert.ToInt32(reader.GetValue(2)),
                        LastGameDate = new DateTime(Convert.ToInt64(reader.GetValue(3))),
                        Score = Convert.ToInt32(reader.GetValue(4))
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
