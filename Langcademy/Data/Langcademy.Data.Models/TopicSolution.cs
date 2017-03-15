using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models
{
    public class TopicSolution
    {
        private ICollection<Answer> selectedAnswers;
        private IList<WordToTranslate> selectedTranslation;

        public TopicSolution()
        {
            this.selectedAnswers = new HashSet<Answer>();
            this.selectedTranslation = new List<WordToTranslate>();
        }

        public int Id { get; set; }

        public int ForTopicId { get; set; }

        public virtual Topic ForTopic { get; set; }

        public virtual ICollection<Answer> SelectedAnswers
        {
            get { return this.selectedAnswers; }
            set { this.selectedAnswers = value; }
        }

        public virtual IList<WordToTranslate> SelectedTranslation
        {
            get { return this.selectedTranslation; }

            set { this.selectedTranslation = value; }
        }
    }
}
