using AutoMapper;
using Langcademy.Data.Models;
using Langcademy.Web.Infrastructure.Mapping;
using System;

namespace Langcademy.Web.ViewModels.Topics
{
    public class TopicViewModel //:IMapFrom<Topic>,IHaveCustomMappings
    {
        public TopicViewModel()
        {
        }

        public TopicViewModel(Topic topic)
        {
            if (topic != null)
            {
                this.Id = topic.Id;
                this.Name = topic.Name;
                this.Description = topic.Description;
                this.NumberOfWordsToTranslate = topic.NumberOfWordsToTranslate;
                this.CreatedOn = topic.CreatedOn;

            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int NumberOfWordsToTranslate { get; set; }

        public DateTime CreatedOn { get; set; }

        //public void CreateMappings(IMapperConfiguration configuration)
        //{
        //    //configuration.CreateMap<TopicViewModel, Topic>();
        //}
    }
}