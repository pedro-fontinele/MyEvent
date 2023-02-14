namespace MyEvents.API.Domain.Entity.Validator.ErrorMessage
{
    public static class SpeakerEventErrorMessage
    {
        // Fields
        public static string IdSpeakerMustBeInformed = "The id speaker must be informed.";
        public static string SpeakerMustBeInformed = "The speaker must be informed.";
        public static string IdEventMustBeInformed = "The id event must be informed.";
        public static string EventMustBeInformed = "The event must be informed.";

        // Exceeded characters
        public static string ExceededNumberOfCharacters = "Exceeded number of characters, maximum supported {0}.";

        // Field null
        public static string FieldCannotBeNull = "Field cannot be null.";
    }
}
