using DiceWars.DAL.Entities;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace DiceWars.DAL
{
    public partial class PlayerManager : DbManager
    {
        public async Task CreateAsync(Player p)
        {
            using var connection = Connection;
            try
            {
                if (await GetByNameAsync(p.Name) is not null)
                {
                    throw new Exception("Player with this username already exists. Try another name.");
                }
                var sql = $"INSERT INTO pl_player_16096 (pl_name_16096" +
                    $", pl_is_pvp_enabled_16096" +
                    $", pl_score_16096)" +
                    $" VALUES ('{p.Name}'" +
                    $", '{Convert.ToInt32(p.IsPvPEnabled)}'" +
                    $", '{0}')";

                using var command = new SQLiteCommand(sql, connection);
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    await connection.CloseAsync();
            }
        }

        public async Task UpdateAsync(Player p)
        {
            using var connection = Connection;
            try
            {
                var sql = $"UPDATE pl_player_16096" +
                    $" SET pl_name_16096 = '{p.Name}'" +
                    $", pl_is_pvp_enabled_16096 = '{Convert.ToInt32(p.IsPvPEnabled)}'" +
                    $" WHERE pl_id_16096 = '{p.Id}'";

                using var command = new SQLiteCommand(sql, connection);
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            using var connection = Connection;
            try
            {
                var sql = $"DELETE FROM pl_player_16096 WHERE pl_id_16096 = {id}";
                using var command = new SQLiteCommand(sql, connection);
                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                    await connection.CloseAsync();
            }
        }



        public async Task<List<Player>> GetAllAsync()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DiceWars"].ConnectionString;
            using var connection = Connection;
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
                await connection.OpenAsync();
                using var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var lastGameDate = reader.GetValue(3);
                    var p = new Player
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = reader.GetValue(1).ToString()!,
                        IsPvPEnabled = Convert.ToBoolean(reader.GetValue(2)),
                        LastGameDate = lastGameDate is DBNull ? null : new DateTime(Convert.ToInt64(lastGameDate)),
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
                    await connection.CloseAsync();
            }

            return result;
        }

        public async Task<Player> GetByIdAsync(int id)
        {
            using var connection = Connection;
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
                await connection.OpenAsync();
                using var reader = await command.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    return new Player
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1))!,
                        IsPvPEnabled = Convert.ToBoolean(reader.GetValue(2)),
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
                    await connection.CloseAsync();
            }

            return null!;
        }

        public async Task<Player> GetByNameAsync(string name)
        {
            using var connection = Connection;
            try
            {
                var sql = "SELECT pl_id_16096, " +
                    "pl_name_16096 as name, " +
                    "pl_is_pvp_enabled_16096, " +
                    "pl_last_game_date_16096, " +
                    "pl_score_16096 " +
                    "FROM pl_player_16096 " +
                    $"WHERE name = '{name}'";
                using var command = new SQLiteCommand(sql, connection);
                await connection.OpenAsync();
                using var reader = await command.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    return new Player
                    {
                        Id = Convert.ToInt32(reader.GetValue(0)),
                        Name = Convert.ToString(reader.GetValue(1))!,
                        IsPvPEnabled = Convert.ToBoolean(reader.GetValue(2)),
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
                    await connection.CloseAsync();
            }

            return null!;
        }
    }
}
