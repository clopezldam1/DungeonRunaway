using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootingPointFireBall : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Flip();
        RestoreRotate();
    }

    private void Flip()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(0, 180, 0);
            transform.position = new Vector3(transform.position.x - 2.78f, transform.position.y, transform.position.z);
        }
    }

    private void RestoreRotate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            transform.Rotate(0, 0, 0);
            transform.position = new Vector3(transform.position.x + 2.78f, transform.position.y, transform.position.z);
        }
    }
}
