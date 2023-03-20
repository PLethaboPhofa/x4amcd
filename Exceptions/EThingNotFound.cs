namespace x4amcd.Exceptions
{
    public class EThingNotFound : Exception
    {
        public EThingNotFound()
        {
        }

        public EThingNotFound(string? message) : base(message)
        {
        }

        public EThingNotFound(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}