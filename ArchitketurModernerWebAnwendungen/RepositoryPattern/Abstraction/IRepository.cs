﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Abstraction
{
    public interface IRepository<T> : IReadonlyRepository<T> where T : class
    {
        Task Create(T item);
        Task Update(T item);
        Task Delete(int id);
    }
}
