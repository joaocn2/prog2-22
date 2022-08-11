using System;
using System.Collections.Generic;
using System.Text;
using SisVet.Model;

namespace SisVet.Repository
{
    public class ClinicaRepository
    {
         public Clinica Retornar(int ClinicaId)
         {
            Clinica clinica = new Clinica();
            if (ClinicaId == 1)
            {
                clinica.Id = 1;
                clinica.Nome = "Casa do bixo";
                clinica.Telefone = "4998768688";
                clinica.Email = "jvsavaris@gmail.com";
                clinica.Endereco = new Endereco();
                clinica.EnderecoId = 1;
                clinica.Atendimentos = new List<Atendimento>();
            }

            return clinica;
         }

        public bool Salvar(Clinica clinica)
        {
            return true;
        }
    }
}