namespace Catalog.API.Products.CreateProduct;
public record CreateProductCommand(string Name, string Description, decimal Price, string ImageFile, List<string> Category)
    :ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);
internal class CreateProductHandler(IDocumentSession session) : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        // creating new product
        var product = new Product
        {
            Name = command.Name,
            Description = command.Description,
            Price = command.Price,
            ImageFile = command.ImageFile,
            Category = command.Category
        };

        // saving product to database
        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        // returning product id
        return new CreateProductResult(product.Id);
       
    }
}
