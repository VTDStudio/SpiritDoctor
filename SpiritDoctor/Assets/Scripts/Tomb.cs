using UnityEngine;

public enum TombGrade
{
    Normal,
    Rare,
    Epic,
    Legendary
}

public class Tomb : MonoBehaviour
{
    public TombGrade tombGrade;
    public float moveSpeed = 1f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
