using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Langcademy.Web.ViewModels.Topics
{
    public class TopicsListViewModel
    {
        public IQueryable<TopicViewModel> Topics { get; set; }
    }
}