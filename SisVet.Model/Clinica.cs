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

}
}
