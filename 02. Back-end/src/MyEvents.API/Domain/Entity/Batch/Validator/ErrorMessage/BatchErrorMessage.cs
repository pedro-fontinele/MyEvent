namespace MyEvents.API.Domain.Entity.Validator.ErrorMessage
{
    public static class BatchErrorMessage
    {
        // Fields 
        public static string NameMustBeInformed = "The name of batch must be informed.";
        public static string PriceMustBeInformed = "The price must be informed.";
        public static string StartDateMustBeInformed = "The start date must be informed.";
        public static string EndDateMustBeInformed = "The end date must be informed.";
        public static string TheAmountMustBeInformed = "The amount of participants must be informed.";
        public static string IdEventMustBeInformed = "The id event must be informed.";
        public static string EventMustBeInformed = "The event must be informed.";

        // Exceeded characters
        public static string ExceededNumberOfCharacters = "Exceeded number of characters, maximum supported {0}.";

        // Field null
        public static string FieldCannotBeNull = "Field cannot be null.";
    }
}
