using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public Sprite[] tombSprites;
    public GameObject tombPrefab;
    public Transform tombSpawnPoint;

    private float spawnTime;

    void Update()
    {
        spawnTime += Time.deltaTime;

        if (spawnTime >= Define.tombSpawnTime)
        {
            // ���� ����
            GameObject tombObject = Instantiate(tombPrefab, tombSpawnPoint);
            Tomb tomb = tombObject.GetComponent<Tomb>();

            int tombGradeIndex = SpawnTombIndex();

            // ���� ��� �� ���� �̹��� ����
            tomb.tombGrade = (TombGrade)tombGradeIndex;
            tombObject.GetComponent<SpriteRenderer>().sprite = tombSprites[tombGradeIndex];

            spawnTime = 0;
        }
    }

    // ������ Ȯ�� ���� : ���������� Ŀ���� ������ ĳġ
    int SpawnTombIndex()
    {
        // ���� ��
        float rand = Random.value;
        Debug.Log(rand);
        float cumulative = 0f;

        for (int i = 0; i < Define.tombProbability.Length; i++)
        {
            cumulative += Define.tombProbability[i];

            if (rand < cumulative)
                return i;
        }

        // ����ó��
        return 0;
    }

}
