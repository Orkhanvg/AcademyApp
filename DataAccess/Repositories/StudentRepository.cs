using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public bool Create(Student entity)
        {
            try
            {
                DataContext.Students.Add(entity);
                return true;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Student entity)
        {
            try
            {
                DataContext.Students.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
            try
            {

                return DataContext.Students.FindAll(filter);
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student GetOne(Predicate<Student> filter = null)
        {
            try
            {
                return filter == null ? DataContext.Students[0]:
                    DataContext.Students.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Student entity)
        {
            try
            {
                Student isExist = GetOne(s => s.Id == entity.Id);
                isExist = entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
