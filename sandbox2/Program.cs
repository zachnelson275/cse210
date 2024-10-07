using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Costume nurse = new Costume();
        nurse.headware = "face mask";
        nurse.gloves = "nitrile gloves";
        nurse.shoes = "orthopedic sneakers";
        nurse.upperGarment = "scrubs";
        nurse.lowerGarment = "scrubs";
        nurse.accessory = "stethoscope";

        Costume detective = new Costume();
        detective.headware = "fedora";
        detective.gloves = "leather gloves";
        detective.shoes = "loafers";
        detective.upperGarment = "trench coat";
        detective.lowerGarment = "slacks";
        detective.accessory = "magnifying glass";

        Costume rancher = new Costume();
        rancher.headware = "cowboy hat";
        rancher.gloves = "work gloves";
        rancher.shoes = "boots";
        rancher.upperGarment = "vest";
        rancher.lowerGarment = "jeans";
        rancher.accessory = "lasso";

        nurse.showWardrobe();
        detective.showWardrobe();
        rancher.showWardrobe();
    }
}