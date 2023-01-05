using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleRegAPI.Interfaces;
namespace SimpleRegAPI.Implementation
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public IStudent AddStudent()
        {
            return this;
        }

        public void DeleteStudent()
        {
            throw new NotImplementedException();
        }

        public IStudent GetStudent()
        {
            return this;
        }

        public int UpdateStudent()
        {
            throw new NotImplementedException();
        }
    }
}
