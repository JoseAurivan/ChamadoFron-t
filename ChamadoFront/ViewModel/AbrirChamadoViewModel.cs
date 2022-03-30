using System.ComponentModel.DataAnnotations;
using Models;
using Models.Enums;

namespace ChamadoFront.ViewModel
{
    public class AbrirChamadoViewModel
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Setor { get; set; }
        [Required]
        public string Celular { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public Setor SetorDestino { get; set; }

        public Cliente ToModelCliente(string nome, string cpf, string email, string setor, string celular)
        {
            return new Cliente()
            {
                Nome = nome,
                Cpf = cpf,
                Email = email,
                Setor = setor,
                Celular = celular
            };
        }

        public Chamado ToModelChamado(string descricao, Setor setorDestino)
        {
            return new Chamado()
            {
                Descricao = descricao,
                SetorDestimno = setorDestino,
                StatusChamado = StatusChamado.Aberto
            };
        }
    }
}