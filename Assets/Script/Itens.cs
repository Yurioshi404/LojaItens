using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Tipo
{
    equipamento, consumivel
}

public abstract class Itens
{
    protected string nome;
    public string GetNome { get { return nome; } }

    protected float valor;
    public float GetValor { get { return valor; } }

    protected string descricao;
    public string Descricao { get { return descricao; } set { descricao = value; } }

    protected Tipo tipo;
    public Tipo GetTipo { get { return tipo; } }
}

public class Pocao : Itens
{
    public Pocao(string _nome, float _valor, Tipo _tipo)
    {
        nome = _nome;
        valor = _valor;
        tipo = _tipo;
    }
}

public class Arma : Itens
{
    public Arma(string _nome, float _valor, Tipo _tipo)
    {
        nome = _nome;
        valor = _valor;
        tipo = _tipo;
    }
}

public class Armadura : Itens
{
    public Armadura(string _nome, float _valor, Tipo _tipo)
    {
        nome = _nome;
        valor = _valor;
        tipo = _tipo;
    }
}

