namespace DoomsdayManager.Data
{
    public class Item
    {
        public string ItemName { get; set; }
        public string Quantity { get; set; }
        public string WeightKG { get; set; }
        public string ProductionDate { get; set; }
        public string ExpirationDate { get; set; }
        public string Size { get; set; }
        public string Kcal { get; set; }
        public string Proteins { get; set; }
        public string Fats { get; set; }
        public string Carbs { get; set; }

        public Unit Unit { get; set; }
    }
}