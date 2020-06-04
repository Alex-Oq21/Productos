using Ecommerce.Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Datos.Repositorio
{
    public class ProductoRepositorio
    {
        private TiendaLibreConection BD;
        public ProductoRepositorio()
        {
            BD = new TiendaLibreConection();
        }
        /// <summary>
        /// Permite consultar los productos disponibles
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Producto> ObtenerProducto()
        {
            return BD.Producto;
        }
       
    }
}
