using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botoes : MonoBehaviour
{
    public Jogador jogador;

    public void BotaoPocaoVida()
    {
        Pocao pocao = new Pocao("Poção de Vida", 50f, Raridade.comum, Tipo.consumivel);
        jogador.itemAtual = pocao;
    }

    public void BotaoPocaoMana()
    {
        Pocao pocao = new Pocao("Poção de Mana", 70f, Raridade.incomum, Tipo.consumivel);
        jogador.itemAtual = pocao;
    }

    public void BotaoArmaduraMalha()
    {
        Armadura armadura = new Armadura("Armadura de Cota de Malha", 150f, Raridade.comum, Tipo.equipamento);
        jogador.itemAtual = armadura;
    }

    public void BotaoArmaduraBroze()
    {
        Armadura armadura = new Armadura("Armadura de Bronze", 275f, Raridade.raro, Tipo.equipamento);
        jogador.itemAtual = armadura;
    }

    public void BotaoArmaEspada()
    {
        Arma arma = new Arma("Espada Excalibur", 600f, Raridade.lendario, Tipo.equipamento);
        jogador.itemAtual = arma;
    }

    public void BotaoArmaArco()
    {
        Arma arma = new Arma("Arco Elfico Triplo", 400f, Raridade.epico, Tipo.equipamento);
        jogador.itemAtual = arma;
    }

    public void BotaoComprar()
    {
        if(jogador.dinheiro >= jogador.itemAtual.GetValor)
        {
            jogador.dinheiro -= jogador.itemAtual.GetValor;
        }
        else { return; }
    }
}
