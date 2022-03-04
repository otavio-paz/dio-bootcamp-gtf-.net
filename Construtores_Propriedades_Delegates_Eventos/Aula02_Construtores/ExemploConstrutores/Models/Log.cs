namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log _log;

        public string LogProperty { get; set; }
        private Log()
        {

        }

        public static Log GetInstance()
        {
            if (_log == null)
                _log = new Log();

            return _log; //sera chamado uma vez apenas
        }
    }
}