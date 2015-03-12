namespace GSMproject
{
    using System;

    public class Call
    {
        // fields
        private DateTime dateTime;
        private string dialedPhoneNumber;
        private ulong callDuration;

        // constructors
        public Call()
        {

        }

        public Call(string dialedPhoneNumber, ulong callDuration)
        {
            this.DateTime = DateTime.Now;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.CallDuration = callDuration;
        }

        // properties
        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                int n;
                if (!int.TryParse(value, out n))
                {
                    throw new ArgumentException("Phone must be an actual phone number, no signs(+-=).");
                }
                this.dialedPhoneNumber = value;
            }
        }

        public ulong CallDuration
        {
            get
            {
                return this.callDuration;
            }
            set
            {
                if (callDuration < 0)
                {
                    throw new ArgumentException("Call duration cannot be less than 0.");
                }
                this.callDuration = value;
            }
        }
    }
}
