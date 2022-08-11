using System.Collections.Generic;

namespace SisVet.Model
{
    public class Clinica
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public Endereco Endereco { get; set; }

        // Navegation Property
        public int EnderecoId { get; set; }

        public ICollection<Atendimento> Atendimentos  { get; set; } = new List<Atendimento>();

        public Clinica()
        {
        }

        public Clinica(int id, string nome, string telefone, string email, Endereco endereco, int enderecoId, ICollection<Atendimento> atendimentos)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            EnderecoId = enderecoId;
            Atendimentos = atendimentos;
        }
    }
}
