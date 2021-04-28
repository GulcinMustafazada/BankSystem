using BankSystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Business.Abstract
{
    public interface IDirectorService
    {
        void Add(Director director);
        void Update(Director director);
        void Delete(Director director);
        Director GetById(int id);
        List<Director> GetAll();
    }
}
