
using ArtSoftAPI.Data.Model;
using ArtSoftAPI.Service.LoggerService.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace ArtSoftAPI.Data
{
    public class AppRepository
    {
        private readonly AppContext _context;
        public AppRepository()
        {
            DbContextOptionsBuilder<AppContext> optionsBuilder = new DbContextOptionsBuilder<AppContext>();
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OSKITest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _context = new AppContext(optionsBuilder.Options);
        }

        /// <summary>
        /// Лог системних помилок 
        /// </summary>
        /// <param name="errorRecord">інфоромація про помилку</param>
        /// <returns></returns>
        public async Task SetErrorAsync(ErrorRecord errorRecord)
        {
            SqlParameter[] Parameters = new SqlParameter[]
            {
                new SqlParameter("@OperationId", errorRecord.OperationId.SqlValue()),
                new SqlParameter("@ErrorMessage", errorRecord.ErrorMessage.SqlValue()),
                new SqlParameter("@StackTrace", errorRecord.StackTrace.SqlValue()),
            };

            await _context.Database.ExecuteSqlRawAsync("dbo.SetLog @OperationId, @ErrorMessage, @StackTrace", Parameters);
        }

        /// <summary>
        /// Отримання списку Тестів
        /// </summary>
        /// <returns></returns>
        public async Task<List<Test>> GetTests()
        {
            var resp = await _context.Tests.FromSqlRaw("Exec dbo.GetTests").ToListAsync();

            return resp;
        }

        /// <summary>
        /// Отримання списку інформації про тест
        /// </summary>
        /// <returns></returns>
        public async Task<Test> GetTestById(int testId)
        {

            SqlParameter[] Parameters = new SqlParameter[]
          {
                new SqlParameter("@TestId", testId.SqlValue()),
    
          };
            var resp = await _context.Tests.FromSqlRaw("Exec dbo.GetTestById @TestId", Parameters).ToListAsync();

            return resp.FirstOrDefault();
        }


        /// <summary>
        /// Отримання списку питань та відповідей
        /// </summary>
        /// <returns></returns>
        public async Task<List<Question>> GetQuestionByTestId(int testId)
        {

            SqlParameter[] Parameters = new SqlParameter[]
          {
                new SqlParameter("@TestId", testId.SqlValue()),

          };
            var resp = await _context.Questions.FromSqlRaw("Exec dbo.GetQuestionByTestId @TestId", Parameters).ToListAsync();

            return resp;
        }

        /// <summary>
        /// Отримання списку питань та відповідей
        /// </summary>
        /// <returns></returns>
        public async Task<List<AnswerModel>> GetAnswerByQuestionId(int questionId)
        {

            SqlParameter[] Parameters = new SqlParameter[]
          {
                new SqlParameter("@QuestionId", questionId.SqlValue()),

          };
            var resp = await _context.Answers.FromSqlRaw("Exec dbo.GetAnswerByQuestionId @QuestionId", Parameters).ToListAsync();

            return resp;
        }

    }
}
