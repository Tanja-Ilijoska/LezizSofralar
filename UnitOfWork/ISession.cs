﻿using System.Data;

namespace UnitOfWork
{
    public interface ISession : IDbConnection
    {
        IDbConnection Connection { get; }
        IUnitOfWork UnitOfWork();
        IUnitOfWork UnitOfWork(IsolationLevel isolationLevel);
        SqlDialect SqlDialect { get; }
    }
}
