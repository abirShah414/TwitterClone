namespace TwitterClone.Domain.Entities
{
    public class MentionNotification : Notification{

        public Guid MentionedByUserId {get; set;}

        public MentionNotification(Guid mentionedByUserId) : base("Mention")
        {
            MentionedByUserId = mentionedByUserId;
        }

        public void AddMessage(string message)
        {
            message = message;
        }

        public override string GetMessage()
        {
            return $"Mentioned by user id {MentionedByUserId}";
        }
        
    }
}