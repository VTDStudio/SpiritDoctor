using UnityEngine;

public class Tomb : MonoBehaviour
{
    public float moveSpeed = 1f;
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
