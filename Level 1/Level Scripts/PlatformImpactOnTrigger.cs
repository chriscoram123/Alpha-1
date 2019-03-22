﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlatformImpactOnTrigger : MonoBehaviour {
    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Update();
        }
    }

    // Update is called once per frame
    void Update() {
        // Explosion animation with sound
        Debug.Log("RESTART");
    }
}
