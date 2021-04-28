
using System.Data.Common;
using System;
using System.Data.Entity.Infrastructure.Interception;


namespace MVCAssignment.Interception
    {
    public class EFCommandInterceptor : IDbCommandInterceptor
        {
        public void NonQueryExecuted(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
            {
            LogInfo("NonQueryExecuted", string.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
            }

        public void NonQueryExecuting(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
            {
            LogInfo("NonQueryExecuting", string.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
            }

        public void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
            {
            LogInfo("ReaderExecuted", string.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
            }

        public void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
            {
            LogInfo("ReaderExecuting", string.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
            }

        public void ScalarExecuted(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
            {
            LogInfo("ScalarExecuted", string.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
            }

        public void ScalarExecuting(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
            {
            LogInfo("ScalarExecuting", string.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
            }

        private void LogInfo(string command, string commandText)
            {
            System.Diagnostics.Debug.WriteLine("Intercepted on: {0} :- {1} ", command, commandText);
            }
        }
    }