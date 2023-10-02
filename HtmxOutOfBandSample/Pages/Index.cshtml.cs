using HtmxOutOfBandSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HtmxOutOfBandSample.Pages;

public class IndexModel : PageModel
{
    public Count Count { get; }
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger, Count count)
    {
        Count = count;
        _logger = logger;
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        Count.Value++;
        return Partial(
            "Shared/Button", 
            new CounterModel(Count, true)
        );
    }
}