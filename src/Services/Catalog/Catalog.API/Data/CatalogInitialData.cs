using Marten.Schema;

namespace Catalog.API.Data;

public class CatalogInitialData : IInitialData
{
    public async Task Populate(IDocumentStore store, CancellationToken cancellation)
    {
        using var session = store.LightweightSession();

        if (await session.Query<Product>().AnyAsync(token: cancellation))
        {
            return;
        }

        session.Store(GetSampleProducts());
        await session.SaveChangesAsync(cancellation);
    }

    private static IEnumerable<Product> GetSampleProducts()
    {
        return
        [
            new Product {
                Id = Guid.NewGuid(),
                Name = "Apple iPhone 1",
                Description = "Apple iPhone 1 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-1.png",
                Price = 309.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "LG ThinQ 2",
                Description = "LG ThinQ 2 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-2.png",
                Price = 319.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Sony Xperia 3",
                Description = "Sony Xperia 3 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-3.png",
                Price = 329.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "HuaweiMate 4",
                Description = "HuaweiMate 4 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-4.png",
                Price = 339.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Google Pixel 5",
                Description = "Google Pixel 5 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-5.png",
                Price = 349.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Xiaomi Redmi 6",
                Description = "Xiaomi Redmi 6 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-6.png",
                Price = 359.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy 7",
                Description = "Samsung Galaxy 7 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-7.png",
                Price = 369.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Apple iPhone 8",
                Description = "Apple iPhone 8 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-8.png",
                Price = 379.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "LG ThinQ 9",
                Description = "LG ThinQ 9 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-9.png",
                Price = 389.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Sony Xperia 10",
                Description = "Sony Xperia 10 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-10.png",
                Price = 399.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "HuaweiMate 11",
                Description = "HuaweiMate 11 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-11.png",
                Price = 409.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Google Pixel 12",
                Description = "Google Pixel 12 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-12.png",
                Price = 419.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Xiaomi Redmi 13",
                Description = "Xiaomi Redmi 13 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-13.png",
                Price = 429.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy 14",
                Description = "Samsung Galaxy 14 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-14.png",
                Price = 439.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Apple iPhone 15",
                Description = "Apple iPhone 15 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-15.png",
                Price = 449.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "LG ThinQ 16",
                Description = "LG ThinQ 16 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-16.png",
                Price = 459.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Sony Xperia 17",
                Description = "Sony Xperia 17 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-17.png",
                Price = 469.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "HuaweiMate 18",
                Description = "HuaweiMate 18 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-18.png",
                Price = 479.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Google Pixel 19",
                Description = "Google Pixel 19 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-19.png",
                Price = 489.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Xiaomi Redmi 20",
                Description = "Xiaomi Redmi 20 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-20.png",
                Price = 499.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy 21",
                Description = "Samsung Galaxy 21 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-21.png",
                Price = 509.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Apple iPhone 22",
                Description = "Apple iPhone 22 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-22.png",
                Price = 519.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "LG ThinQ 23",
                Description = "LG ThinQ 23 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-23.png",
                Price = 529.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Sony Xperia 24",
                Description = "Sony Xperia 24 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-24.png",
                Price = 539.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "HuaweiMate 25",
                Description = "HuaweiMate 25 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-25.png",
                Price = 549.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Google Pixel 26",
                Description = "Google Pixel 26 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-26.png",
                Price = 559.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Xiaomi Redmi 27",
                Description = "Xiaomi Redmi 27 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-27.png",
                Price = 569.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy 28",
                Description = "Samsung Galaxy 28 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-28.png",
                Price = 579.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Apple iPhone 29",
                Description = "Apple iPhone 29 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-29.png",
                Price = 589.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "LG ThinQ 30",
                Description = "LG ThinQ 30 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-30.png",
                Price = 599.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Sony Xperia 31",
                Description = "Sony Xperia 31 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-31.png",
                Price = 609.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "HuaweiMate 32",
                Description = "HuaweiMate 32 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-32.png",
                Price = 619.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Google Pixel 33",
                Description = "Google Pixel 33 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-33.png",
                Price = 629.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Xiaomi Redmi 34",
                Description = "Xiaomi Redmi 34 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-34.png",
                Price = 639.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy 35",
                Description = "Samsung Galaxy 35 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-35.png",
                Price = 649.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Apple iPhone 36",
                Description = "Apple iPhone 36 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-36.png",
                Price = 659.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "LG ThinQ 37",
                Description = "LG ThinQ 37 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-37.png",
                Price = 669.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Sony Xperia 38",
                Description = "Sony Xperia 38 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-38.png",
                Price = 679.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "HuaweiMate 39",
                Description = "HuaweiMate 39 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-39.png",
                Price = 689.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Google Pixel 40",
                Description = "Google Pixel 40 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-40.png",
                Price = 699.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Xiaomi Redmi 41",
                Description = "Xiaomi Redmi 41 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-41.png",
                Price = 709.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy 42",
                Description = "Samsung Galaxy 42 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-42.png",
                Price = 719.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Apple iPhone 43",
                Description = "Apple iPhone 43 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-43.png",
                Price = 729.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "LG ThinQ 44",
                Description = "LG ThinQ 44 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-44.png",
                Price = 739.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Sony Xperia 45",
                Description = "Sony Xperia 45 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-45.png",
                Price = 749.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "HuaweiMate 46",
                Description = "HuaweiMate 46 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-46.png",
                Price = 759.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Google Pixel 47",
                Description = "Google Pixel 47 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-47.png",
                Price = 769.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Xiaomi Redmi 48",
                Description = "Xiaomi Redmi 48 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-48.png",
                Price = 779.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy 49",
                Description = "Samsung Galaxy 49 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-49.png",
                Price = 789.99M,
                Category = ["Smartphones", "Electronics"]
            },
            new Product {
                Id = Guid.NewGuid(),
                Name = "Apple iPhone 50",
                Description = "Apple iPhone 50 is a premium smartphone with cutting-edge features.",
                ImageFile = "mobile-50.png",
                Price = 799.99M,
                Category = ["Smartphones", "Electronics"]
            }
        ];
    }
}
