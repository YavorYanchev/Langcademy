using Langcademy.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models
{
    public class Topic:BaseModel<int>
    {
        private ICollection<WordToTranslate> wordsToTranslate;
        private ICollection<TopicSolution> solutions;

        public Topic()
        {
            this.wordsToTranslate = new HashSet<WordToTranslate>();
            this.solutions = new HashSet<TopicSolution>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfWordsToTranslate { get; set; }

        public virtual ICollection<WordToTranslate> WordsToTranslate
        {
            get { return this.wordsToTranslate; }

            set { this.wordsToTranslate = value; }
        }

        public virtual ICollection<TopicSolution> Solutions
        {
            get { return this.solutions; }

            set { this.solutions = value; }
        }

    }
}
