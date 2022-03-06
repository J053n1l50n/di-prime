using System;
using System.Collections.Generic;
using Nova_pasta_(3).Interface;

namespace Nova_pasta_(3)
{
    public class SerieRespo:Irepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualizar(int ID, Serie entidade)
		{
			listaSerie[ID] = entidade;
		}

		public void Excluir(int ID)
		{
			listaSerie[ID].Excluir();
		}

		public void Inserir(Serie entidade)
		{
			listaSerie.Add(entidade);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int ID)
		{
			return listaSerie[ID];
		}
	}
    }
}