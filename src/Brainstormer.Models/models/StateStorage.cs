using System.Collections.Generic;
using Brainstormer.Models.interfaces;

namespace Brainstormer.Models.models
{
    public class StateStorage : IStateStorage
    {

        public IList<Idea> Ideas { get; set; } = new List<Idea>();
        public BrainstormSettings BrainstormSettings { get; set; } = new BrainstormSettings();
    }
}