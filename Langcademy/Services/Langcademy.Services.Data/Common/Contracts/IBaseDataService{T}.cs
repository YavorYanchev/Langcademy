﻿namespace Langcademy.Services.Data.Common.Contracts
{
    using System.Linq;
    using Langcademy.Data.Common.Models;

    public interface IBaseDataService<T>
        where T : class, IDeletableEntity, IAuditInfo
    {
        void Add(T item);

        void Delete(object id);

        IQueryable<T> GetAll();

        T GetById(object id);

        void Save();

        void Dispose();
    }
}