using Langcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langcademy.Web.ViewModels.Topics
{
    public class TopicDetailsViewModel
    {
        public TopicDetailsViewModel()
        {
        }

        public TopicDetailsViewModel(Topic topic)
        {
            if (topic != null)
            {
                this.Id = topic.Id;
                this.Name = topic.Name;
                this.Description = topic.Description;
                this.NumberOfWordsToTranslate = topic.NumberOfWordsToTranslate;
                this.CreatedOn = topic.CreatedOn;
                this.Creator = topic.Creator.UserName;
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfWordsToTranslate { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Creator { get; set; }

    }
}