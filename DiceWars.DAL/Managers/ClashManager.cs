using DiceWars.DAL.Entities;
using System.Data;
using System.Data.SQLite;


namespace DiceWars.DAL.Managers;

public class ClashManager : DbManager
{
    public async Task CreateAsync(Clash c)
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
                await connection.OpenAsync();
        }
    }


    public async Task<List<Clash>> GetAllAsync()
    {
        var allPlayers = (await new PlayerManager().GetAllAsync())
            .ToDictionary(t => t.Id, t => t);
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
            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
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
                await connection.CloseAsync();
        }

        return result;
    }

    public async Task<Clash> GetByIdAsync(int id)
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
            await connection.OpenAsync();
            using var reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new Clash
                {
                    Id = Convert.ToInt32(reader.GetValue(0)),
                    Player1 = await new PlayerManager().GetByIdAsync(Convert.ToInt32(reader.GetValue(1))),
                    Player2 = await new PlayerManager().GetByIdAsync(Convert.ToInt32(reader.GetValue(2))),
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
                await connection.CloseAsync();
        }

        return null!;
    }

}
