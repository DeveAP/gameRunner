using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backgroundUmi : MonoBehaviour {
    public RawImage background;
    public Texture[] images;
    private int count;
    public float velocity = 0.001f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (GameController.active_game)
        {
            moveGround();
        }
    }
    void moveGround()
    {
        background.uvRect = new Rect(new Vector2(background.uvRect.x + velocity, background.uvRect.y), new Vector2(1, 1));
    }
    void changeTexture() {
        background.texture = images[count];
        if (count == images.Length) {
            count = 0;
        }
        count++;

    }
}
