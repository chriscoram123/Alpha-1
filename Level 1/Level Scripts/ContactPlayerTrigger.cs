using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContactPlayerTrigger : MonoBehaviour {
    public Rigidbody bot;
    public float seconds;
    public AudioClip Au;
    public AudioSource As;

    void Start() {
        As.clip = Au;
    }
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            As.Play();
            Update();
        }
    }

    // Update is called once per frame
    void Update() {
        // Explosion animation with sound
        Debug.Log("ENG GAME EXPLOSION");
    }
}
