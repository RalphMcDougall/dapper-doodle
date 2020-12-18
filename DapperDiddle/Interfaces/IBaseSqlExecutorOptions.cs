﻿using System.Data;
using DapperDiddle.Enums;

namespace DapperDiddle.Interfaces
{
    public interface IBaseSqlExecutorOptions
    {
        IDbConnection Connection { get; set; }
        DBMS Dbms { get; set; }
    }

    public class BaseSqlExecutorOptions : IBaseSqlExecutorOptions
    {
        public IDbConnection Connection { get; set; }
        public DBMS Dbms { get; set; }
    }
}