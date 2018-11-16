using System;
using System.Collections.Generic;
using Fii.Data;

namespace Fii.Business
{
    public interface IRepository<T>
    {
        void Create(T products);
        IReadOnlyList<T> GetAll();
        T GetById(Guid id);
    }
}