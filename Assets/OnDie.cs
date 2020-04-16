using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class OnDie : MonoBehaviour
{
    public MonoBehaviour runScript;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == false) {
             SceneManager.LoadScene("SpaceShip");
        }
    }
}
