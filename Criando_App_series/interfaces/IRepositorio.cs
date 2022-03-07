namespace Criando_App_series.interfaces
{
    public interface IRepositorio<T> //quem implementa a classe q implementar o repositorio
    {                                  //implementa esse T
         List<T> Lista(); //essa interface tem um metodo de lista de T

         T RetornaPorId(int d); //retorna T como parametro

         void Insere(T entidade);

         void Exclui(int id);

         void Atualiza(int id, T entidade);

         int ProximoId();
         
    }
}