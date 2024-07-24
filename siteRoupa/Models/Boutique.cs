using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace siteRoupa.Models
{
    [Table("Boutiques")]
    public class Boutique
    {
        [Key]
        public int BoutiqueID { get; set; }

        [Required(ErrorMessage="O nome da roupa deve ser informado")]
        [Display(Name="Nome da Roupa")]
        [StringLength(80, MinimumLength=10, ErrorMessage="O {0} deve ter o mínimo {1} e no máximo {2}")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A descrição da roupa deve ser informada")]
        [Display(Name = "Descrição da Roupa")]
        [MinLength(20, ErrorMessage="Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage="Descrição pode exceder {1} caracteres")]
        public string ShortDescription { get; set; }

        [Required(ErrorMessage = "A descrição detalhada da roupa deve ser informada")]
        [Display(Name = "Descrição Detalhada da Roupa")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} caracteres")]
        public string DetailedDescription { get; set; }

        [Required(ErrorMessage="Informe o preço da roupa")]
        [Display(Name="Preço")]
        [Column(TypeName="decimal(10,2)")]
        [Range(1, 999.999, ErrorMessage="O preço deve estar entre 1 e 999,99")]
        public decimal Price { get; set; }

        [Display(Name="Caminho da Imagem")]
        [StringLength(200, ErrorMessage="O {0} deve ter no máximo {1} caracteres")]
        public string ImageURL { get; set; }

        [Display(Name = "Caminho da Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageThumbnail { get; set; }

        [Display(Name="Queridinho?")]
        public bool Darlings { get; set; } //Os queridinhos da semana

        [Display(Name="Estoque")]
        public bool InStock { get; set; } //Em estoque


        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
