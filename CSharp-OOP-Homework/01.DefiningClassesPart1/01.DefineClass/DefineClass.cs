using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics 
/// (model, hours idle and hours talk) and display characteristics (size and number of colors).
/// Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
/// 
/// </summary>

// Define a class
class GSM
{
    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    private string manufacturer;

    public string Manufacturer
    {
        get { return manufacturer; }
        set { manufacturer = value; }
    }

    private decimal price;

    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    private string owner;

    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }

    public GSM(string model, string manufacturer, decimal price, string owner)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
    }
}

// Define a class
class Display
{
    private double size;

    public double Size
    {
        get { return size; }
        set { size = value; }
    }

    private int nColors;

    public int NColors
    {
        get { return nColors; }
        set { nColors = value; }
    }

    public Display(double size, int nColors)
    {
        this.size = size;
        this.nColors = nColors;
    }
}

// Define a class
class Battery
{
    private string model;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    private double hoursIdle;

    public double HoursIdle
    {
        get { return hoursIdle; }
        set { hoursIdle = value; }
    }

    private double hoursTalk;

    public double HourseTalk
    {
        get { return hoursTalk; }
        set { hoursTalk = value; }
    }

    public Battery(string model, double hoursIdle, double hoursTalk)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
    }
}
class DefineClass
{
    static void Main()
    {
        GSM krisPhone = new GSM("Iphone", "Apple", 300, "Kristian");
        Display display = new Display(5.5, 16000000);
        Battery battery = new Battery("LiIon", 250, 30);
    }
}