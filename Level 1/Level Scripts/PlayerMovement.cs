using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody player;
    public float speed;

    void Update() {
        if(Input.GetKey(KeyCode.RightArrow)) {
            player.AddForce(speed * Time.deltaTime, 0, 0);
            Debug.Log("PLAYER IS MOVING");
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            player.AddForce(-speed * Time.deltaTime, 0, 0);
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
    }
}
