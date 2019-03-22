using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour {
    public AudioClip Au;
    public AudioSource As;

    // Start is called before the first frame update
    void Start() {
        As.clip = Au;
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetKey(KeyCode.RightArrow)) {
            As.Play();
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            As.Play();
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            As.Play();
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            As.Play();
        }
    }
}
