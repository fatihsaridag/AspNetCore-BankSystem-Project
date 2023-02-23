using BankSystem.Data.EntityFramework.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Data.UnitOfWorks.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICartRepository Carts { get; }
        ICartApplicationRepository CartApplications { get; }
        int Save();
    }
}
