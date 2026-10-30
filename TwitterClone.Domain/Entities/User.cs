namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity,IFollowable,INotifiable
    {
        private string _username;
        private string _email;

        public User(string username, string email) : base(Guid.NewGuid())
        {
            _username = username;
            _email = email;
        }

        public string Username
        {
            get {return _username;}
            set{
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Username cannot be empty");
                }          
                _username = value;}         
        }

        public string Email
        {
            get {return _email;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be empty");
                } 
                _email = value; }
        }

        private List<Guid> _followers = new List<Guid>();
        private List<Guid> _inComingNotifications = new List<Guid>();

        public void Follow(Guid userId)
        {
            if(!_followers.Contains(userId))
            {
                _followers.Add(userId);
            }
        }

        public void Unfollow(Guid userId)
        {
            if (_followers.Contains(userId))
            {
                _followers.Remove(userId);
            }
        }

        public void AddNotification(Guid notificationId)
        {
            if(!_inComingNotifications.Contains(notificationId))
            {
                _inComingNotifications.Add(notificationId);
            }
        }
    }
}