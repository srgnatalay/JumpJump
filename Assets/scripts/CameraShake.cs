using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 _offset = new (0, 1, 0);

    private void Start() => player = GameObject.FindGameObjectWithTag("Player");

    void LateUpdate() => transform.position = player.transform.position + _offset;
}
