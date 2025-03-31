using SQLite;
namespace MauiAppMinhasComprasCerto.Models
{
    public class Produto
    {
        string _descricao;
        private double _quantidade;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Categoria { get; set; }
        public string Descricao
        {
            get => _descricao;
            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new Exception("Por favor preencha a descrição");
                }
                _descricao = value;
            }
        }
        public double Quantidade { get; set; }

        public double Preco { get; set; }
        public double Total { get => Quantidade * Preco; }

    }
}