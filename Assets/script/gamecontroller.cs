using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontroller : MonoBehaviour
{
    public GameObject Goal;
    public GameObject gameclear;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            gameclear.GetComponent<Text>();
            gameclear.SetActive(true);
            Debug.Log("hit");
        }
    }
}
