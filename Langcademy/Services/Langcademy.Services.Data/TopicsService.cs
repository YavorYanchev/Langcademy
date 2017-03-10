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
                throw new ArgumentNullException();
            }

            this.topics.Add(topic);
            this.topics.Save();
        }
    }
}
