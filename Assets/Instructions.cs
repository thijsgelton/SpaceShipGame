using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    public KeyCode key;

    public Text instructions;

    void StartGame() {
        GameObject alien = GameObject.FindWithTag("Pickup");
        GameObject spaceShip = GameObject.FindWithTag("Player");

        if(alien != null && spaceShip != null) {
            alien.GetComponent<FleeFromTarget>().enabled = true;
            spaceShip.GetComponent<DeployAsteroid>().enabled = true;
            spaceShip.GetComponent<Push>().enabled = true;
            spaceShip.GetComponent<Rotate>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key)) {
            Destroy(instructions);
            StartGame();
        }
    }
}
