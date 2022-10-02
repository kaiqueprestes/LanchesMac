using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [StringLength(100, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }
        [StringLength(200, ErrorMessage = "O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição da categoria")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }

    }
}
