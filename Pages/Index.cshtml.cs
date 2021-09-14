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
        private readonly ILogger<IndexModel> _logger;
        public List<Todos> todos { get; set; }

        [BindProperty]
        [MaxLength(25), Required]
        public string Description { get; set; }

        [BindProperty]
        public Todos todo { get; set; }

        public IndexModel(ITodoRepo repo, ILogger<IndexModel> logger)
        {
            _todoRepo = repo;
            todos = _todoRepo.GetTodo();

            _logger = logger;
        }

        public void OnGet()
        {
            
            
        }

        public void OnPost()
        {

        }
        
        public IActionResult OnPostEdit(Guid id, string UpdateDescription)
        {
            _logger.LogWarning(id.ToString());
            Todos updateTodo = _todoRepo.GetItemById(id);
            updateTodo.TaskDescription = UpdateDescription;
            _todoRepo.UpdateTodo(updateTodo);
            return Page();
        }

        public void OnPostDelete(Guid id)
        {

            _todoRepo.DeleteTodo(id);
            
        }
        
        public void OnPostCreate()
        {
            _todoRepo.CreateTodo(new Todos() { Id = Guid.NewGuid(), TaskDescription = Description });
            
        }

        public IActionResult OnGetJsonObj(Guid id)
        {
            Todos todo = _todoRepo.GetItemById(id);
            return new JsonResult(todo);
        }

    }
}
