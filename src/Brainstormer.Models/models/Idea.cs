using System;

namespace Brainstormer.Models.models
{
    public class Idea
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Rank { get; set; }
    }
}