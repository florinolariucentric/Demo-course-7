using Fii.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fii.BusinessLayer
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext context;

        public TodoRepository(TodoContext context)
        {
            this.context = context;
        }
        public void Create(Todo todo)
        {
            if (todo!=null)
            {
                this.context.Todos.Add(todo);
                this.context.SaveChanges();
            }
        }

        public Todo GetById(Guid id)
        {
            return this.context.Todos.FirstOrDefault(t => t.Id == id);
        }

        public IReadOnlyList<Todo> GetAll()
        {
            return this.context.Todos.ToList();
        }
    }
}
