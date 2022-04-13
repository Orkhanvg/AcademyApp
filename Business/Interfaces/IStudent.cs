using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    interface IStudent
    {
        Student Create(Student Student);
        Student Update(int Id, Student Student);

        Student Delete(int Id);

        Student GetStudent(string name);
        Student GetStudent(int id);

        List<Student> GetAll(string name = null);

    }
}
