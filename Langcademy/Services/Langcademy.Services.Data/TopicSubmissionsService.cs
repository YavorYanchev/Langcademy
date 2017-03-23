using Langcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Services.Data
{
    //public class TopicSubmissionsService:ITopicSubmissionsService
    //{
    //    private readonly IIdentifierProvider identifierProvider;
    //    private readonly IDbRepository<Topic> topics;

    //    public TopicsService(IDbRepository<Topic> topics, IIdentifierProvider identifierProvider)
    //    {
    //        this.topics = topics;
    //        this.identifierProvider = identifierProvider;
    //    }

    //    public void Add(TopicSubmission topic)
    //    {
    //        if (topic == null)
    //        {
    //            throw new ArgumentNullException("Topic should not be null");
    //        }

    //        this.topics.Add(topic);
    //        this.topics.Save();
    //    }

    //    public Topic GetById(int id)
    //    {
    //        var topic = this.topics.GetById(id);
    //        if (topic == null)
    //        {
    //            throw new ArgumentNullException("Topic with the provided id is not found");
    //        }

    //        return topic;
    //    }

    //    public IQueryable<Topic> GetAllTopics()
    //    {
    //        return this.topics.All();
    //    }
    //}
}
