using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground : MonoBehaviour {
    public RawImage back;
    public Texture[] images;
    public Text texto;
    private int count = 0;
    // Use this for initialization
    void Start() {
        change();
    }

    // Update is called once per frame
    void Update() {
        //back.renderer(backs[0]);
    }
    void change() {
        if (count == (images.Length))
        {
            count = 0;
            texto.color = new Color(0, 0, 0);

        }
        else if (count == 2)
        {
            texto.color = new Color(255, 255, 255);
            Debug.Log(count);
        }
        else if (count == 0 || count == 1)
        {
            texto.color = new Color(0, 0, 0);
            Debug.Log(count);

        }

        back.texture = images[count];
        count++;
        Invoke("change", 25);
    }
}
