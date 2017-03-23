using Langcademy.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models
{
    public class WordToTranslate : BaseModel<int>
    {
       // private ICollection<Answer> answers;

        public WordToTranslate()
        {
           // this.answers = new HashSet<Answer>();
        }

        public string Text { get; set; }

        public string Translation { get; set; }

        //public string ResultDescription { get; set; }

        //public virtual ICollection<Answer> Answers
        //{
        //    get
        //    {
        //        return this.answers;
        //    }

        //    set
        //    {
        //        this.answers = value;
        //    }
        //}

        public int TopicId { get; set; }

        public virtual Topic Topic { get; set; }
        

    }
}
