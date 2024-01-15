using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperProductos
    {
        public List<Producto> Productos;

        public HelperProductos()
        {
            this.Productos = new List<Producto>();
        }

        public async Task WriteProductosAsync(string path)
        {
            string data = ConvertProductosToString();
            await HelperFiles.WriteFileAsync(path, data);
        }

        public async Task ReadProductosAsync(string path)
        {
            string text = await HelperFiles.ReadFileAsync(path);
            this.ConvertProductosToList(text);
        }

        private string ConvertProductosToString()
        {
            string data = "";
            foreach (Producto producto in this.Productos)
            {
                data += producto.Nombre + "," + producto.Cantidad + "/";
            }
            return data.TrimEnd('/');
        }

        private void ConvertProductosToList(string text)
        {
            this.Productos.Clear();
            foreach (string productoString in text.Split("/"))
            {
                string[] propiedades = productoString.Split(",");
                Producto producto = new Producto();
                producto.Nombre = propiedades[0];
                producto.Cantidad = Convert.ToInt32(propiedades[1]);
                Productos.Add(producto);
            }
        }
    }
}