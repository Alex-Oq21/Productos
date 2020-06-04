using Ecommerce.Datos.Repositorio;
using Ecommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ecommerce.Datos.Extensiones;

namespace Ecommerce.Servicios.Controllers
{
    public class ProductoController : ApiController
    {
        private ProductoRepositorio repositorio;
        public ProductoController()
        {
            repositorio = new ProductoRepositorio();
        }
        [HttpGet]
        public IEnumerable<ProductoDTO> ObtenerProducto()
        {
           var listado = repositorio.ObtenerProducto();
            return listado.Select(x=> x.ToDTO());
        }
    }
}
