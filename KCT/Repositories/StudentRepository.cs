using KCT.Interfaces;
using KCT.Models;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KCT.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public StudentRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        private IDbConnection CreateConnection() => new SqlConnection(_connectionString);


        public async Task<IEnumerable<StudentViewModel>> GetAllAsync()
        {
            var query = "SELECT * FROM Students";
            using var connection = CreateConnection();
            return await connection.QueryAsync<StudentViewModel>(query);
        }

        public async Task<StudentViewModel> GetByIdAsync(int id)
        {
            var query = "SELECT * FROM Students WHERE Id = @Id";
            using var connection = CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<StudentViewModel>(query, new { Id = id });
        }

        public async Task<int> AddAsync(StudentViewModel student)
        {
            var query = "INSERT INTO Students (FullName, Email) VALUES (@FullName, @Email)";
            using var connection = CreateConnection();
            return await connection.ExecuteAsync(query, student);
        }


        public async Task<int>UpdateAsync(StudentViewModel student)
        {
            var query = "UPDATE Students SET FullName = @FullName, Email = @Email WHERE Id = @Id";
            using var connection = CreateConnection();
            return await connection.ExecuteAsync(query, student);
        }

        public async Task<int>DeleteAsync(int id)
        {
            var query = "DELETE FROM Students WHERE Id = @Id";
            using var connection = CreateConnection();
            return await connection.ExecuteAsync(query, new { Id = id });
        }

        

        

        
    }
}
