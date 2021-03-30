using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNessJogadores.Models
{
    public class Times
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome Jogador")]
        public string NomeJogador { get; set; }

        [Display(Name = "Posição")]
        public string Posicao { get; set; }

        public string Time { get; set; }

        public string Cores { get; set; }
    }
}
