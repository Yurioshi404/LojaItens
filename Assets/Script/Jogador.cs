using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float dinheiro;                      //Float que armazena o dinheiro do jogador
    public Itens itemAtual;                     //Itens que armazena o item a selecionado pelo jogador
    public static Jogador Singleton;            //Singleton de jogador

    private void Awake()
    {
        Singleton = GetComponent<Jogador>();    //Singleton pegando os componentes de jogador
    }
}
