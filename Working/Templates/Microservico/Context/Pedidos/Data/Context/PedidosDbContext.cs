using Core.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pedidos.Domain.Entity;

namespace Pedidos.Data.Context
{
    /// <summary>
    ///
    /// </summary>
    public class PedidosDbContext : CoreDbContext
    {
        private const string DB_NAME = "BDFAPCLP";

        /// <summary>
        ///
        /// </summary>
        /// <param name="configuration"></param>
        public PedidosDbContext(IConfiguration configuration)
            : base(configuration)
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public DbSet<MaquinaEntity>? MaquinaEntity { get; set; }

        /// <summary>
        ///
        /// </summary>
        protected override string DbName => DB_NAME;
    }
}