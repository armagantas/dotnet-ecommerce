namespace Ordering.Infrastructure.Data.Extentions;

public class InitialData
{
    public static IEnumerable<Customer> Customers => new List<Customer>
    {
        Customer.Create(CustomerId.Of(new Guid("863C431F-C298-4D61-890D-4DBAED4BC089")), "John Doe", "john@gmail.com"),
        Customer.Create(CustomerId.Of(new Guid("DF8188D0-0272-44CA-A523-013B98F6E081")), "Maria Castellanos", "maria@gmail.com")
    };

    public static IEnumerable<Product> Products => new List<Product>
    {
        Product.Create(ProductId.Of(new Guid("F3D3A3A4-3D3A-4D3A-8D3A-3D3A3D3A3D3A")), "Keyboard", 200),
        Product.Create(ProductId.Of(new Guid("F3D3A3A4-3D3A-4D3A-8D3A-3D3A3D3A3D3B")), "Mouse", 100),
        Product.Create(ProductId.Of(new Guid("089122E1-7679-48FF-AD42-F6932195F29F")), "Phone", 500),
        Product.Create(ProductId.Of(new Guid("D641F153-CD94-4DE5-9293-DEA44D5E5D63")), "Headset", 400)
    };

    public static IEnumerable<Order> OrdersWithItems
    {
        get
        {
            var address1 = Address.Of("mehmet", "ozkaya", "mehmet@gmail.com", "Bahcelievler No:4", "Turkey", "Istanbul", "38050");
            var address2 = Address.Of("john", "doe", "john@gmail.com", "Broadway No:1", "England", "Nottingham", "08050");

            var payment1 = Payment.Of("mehmet", "5555555555554444", "12/28", "355", 1);
            var payment2 = Payment.Of("john", "8885555555554444", "06/30", "222", 2);

            var order1 = Order.Create(
                            OrderId.Of(Guid.NewGuid()),
                            CustomerId.Of(new Guid("58c49479-ec65-4de2-86e7-033c546291aa")),
                            OrderName.Of("ORD_1"),
                            shippingAddress: address1,
                            billingAddress: address1,
                            payment1);
            order1.Add(ProductId.Of(new Guid("5334c996-8457-4cf0-815c-ed2b77c4ff61")), 2, 500);
            order1.Add(ProductId.Of(new Guid("c67d6323-e8b1-4bdf-9a75-b0d0d2e7e914")), 1, 400);

            var order2 = Order.Create(
                            OrderId.Of(Guid.NewGuid()),
                            CustomerId.Of(new Guid("189dc8dc-990f-48e0-a37b-e6f2b60b9d7d")),
                            OrderName.Of("ORD_2"),
                            shippingAddress: address2,
                            billingAddress: address2,
                            payment2);
            order2.Add(ProductId.Of(new Guid("4f136e9f-ff8c-4c1f-9a33-d12f689bdab8")), 1, 650);
            order2.Add(ProductId.Of(new Guid("6ec1297b-ec0a-4aa1-be25-6726e3b51a27")), 2, 450);

            return new List<Order> { order1, order2 };
        }
    }
}
