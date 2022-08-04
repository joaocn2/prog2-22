using System.Collections.Generic;

namespace SisVet.Model
{
    public class Veterinario
    {
        public int Id { get; set; }

        public string Nome { get; set; }


        public string Sobrenome { get; set; }


        public string NomeSobrenome 
        {
            get 
            { string nome_sobrenome = Sobrenome;

                if(!string.IsNullOrWhiteSpace(Nome))
                {
                    if (!string.IsNullOrWhiteSpace(Sobrenome))
                    {
                        nome_sobrenome += ", ";
                    }
                    nome_sobrenome += Nome;
                }
                return nome_sobrenome;       
            }
                
        }

        public string CRV { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public Endereco Endereco { get; set; }

        public int EnderecoId { get; set; }

        public ICollection<Atendimento> Atendimentos  { get; set; } = new List<Atendimento>();

        public Veterinario()
        {
        }
        // modelo, visao, camada de negocios
        //alta coesao 
        public Veterinario(int id)
        {
            Id = id;
        }


        public bool Validar()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Sobrenome))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(Nome))
            {
                isValid = false;
            }
            return isValid;
        }


    }
}
