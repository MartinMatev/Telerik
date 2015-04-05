namespace TradeAndTravel
{
    using System;
    using System.Linq;

    class ExtendedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }
            return item;
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
            return person;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "town":
                    location = new Town(locationName);
                    break;
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }

            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords, actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            Item gatherItem = null;
            var itemType = commandWords[2];
            var itemName = commandWords[3];

            if (itemType == "armor")
            {
                if (actor.ListInventory().Any(x => x.ItemType == ItemType.Iron))
                {
                    gatherItem = new Armor(itemName);
                    this.AddToPerson(actor, gatherItem);
                }
            }
            else if (itemType == "weapon")
            {
                if (actor.ListInventory().Any(x => x.ItemType == ItemType.Iron) && actor.ListInventory().Any(x => x.ItemType == ItemType.Wood))
                {
                    gatherItem = new Weapon(itemName);
                    this.AddToPerson(actor, gatherItem);
                }
            }
        }

        private void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            var itemName = commandWords[2];

            if (actor.Location is IGatheringLocation)
            {
                var gatheringLocation = actor.Location as IGatheringLocation;
                if (actor.ListInventory().Any(x => x.ItemType == gatheringLocation.RequiredItem))
                {
                    this.AddToPerson(actor, gatheringLocation.ProduceItem(itemName));
                }
            }

            // ORIGINAL way of solving this shit up

            // Item gatherItem = null;
            //if (actor.Location.LocationType == LocationType.Mine && actor.ListInventory().Any(x => x.ItemType == ItemType.Armor))
            //{
            //    gatherItem = new Iron(itemName);
            //    this.AddToPerson(actor, gatherItem);
            //}
            //else if (actor.Location.LocationType == LocationType.Forest && actor.ListInventory().Any(x => x.ItemType == ItemType.Weapon))
            //{
            //    gatherItem = new Wood(itemName);
            //    this.AddToPerson(actor, gatherItem);
            //}
        }
    }
}
