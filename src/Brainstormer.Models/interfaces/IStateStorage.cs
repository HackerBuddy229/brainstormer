using System.Collections.Generic;
using Brainstormer.Models.models;

namespace Brainstormer.Models.interfaces
{
    public interface IStateStorage
    {
        public IList<Idea> Ideas { get; set; }
        public BrainstormSettings BrainstormSettings { get; set; }
    }
}