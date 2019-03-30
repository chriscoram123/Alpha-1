using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour {
    public AudioClip Au;
    public AudioSource As;

    void Start() {
        As.clip = Au;
    }

    // Update is called once per frame
    void Update() {
        As.Play();
    }
}
