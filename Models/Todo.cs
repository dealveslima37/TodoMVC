using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoMvc.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage ="preencha o campo {0}")]
        public string Title { get; set; }

        [DisplayName("Concluído")]
        public bool Done { get; set; }

        [DisplayName("Criado em")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Última atualização")]
        public DateTime LastUpdateDate { get; set; }

        [DisplayName("Usuário")]
        public string User { get; set; }


    }
}
