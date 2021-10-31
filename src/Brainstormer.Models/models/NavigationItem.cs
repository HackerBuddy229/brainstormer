namespace Brainstormer.Models.models
{
    public record NavigationItem(string Label, string Path, Func<bool> ActiveCondition);
}