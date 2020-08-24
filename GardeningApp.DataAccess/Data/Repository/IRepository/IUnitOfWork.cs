using System;

namespace GardeningApp.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork :  IDisposable
    {
         ICategoryRepository Category { get; }
         void Save();
    }
}