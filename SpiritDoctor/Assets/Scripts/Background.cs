using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float endPoint = -4.94f;
    [SerializeField]
    private float startPoint = 4.94f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= endPoint)
        {
            Vector3 pos = transform.position;
            pos.x += startPoint * 2f;
            transform.position = pos;
        }
    }
}
