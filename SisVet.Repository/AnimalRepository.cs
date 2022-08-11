using SisVet.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SisVet.Repository
{
    public class AnimalRepository
    {
        public Animal Retornar(int AnimalId)
        {
            Animal animal = new Animal();
            if (AnimalId == 1)
            {
                animal.Id = 1;
                animal.Nome = "Peralta";
                animal.Peso = 2;
                animal.Comprimento = 30;
                animal.Cor = "Preto";
                animal.Raca = new Raca();
                animal.TipoAnimalId = new TipoAnimal();
                animal.EnderecoId = 1;
                animal.Endereco = new Endereco();
                animal.Atendimentos = new List<Atendimento>();
            }
            return animal;
        }

        public bool Salvar()
        {
            return true;
        }
    }
}
