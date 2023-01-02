using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminspawner : MonoBehaviour
{
    public GameObject zeminPrefab;
    public float time = 0.5f;
    private float xRange = 2.22f;
    int zeminSayaci = 1;
   

    private void Start()
    {
        InvokeRepeating(nameof(Cube), 0.1f, 0.6f);
    }

    void Cube()
    {
        var randomX = Random.Range(-xRange, xRange);
        var position = new Vector3(randomX, transform.position.y * zeminSayaci);
        Instantiate(zeminPrefab, position, Quaternion.identity);
        zeminSayaci++;
    }


}
 