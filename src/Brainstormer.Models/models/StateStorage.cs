using System.Collections.Generic;
using Brainstormer.Models.interfaces;

namespace Brainstormer.Models.models
{
    public class StateStorage : IStateStorage
    {

        public IList<Idea> Ideas { get; set; } = new List<Idea>();
        public BrainstormSettings BrainstormSettings { get; set; } = new BrainstormSettings();

        private readonly IList<Func<Task>> _subscribers = new List<Func<Task>>(); 
        public void Subscribe(Func<Task> action)
        {
            _subscribers.Add(action);
        }

        public async Task StateHasChanged()
        {
            foreach (var action in _subscribers) 
                await action();
        }
    }
}