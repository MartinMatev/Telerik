﻿namespace TradeAndTravel
{
    using System;
    using System.Collections.Generic;

    public class Weapon : Item
    {
        private const int WEAPON_VALUE = 10;

        public Weapon(string name, Location location = null)
            : base(name, WEAPON_VALUE, ItemType.Weapon, location) 
        {

        }

        static List<ItemType> GetComposingItems()
        {
            return new List<ItemType>() { ItemType.Iron, ItemType.Wood };
        }
    }
}
