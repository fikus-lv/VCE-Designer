using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fikus_Server.Classes
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Difficult { get; set; }
        public int IdTest { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public Question()
        {
            Questions = new List<Question>();
        }
    }
}
