using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class FaseJogo : ComponenteFase
    {
        public FaseJogo(string nome) : base(nome)
        {

        }
        public override void Adicionar(ComponenteFase c)
        {
            Console.WriteLine("Não é possível adicionar a fase no jogo por aqui!");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + base.nome);
        }

        public override void Remover(ComponenteFase comp)
        {
            Console.WriteLine("Não é possível remover a fase no jogo por aqui!");
        }
    }
}
