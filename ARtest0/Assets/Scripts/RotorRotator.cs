using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotorRotator : MonoBehaviour
{
    public float rotationSpeed = 30f;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -1 * (Time.deltaTime * rotationSpeed));
    }
}
