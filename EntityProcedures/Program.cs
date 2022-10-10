using EntityProcedures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityProcedures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string filterName = "Bahar";
            EFStoredProceduresExampleContext _db = new EFStoredProceduresExampleContext();
            var result = _db.Students.FirstOrDefault();
            IQueryable<uspResult> _Uspresult = _db.UspResults
                .FromSqlInterpolated($"exec [dbo].[uspStudentFilterName] @FirstName={filterName}");

            Console.WriteLine(result.StudentName);

            Console.ReadLine();
        }
    }
}
//Scaffold-DbContext "Server=Serv_name; Databasestu_db;Trusted_Connection=True;"
//Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f