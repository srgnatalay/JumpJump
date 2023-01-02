using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject zeminPrefab;
    private float xRange = 2.22f;
    int counter = 1;
   

    private void Start()
    {
        InvokeRepeating(nameof(SpawnGround), 0.1f, 0.6f);
    }

    void SpawnGround()
    {
        var randomX = Random.Range(-xRange, xRange);
        var position = new Vector3(randomX, transform.position.y * counter);
        Instantiate(zeminPrefab, position, Quaternion.identity);
        counter++;
    }


}
 