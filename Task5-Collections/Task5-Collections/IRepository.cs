using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Collections
{
    public interface IRepository<TObject> where TObject : class
    {
        public void Add(TObject obj);
        public void Update(TObject obj);
        public IEnumerable<TObject> GetAll();
        public void Delete(TObject obj);
        public TObject Get(int id);
    }
}
