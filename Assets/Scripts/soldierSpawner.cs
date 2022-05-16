using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierSpawner : MonoBehaviour
{
    public float speed = 0;
    public Transform ground;
    public Transform prince;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = ground.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = prince.position + offset;
    }
}
