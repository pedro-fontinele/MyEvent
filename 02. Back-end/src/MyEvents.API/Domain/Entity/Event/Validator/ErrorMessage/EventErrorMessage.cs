namespace MyEvents.API.Domain.Entity.Validator.ErrorMessage
{
    public static class EventErrorMessage
    {
        // Fields
        public static string LocalMustBeInformed = "The event location must be informed.";
        public static string EventDateMustBeInformed = "The event date must be informed.";
        public static string ThemeMustBeInformed = "The event theme must be informed.";
        public static string NumberOfParticipantsMustBeInformed = "The number of participants must be informed.";
        public static string ImageUrlMustBeInformed = "The event image must be informed.";
        public static string TelephoneMustBeInformed = "The contact phone must be informed.";
        public static string EmailMustBeInformed = "The contact email must be informed.";
        public static string EmailMustBeValid = "The contact email must be valid.";
        public static string BatchMustBeInformed = "The batch must be informed.";
        public static string SocialNetworkMustBeInformed = "The social network must be informed.";
        public static string SpeakerEventkMustBeInformed = "The speaker event must be informed.";

        // Exceeded characters
        public static string ExceededNumberOfCharacters = "Exceeded number of characters, maximum supported {0}.";

        // Field null
        public static string FieldCannotBeNull = "Field cannot be null.";
    }
}
