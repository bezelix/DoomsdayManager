namespace DoomsdayManager.Data
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }
        public string BithDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo
        {
            get 
            {
                return $"{ FirstName }{ LastName } { Email }";
            }
        }

    }
}