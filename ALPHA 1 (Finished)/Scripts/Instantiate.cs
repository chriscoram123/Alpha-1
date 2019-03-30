using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour {
    public Rigidbody Beam;
    public float speed;
    public float speed2;
    public AudioClip Ac;
    public AudioSource As;
    public Rigidbody Barrel;

    void Start() {
        As.clip = Ac;
    }
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            Instantiate(Beam);
            Beam.AddForce(speed * Time.deltaTime, speed2 * Time.deltaTime, 0);
            As.Play();
            Update();
        }
    }

    // Update is called once per frame
    void Update() {
        Debug.Log("TURRET 1 CHECKS OUT");
    }
}
