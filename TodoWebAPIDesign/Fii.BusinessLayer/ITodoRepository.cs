using System;
using System.Collections.Generic;
using Fii.DataLayer;

namespace Fii.BusinessLayer
{
    public interface ITodoRepository
    {
        void Create(Todo todo);
        IReadOnlyList<Todo> GetAll();
        Todo GetById(Guid id);
    }
}