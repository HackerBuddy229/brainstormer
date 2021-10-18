using System.Collections.Generic;
using Brainstormer.Models.interfaces;

namespace Brainstormer.Models.models
{
    public class StateStorage : IStateStorage
    {

        public IEnumerable<Idea> Ideas { get; init; } = new List<Idea>();
    }
}