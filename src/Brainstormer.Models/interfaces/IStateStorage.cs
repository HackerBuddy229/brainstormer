using System.Collections.Generic;
using Brainstormer.Models.models;

namespace Brainstormer.Models.interfaces
{
    public interface IStateStorage
    {
        public IEnumerable<Idea> Ideas { get; init; }
    }
}