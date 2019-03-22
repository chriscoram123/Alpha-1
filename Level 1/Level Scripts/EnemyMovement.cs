using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public Rigidbody bots;
    public float speed;

    void Update() {
        bots.AddForce(speed * Time.deltaTime, 0, 0);
    }
}
