using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
        Blade b = collision.GetComponent<Blade>();

        if (b)
        {
            FindObjectOfType<GameManager>().OnBombHit();
        }
        else
        {
            return;
        }
    }
}
