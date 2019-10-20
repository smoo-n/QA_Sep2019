namespace AutoReg
{
    public static class UserInfo
    {
        public static RegUser CreateValidUser()
        {
            return new RegUser
            {
                Email = "weddingpeach@abv.bg",
                FirstName = "Ria",
                LastName = "Sen",
                Password = "Pass123654",
                Year = "1983",
                Month = "3",
                Date = "10",
                RealFirstName = "Ria",
                RealLastName = "Sen",
                Gender = "female",
                Address = "Empty Str. 21",
                City = "New York",
                State = "Arizona",
                PostCode = "10000",
                Country = "21",
                Phone = "123456789",
                Alias = "weddingpeach"

            };
        }
    }
}
