﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.BLL
{
    public interface IRepository<T> where T : class
    {
       /* List<T> GetList(Expression<Func<T, bool>> expression)
        {
            T Buscar(int id);
            bool Guardar(T entity);
            bool Modificar(T entity);
            bool Eliminar(T entity);

        }*/
    }
}
