namespace MyEvents.API.Domain.Entity.Validator.ErrorMessage
{
    public static class SpeakerErrorMessage
    {
        // Fields
        public static string NameMustBeInformed = "The name must be informed.";
        public static string SummaryMustBeInformed = "The summary must be informed.";
        public static string ImageUrlMustBeInformed = "The image must be informed.";
        public static string TelephoneMustBeInformed = "The telephone must be informed.";
        public static string EmailMustBeInformed = "The email must be informed.";
        public static string SocialNetworkMustBeInformed = "The social network must be informed.";
        public static string SpeakerEventMustBeInformed = "The speaker of event must be informed.";

        // Exceeded characters
        public static string ExceededNumberOfCharacters = "Exceeded number of characters, maximum supported {0}.";

        // Field null
        public static string FieldCannotBeNull = "Field cannot be null.";
    }
}
