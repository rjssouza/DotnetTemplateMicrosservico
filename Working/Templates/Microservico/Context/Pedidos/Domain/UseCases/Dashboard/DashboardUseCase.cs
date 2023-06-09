using Core.Application.UseCases;
using Core.Domain.Interfaces;
using Core.Domain.Interfaces.Repositories;
using Core.Extensions;
using Pedidos.Application.ViewModels.Dashboard;
using Pedidos.Domain.Entity;

namespace Pedidos.Domain.UseCases.Dashboard
{
    /// <summary>
    ///
    /// </summary>
    public class DashboardUseCase : UseCase<FiltroComumViewModel, DashboardViewModel>, IUseCase<FiltroComumViewModel, DashboardViewModel>
    {
        private readonly IEntityRepository<MaquinaEntity, int> _maquinaRepository;

        /// <summary>
        ///
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <returns></returns>
        public DashboardUseCase(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _maquinaRepository = serviceProvider.GetRequiredService<IEntityRepository<MaquinaEntity, int>>();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        protected override Task<DashboardViewModel> ExecuteInternal(FiltroComumViewModel entry)
        {
            var maquinas = _maquinaRepository.GetAll(t => t.Bezeichnung == "");

            return Task.FromResult(new DashboardViewModel(entry.UserInfo));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="entry"></param>
        protected override void ValidateEntry(FiltroComumViewModel entry)
        {
            base.ValidateEntry(entry);
        }
    }
}