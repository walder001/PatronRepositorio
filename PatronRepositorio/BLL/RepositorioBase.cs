using PatronRepositorio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.BLL
{

    public class RepositorioBase<T> :IDisposable, IRepository<T> where T : class
    {
        internal Contexto _contexto;

        public RepositorioBase()
        {
            _contexto = new Contexto();
        }

        public virtual bool Guardar<T>(T entity) where T : class
        {
            bool paso = false;
            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                {
                    paso = _contexto.SaveChanges() > 0;

                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual bool Modificar<T>(T entity) where T : class
        {
            bool paso = false;
            try
            {
                _contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual bool Eliminar<T>(int id) where T : class
        {
            bool paso = false;
            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);
                paso = _contexto.SaveChanges() > 0;
             
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual T Buscar<T>(int id) where T : class
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);
           
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

       

        public void Dispose()
        {
            _contexto.Dispose();
      
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {

            List<T> Lista = new List<T>();

            try
            {
                Lista = _contexto.Set<T>().Where(expression).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return Lista; ;
        }
    }
}
