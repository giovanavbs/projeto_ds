using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aplicacao_ds.Models
{
    public class Cliente
    {



        public int CodigoCli { get; set; }



        [Display(Name = "Nome do Usuário")]
        [RegularExpression(@"/^\s*$/}")]
        public string NomeCliente { get; set; }



        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Digite um endereço")]
        [RegularExpression(@"/^\s*$/}[A-Za-z][0-9]")]
        public string EnderecoCli { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Digite o email valido")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string EmailCli { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Digite os 11 digitos do cpf")]
        [RegularExpression(@"\[0-9]{0,11}")]
        public string CPFCli { get; set; }


        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Digite uma data de nascimento valida")]
        public DateTime DataNasc { get; set; }


        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Digite seu telefone de 11 digitos")]
        [RegularExpression(@"\[0-9]{0,11}")]
        public int TelefoneCli { get; set; }



    }
}