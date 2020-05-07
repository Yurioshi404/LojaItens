using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text nomeText;       //Text que armazena o componente Text do nome do item
    public Text valorText;      //Text que armazena o componente Text do preço do item
    public Text descricaoText;  //Text que armazena o componente Text da descrição do item
    public Text dinheiroText;   //Text que armazena o componente Text do dinheiro do jogador

    private void Awake()
    {
        nomeText.text = null;       //Deixa do texto de nomeText vazio
        valorText.text = null;      //Deixa do texto de valorText vazio
        descricaoText.text = null;  //Deixa do texto de descricaoText vazio
    }

    public void AtualizarPainel()
    {
        nomeText.text = Jogador.Singleton.itemAtual.GetNome;                        //Deixa o texto de nomeText igual ao nome do item atual
        valorText.text = "R$" + Jogador.Singleton.itemAtual.GetValor.ToString();    //Deixa o texto de valorText igual a R$ + preço do item atual transformado em string
        descricaoText.text = Jogador.Singleton.itemAtual.Descricao;                 //Deixa o texto de descricaoText igual a descrição do item atual
        dinheiroText.text = Jogador.Singleton.dinheiro.ToString();                  //Deixa o texto de dinheiroText igual ao valor de dinheiro do jogador transformado em string                     
    }
}
