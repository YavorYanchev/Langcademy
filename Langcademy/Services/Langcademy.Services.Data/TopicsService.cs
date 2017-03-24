using Langcademy.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Langcademy.Data.Models;
using Langcademy.Services.Web;
using Langcademy.Data.Common;

namespace Langcademy.Services.Data
{
    public class TopicsService : ITopicsService
    {
        private readonly IIdentifierProvider identifierProvider;
        private readonly IDbRepository<Topic> topics;

        public TopicsService(IDbRepository<Topic> topics, IIdentifierProvider identifierProvider)
        {
            this.topics = topics;
            this.identifierProvider = identifierProvider;
        }

        public void Add(Topic topic)
        {
            if (topic == null)
            {
                throw new ArgumentNullException("Topic should not be null");
            }

            this.topics.Add(topic);
            this.topics.Save();
        }

        public Topic GetById(int id)
        {
            var topic = this.topics.GetById(id);
            if (topic == null)
            {
                throw new ArgumentNullException("Topic with the provided id is not found");
            }

            return topic;
        }

        public IQueryable<Topic> GetAllTopics()
        {
            return this.topics.All();
        }

        public void HardDeleteTopicById(int id)
        {
            this.topics.HardDeleteById(id);
            this.topics.Save();
        }

        public IEnumerable<Topic> GetTopicByNameOrDescription(string searchTerm)
        {
            return string.IsNullOrEmpty(searchTerm) ? this.topics.All().ToList()
                : this.topics.All().Where(t =>
                (string.IsNullOrEmpty(t.Name) ? false : t.Name.Contains(searchTerm))
                ||
                (string.IsNullOrEmpty(t.Description) ? false : t.Description.Contains(searchTerm))).ToList();
        }
    }
}
