using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMakeDeck : MonoBehaviour {
    private bool IsPressed = false;

    public void PressMakeDeckButton() {

        if (!IsPressed) {
            SceneManager.LoadScene("MakeDeck");
            IsPressed = true;
        }

    }
}
