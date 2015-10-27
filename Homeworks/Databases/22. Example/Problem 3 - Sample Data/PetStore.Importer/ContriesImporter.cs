namespace PetStore.Importer
{
    using Data;

    public class ContriesImporter : IDataGenerator
    {
        public void GenerateData(PetStoreEntities2 data, IRandomGenerator random, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var contries = new Species
                {
                    Name = random.GetRandomString(random.GetRandomNumber(5, 50)),
                    OriginCountry = random.GetRandomString(random.GetRandomNumber(5, 50))                 
                };

                data.Species.Add(contries);
            }
        }
    }
}
