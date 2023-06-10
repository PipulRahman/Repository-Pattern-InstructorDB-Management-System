using Repository_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Project.Repositories
{
    public interface IRepo
    {
        IEnumerable<Instructor> GetAll();
        Instructor GetById(int InstructorId);
        void Insert(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(int instructorId);

    }
}
