using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    [SerializeField] private float leftLimit = -39;
    [SerializeField] private float bottomLimit = -1;


    void Update()
    {
        if (transform.position.x < leftLimit || transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
