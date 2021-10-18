using System.Collections.Generic;
using Brainstormer.Models.models;

namespace Brainstormer.services
{
    public interface IStorageService
    {
        public void StoreIdeas(IEnumerable<Idea> ideas);
        public IEnumerable<Idea> FetchIdeas();
    }
}