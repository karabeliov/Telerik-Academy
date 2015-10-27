namespace PetStore.Importer
{
    using Data;

    public class CategoriesImporter : IDataGenerator
    {
        public void GenerateData(PetStoreEntities2 data, IRandomGenerator random, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var categories = new ProductCategory
                {
                    Name = random.GetRandomString(random.GetRandomNumber(5, 20))
                };

                data.ProductCategories.Add(categories);
            }
        }
    }
}
