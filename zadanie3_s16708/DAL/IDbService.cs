using System.Collections;
using System.Collections.Generic;
using zadanie3_s16708.Models;

namespace zadanie3_s16708.DAL
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}