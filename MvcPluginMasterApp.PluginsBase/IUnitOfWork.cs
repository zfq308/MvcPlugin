﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection;

namespace MvcPluginMasterApp.PluginsBase
{
    public interface IUnitOfWork : IDisposable
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveAllChanges();
        void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class;
        IList<T> GetRows<T>(string sql, params object[] parameters) where T : class;
        IEnumerable<TEntity> AddThisRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
        void SetDynamicEntities(Type[] dynamicTypes);
        void ForceDatabaseInitialize();
        void SetConfigurationsAssemblies(Assembly[] assembly);
    }
}