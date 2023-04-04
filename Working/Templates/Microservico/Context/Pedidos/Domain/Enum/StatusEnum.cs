using System.ComponentModel;

namespace Pedidos.Domain.Enum
{
    /// <summary>
    ///
    /// </summary>
    public enum StatusEnum
    {
        ///
        [Description("#FF00FB")]
        Novo = 0,

        ///
        [Description("#F3FF00")]
        Atendimento = 1,

        ///
        [Description("#FF0000")]
        Atraso = 2,

        ///
        [Description("#55FF00")]
        Finalizado = 3
    }
}