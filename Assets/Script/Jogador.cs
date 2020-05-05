﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float dinheiro;
    public Itens itemAtual;

    public static Jogador Singleton;

    private void Awake()
    {
        Singleton = GetComponent<Jogador>();
    }
}
