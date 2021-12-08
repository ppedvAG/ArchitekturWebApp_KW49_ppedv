using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Abstraction
{
    //T steht für ein Datentyp (POCO Object). Ein POCO Object steht für ein Datansatz in einer Tabelle
    public interface IReadonlyRepository<T> where T : class
    {
        Task<IList<T>> GetAll();
        Task<T> GetById(int id);
    }
}
