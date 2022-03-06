using System.Collections.Generic;
namespace Nova_pasta_(3).Interface
{
    public interface Irepositorio<Res>
    {
       List<Res> Lista();
       Res RetornaPorId(int ID);        
        void Inserir(Res entidade);        
        void Excluir(int ID);        
        void Atualizar(int ID, Res entidade);
        int ProximoId(); 
    }
}