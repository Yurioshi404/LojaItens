using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botoes : MonoBehaviour
{
    private Button botaoAtual;          //Button que armazena as informções do botão clicado (caso e item seja do Tipo equipamento)
    public Button botaoArmaduraMalha;   //Button que tem os componentes do botão da armadura de malha
    public Button botaoArmaduraBronze;  //Button que tem os componentes do botão da armadura de bronze
    public Button botaoArmaEspada;      //Button que tem os componentes do botão da arma espada
    public Button botaoArmaArco;        //Button que tem os componentes do botão da arma arco

    public UIScript uiScript;           //UIScript que referencia o UIScript

    //As funções a seguir criam a função de cada botão do jogo criando seus respectivos Itens e os armazenda no itemAtual de Jogador, logo em seguida atualiza o painel de informações
    public void BotaoPocaoVida()
    {
        Pocao pocao = new Pocao("Poção de Vida", 50f, Tipo.consumivel);
        pocao.Descricao = "Essa poção irá regenerar 25 pontos de vida por uso.";
        Jogador.Singleton.itemAtual = pocao;
        uiScript.AtualizarPainel();
    }

    public void BotaoPocaoMana()
    {
        Pocao pocao = new Pocao("Poção de Mana", 70f, Tipo.consumivel);
        pocao.Descricao = "Essa poçõa irá regenerar 20 pontos de mana por uso.";
        Jogador.Singleton.itemAtual = pocao;
        uiScript.AtualizarPainel();
    }
    //-----------------------------

    //As funções a seguir criam a função de cada botão do jogo, criando seus respectivos Itens e os armazenando
    //no itemAtual de Jogador, logo em seguida iguala o botao atual ao seu respectivo botão e atualiza o painel de informações
    public void BotaoArmaduraMalha()
    {
        Armadura armadura = new Armadura("Armadura de Cota de Malha", 150f, Tipo.equipamento);
        armadura.Descricao = "Essa armadura permitirá que você tenha uma mobilidade maior durante o combate e ainda te defenderá de facadas.";
        Jogador.Singleton.itemAtual = armadura;
        botaoAtual = botaoArmaduraMalha;
        uiScript.AtualizarPainel();
    }

    public void BotaoArmaduraBronze()
    {
        Armadura armadura = new Armadura("Armadura de Bronze", 275f, Tipo.equipamento);
        armadura.Descricao = "Essa armadura te dará uma grande quantidade de defesa, porém diminuirá significantemente sua mobilidade.";
        Jogador.Singleton.itemAtual = armadura;
        botaoAtual = botaoArmaduraBronze;
        uiScript.AtualizarPainel();
    }

    public void BotaoArmaEspada()
    {
        Arma arma = new Arma("Espada Excalibur", 600f, Tipo.equipamento);
        arma.Descricao = "Essa espada pertencia ao maior de todos os guerreiros, seu simples balançar é capaz de reduzir rochas a pó.";
        Jogador.Singleton.itemAtual = arma;
        botaoAtual = botaoArmaEspada;
        uiScript.AtualizarPainel();
    }

    public void BotaoArmaArco()
    {
        Arma arma = new Arma("Arco Elfico Triplo", 400f, Tipo.equipamento);
        arma.Descricao = "Esse arco pode lançar três flechas ao mesmo tempo, regem as lendas de que foi criado pelo primeiro elfo da história.";
        Jogador.Singleton.itemAtual = arma;
        botaoAtual = botaoArmaArco;
        uiScript.AtualizarPainel();
    }
    //-----------------------------

    public void BotaoComprar()
    {
        if (Jogador.Singleton.dinheiro >= Jogador.Singleton.itemAtual.GetValor)                         //Verifica se o dinheiro do jogador é maior ou igual ao preço do item atual
        {
            Jogador.Singleton.dinheiro -= Jogador.Singleton.itemAtual.GetValor;                         //Subtrai o dinheiro do jogador pelo preço do item atual
            if(Jogador.Singleton.itemAtual.GetTipo == Tipo.equipamento)                                 //Se o tipo do item for equipamento, a interação do botao atual é desligada
            {
                botaoAtual.interactable = false;
            }
        }
        else
        {
            Jogador.Singleton.itemAtual.Descricao = "Você não tem dinheiro para comprar este item.";    //Se não a descrição do item muda para "Você não tem dinheiro para comprar este item."
        }

        uiScript.AtualizarPainel();                                                                     //Chama a função atualizar painel
    }
}
