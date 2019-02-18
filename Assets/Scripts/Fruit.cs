using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject slicedFruit;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScliceTheFruit();
        }
    }


    public void ScliceTheFruit()
    {

        GameObject instance = (GameObject) Instantiate(slicedFruit, transform.position, transform.rotation);

        Rigidbody[] slices = instance.transform.GetComponentsInChildren<Rigidbody>();

        foreach(Rigidbody r in slices)
        {
            r.transform.rotation = Random.rotation;
            r.AddExplosionForce(Random.Range(600, 1200), transform.position, 5f);
        }
        Destroy(gameObject);
    }


}
