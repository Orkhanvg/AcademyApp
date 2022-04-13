using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
   public class StudentService: IStudent
    {
       
        
            public static int Count { get; set; }
            private StudentRepository _StudentRepository;
            public StudentService()
            {
                _StudentRepository = new StudentRepository();
            }

            public Student Create(Student Student)

            {
                Student.Id = Count;

                _StudentRepository.Create(Student);
                Count++;
                return Student;

            }

            public Student Delete(int Id)
            {
                Student isExist = _StudentRepository.GetOne(g => g.Id == Id);
                if (isExist == null)
                {
                    return null;
                }
                _StudentRepository.Delete(isExist);
                return isExist;
            }

            public Student GetStudent(string name)
            {
                return _StudentRepository.GetOne(g => g.Name == name);
            }



            public List<Student> GetAll()
            {
                return _StudentRepository.GetAll();
            }

            public Student GetStudent(int id)
            {
                return _StudentRepository.GetOne(g => g.Id == id);
            }

            public List<Student> GetAll(string name = null)
            {
                throw new NotImplementedException();
            }

            public Student Update(int id, Student Student)
            {
                throw new NotImplementedException();
            }

        

        Student IStudent.Delete(int Id)
        {
            throw new NotImplementedException();
        }

        Student IStudent.GetStudent(string name)
        {
            throw new NotImplementedException();
        }

        Student IStudent.GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        List<Student> IStudent.GetAll(string name)
        {
            throw new NotImplementedException();
        }
    }
}
