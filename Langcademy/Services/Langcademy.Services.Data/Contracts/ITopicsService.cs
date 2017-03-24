using Langcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Langcademy.Services.Data.Contracts
{
    public interface ITopicsService
    {
        void Add(Topic topic);

        Topic GetById(int id);

        IQueryable<Topic> GetAllTopics();

        //void DeleteTopic(Topic topicToDelete);

        void HardDeleteTopicById(int id);

        IEnumerable<Topic> GetTopicByNameOrDescription(string searchTerm);
    }
}
