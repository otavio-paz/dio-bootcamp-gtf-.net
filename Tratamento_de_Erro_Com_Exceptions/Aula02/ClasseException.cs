namespace Aula02
{
    [Serializable]
    public class ClasseException : Exception
    {
        public MyClassException(string? message) : base(message)
        {

        }

        public MyClassException(string? message, Exception? innerException) : base (message, innerException)
        {
            
        }
    }
}