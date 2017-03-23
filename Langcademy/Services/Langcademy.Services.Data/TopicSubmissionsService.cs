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
    public class TopicSubmissionsService : ITopicSubmissionsService
    {
        private readonly IIdentifierProvider identifierProvider;
        private readonly IDbRepository<TopicSubmission> submissions;

        public TopicSubmissionsService(IDbRepository<TopicSubmission> submissions, IIdentifierProvider identifierProvider)
        {
            this.submissions = submissions;
            this.identifierProvider = identifierProvider;
        }

        public void Add(TopicSubmission submission)
        {
            if (submission == null)
            {
                throw new ArgumentNullException("Submission should not be null");
            }

            this.submissions.Add(submission);
            this.submissions.Save();
        }

        public TopicSubmission GetById(int id)
        {
            var submission = this.submissions.GetById(id);
            if (submission == null)
            {
                throw new ArgumentNullException("Submission with the provided id is not found");
            }

            return submission;
        }

        public IQueryable<TopicSubmission> GetAllTopicSubmissions()
        {
            return this.submissions.All();
        }
    }
}
