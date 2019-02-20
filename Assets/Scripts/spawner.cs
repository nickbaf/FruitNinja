using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public GameObject theFruit;
    public float waitTimeMin = .3f;
    public float waitTimeMax = 1f;
    public Transform[] spawnPlaces;
    public float minForce = 12f;
    public float maxForce = 17f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }



    private IEnumerator Spawn()
    {
        while (true)
        {

            yield return new WaitForSeconds(Random.Range(waitTimeMin, waitTimeMax));
            Transform t = spawnPlaces[Random.Range(0, spawnPlaces.Length)];

            GameObject frut = Instantiate(theFruit, t.position, t.rotation);

            frut.GetComponent<Rigidbody2D>().AddForce(t.transform.up *Random.Range(minForce,maxForce), ForceMode2D.Impulse);

            Destroy(frut, 5f);
        }
    }

}
