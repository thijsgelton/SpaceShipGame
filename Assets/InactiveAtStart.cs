using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveAtStart : MonoBehaviour
{
    public MonoBehaviour script;

    // Start is called before the first frame update
    void Awake()
    {
        script.enabled = false;
    }

}
