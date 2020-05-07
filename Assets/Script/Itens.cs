using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tipo    //Enum criado para determinar se o tipo do item é equipamento ou consumível
{
    equipamento, consumivel
}

public abstract class Itens
{
    protected string nome;                          //String criado para armazenar o nome do item
    public string GetNome { get { return nome; } }  //Encapsulamento de nome

    protected float valor;                          //Float criado para armazenar o preço do item
    public float GetValor { get { return valor; } } //Encapsulamento de valor

    protected string descricao;                     //String criado para armazenar a descrição do item
    public string Descricao { get { return descricao; } set { descricao = value; } }    //Encapsulamento de descricao

    protected Tipo tipo;                            //Tiipo criado para armazenar o tipo do item
    public Tipo GetTipo { get { return tipo; } }    //Encapsulamento de tipo
}

public class Pocao : Itens
{
    public Pocao(string _nome, float _valor, Tipo _tipo)    //Contrutor de Pocao
    {
        nome = _nome;
        valor = _valor;
        tipo = _tipo;
    }
}

public class Arma : Itens
{
    public Arma(string _nome, float _valor, Tipo _tipo)     //Construtor de Arma
    {
        nome = _nome;
        valor = _valor;
        tipo = _tipo;
    }
}

public class Armadura : Itens
{
    public Armadura(string _nome, float _valor, Tipo _tipo) //Construtor de Armadura
    {
        nome = _nome;
        valor = _valor;
        tipo = _tipo;
    }
}

