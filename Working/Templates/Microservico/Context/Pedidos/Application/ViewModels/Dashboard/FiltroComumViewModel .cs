using Core.Application.Seguranca;

namespace Pedidos.Application.ViewModels.Dashboard
{
    /// <summary>
    ///
    /// </summary>
    public class FiltroComumViewModel
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="userInfo"></param>
        public FiltroComumViewModel(UserInfo userInfo)
        {
            NomeUsuario = userInfo.UserName;
            DataCorrente = DateTime.Now;
            UserInfo = userInfo;
        }

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public DateTime DataCorrente { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public string? NomeUsuario { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public UserInfo UserInfo { get; set; }
    }
}