using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerce.Domain.Models
{
    public class UsuarioModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;   
        public string Cpf { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public DateTime createdAt { get; set; }
    }
}
