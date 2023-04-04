using Pedidos.Application.ViewModels.Dashboard;

namespace Pedidos.Application.Interfaces
{
    /// <summary>
    /// Interface abertura de chamado
    /// </summary>
    public interface IDashboardAppService : IDisposable
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        Task<DashboardViewModel> ObterViewModel();
    }
}