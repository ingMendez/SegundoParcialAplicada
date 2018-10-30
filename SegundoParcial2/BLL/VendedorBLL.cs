using SegundoParcial2.DAL;
using SegundoParcial2.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SegundoParcial2.BLL
{
   public  class VendedorBLL
    {
        static RepositorioBase<Meta> repos;
        public static bool Guardar(Vendedor vendedor)
        {
            repos = new RepositorioBase<Meta>(new Contexto());
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                foreach(var item in vendedor.vendedor)
                {
                    var couta = contexto.Metas.Find(item.idMeta);
                    couta.cuota -= item.cuota;
                }
                if (contexto.Vende.Add(vendedor) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }

            } catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Vendedor vendedor)
        {
            bool paso = false;
            var Ante = VendedorBLL.Buscar(vendedor.VendedorId);
            Contexto contexto = new Contexto();
            try
            {
                foreach(var item in Ante.vendedor)
                {
                    var Couta = contexto.Vende.Find(item.IdMetas);
                    if(!vendedor.vendedor.Exists(d =>d.DetalleVendedorId == item.DetalleVendedorId))
                    {
                        Couta.cuotasDiarias += item.cuota;
                    }
                    contexto.Entry(item).State = EntityState.Deleted;
                }
                foreach(var item in vendedor.vendedor)
                {
                    var estado = (item.DetalleVendedorId == 0) ? EntityState.Added : EntityState.Modified;
                    contexto.Entry(item).State = estado;
                }
                contexto.Entry(vendedor).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Vende.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);

            }
            catch (Exception)
            { throw; }
            finally
            { contexto.Dispose(); }
            return paso;
        }

        public static Vendedor Buscar(int id)
        {
            var vendedor = new Vendedor();
            Contexto contexto = new Contexto();
            try
            {
                vendedor = contexto.Vende.Find(id);
                if (vendedor == null)
                    return vendedor;
                vendedor.vendedor.Count();
            }
            catch (Exception)
            { throw; }
            finally
            { contexto.Dispose(); }
            return vendedor;
        }

        public static List<Vendedor> GetList(Expression<Func<Vendedor, bool>> expression)
        {
            List<Vendedor> Lista = new List<Vendedor>();
            Contexto contexto = new Contexto();
            try
            {
                Lista = contexto.Vende.Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }
    }
}
