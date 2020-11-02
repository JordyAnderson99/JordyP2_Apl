using System;
using System.Linq;
using System.Linq.Expressions;
using JordyP2_Apl.Dal;
using JordyP2_Apl.Entidades;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JordyP2_Apl.BLL
{
    public class TareasBLL
    {
        public static List<Tareas> GetList(Expression<Func<Tareas, bool>> criterio)
        {

            List<Tareas> lista = new List<Tareas>();
            Contexto contexto = new Contexto();

            try
            {
                //obtener la lista y filtrarla segun el criterio recibido por parametro
                lista = contexto.Tareas.Where(criterio).ToList();

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