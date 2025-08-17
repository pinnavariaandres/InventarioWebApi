using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Invetory.Persistence.Interfaces
{
    public interface IBaseRepository<T>
     where T : class //repositorio generico ,metodos en comun de los repositorios en comun
    {
        //metodo para obtener todos los registros de una tabla
        Task<IEnumerable<T>> GetAllAsync();
        //seleccionamos un task xq es asincorno, nos devuelve un objeto T y el metodo
        //GetbyIDasync recibe un entero
        Task<T> GetByIdAsync(int id);
        Task<T> AddASync(T entity);
        //nos devuelve un bool para decirnos si actualiza y recibe un int id q a va actualizar y la entidad T
        Task<bool> UpdateAsync(int id, T entity);
        //devuleve una lista ienumatable y recibe una lista T
        Task<IEnumerable<T>> AddAll(IEnumerable<T> entities);

        Task<bool> DeleteAsync(int id);
        
        Task<bool> DeleteAsync (T Entity);
    }
}