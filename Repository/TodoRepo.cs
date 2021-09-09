using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Model;
using Todo.Pages;

namespace Todo.Repository
{
    public class TodoRepo : ITodoRepo
    {

        private List<Todos> todos = new List<Todos>();

        public void CreateTodo(Todos todo)
        {

            todos.Add(todo);
        }

        public Todos GetItemById(Guid id)
        {
            return todos.Find(x => x.Id == id);
        }

        public void DeleteTodo(Guid id)
        {
            todos.Remove(GetItemById(id));
        }

        public List<Todos> GetTodo()
        {
            
            return todos;
        }

        public void UpdateTodo(Todos todo)
        {
            
        }
    }
}
