using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEdgeTurrets2 : MonoBehaviour {
    public AudioClip Ac;
    public AudioSource As;
    public Rigidbody Beam;
    public float speed;
    public float speed2;
    public Rigidbody Barrel;

    // Start is called before the first frame update
    void Start() {
        As.clip = Ac;
    }
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Instantiate(Beam);
            Beam.AddForce(speed * Time.deltaTime, speed2 * Time.deltaTime, 0);
            As.Play();
            Debug.Log("BEAM INSTANTIATE + AUDIO ACTIVATE");
        }
    }
}
