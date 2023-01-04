namespace MyEvents.API.Domain.Entity.Validator.ErrorMessage
{
    public class SocialNetworkErrorMessage
    {
        // Fields
        public static string NameMustBeInformed = "The name of social network must be informed.";
        public static string UrlMustBeInformed = "The url must be informed.";
        public static string IdEventMustBeInformed = "The id event must be informed.";
        public static string EventDtoMustBeInformed = "The event must be informed.";
        public static string IdSpeakerMustBeInformed = "The id speaker must be informed.";
        public static string SpeakerDtoMustBeInformed = "The speaker must be informed.";

        // Exceeded characters
        public static string ExceededNumberOfCharacters = "Exceeded number of characters, maximum supported {0}.";

        // Field null
        public static string FieldCannotBeNull = "Field cannot be null.";
    }
}
