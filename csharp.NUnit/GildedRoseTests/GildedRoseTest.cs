using System.Collections.Generic;
using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class GildedRoseTest
// {
//     [Test]
//     public void Foo()
//     {
//         var items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
//         var app = new GildedRose(items);
//         app.UpdateQuality();
//         Assert.That(items[0].Name, Is.EqualTo("fixme"));
//     }
// }

{
    [Test]
    public void CheckSellInReduces()
    {
        var itemSellIn = 10;
        var items = new List<Item> { new Item { Name = "genericItem", SellIn = itemSellIn, Quality = 10 } };
        var app = new GildedRose(items);
        app.UpdateQuality();
        Assert.That(items[0].SellIn, Is.EqualTo(itemSellIn-1));
    }
}