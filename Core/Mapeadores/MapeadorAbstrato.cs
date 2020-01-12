
namespace Core.Mapeadores
{
    public class MapeadorAbstrato
    {
        protected Conexao _conexao;
        public MapeadorAbstrato()
        {
            _conexao = new Conexao();
        }

    }
}
