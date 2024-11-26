using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject car;
    public GameObject player;
    public GameObject camera;
    public GameObject crosshair;

    private void OnTriggerEnter(Collider car)
    {
        crosshair.SetActive(true);
        camera.GetComponent<AudioListener>().enabled = false;
        player.SetActive(true);
    }
}
