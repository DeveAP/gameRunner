using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje_Final : MonoBehaviour {
    public Text puntaje;

    // Use this for initialization
	void Start () {
        cambio();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void cambio() {
        puntaje.text = (Puntaje.suma).ToString();
        Puntaje.suma = 0;
    }
}
