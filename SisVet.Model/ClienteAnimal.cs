namespace SisVet.Model
{
    public class ClienteAnimal
    {
        public int Id { get; set; }

        public Cliente ClienteId { get; set; }

        public Animal AnimalId { get; set; }
    }
}
