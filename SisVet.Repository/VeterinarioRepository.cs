using SisVet.Model;
using System.Collections.Generic;


namespace SisVet.Repository
{
    public class VeterinarioRepository
    {
        public Veterinario Retornar(int veterinarioId)
        {
            Veterinario veterinario = new Veterinario(veterinarioId);

            //buscar dados do banco de dados
            if (veterinarioId == 1)
            {
                veterinario.Nome = "Joao";
                veterinario.Sobrenome = "Savaris";
                veterinario.CRV = "123456";
                veterinario.Email = "jvsavaris@gmail.com";
                veterinario.Telefone = "49 98868-9688";
            }
            return veterinario;
        }

        public List<Veterinario> Retornar()
        {
            Veterinario veterinario = new Veterinario();
            return new List<Veterinario>();
        }

        public bool Salvar()
        {
            return true;
        }
    }

}
