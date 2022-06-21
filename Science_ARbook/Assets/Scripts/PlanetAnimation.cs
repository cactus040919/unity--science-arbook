using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAnimation : MonoBehaviour
{
    public float planetRotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, planetRotationSpeed * Time.deltaTime, 0));
    }
}
