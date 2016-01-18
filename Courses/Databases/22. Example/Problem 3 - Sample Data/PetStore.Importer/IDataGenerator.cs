namespace PetStore.Importer
{
    using Data;

    public interface IDataGenerator
    {
        void GenerateData(PetStoreEntities2 data, IRandomGenerator random, int count);
    }
}
