using System;
/// <summary>
/// 
/// The gravitational field of the Moon is approximately 17% of that on the Earth.
/// Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
/// 
/// </summary>
class GravitationMoon
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double weightMoon = weight - (weight * 0.83);

        Console.WriteLine(weightMoon);
    }
}