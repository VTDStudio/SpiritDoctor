using UnityEngine;

public class Player : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        // TODO : 1. ���Ĵ� �ִϸ��̼� �۵�
        // TODO : 2. �ڵ�������� Ȯ�� �� �̴ϰ��� �Ǵ� 20�ʰ� ���ı� �ð� ���

        Destroy(collision.gameObject);
    }
}
