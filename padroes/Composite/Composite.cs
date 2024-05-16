namespace Composite
{
    public class Composite : ComponenteFase
    {
        private List<ComponenteFase> fasesJogo = new List<ComponenteFase>();

        public Composite(string nome) : base(nome)
        {
        }

        public override void Adicionar(ComponenteFase c)
        {
            this.fasesJogo.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + base.nome);
            foreach(ComponenteFase item in fasesJogo)
            {
                item.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(ComponenteFase comp)
        {
            this.fasesJogo.Remove(comp);
        }
    }
}
