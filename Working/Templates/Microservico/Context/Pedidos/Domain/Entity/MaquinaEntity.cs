using Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pedidos.Domain.Entity
{
    /// <summary>
    ///
    /// </summary>
    public class MaquinaEntity : Entity<MaquinaEntity, int>
    {
        /// <summary>
        ///
        /// </summary>
        public MaquinaEntity()
        {
            Bezeichnung = string.Empty;
        }

        /// <summary>
        ///
        /// </summary>
        public string Bezeichnung { get; private set; }

        /// <summary>
        ///
        /// </summary>
        public int Liniennummer { get; private set; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="builder"></param>
        public override void Configure(EntityTypeBuilder<MaquinaEntity> builder)
        {
            base.Configure(builder);

            builder.ToView("Maquina");
        }
    }
}