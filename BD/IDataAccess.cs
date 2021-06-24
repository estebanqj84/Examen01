﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace BD
{
    public interface IDataAccess
    {
        Task<DBEntity> ExecuteAsync(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<dynamic>> QueryAsync(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C, D, E, F, G>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C, D, E, F>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C, D, E>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C, D>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B, C>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T, B>(string sp, object Param = null, int? Timeout = null);
        Task<IEnumerable<T>> QueryAsync<T>(string sp, object Param = null, int? Timeout = null);
        Task<T> QueryFirstAsync<T>(string sp, object Param = null, int? Timeout = null);
    }
}