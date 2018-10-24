using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPlayer : MonoBehaviour {
    public Transform player;
    public float separacion = 4.4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.active_game)
        {
            move();
        }
	}
    void move() {
        transform.position = new Vector3(player.position.x + separacion, transform.position.y, transform.position.z);
    }
}
