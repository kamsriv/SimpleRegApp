using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRegAPI.Interfaces
{
    public interface IStudent
    {
        int Id { get;set; }
        string Name { get;set; }
        IStudent AddStudent();
        IStudent GetStudent();
        int UpdateStudent();
        void DeleteStudent();
    }
}
