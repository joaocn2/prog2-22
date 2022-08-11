using System;
using System.Collections.Generic;
using System.Text;
using SisVet.Model;

namespace SisVet.Repository
{
    public class AtendimentoRepository
    {
        public Atendimento Retornar(int AtendimentoId)
        {
            Atendimento atendimento = new Atendimento();
            if (AtendimentoId == 1)
            {
                atendimento.Id = 1;
                atendimento.ClinicaId = 1;
                atendimento.Clinica = new Clinica();
                atendimento.VeterinarioId = 1;
                atendimento.Veterinario = new Veterinario();
                atendimento.AnimalId = 1;
                atendimento.Animal = new Animal();
                atendimento.ProcedimentoId = new Procedimento();
            }
            return atendimento;
        }

        public List<Atendimento> Retornar()
        {
            Atendimento atendimento = new Atendimento();
            return new List<Atendimento>();
        }

        public bool Salvar(Clinica clinica)
        {
            return true;
        }
    }
}
