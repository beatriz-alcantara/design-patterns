// See https://aka.ms/new-console-template for more information
using Composite;

Composite.Composite Mapa = new Composite.Composite("MAPA DAS CAVERNAS");

Composite.Composite caverna1 = new Composite.Composite("Caverna 1");
caverna1.Adicionar(new FaseJogo("SubFase 1"));
caverna1.Adicionar(new FaseJogo("SubFase 2"));
caverna1.Adicionar(new FaseJogo("SubFase 3"));


Composite.Composite caverna2 = new Composite.Composite("Caverna 2");
caverna2.Adicionar(new FaseJogo("SubFase 4"));
caverna2.Adicionar(new FaseJogo("SubFase 5"));

Composite.Composite porta_secreta = new Composite.Composite("Porta Secreta");
porta_secreta.Adicionar(new FaseJogo("Sub Fase Secreta X"));

Mapa.Adicionar(caverna1);
Mapa.Adicionar(caverna2);
caverna2 .Adicionar(porta_secreta);

Mapa.Mostrar(1);
