using Core.Domain.Entities;

namespace Pedidos.Domain.Entity
{
    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class AuditoryEntity<TEntity> : Entity<TEntity, int>
        where TEntity : Entity<TEntity, int>
    {
        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public DateTime DtReg { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public int UsReg { get; set; }
    }
}