using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Model;
using Todo.Pages;

namespace Todo.Repository
{
    public interface ITodoRepo
    {
        void CreateTodo(Todos todos);

        List<Todos> GetTodo();

        void UpdateTodo(Todos todo);

        Todos GetItemById(Guid id);

        void DeleteTodo(Guid id);

    }
}
