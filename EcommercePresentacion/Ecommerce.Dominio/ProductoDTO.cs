using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Dominio
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public short Stock { get; set; }
        public string Descripcion { get; set; }
        public string Referecnia { get; set; }
        public IEnumerable<ImagenProductoDTO> Imagenes { get; set; }
    }
}
