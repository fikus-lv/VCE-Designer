using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fikus_Server.Classes
{
    public class UserAnswer
    {
        public int IdUser { get; set; }
        public int date { get; set; }
        public string Login { get; set; }
        public int Id { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public UserAnswer()
        {
            Answers = new List<Answer>();
        }
    }
}
