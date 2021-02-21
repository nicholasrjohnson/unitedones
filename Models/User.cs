namespace unitedones
{
    public class User
    {
        public string UserName { get; set; }
        public string SessionId { get; set; }      
        private string Role { get; set; }

        public User() {

        }

        public bool UserInRole( string role ) {
            if ( this.Role.Equals( role ) ) {
                return true;
            } else {
                return false;
            }
        }
    }
}