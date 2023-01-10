using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX2 : MonoBehaviour
{

    [SerializeField] GameObject myBullet;
    [SerializeField] [Range(0, 5)] float cooldown = 1f;
    float cd0 = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cd0 <= 0)
        {
            cd0 = cooldown;
            Instantiate(myBullet, transform.position, myBullet.transform.rotation);
        }
        if (cd0 >= 0)
        {
            cd0 -= Time.deltaTime;
        }
    }
}

