using Repository_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Project.Repositories
{
    public class InstructorRepo : IRepo
    {
        public void Delete(int instructorId)
        {
            Instructor instructor = InstructorDB.InstructorList.FirstOrDefault(x => x.InstructorId == instructorId);
            InstructorDB.InstructorList.Remove(instructor);
        }

        public IEnumerable<Instructor> GetAll()
        {
            return InstructorDB.InstructorList;
        }

        public Instructor GetById(int instructorId)
        {
            Instructor instructor = InstructorDB.InstructorList.FirstOrDefault(x => x.InstructorId == instructorId);
            return instructor;
        }

        public void Insert(Instructor instructor)
        {
            InstructorDB.InstructorList.Add(instructor);
        }

        public void Update(Instructor instructor)
        {
            Instructor _instructor = InstructorDB.InstructorList.FirstOrDefault(x => x.InstructorId == instructor.InstructorId);
            if(instructor.Name != null)
            {
                _instructor.Name=instructor.Name;
            }
            if(instructor.Age != 0)
            {
                _instructor.Age=instructor.Age;
            }
            if(instructor.Designation != null)
            {
                _instructor.Designation=instructor.Designation;
            }
            if(instructor.Faculty != null)
            {
                _instructor.Faculty=instructor.Faculty;
            }
            if(instructor.Salary != 0)
            {
                _instructor.Salary=instructor.Salary;
            }
            if(instructor.ContactNo != null)
            {
                _instructor.ContactNo=instructor.ContactNo;
            }
            if(instructor.Address != null)
            {
                _instructor.Address=instructor.Address;
            }
        }
    }
}
