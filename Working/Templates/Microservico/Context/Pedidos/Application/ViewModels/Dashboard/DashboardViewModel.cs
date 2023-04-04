using Core.Application.Seguranca;

namespace Pedidos.Application.ViewModels.Dashboard
{
    /// <summary>
    ///
    /// </summary>
    public class DashboardViewModel
    {
        /// <summary>
        ///
        /// </summary>
        public DashboardViewModel(UserInfo userInfo)
        {
            EhAdmin = userInfo.Role == UserInfo.ROLE_ADMIN;
            NomeUsuario = string.IsNullOrWhiteSpace(userInfo.Name) ? userInfo.UserName : userInfo.Name;
        }

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public bool EhAdmin { get; set; }

        /// <summary>
        /// Nome usuário
        /// </summary>
        /// <value></value>
        public string NomeUsuario { get; set; }
    }
}