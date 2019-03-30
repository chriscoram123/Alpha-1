using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody player;
    public float speed;
    public float speed2;
    public float speed3;

    void Update() {
        // KeyPad Movement
        if (Input.GetKey(KeyCode.RightArrow)) {
            player.AddForce(0, 0, -speed * Time.deltaTime);
            Debug.Log("PLAYER IS MOVING");
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            player.AddForce(0, 0, speed * Time.deltaTime);
            Debug.Log("PLAYER IS MOVING");
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            player.AddForce(0, speed * Time.deltaTime, 0);
            Debug.Log("PLAYER IS MOVING");
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            player.AddForce(0, -speed * Time.deltaTime, 0);
            Debug.Log("PLAYER IS MOVING");
        }

        // Q / W Forward Movement
        if (Input.GetKey(KeyCode.Q)) {
            player.AddForce(speed2 * Time.deltaTime, 0, 0);
            Debug.Log("PLAYER IS MOVING");
        }
        if (Input.GetKey(KeyCode.W)) {
            player.AddForce(-speed2 * Time.deltaTime, 0, 0);
            Debug.Log("PLAYER IS MOVING");
        }

        // Increase Speed
        if (Input.GetKey(KeyCode.A)) {
            player.AddForce(speed3 * Time.deltaTime, 0, 0);
            Debug.Log("PLAYER IS MOVING");
        }
        if (Input.GetKey(KeyCode.S)) {
            player.AddForce(-speed3 * Time.deltaTime, 0, 0);
            Debug.Log("PLAYER IS MOVING");
        }
    }
}
