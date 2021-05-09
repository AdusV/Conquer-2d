using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform navStartPatrol;
    public Transform navEndPatrol;

    private Vector2 startPatrol;
    private Vector2 endPatrol;
    public float speed;

    private Vector2 currentPlacePosition;
        private void Start()
    {
        startPatrol = navStartPatrol.position;
        endPatrol = navEndPatrol.position;
        //Destroy(navStartPatrol);
       // Destroy(navEndPatrol);
    }
    private void Update()
    {
        currentPlacePosition = Vector2.Lerp(startPatrol, endPatrol, Mathf.PingPong(Time.time * speed, 1));
        transform.position = currentPlacePosition;
    }
}
