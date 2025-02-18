using System.Data.Common;
using System.Net;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace NotificationManager.Infrastructure
{
    public class EFCommandInterceptor : IDbCommandInterceptor
    {
        private readonly ILogger<DbContext> _logger;

        public EFCommandInterceptor(ILogger<DbContext> logger)
        {
            _logger = logger;
        }

        public InterceptionResult<DbCommand> CommandCreating(CommandCorrelatedEventData eventData, InterceptionResult<DbCommand> result)
        {
            _logger.LogInformation("{Message}", "Check DNS : " + GetIpAdressesFromDataSource(eventData?.Context?.Database?.GetDbConnection()?.DataSource));
            return result;
        }

        public DbCommand CommandCreated(CommandEndEventData eventData, DbCommand result)
        {
            return result;
        }

        public Task CommandFailedAsync(DbCommand command, CommandErrorEventData eventData, CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask;
        }

        public InterceptionResult<DbDataReader> ReaderExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result)
        {
            return result;
        }

        public ValueTask<InterceptionResult<DbDataReader>> ReaderExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<DbDataReader> result, CancellationToken cancellationToken = default)
        {
            return new ValueTask<InterceptionResult<DbDataReader>>(result);
        }

        public DbDataReader ReaderExecuted(DbCommand command, CommandExecutedEventData eventData, DbDataReader result)
        {
            return result;
        }

        public ValueTask<DbDataReader> ReaderExecutedAsync(DbCommand command, CommandExecutedEventData eventData, DbDataReader result, CancellationToken cancellationToken = default)
        {
            return new ValueTask<DbDataReader>(result);
        }

        public InterceptionResult DataReaderDisposing(DbCommand command, DataReaderDisposingEventData eventData, InterceptionResult result)
        {
            return result;
        }

        public int NonQueryExecuted(DbCommand command, CommandExecutedEventData eventData, int result)
        {
            return result;
        }

        public ValueTask<int> NonQueryExecutedAsync(DbCommand command, CommandExecutedEventData eventData, int result, CancellationToken cancellationToken = default)
        {
            return new ValueTask<int>(result);
        }

        public InterceptionResult<int> NonQueryExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<int> result)
        {
            return result;
        }

        public ValueTask<InterceptionResult<int>> NonQueryExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            return new ValueTask<InterceptionResult<int>>(result);
        }

        public object ScalarExecuted(DbCommand command, CommandExecutedEventData eventData, object result)
        {
            return result;
        }

        public async ValueTask<object> ScalarExecutedAsync(DbCommand command, CommandExecutedEventData eventData, object result, CancellationToken cancellationToken = default)
        {
            await Task.CompletedTask;
            return new ValueTask<object>(result);
        }

        public InterceptionResult<object> ScalarExecuting(DbCommand command, CommandEventData eventData, InterceptionResult<object> result)
        {
            return result;
        }

        public ValueTask<InterceptionResult<object>> ScalarExecutingAsync(DbCommand command, CommandEventData eventData, InterceptionResult<object> result, CancellationToken cancellationToken = default)
        {
            return new ValueTask<InterceptionResult<object>>(result);
        }

        /// <summary>
        /// Récupère l'adresse IP à partir de la Datasource
        /// </summary>
        /// <param name="dataSource">Datasource au format "protocol:hostname,port"</param>
        /// <returns></returns>
        public static string GetIpAdressesFromDataSource(string dataSource)
        {
            try
            {
                string[] dataSourceSegments = dataSource.Split(":")[^1].Split(",");
                string hostname = dataSourceSegments[0];

                IPAddress[] addresses = Dns.GetHostAddresses(hostname);
                string sAddress = $"IP trouvées pour '{hostname}' : " + string.Join(";", addresses.ToList());
                return sAddress;
            }
            catch
            {
                return $"IP non trouvée pour {dataSource}";
            }
        }
    }
}
