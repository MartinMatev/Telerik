namespace StudentClass
{
    public class Address
    {
        public string CountryCode { get; set; }
        public string CityCode { get; set; }
        public string Street { get; set; }

        public Address(string countryCode, string cityCode, string street)
        {
            this.CountryCode = countryCode;
            this.CityCode = cityCode;
            this.Street = street;
        }
    }
}
