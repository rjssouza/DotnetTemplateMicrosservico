using Core.Application;
using Core.Domain.Interfaces;
using Core.Extensions;
using Pedidos.Application.Interfaces;
using Pedidos.Application.ViewModels.Dashboard;

namespace Pedidos.Application
{
    /// <summary>
    /// Service para abrir chamados
    /// </summary>
    public class DashboardAppService : ServiceApp, IDashboardAppService
    {
        private readonly IUseCase<FiltroComumViewModel, DashboardViewModel> _dashboardUseCase;

        /// <summary>
        ///
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public DashboardAppService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _dashboardUseCase = serviceProvider.GetRequiredService<IUseCase<FiltroComumViewModel, DashboardViewModel>>();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public async Task<DashboardViewModel> ObterViewModel()
        {
            return await _dashboardUseCase.Execute(new FiltroComumViewModel(CurrentUser));
        }
    }
}