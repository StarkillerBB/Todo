using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo.Model
{

    public enum Priority { Low, Normal, High }
    public class Todos
    {

        public Guid Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public string TaskDescription { get; set; }
        public Priority Prio { get; set; }
        public bool IsCompleted { get; set; }



        public Todos()
        {
            //Id = Guid.NewGuid();
            CreatedTime = DateTime.Today;
            Prio = Priority.Normal;
            IsCompleted = false;

        }
    }
}
