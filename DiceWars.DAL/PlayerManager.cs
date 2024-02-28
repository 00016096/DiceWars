using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


namespace DiceWars.DAL
{
    public class PlayerManager
    {
        public void Create(Player p)
        {
            using var connection = new SQLiteConnection();
            try
            {
                var sql = $"INSERT INTO pl_player_16096 (pl_name_16096, pl_is_pvp_enabled_16096, pl_last_game_date_16096, pl_score_16096) VALUES ('{p.Name}', {p.IsPvPEnabled}, {p.LastGameDate}, {p.Score})";
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
                var sql = $"UPDATE Player SET pl_name_16096 = {p.Name}, pl_is_pvp_enabled_16096 = {p.IsPvPEnabled}, pl_last_game_date_16096 = {p.LastGameDate}, pl_score_16096 = {p.Score})";
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
                var sql = $"UPDATE Player SET pl_name_16096 = {p.Name}, pl_is_pvp_enabled_16096 = {p.IsPvPEnabled}, pl_last_game_date_16096 = {p.LastGameDate}, pl_score_16096 = {p.Score})";
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
            using var connection = new SQLiteConnection();
            var result = new List<Player>();
            try
            {
                var sql = "SELECT Id, Name FROM Player";
                using var command = new SQLiteCommand(sql, connection);
                connection.Open();
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var c = new Player
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1))
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

    }
}
