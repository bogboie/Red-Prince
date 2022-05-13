using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldierSpawner : MonoBehaviour
{
    public float speed = 0;
    public Transform prince;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = prince.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
