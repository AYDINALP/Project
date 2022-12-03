using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    public float sayac = 0;
    public GameObject Asteroits;
    public float yukseklik;

    void Start()
    {
        GameObject newAsteroits = Instantiate(Asteroits);
        newAsteroits.transform.position = transform.position + new Vector3(0,Random.Range(-yukseklik,yukseklik),0);

    }
    void Update()
    {
        if(sayac > maxTime)
        {
            GameObject newAsteroits = Instantiate(Asteroits);
            newAsteroits.transform.position = transform.position + new Vector3(0,Random.Range(-yukseklik,yukseklik),0);
            Destroy(newAsteroits, 16);
            sayac = 0;
        }
        sayac += Time.deltaTime;
    }
}
