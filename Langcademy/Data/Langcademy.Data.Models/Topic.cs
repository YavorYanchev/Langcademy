﻿using Langcademy.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Data.Models
{
    public class Topic:BaseModel<int>
    {
        private IList<WordToTranslate> wordsToTranslate;
        private IList<TopicSolution> solutions;

        public Topic()
        {
            this.wordsToTranslate = new List<WordToTranslate>();
            this.solutions = new List<TopicSolution>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfWordsToTranslate { get; set; }

        public virtual IList<WordToTranslate> WordsToTranslate
        {
            get { return this.wordsToTranslate; }

            set { this.wordsToTranslate = value; }
        }

        public virtual IList<TopicSolution> Solutions
        {
            get { return this.solutions; }

            set { this.solutions = value; }
        }

    }
}
