using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    Transform bird;

    void Start() {
        bird = GameObject.Find("Bird").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.position.x - transform.position.x > 10)
        {
            Destroy(gameObject);
        }
    }
}
