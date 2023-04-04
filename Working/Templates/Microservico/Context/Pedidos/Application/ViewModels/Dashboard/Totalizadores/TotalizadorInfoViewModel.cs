using Pedidos.Application.ViewModels.Dashboard.Evolutivo;

namespace Pedidos.Application.ViewModels.Dashboard.Totalizadores
{
    /// <summary>
    ///
    /// </summary>
    public class TotalizadorInfoViewModel : TotalPorcentagem
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="qtdTotalChamados"></param>
        /// <param name="total"></param>
        /// <param name="descricao"></param>
        /// <param name="cor"></param>
        /// <param name="arrow"></param>
        public TotalizadorInfoViewModel(int qtdTotalChamados, int total, string descricao, string cor, string arrow)
            : base(qtdTotalChamados, total, cor, descricao)
        {
            ValorMensal = new List<EvolucaoMensalViewModel>();
            Arrow = arrow;
        }

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public string Arrow { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <value></value>
        public IEnumerable<EvolucaoMensalViewModel> ValorMensal { get; set; }
    }
}