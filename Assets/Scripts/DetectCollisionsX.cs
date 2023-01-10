using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Debug.Log("GameOver !!!!!");
            Time.timeScale = 0f;
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
