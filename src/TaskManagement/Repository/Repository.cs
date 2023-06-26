using Dapper;
using System.Data;
using System.Text.Json;
using TaskManagement.Context;
using TaskManagement.Interfaces;
using TaskManagement.Models;

namespace TaskManagement.Repository
{
    public class Repository :IRepository
    {
        private readonly DapperContext _context;
        public Repository(DapperContext context)
        {
            _context = context;
        }
        public async Task<string> CreateTask(TaskDTO json)
        {
            var procedure = "sp_CreateTask";
            var parameters = new DynamicParameters();
            parameters.Add("@json", JsonSerializer.Serialize<TaskDTO>(json), DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);

                }
                    catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }
        public async Task<string> EditTask(TaskDTO json, int taskId)
        {
            var procedure = "sp_EditTask";
            var parameters = new DynamicParameters();
            parameters.Add("@json", JsonSerializer.Serialize<TaskDTO>(json), DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@taskId", taskId, DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }
        public async Task<string> DeleteTask(int taskId)
        {
            var procedure = "sp_DeleteTask";
            var parameters = new DynamicParameters();
            parameters.Add("@taskId", taskId, DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }

        public async Task<string> CompleteTask(int taskId)
        {
            var procedure = "sp_CompleteTask";
            var parameters = new DynamicParameters();
            parameters.Add("@taskId", taskId, DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }
        public async Task<string> GetTasks()
        {
            var procedure = "sp_GetTasks";
            var parameters = new DynamicParameters();
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }
        public async Task<string> GetTask(int id)
        {
            var procedure = "sp_GetTask";
            var parameters = new DynamicParameters();
            parameters.Add("@taskId", id, DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }

        public async Task<string> GetUserTasks(int id)
        {
            var procedure = "sp_GetUserTasks";
            var parameters = new DynamicParameters();
            parameters.Add("@userId", id, DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }

        public async Task<string> GetComments(int id)
        {
            var procedure = "sp_GetComments";
            var parameters = new DynamicParameters();
            parameters.Add("@taskId", id, DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }

        public async Task<string> CreateComment(CommentDTO json)
        {
            var procedure = "sp_CreateComment";
            var parameters = new DynamicParameters();
            parameters.Add("@json", JsonSerializer.Serialize<CommentDTO>(json), DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);

                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }
            public async Task<string> CreateUser(UserDTO json)
        {
            var procedure = "sp_CreateUser";
            var parameters = new DynamicParameters();
            parameters.Add("@json", JsonSerializer.Serialize<UserDTO>(json), DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@returnJsonDocument", null, DbType.String, direction: ParameterDirection.Output, Int32.MaxValue);
            using (var conn = _context.CreateConnection())
            {
                try
                {
                    var result = await conn.ExecuteAsync(procedure, parameters, commandType: CommandType.StoredProcedure);
                    
                }
                catch (Exception ex)
                {
                    throw new Exception($"Błąd bazy danych: {ex.Message}");
                }
                var returnedJson = parameters.Get<string>("returnJsonDocument");
                return returnedJson;

            }
        }
    }
}
