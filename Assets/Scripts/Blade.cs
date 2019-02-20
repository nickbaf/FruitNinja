using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{

    private Rigidbody2D b;

    // Start is called before the first frame update
    void Awake()
    {
        b = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        followBlade();
    }



    private void followBlade()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 10;
        b.position = Camera.main.ScreenToWorldPoint(mousePos);
    }
}
