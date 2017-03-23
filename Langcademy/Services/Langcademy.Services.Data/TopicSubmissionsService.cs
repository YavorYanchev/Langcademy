using Langcademy.Data.Common;
using Langcademy.Data.Models;
using Langcademy.Services.Data.Contracts;
using Langcademy.Services.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Services.Data
{
    //public class TopicSubmissionsService : ITopicSubmissionsService
    //{
    //    private readonly IIdentifierProvider identifierProvider;
    //    private readonly IDbRepository<TopicSubmission> submissions;

    //    public TopicSubmissionsService(IDbRepository<TopicSubmission> submissions, IIdentifierProvider identifierProvider)
    //    {
    //        this.submissions = submissions;
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

    //    public TopicSubmission GetById(int id)
    //    {
    //        var topic = this.topics.GetById(id);
    //        if (topic == null)
    //        {
    //            throw new ArgumentNullException("Topic with the provided id is not found");
    //        }

    //        return topic;
    //    }

    //    public IQueryable<TopicSubmission> GetAllTopicSubmissions()
    //    {
    //        return this.topics.All();
    //    }
    //}
}
