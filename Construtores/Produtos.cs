using System.Collections.Generic;

namespace Construtores
{
    public class Produtos
    {
        public Produtos(int Id)
        {
            Complementos = new List<Complemento>();
            this.Id = Id;
        }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public List<Complemento> Complementos { get; set; }
    }
}
