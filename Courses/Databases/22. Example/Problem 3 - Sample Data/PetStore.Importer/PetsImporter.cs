namespace PetStore.Importer
{
    using Data;

    public class PetsImporter : IDataGenerator
    {
        public void GenerateData(PetStoreEntities2 data, IRandomGenerator random, int count)
        {
            int startDay = 2;
            int startMount = 1;
            int startYears = 2010;
            int daysFromNow = -60;

            int startPrice = 5;
            int endPrice = 2500;

            for (int i = 0; i < count; i++)
            {
                var newPet = new Pet
                {
                    DateOfBirth = random.GetRandomDate(startDay, startMount, startYears, daysFromNow),
                    Price = (decimal)random.GetRandomNumber(startPrice, endPrice),
                    ColorId = random.GetRandomNumber(1, 3), // ColorType
                    SpeciesId = random.GetRandomNumber(1, 10)                    
                };

                data.Pets.Add(newPet);
            }
        }
    }
}
