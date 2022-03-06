using CsvHelper.Configuration.Attributes;

namespace csvHelper_header.Model
{
    public class Livro
    {
        [Index(0)]
        public string Titulo {get; set; }
        [Index(2)]
        public string Autor {get; set; }
        [Index(1)]
        [CultureInfo("pt-BR")]
        public decimal Preco {get; set; }
        [Index(3)]
        [Format("dd/MM/yyyy")]
        public DateOnly Lancamento {get; set; }
    }
}