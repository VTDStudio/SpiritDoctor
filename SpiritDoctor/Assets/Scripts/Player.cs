using UnityEngine;

public class Player : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO : 1. 땅파는 애니메이션 작동
        // TODO : 2. 자동모드인지 확인 후 미니게임 또는 20초간 땅파기 시간 재기

        Destroy(collision.gameObject);
    }
}
