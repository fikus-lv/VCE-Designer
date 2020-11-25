using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fikus_Server.Classes
{
    public class Answer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsRight { get; set; }
        public int idQuestion { get; set; }
    }
}
