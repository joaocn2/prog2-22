using System.Collections.Generic;

namespace SisVet.Model
{
    public class TipoAnimal
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public ICollection<Raca> Racas { get; set; } = new List<Raca>();
    }
}
