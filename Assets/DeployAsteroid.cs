using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DeployAsteroid : MonoBehaviour
{
    public Transform target;

    public Camera MainCamera;
    public GameObject AsteroidBig;
    public GameObject AsteroidSmall;

    public float respawnTime = 3.0f;
    public float respawnMax = 10.0f;
    private float respawnCount = 0.0f;


    private Vector2 screeenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screeenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        StartCoroutine(AsteroidWave());
    }

    private void SpawnAsteroid() {
        int x = Random.Range(0, 2);
        GameObject temp;
        switch(x) {
            case 0:            
                temp = Instantiate(AsteroidBig) as GameObject;
                break;
            default:                
                temp = Instantiate(AsteroidSmall) as GameObject;
                break;
        }        
        temp.GetComponent<FollowTarget>().target = target;
        temp.transform.position = RandomStartingPosition();
    }

    private Vector2 RandomStartingPosition() {
        return new Vector2(screeenBounds.x * RandomNegativePositive() * Random.Range(1, 3), screeenBounds.y * RandomNegativePositive() * Random.Range(1, 3));
    }

    private int RandomNegativePositive() {
        int x = Random.Range(0, 2);
        int[] randomNegative = {1, -1};
        return randomNegative[x];
    }

    // private GameObject RandomAsteroid() {
    //     int x = Random.Range(0, Asteroids.Length);
    //     return Asteroids[x];
    // }

    IEnumerator AsteroidWave() {
        while(respawnCount < respawnMax) {
            yield return new WaitForSeconds(respawnTime);
            SpawnAsteroid();
            respawnCount++;
        }
    }
}
