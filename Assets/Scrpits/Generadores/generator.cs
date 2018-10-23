using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour {
    public GameObject[] obj;
    public float tiempoMinimo = 1f;
    public float tiempoMaximo = 3f;

    // Use this for initialization
    void Start () {
        generar();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void generar() {
        Instantiate(obj[Random.Range(0,obj.Length)],transform.position, Quaternion.identity);
        Invoke("generar", Random.Range(tiempoMinimo, tiempoMaximo));
    }
}
