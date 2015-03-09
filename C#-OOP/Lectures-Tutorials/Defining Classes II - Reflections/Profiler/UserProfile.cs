namespace Profiler
{
    using System;
    using System.Collections.Generic;

    class UserProfile
    {
        [Save]
        public string FirstName { get; set; }

        [Save]
        public string LastName { get; set; }

        public int Age { get; set; }

        [Save]
        public DateTime DateOfBirth { get; set; }

        [Save]
        public string City { get; set; }
    }
}
