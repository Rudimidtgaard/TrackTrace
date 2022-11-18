using Dapper;
using System.Data;
using TrackTrace.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TrackTrace.Data
{
    public class DataProvider : IDataProvider
    {
        private readonly DapperContext _context;

        public DataProvider(DapperContext context)
        {
            _context = context;
        }

        public async Task<List<Event>> GetEvents()
        {
            var query = "Select id, classifier, level from [dbo].[Events]";

            using (var connnection = _context.CreateConnection())
            {
                var retVal = await connnection.QueryAsync<Event>(query);
                
                return retVal.ToList();
            }
        }

        public async Task<Event> GetEvent(string id)
        {
            var query = "Select id, classifier, level from [dbo].[Events] Where id = @Id";

            var parameter = new { Id = id };

            using (var connnection = _context.CreateConnection())
            {
                var retVal = await connnection.QueryFirstOrDefaultAsync<Event>(query, parameter );
                
                return retVal;
            }
        }

        public async Task<EventDto> AddEvent(Event eventForCreation)
        {

            string sql = @"Insert into [dbo].[Events] ([classifier], [level])
                            OUTPUT inserted.id
                            VALUES (@Classifier, @Level)";
            
            using (var connection = _context.CreateConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction(IsolationLevel.Serializable))
                {
                    try
                    {
                        var command = connection.CreateCommand();

                        command.CommandText = sql;
                        command.CommandType = CommandType.Text;
                        var parameters = new DynamicParameters();

                        parameters.Add("@Classifier", eventForCreation.Classifier);
                        parameters.Add("@Level", eventForCreation.Level);

                        var insertedEvent = await connection.QueryFirstOrDefaultAsync<EventDto>(sql, parameters, transaction);

                        //var insertedEvent = await connection.ExecuteAsync(sql, parameters, transaction);

                        transaction.Commit();
                        connection.Close();

                        return insertedEvent;

                }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        connection.Close();
                        throw;
                    }
                }

            }
        }
    }
}
