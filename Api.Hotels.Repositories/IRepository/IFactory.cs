using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.Hotels.Repositories.IRepository
{
   public interface IFactory
    {
        Task SaveChange();
    }
}
