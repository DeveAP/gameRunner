using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour {
    public Rigidbody2D player;
    public  float speed = 10f;
    public int fase = 3;
    public int contador;
    public  float force_jump = 600;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.active_game)
        {
            contador = Puntaje.puntaje_valor();
            runningPlayer(contador);
        }
	}
    public  void runningPlayer (int puntaje) {
        if (puntaje % 1000 == 0)
        {
            fase++;
            Debug.Log("Hrcho");

        }
        player.velocity = new Vector2(speed * (Time.deltaTime * fase) , player.velocity.y);
        if (Input.GetMouseButtonDown(0)) { jump(); }
    }
    public  void jump() {
        player.AddForce(Vector2.up * force_jump);
    }
}
