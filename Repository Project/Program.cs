using Repository_Project.Models;
using Repository_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayOption();
            Console.ReadKey();
        }
        public static void DisplayOption()
        {
            Console.WriteLine("1. Show All Instructor");
            Console.WriteLine("2. Insert Instructor");
            Console.WriteLine("3. Update Instructor");
            Console.WriteLine("4. Delete Instructor");

            var index = int.Parse(Console.ReadLine());
            Show(index);

        }
        public static void Show(int index)
        {
            InstructorRepo instructorRepo=new InstructorRepo();
            if(index == 1)
            {
                var instructorList = instructorRepo.GetAll();
                if(instructorList.Count()==0)
                {
                    Console.WriteLine("###############");
                    Console.WriteLine("No Data Found");
                    Console.WriteLine("###############");
                    DisplayOption();
                }
                else
                {
                    foreach (var item in instructorRepo.GetAll())
                    {
                        Console.WriteLine($"Instructor Id: {item.InstructorId}, \nName: {item.Name}, \nAge: {item.Age}, \nDesignation: {item.Designation}, \nFaculty: {item.Faculty}, \nSalary: {item.Salary}, \nContact No: {item.ContactNo}, \nAddress: {item.Address}");

                    }
                    Console.WriteLine("###############");
                    DisplayOption();
                }
            }
            else if(index == 2)
            {
                Console.WriteLine("###############");
                Console.Write("Name :");
                string name=Console.ReadLine();

                Console.Write("Age :");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Designation :");
                string designation = Console.ReadLine();

                Console.Write("Faculty :");
                string faculty = Console.ReadLine();

                Console.Write("Salary :");
                int salary = int.Parse(Console.ReadLine());

                Console.Write("Contact No :");
                string contactNo = Console.ReadLine();

                Console.Write("Address :");
                string address = Console.ReadLine();

                int maxId = instructorRepo.GetAll().Any() ? instructorRepo.GetAll().Max(x => x.InstructorId) : 0;

                Instructor instructor = new Instructor
                {
                    InstructorId = maxId + 1,
                    Name= name,
                    Age= age,
                    Designation= designation,
                    Faculty= faculty,
                    Salary= salary,
                    ContactNo= contactNo,
                    Address= address
                };
                instructorRepo.Insert(instructor);
                Console.WriteLine("Data Inserted Successfully!!!");
                Console.WriteLine("###############");
                DisplayOption();
            }
            else if(index == 3)
            {
                Console.WriteLine("###############");
                Console.Write("Enter Instructor Id to Update");
                int id = int.Parse(Console.ReadLine());
                var _instructor=instructorRepo.GetById(id);

                if(_instructor == null )
                {
                    Console.WriteLine("###############");
                    Console.WriteLine("Instructor Id is Invalid");
                    Console.WriteLine("###############");
                    DisplayOption();
                }
                else
                {
                    Console.WriteLine($"Update Info for Instructor Id : {id}");
                    Console.WriteLine("###############");
                    Console.Write("Name :");
                    string name = Console.ReadLine();

                    Console.Write("Age :");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Designation :");
                    string designation = Console.ReadLine();

                    Console.Write("Faculty :");
                    string faculty = Console.ReadLine();

                    Console.Write("Salary :");
                    int salary = int.Parse(Console.ReadLine());

                    Console.Write("Contact No :");
                    string contactNo = Console.ReadLine();

                    Console.Write("Address :");
                    string address = Console.ReadLine();
                    Instructor instructor = new Instructor
                    {
                        InstructorId = id,
                        Name = name,
                        Age = age,
                        Designation = designation,
                        Faculty = faculty,
                        Salary = salary,
                        ContactNo = contactNo,
                        Address = address
                    };
                    instructorRepo.Update(instructor);
                    Console.WriteLine("Data Updated Successfully!!!");
                    Console.WriteLine("###############");
                    DisplayOption();
                }
            }
            else if(index == 4)
            {
                Console.WriteLine("###############");
                Console.Write("Enter Instructor Id to Delete: ");
                int id = int.Parse(Console.ReadLine());
                var _instructor = instructorRepo.GetById(id);

                if (_instructor == null)
                {
                    Console.WriteLine("###############");
                    Console.WriteLine("Instructor Id is Invalid");
                    Console.WriteLine("###############");
                    DisplayOption();
                }
                else
                {
                    instructorRepo.Delete(id);
                    Console.WriteLine("Data Deleted Successfully!!!");
                    Console.WriteLine("###############");
                    DisplayOption();
                }
            }
        }
    }
}
