namespace Profiler
{
    using System;
    using System.IO;

    class Profiler
    {
        static void Main()
        {
            UserProfile profile = new UserProfile();
            profile.FirstName = "Martin";
            profile.LastName = "Matev";
            profile.DateOfBirth = new DateTime(1989, 3, 13);
            profile.City = "Bourgas";
            Save(profile);
        }

        static void Save(UserProfile profile)
        {
            StreamWriter writer = new StreamWriter("data.txt");

            using (writer)
            {
                Type profileType = typeof(UserProfile);

                var profileProperties = profileType.GetProperties();

                foreach (var property in profileProperties)
                {
                    var attributes = property.GetCustomAttributes(typeof(SaveAttribute), false);

                    if (attributes.Length >= 1)
                    {
                        writer.WriteLine(property.Name + ": " + property.GetValue(profile));
                    }

                }
            }
        }

        static UserProfile Load()
        {
            StreamReader reader = new StreamReader("data.txt");
            UserProfile profile = new UserProfile();

            using (reader)
            {
                Type profileType = typeof(UserProfile);

                string currentData = reader.ReadLine();

                while (!string.IsNullOrEmpty(currentData))
                {
                    string[] values = currentData.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                    string propertyName = values[0];
                    string propertyValue = values[1];

                    var property = profileType.GetProperty(propertyName);
                    property.SetValue(profile, propertyValue);

                    currentData = reader.ReadLine();
                }
            }

            return profile;
        }
    }
}
