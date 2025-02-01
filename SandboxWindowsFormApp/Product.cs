using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxWindowsFormApp
{
    public class Product
    {
        public int ProductId { get; set; }

        public string? Name { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
    }
}
