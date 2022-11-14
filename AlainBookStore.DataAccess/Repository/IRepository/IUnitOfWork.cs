using AlainBookStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlainBookStore.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
//    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
