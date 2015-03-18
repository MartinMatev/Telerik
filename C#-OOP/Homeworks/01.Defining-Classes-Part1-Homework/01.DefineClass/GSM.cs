namespace GSMproject
{
    using System;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class GSM
    {
        // static field
        private static GSM iphone4s = new GSM("iPhun4s", "Some fruit", 0.3371m, "Someone", new Display(2, 1337), new Battery("I have no idea whatsoever", 13m, 37m, BatteryTypes.NiCd));

        // constants
        private const decimal PRICE_PER_MINUTE = 0.37m;

        // fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Display display;
        private Battery battery;

        // Constructors

        // Constructor with the mandatory fields 
        public GSM(string newModel, string newManufacturer)
            : base()
        {
            this.Model = newModel;
            this.Manufacturer = newManufacturer;
        }

        // Constructor with every possible field
        public GSM(string newModel, string newManufacturer, decimal price, string owner, Display display, Battery battery) : this(newModel, newManufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
            this.CallHistory = new List<Call>();
        }

        public GSM(string newModel, string newManufacturer, decimal price)
            : this(newModel, newManufacturer)
        {
            this.Price = price;
        }

        //Properties
        public List<Call> CallHistory {get; set;}

        public static GSM Iphone4s
        {
            get
            {
                return iphone4s;
            }
        }


        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be a negative number... Who would have thought, right ?");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == "My mom")
                {
                    throw new ArgumentOutOfRangeException("But moooom");
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        // Problem 10: Making/Deleting calls / History clear
        public List<Call> MakingCalls(Call call)
        {
            this.CallHistory.Add(call);
            return this.CallHistory;
        }

        public List<Call> DeletingCalls(int index)
        {
            this.CallHistory.RemoveAt(index);
            return this.CallHistory;
        }

        public void DeletingHistory()
        {
            this.CallHistory.Clear();
        }
        
        // Calculate total price of the call history
        public decimal TotalPrice()
        {
            ulong totalCallDuration = 0;
            foreach (var call in CallHistory)
            {
                totalCallDuration += call.CallDuration;
            }

            decimal total = (totalCallDuration / 60) * PRICE_PER_MINUTE;
            return total;
        }

        // Print the call history
        public void PrintCallHistory()
        {
            foreach (var call in this.CallHistory)
            {
                Console.WriteLine(string.Format("Dialed phone num: {0}, Call duration: {1}", call.DialedPhoneNumber, call.CallDuration));
            }
        }

        // Overriding ToString
        public override string ToString()
        {
            return string.Format("Model = {0}; Manufacturer = {1}; Price = {2:c}", this.Model, this.Manufacturer, this.Price);
        }
    }
}
