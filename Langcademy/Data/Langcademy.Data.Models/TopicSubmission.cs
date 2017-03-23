using Langcademy.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models
{
    public class TopicSubmission: BaseModel<int>
    {
       // private ICollection<Answer> selectedAnswers;
        private IList<WordToTranslate> selectedTranslation;

        public TopicSubmission()
        {
           // this.selectedAnswers = new HashSet<Answer>();
            this.selectedTranslation = new List<WordToTranslate>();
        }

        public int Id { get; set; }

        public int ForTopicId { get; set; }

        [ForeignKey("ForTopicId")]
        public virtual Topic ForTopic { get; set; }

        public string ByUserId { get; set; }

        [ForeignKey("ByUserId")]
        public virtual ApplicationUser ByUser { get; set; }

        public string TimeElapsed { get; set; }

        public int TimeElapsedInSeconds { get; set; }

        public double PercentageCorrectTranslations { get; set; }

        public virtual IList<WordToTranslate> SelectedTranslations
        {
            get { return this.selectedTranslation; }

            set { this.selectedTranslation = value; }
        }



        //public virtual ICollection<Answer> SelectedAnswers
        //{
        //    get { return this.selectedAnswers; }
        //    set { this.selectedAnswers = value; }
        //}
    }
}
