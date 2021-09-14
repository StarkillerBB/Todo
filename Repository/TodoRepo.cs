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

        /// <summary>
        /// Adds a todo to the list.
        /// </summary>
        /// <param name="todo"></param>
        public void CreateTodo(Todos todo)
        {

            todos.Add(todo);
        }
        
        /// <summary>
        /// Find a specific todo object.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Todos GetItemById(Guid id)
        {
            return todos.Find(x => x.Id == id);
        }

        /// <summary>
        /// Delete a specific todo.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteTodo(Guid id)
        {
            todos.Remove(GetItemById(id));
        }

        /// <summary>
        /// Gets the list of todos.
        /// </summary>
        /// <returns></returns>
        public List<Todos> GetTodo()
        {
            return todos;
        }

        /// <summary>
        /// Updates the selected todo.
        /// </summary>
        /// <param name="todo"></param>
        public void UpdateTodo(Todos todo)
        {

            int todoIndex = todos.FindIndex(x => x.Id == todo.Id);
            if (todoIndex != -1)
            {
                todos[todoIndex] = todo;
            }

        }
    }
}
