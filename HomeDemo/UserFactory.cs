using System;

namespace SeleniumTestsPOM
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                Email = $"{Guid.NewGuid().ToString()}@abv.bg",
                FirstName = "Madiko",
                LastName = "Test",
                Password = "gdsjafgujdsw",
                Address = "Home",
                City = "Plovdiv",
                State = "Alabama",
                PostCode = "99501",
                MobilePhone = "0888123456",
                Alias = "Second Home Address"
            };
        }
    }
}
