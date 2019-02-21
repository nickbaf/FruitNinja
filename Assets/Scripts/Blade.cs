using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{

    private Rigidbody2D b;

    private float minVelocity = 0.1f;
    private Vector3 lastPos;
    private Vector3 mouseVel;

    private Collider2D col;

    // Start is called before the first frame update
    void Awake()
    {
        b = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        col.enabled = IsMoving();
        followBlade();
    }



    private void followBlade()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 10;
        b.position = Camera.main.ScreenToWorldPoint(mousePos);
    }



    private bool IsMoving()
    {
        Vector3 mousePos = transform.position;
        float traveled = (lastPos - mousePos).magnitude;
        lastPos = mousePos;

        if (traveled > minVelocity)
        {
            return true;
        }
        return false;
    }
}
