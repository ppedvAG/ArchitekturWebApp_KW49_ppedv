using System;
using System.Collections.Generic;

namespace SegerationOfConcernPrincipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUpdateCommand updateRepo = new MyEmployeeRepository();

            IReadCommand readRepo = new MyEmployeeRepository();
            
        }
    }

    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }

    }

    #region gägngie Variante
    public interface IRepository
    {
        void Create(Employee employee);
        
        List<Employee> GetAll();
        Employee GetById(int id);   

        void Update(Employee employee); 
        void Delete(int id);
    }

    public class EmployeeRepositoy : IRepository
    {
        public void Create(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Variante nach Sgeration of Concern Principe

    public interface IInsertCommand
    {
        void Insert(Employee employee);
    }


    public interface IUpdateCommand
    {
        void Update(Employee employee); 
    }

    public interface IDeleteCommant
    {
        void Delete(int id);    
    }

    public interface IReadCommand
    {
        IList<Employee> GetAll();
        Employee GetById(int id);
    }

    public interface IEmployeeRepository : IReadCommand, IInsertCommand, IUpdateCommand, IDeleteCommant
    {
        int Count();
    }


    public class MyEmployeeRepository : IEmployeeRepository
    {
        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }

    #endregion
}
