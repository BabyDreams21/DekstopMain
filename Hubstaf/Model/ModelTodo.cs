using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubstaf.Model
{
    public class ModelTodo
    {
        public int idProject { get; set; } 
        public string nameTodo { get; set; }
        public string description { get; set; }
        public string changed { get; set; }
    }
}
