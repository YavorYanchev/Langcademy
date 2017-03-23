using Langcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Services.Data.Contracts
{
    public interface ITopicSubmissionsService
    {
        void Add(TopicSubmission topicSubmission);

        TopicSubmission GetById(int id);

        IQueryable<TopicSubmission> GetAllTopicSubmissions();


    }
}
