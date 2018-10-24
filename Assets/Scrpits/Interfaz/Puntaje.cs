﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {
    private int valor = 0;
    public Text puntaje;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        valor = puntaje_valor();
        
        puntaje.text = valor.ToString();
	}
    public static int puntaje_valor() {
        int valor = Mathf.RoundToInt(Time.time * 50);
        return valor;

    }
}