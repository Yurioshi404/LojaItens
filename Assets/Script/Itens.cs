using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Raridade
{
    comum, incomum, raro, epico, lendario
}

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

    protected bool compravel;
    public bool Compravel { get { return compravel; } set { compravel = value; } }

    protected Raridade raridade;
    protected Tipo tipo;
}

public class Pocao : Itens
{
    public Pocao(string _nome, float _valor, Raridade _raridade, Tipo _tipo)
    {
        nome = _nome;
        valor = _valor;
        raridade = _raridade;
        tipo = _tipo;
    }
}

public class Arma : Itens
{
    public Arma(string _nome, float _valor, Raridade _raridade, Tipo _tipo)
    {
        nome = _nome;
        valor = _valor;
        raridade = _raridade;
        tipo = _tipo;
    }
}

public class Armadura : Itens
{
    public Armadura(string _nome, float _valor, Raridade _raridade, Tipo _tipo)
    {
        nome = _nome;
        valor = _valor;
        raridade = _raridade;
        tipo = _tipo;
    }
}

