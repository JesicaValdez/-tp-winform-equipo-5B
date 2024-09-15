using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    public class ArticuloNegocio
    {
        private List<Articulo> listaArticulos = new List<Articulo>();
        private List<Categoria> ListaCategorias = new List<Categoria>();
        AccesoDB datos = new AccesoDB();

        public ArticuloNegocio()
        {
            datos = new AccesoDB();
        }

        public List<Articulo> listarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDB datos = new AccesoDB();
            try
            {
                datos.setearConsulta("Select A.Id, Codigo, Nombre, A.Descripcion as Detalle, M.Descripcion as Marca, C.Descripcion as Categoria, Precio, ImagenUrl From ARTICULOS A, MARCAS M, CATEGORIAS C, IMAGENES I where A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Id = I.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Detalle"];
                    aux.marca = new Marca();
                    aux.marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.precio = (decimal)datos.Lector["Precio"];
                    aux.imagenurl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public List<Articulo> buscarpormarca(string marca)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lista1 = negocio.listarArticulos();
            List<Articulo> lista2 = new List<Articulo>();
            foreach (Articulo art in lista1)
            {
                if (art.marca.Descripcion == marca)
                {
                    lista2.Add(art);
                }
            }
            return lista2;
        }

        public List<Articulo> buscarporcategoria(string cat)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> lista1 = negocio.listarArticulos();
            List<Articulo> lista2 = new List<Articulo>();
            foreach (Articulo art in lista1)
            {
                if (art.categoria.Descripcion == cat)
                {
                    lista2.Add(art);
                }
            }
            return lista2;
        }

        public void agregarArticulo(Articulo nuevo)
        {
            AccesoDB datos = new AccesoDB();

            try 
            {
                datos.setearConsulta("inset into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) \r\n values (@Codigo, @Nombre, @Descripcion, @Precio)");
                datos.setearParametro("@Codigo", nuevo.codigo);
                datos.setearParametro("@Nombre", nuevo.nombre);
                datos.setearParametro("@Descripcion", nuevo.descripcion);
                datos.setearParametro("@IdMarca", nuevo.marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.categoria.Id);
                datos.setearParametro("@Precio", nuevo.precio);
                datos.ejecutarAccion();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarArticulo(int id)
        {
            try
            {
                AccesoDB datos = new AccesoDB();
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
