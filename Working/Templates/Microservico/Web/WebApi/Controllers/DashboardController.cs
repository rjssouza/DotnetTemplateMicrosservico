using Pedidos.Application.Interfaces;
using Pedidos.Application.ViewModels.Dashboard;
using Core.Application.Seguranca;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    /// <summary>
    ///
    /// </summary>
    [Authorize(Roles = UserInfo.ROLE_COLABORADOR_AUTHORIZE)]
    [ApiController]
    [Route("api/dashboard")]
    public class DashboardController : Controller
    {
        private readonly IDashboardAppService _dashboardAppService;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="serviceProvider">Service provider</param>
        public DashboardController(IServiceProvider serviceProvider)
        {
            _dashboardAppService = serviceProvider.GetRequiredService<IDashboardAppService>();
        }

        /// <summary>
        /// Obter view model da tela de dashboard
        /// </summary>
        /// <returns>Dashboard</returns>
        [HttpGet()]
        [Authorize(Roles = UserInfo.ROLE_COLABORADOR_AUTHORIZE)]
        [ProducesResponseType(200, Type = typeof(DashboardViewModel))]
        [ProducesResponseType(400, Type = typeof(JsonResult))]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        public async Task<IActionResult> Get()
        {
            var result = await _dashboardAppService.ObterViewModel();

            return Ok(result);
        }
    }
}