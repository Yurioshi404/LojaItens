using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text nomeText;
    public Text valorText;
    public Text descricaoText;
    public Text dinheiroText;

    private void Awake()
    {
        nomeText.text = null;
        valorText.text = null;
        descricaoText.text = null;
    }

    public void AtualizarPainel()
    {
        nomeText.text = Jogador.Singleton.itemAtual.GetNome;
        valorText.text = "R$" + Jogador.Singleton.itemAtual.GetValor.ToString();
        descricaoText.text = Jogador.Singleton.itemAtual.Descricao;
        dinheiroText.text = Jogador.Singleton.dinheiro.ToString();
    }
}
