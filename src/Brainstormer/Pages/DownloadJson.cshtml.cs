using System.Text;
using System.Text.Json;
using System.Text.Unicode;
using Brainstormer.Models.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Brainstormer.Pages;

public class DownloadJson : PageModel
{
    private readonly IStateStorage _stateStorage;

    public DownloadJson(IStateStorage stateStorage)
    {
        _stateStorage = stateStorage;
    }
    public IActionResult OnGet()
    {
        var json = JsonSerializer.Serialize(_stateStorage.Ideas);
        var bytes = Encoding.UTF8.GetBytes(json);
        return File(bytes, "application/force-download");
    }
}