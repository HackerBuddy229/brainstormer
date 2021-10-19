using System.Collections.Generic;
using Brainstormer.Models.models;

namespace Brainstormer.Models.interfaces
{
    public interface IStateStorage
    {
        public IEnumerable<Idea> Ideas { get; init; }
        public BrainstormSettings BrainstormSettings { get; set; }
    }
}