using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterOutofView : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
