using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backgroundUmi : MonoBehaviour {
    public AudioSource audio;
    public RawImage background;
    public Texture[] images;
    public Text puntaje_interfaz;
    public Text active_text_help;
    private int count;
    private int puntaje;
    public float velocity = 0.001f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (GameController.active_game)
        {
            active_text_help.enabled = false;
            moveGround();
            changeTexture();

        }
    }
    void moveGround()
    {
        background.uvRect = new Rect(new Vector2(background.uvRect.x + velocity, background.uvRect.y), new Vector2(1, 1));
    }
    void changeTexture() {
        puntaje = Puntaje.puntaje_valor();
        /*if (count == images.Length) {
            count = 0;
        }*/
        if (puntaje <= 1000)
        {
            background.texture = images[0];
        }
        else if (puntaje == 2000)
        {
            background.texture = images[1];
        }
        else if (puntaje >= 3000) {
            puntaje_interfaz.color = new Color(229, 229, 229);
            background.texture = images[2];
        }
        //count++;

    }
}
