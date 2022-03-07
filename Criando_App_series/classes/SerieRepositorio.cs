using Criando_App_series.interfaces;

namespace Criando_App_series.classes
{
    
    
    //public class FilmeRepositorio : IRepositorio<Filme>
    public class SerieRepositorio : IRepositorio<Serie> //Interface<Classe>
    {                                                   //vai substituir o T da interface pela classe série
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }
    

        public void Exclui(int id)
        {
            //listaSerie.RemoveAt(id); pode dar problema ao deletar
            listaSerie[id].Excluir();

        }
    

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
    

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    
    }
}