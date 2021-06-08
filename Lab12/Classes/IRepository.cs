using System.Collections.Generic;

namespace GoodFood.Classes {
  interface IRepository<T> where T : class {
    void Create(T obj);
    IEnumerable<T> Get();
    void Update(T obj);
    void Delete(T obj);
  }
}
