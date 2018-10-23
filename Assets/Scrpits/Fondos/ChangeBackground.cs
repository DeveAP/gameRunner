using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBackground : MonoBehaviour {
    public RawImage back;
    public Texture[] images;
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
        if (count == (images.Length)) {
            count = 0;
        }
        back.texture = images[count];
        count++;
        Debug.Log(count);
        Invoke("change", 2);
    }
}
