using System;

Product product1 = new("Yoghurt", "YG0000X328", 2, 24);
Product product2 = new("Milk", "MK190034Z234", 3, 12);
Product product3 = new("Sausage", "SG802141T001", 2.01, 1);
Product product4 = new("Water", "HO276219B123", 1, 7);
Product product5 = new("Eggs", "FT032946K532", 0.76, 24);
Product product6 = new("Bread", "AP204512G599", 2, 10.5);
Customer tsinjo = new("Tsinjondraza Tranombiby", "13 Rue Patrice Lumumba, Tsaralalana, Antananarivo, Madagascar");
List<Product> tsinjoLists = new List<Product>
    {
        product1,
        product2,
        product3,
        product6
    };
Customer francis = new("Francis Emaneke", "10 Parktown Rd, Manhattan, New York, USA");
List<Product> francisLists = new List<Product>
{
    product1,
    product4,
    product5
};
Order tsinjoOrder = new(tsinjo, tsinjoLists);
Order francisOrder = new(francis, francisLists);
Console.WriteLine(tsinjoOrder.DisplayShippingLabel());
Console.WriteLine("Products in this pack:");
Console.WriteLine(tsinjoOrder.DisplayPackingLabel());
Console.WriteLine($"Total price (Shipping cost included): ${tsinjoOrder.GetTotalCost()}");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine(francisOrder.DisplayShippingLabel());
Console.WriteLine("Products in this pack:");
Console.WriteLine(francisOrder.DisplayPackingLabel());
Console.WriteLine($"Total price (Shipping cost included): ${francisOrder.GetTotalCost()}");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("");
Console.WriteLine("");


