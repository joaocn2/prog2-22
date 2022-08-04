using System;

namespace SisVet.Model
{
    public class Atendimento
    {
        public long Id { get; set; }

        public int ClinicaId { get; set; }

        public Clinica Clinica { get; set; }

        public int VeterinarioId { get; set; }

        public Veterinario Veterinario { get; set; }

        public int AnimalId { get; set; }

        public Animal Animal { get; set; }

        public DateTime DataHora { get; set; }

        public Procedimento ProcedimentoId { get; set; }

    }
}
