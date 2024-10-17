using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_multiplas_janelas
{
    public class Cliente
    {
        [DisplayName("Id")] public int Id { get; set; }
        [DisplayName("Nome do Cliente")] public string Nome { get; set; }
        [DisplayName("Número de Telefone")] public string Telefone { get; set; }
        [DisplayName("Endereço de E-mail")] public string Email { get; set; }
        [DisplayName("Endereço Fisico")] public string Endereco { get; set; }

    }
}
