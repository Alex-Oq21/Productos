using Ecommerce.Datos.Modelo;
using Ecommerce.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Datos.Extensiones
{
    public static class toDTO
    {
        public static ProductoDTO ToDTO(this Producto model)
        {
            return new ProductoDTO
            {
                IdProducto = model.IdProducto,
                Nombre = model.Nombre,
                Precio = model.Precio,
                Stock = model.Stock,
                Descripcion = model.Descripcion,
                Referecnia = model.Referecnia,
                Imagenes = model.ImagenProducto.Select(x=> x.ToDTO())
            };

        }
        public static ImagenProductoDTO ToDTO(this ImagenProducto model)
        {
            return new ImagenProductoDTO
            {
                IdImagenProducto = model.IdImagenProducto,
                IdProducto = model.IdProducto,
                EsPortada = model.EsPortada,
                Url = model.Url
            };
        }

    }
}
