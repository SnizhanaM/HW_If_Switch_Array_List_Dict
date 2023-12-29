

namespace Homework4
{
    class DrivingLicence
    {
        public const int MinDrivingAge = 18;

        private readonly string _country;

        public string Name { get; set; }
        public int DocumentNumber { get; set; }

        public int Authority { get; set; }

        public string ExpirationDate { get; set; }
        public DrivingLicence(string country, string name, int docNumber, int authority, string expDate)
        {
            _country = country;
            Name = name;
            DocumentNumber = docNumber;
            Authority = authority;
            ExpirationDate = expDate;
        }
    }
}