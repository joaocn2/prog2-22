using System.Collections.Generic;

namespace SisVet.Model
{
    public class Raca
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int TipoAnimalId { get; set; }

        public TipoAnimal TipoAnimal { get; set; }

        public ICollection<Animal> Animais { get; set; } = new List<Animal>();
    }
}
