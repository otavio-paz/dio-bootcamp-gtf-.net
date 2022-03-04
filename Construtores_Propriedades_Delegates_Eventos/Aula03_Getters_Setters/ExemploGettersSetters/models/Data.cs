namespace ExemploGettersSetters.models
{
    public class Data
    {
        private int month;
        private bool validMonth;

        public int GetMonth()
        {
            return this.month;
        }

        public void SetMonth(int month)
        {
            if (month > 0 && month <= 12)
            {
                this.month = month;
                this.validMonth = true;
            }
        }

        public void TellMonth()
        {
            if (this.validMonth)
                System.Console.WriteLine(this.month);
            else
                System.Console.WriteLine("Mês inválido");
        }
    }
}