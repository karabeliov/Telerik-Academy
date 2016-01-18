namespace PetStore.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using Data;

    using PetStore.Importer;

    public class Startup
    {
        public static void Main()
        {
            var dataGeneratorExecutors = new List<DataGeneratorExecutor>
            {
                new DataGeneratorExecutor(new ContriesImporter(), 20),
                new DataGeneratorExecutor(new PetsImporter(), 50), // 5000
               new DataGeneratorExecutor(new CategoriesImporter(), 50),
               new DataGeneratorExecutor(new ProductsImporter(), 50) // 20 000
            };

            foreach (var dataGeneratorExecutor in dataGeneratorExecutors)
            {
                using (var data = new PetStoreEntities2())
                {
                    data.Configuration.AutoDetectChangesEnabled = false;
                    //// data.Configuration.ProxyCreationEnabled = false;

                    Console.WriteLine("Staring {0}...", dataGeneratorExecutor.DataGenerator.GetType().Name);
                    dataGeneratorExecutor.Execute(data, RandomGenerator.Instance);
                    Console.WriteLine("Saving {0}...", dataGeneratorExecutor.DataGenerator.GetType().Name);
                    data.SaveChanges();
                    Console.WriteLine("Finished {0}.", dataGeneratorExecutor.DataGenerator.GetType().Name);
                }
            }
        }
    }
}
