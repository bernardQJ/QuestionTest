using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionTest.Data
{
    public class ElementsModel
    {
        public string category { get; set; }
        public string type { get; set; }
        public string difficulty { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public List <string> incorrect_answers { get; set; }
        public string id { get; set; }
        
    }
}
