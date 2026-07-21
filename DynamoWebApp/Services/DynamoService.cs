using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using DynamoWebApp.Models;

namespace DynamoWebApp.Services;

public class DynamoService
{
    private readonly DynamoDBContext _context;

    public DynamoService(IAmazonDynamoDB client)
    {
        _context = new DynamoDBContext(client);
    }

    // Obtener todos los productos
    public async Task<List<Product>> GetProductsAsync()
    {
        return await _context.ScanAsync<Product>(new List<ScanCondition>())
                             .GetRemainingAsync();
    }

    // Buscar por nombre del youtuber
    public async Task<List<Product>> GetProductsByYoutuberAsync(string youtuber)
    {
        var products = await GetProductsAsync();

        if (string.IsNullOrWhiteSpace(youtuber))
            return products;

        return products
            .Where(p => p.Youtuber != null &&
                        p.Youtuber.Contains(youtuber, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}