namespace SomaShare.Components.Model
{
    public class UserSession
    {

     
        // Store the current user logged in
        public User? CurrentUser { get; set; }

        public int? CurrentUserId { get; set; }

        // Store the current user's role
        public string? CurrentUserRole { get; set; }

        public int? CurrentUserRoleId { get; set; }

        public bool IsSeller => CurrentUserRole == "Seller";
        public bool IsBuyer => CurrentUserRole == "Buyer";
        public bool IsAdmin => CurrentUserRole == "Admin";
    }
}
