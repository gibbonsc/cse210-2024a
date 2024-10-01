using System;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine($"Howdy Sandbox World!");    
        Costume nurse = new();
        nurse.headWear = "face mask";
        nurse.gloves = "nitrile gloves";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new();
        detective.headWear = "fedora";
        detective.gloves = "leather";
        detective.shoes = "loafers";
        detective.upperGarment = "trenchcoat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

        Costume snorkler = new();
        snorkler.headWear = "goggles";
        snorkler.gloves = "rubber";
        snorkler.shoes = "flippers";
        snorkler.upperGarment = "wetsuit";
        snorkler.lowerGarment = "wetsuit";
        snorkler.accessory = "snorkel";

        Costume rancher = new();
        rancher.headWear = "cowboy hat";
        rancher.gloves = "work";
        rancher.shoes = "boots";
        rancher.upperGarment = "fancy vest";
        rancher.lowerGarment = "jeans";
        rancher.accessory = "lasso";

        Costume bagpiper = new();
        bagpiper.headWear = "glengarry";
        bagpiper.gloves = "none";
        bagpiper.shoes = "ghillie brogues";
        bagpiper.upperGarment = "jacket";
        bagpiper.lowerGarment = "kilt";
        bagpiper.accessory = "sporran";

        Console.WriteLine("Nurse costume:");
        nurse.ShowWardrobe();
        Console.WriteLine("Detective costume:");
        detective.ShowWardrobe();
        Console.WriteLine("Snorkler costume:");
        snorkler.ShowWardrobe();
        Console.WriteLine("Rancher costume:");
        rancher.ShowWardrobe();
        Console.WriteLine("Bagpiper costume:");
        bagpiper.ShowWardrobe();
    }
}