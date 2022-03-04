namespace ExemploGettersSetters.models
{
    public class Data
    {
        private int month;
        private bool validMonth;

        public int GetMonth() //MÉTODO GET
        {
            return this.month;
        }

        public void SetMonth(int month) //MÉTODO SET
        {
            if (month > 0 && month <= 12)
            {
                this.month = month;
                this.validMonth = true;
            }
        }

        public int Month //criou a propriedade, q nao esta trabalhando com a variavel month
        {
             get
             {
                 return this.month;
             } 
             
             set
             {
                 if (value > 0 && value <= 12) //esse value é a variavel
                 {
                     this.month = value;
                     this.validMonth = true;
                 }
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