using System;
using System.Linq;
using System.Linq.Expressions;
using JordyP2_Apl.Dal;
using JordyP2_Apl.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JordyP2_Apl.BLL
{
    public class ProyectoBLL
    {
        public static bool Guardar(Proyectos proyectos)
        {
            if (!Existe(proyectos.ProyectoId))
                return Insertar(proyectos);
            else
                return Modificar(proyectos);
        }

        private static bool Insertar(Proyectos proyectos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();
          
            try
            {
                //Agregar a la entidad que se desea ingresar al contexto
                foreach (var item in proyectos.Detalle)
                {
                    contexto.Entry(item.tipo).State = EntityState.Modified;
                }               
                contexto.Proyectos.Add(proyectos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }

        private static bool Modificar(Proyectos proyectos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM MorasDetalle Where MoraId={proyectos.ProyectoId}");

                foreach (var item in proyectos.Detalle)
                {
                    contexto.Entry(item).State = EntityState.Added;
                }
                
                contexto.Entry(proyectos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
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
                //Buscar La entidad que se desea eliminar
                var proyecto = contexto.Proyectos.Find(id);

                if (proyecto != null)
                {
                    contexto.Proyectos.Remove(proyecto);//Removemos la entidad
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Proyectos Buscar(int id)
        {

            Contexto contexto = new Contexto();
            Proyectos proyectos = new Proyectos();

            try
            {
                 proyectos = contexto.Proyectos
                    .Where(d => d.ProyectoId == id)
                    .Include(d => d.Detalle)
                    .ThenInclude(p => p.tipo)
                    .SingleOrDefault();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return proyectos;

        }

        public static bool Existe(int id)
        {

            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Proyectos.Any(e => e.ProyectoId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<Proyectos> GetList(Expression<Func<Proyectos, bool>> criterio)
        {

            List<Proyectos> lista = new List<Proyectos>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.Proyectos.Where(criterio).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}