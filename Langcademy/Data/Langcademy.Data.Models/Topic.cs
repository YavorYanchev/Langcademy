using Langcademy.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models
{
    public class Topic:BaseModel<int>
    {
        private IList<WordToTranslate> wordsToTranslate;
        private IList<TopicSubmission> submissions;
       // private IList<WordToTranslate> selectedTranslations;

        public Topic()
        {
            this.wordsToTranslate = new List<WordToTranslate>();
            this.submissions = new List<TopicSubmission>();
            //this.selectedTranslations = new List<WordToTranslate>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfWordsToTranslate { get; set; }

        public string CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public virtual ApplicationUser Creator { get; set; }

        public virtual IList<WordToTranslate> WordsToTranslate
        {
            get { return this.wordsToTranslate; }

            set { this.wordsToTranslate = value; }
        }

        public virtual IList<TopicSubmission> Submissions
        {
            get { return this.submissions; }

            set { this.submissions = value; }
        }


        //public virtual IList<WordToTranslate> SelectedTranslations
        //{
        //    get { return this.selectedTranslations; }

        //    set { this.selectedTranslations = value; }
        //}

    }
}
