namespace PetStore.Importer
{
    using System;

    public interface IRandomGenerator
    {
        int GetRandomNumber(int min, int max);

        string GetRandomString(int length);

        DateTime GetRandomDate(int minDay, int minMonth, int minYear, double dayBeforeNow);
    }
}
