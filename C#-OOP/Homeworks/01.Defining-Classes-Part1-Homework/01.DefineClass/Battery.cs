namespace GSMproject
{
    using System;

    public class Battery
    {
        // constants
        private const string DEFAULT_MODEL = "I dont know any battery models";
        private const decimal DEFAULT_HOURS_IDLE = 13.37m;
        private const decimal DEFAULT_HOURS_TALK = 73.31m;
        private const BatteryTypes DEFAULT_BATT_TYPE = BatteryTypes.LiIon;

        // fields
        private string model;
        private decimal hoursIdle;
        private decimal hoursTalk;
        private BatteryTypes batType;

        // constructors
        public Battery(string model, decimal hoursIdle, decimal hoursTalk, BatteryTypes batType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatType = batType;
        }

        public Battery(string model)
            : this(model, DEFAULT_HOURS_IDLE, DEFAULT_HOURS_TALK, DEFAULT_BATT_TYPE)
        {

        }

        public Battery()
            : this(DEFAULT_MODEL, DEFAULT_HOURS_IDLE, DEFAULT_HOURS_TALK, DEFAULT_BATT_TYPE)
        {

        }

        // properties
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
                    throw new NullReferenceException("Can't be null or empty");
                }

                this.model = value;
            }
        }

        public decimal HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours Idle cannot be a negative number...Unless you are a magician. Than everything is possible!");
                }
                this.hoursIdle = value;
            }
        }

        public decimal HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("You tried to enter a negative number for the duration of your calls.No, seriously, that's impossible...");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryTypes BatType
        {
            get
            {
                return this.batType;
            }
            private set
            {
                this.batType = value;
            }
        }
    }
}
