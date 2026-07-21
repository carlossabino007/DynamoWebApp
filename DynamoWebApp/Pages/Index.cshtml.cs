using DynamoWebApp.Models;
using DynamoWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly DynamoService _service;

    public IndexModel(DynamoService service)
    {
        _service = service;
    }

    public List<Product> Products { get; set; } = new();

    [BindProperty(SupportsGet = true)]
    public string? YoutuberFilter { get; set; }

    public async Task OnGetAsync()
    {
        if (string.IsNullOrWhiteSpace(YoutuberFilter))
        {
            Products = await _service.GetProductsAsync();
        }
        else
        {
            Products = await _service.GetProductsByYoutuberAsync(YoutuberFilter);
        }
    }
}