using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace siteRoupa.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [StringLength(100, ErrorMessage="O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage="Informe o nome da categoria")]
        [Display(Name="Nome")]
        public string CategoriaName { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        public List<Boutique> Boutiques { get; set; }
    }
}
