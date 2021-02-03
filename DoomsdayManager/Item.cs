namespace DoomsdayManager.Data
{
    public class Item
    {
        public string ItemName { get; set; }
        public Category Category { get; set; }
        public Unit Unit { get; set; }
        public float Quantity { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
        public string Size { get; set; }
        public string ProductionDate { get; set; }
        public string ExpirationDate { get; set; }

    }
}