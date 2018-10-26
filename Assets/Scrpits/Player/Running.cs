using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour {
    public Rigidbody2D player;
    public  float speed = 10f;
    public int fase = 3;
    public int contador;
    public bool isGrounded = true;
    public int suma = 0;
    public  float force_jump = 600;
    public int tiempo;
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
        else
        {
            
        }
	}
    public  void runningPlayer (int puntaje) {
        if (puntaje % 500 == 0)
        {
            fase++;
            Debug.Log("Hrcho");

        }
        player.velocity = new Vector2(speed * (Time.deltaTime * fase) , player.velocity.y);
        if (isGrounded)
        {
            if (Input.GetMouseButtonDown(0)) { jump(); isGrounded = false; }

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("piso"))
        {
            isGrounded = true;
        }
    }
    public  void jump() {
        player.AddForce(Vector2.up * force_jump);
    }
}
