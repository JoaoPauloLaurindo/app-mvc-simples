using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasic.Models
{
    public class FornecedorModel : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres!", MinimumLength = 11)]
        public string Documento { get; set; }
        public TipoFornecedorModel TipoFornecedor { get; set; }
        public EnderecoModel Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relations 1:N */ 
        public IEnumerable<ProdutoModel> Produtos { get; set; }
    }
}
