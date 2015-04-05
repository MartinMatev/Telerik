namespace TradeAndTravel
{
    public class Iron : Item
    {
        private const int IRON_VALUE = 3;

        public Iron(string name, Location location = null)
            : base(name, IRON_VALUE, ItemType.Iron, location) 
        {

        }
    }
}
