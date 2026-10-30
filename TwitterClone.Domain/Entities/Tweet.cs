namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity,ILikeable
    {
        public const int MaxLength = 280;
        private Guid _authorId;
        private string _content;

        public Tweet(string content) : base(Guid.NewGuid())
        {
            _content = content;
        }


        public Guid AuthorId
        {
            get { return _authorId; }
        }

        public string Content
        {
            get { return _content; }
            set { if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Content cannot be empty");
                }
                if(value.Length > MaxLength)
                {
                    throw new ArgumentException("Content cannot exceed 280 characters");
                }
                _content = value;
            }
        }

        public bool CanBeLiked()
        {
            return true;
        }
    }
}