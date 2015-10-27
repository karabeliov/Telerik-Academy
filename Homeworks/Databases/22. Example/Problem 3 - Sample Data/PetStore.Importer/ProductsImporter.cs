namespace PetStore.Importer
{
    using Data;

    public class ProductsImporter : IDataGenerator
    {
        public void GenerateData(PetStoreEntities2 data, IRandomGenerator random, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var products = new PetProduct
                {
                    Name = random.GetRandomString(random.GetRandomNumber(5, 20)),
                    Price = (decimal)random.GetRandomNumber(10, 1000),
                    CategoryId = random.GetRandomNumber(1, 100)
                };

                data.PetProducts.Add(products);
            }
        }
    }
}
