using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {
    // Scene changes with onclick with object
   public void OnMouseDown() {
        SceneManager.LoadScene("Level 1", LoadSceneMode.Additive);
        Update();
    }

    // Update is called once per frame
    void Update() {
        // Notifies when code is working
        Debug.Log("CHANGE SCENE");
    }
}
