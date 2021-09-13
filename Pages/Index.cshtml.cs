using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Todo.Model;
using Todo.Repository;


namespace Todo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ITodoRepo _todoRepo;
        public List<Todos> todos { get; set; }

        [BindProperty]
        [MaxLength(25), Required]
        public string Description { get; set; }

        public IndexModel(ITodoRepo repo)
        {
            
            _todoRepo = repo;
        }

        public void OnGet()
        {
            todos = _todoRepo.GetTodo();
            //CreateStartUpObjects();
        }

        public void OnPost()
        {

        }

        public void OnPostDelete()
        {

        }
        
        public IActionResult OnPostCreate()
        {
            _todoRepo.CreateTodo(new Todos() { TaskDescription = Description});
            return Page();
        }

        //public void CreateStartUpObjects()
        //{
        //    _todoRepo.CreateTodo(new Todos() { TaskDescription = "Todo 1" });
        //    _todoRepo.CreateTodo(new Todos() { TaskDescription = "Todo 2" });
        //    _todoRepo.CreateTodo(new Todos() { TaskDescription = "Todo 3" });
        //    _todoRepo.CreateTodo(new Todos() { TaskDescription = "Todo 4" });
        //}
    }
}
