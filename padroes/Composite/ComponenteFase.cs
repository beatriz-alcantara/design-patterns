using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Classe que define a representação de uma fase
    public abstract class ComponenteFase
    {
        protected string nome;

        protected ComponenteFase(string nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(ComponenteFase c);
        public abstract void Remover(ComponenteFase comp);
        public abstract void Mostrar(int profundidade);
    }
}
