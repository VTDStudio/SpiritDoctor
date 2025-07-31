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
            // 무덤 생성
            GameObject tombObject = Instantiate(tombPrefab, tombSpawnPoint);
            Tomb tomb = tombObject.GetComponent<Tomb>();

            int tombGradeIndex = SpawnTombIndex();

            // 무덤 등급 및 무덤 이미지 결정
            tomb.tombGrade = (TombGrade)tombGradeIndex;
            tombObject.GetComponent<SpriteRenderer>().sprite = tombSprites[tombGradeIndex];

            spawnTime = 0;
        }
    }

    // 누적합 확률 계산법 : 랜덤값보다 커지는 순간을 캐치
    int SpawnTombIndex()
    {
        // 랜덤 값
        float rand = Random.value;
        Debug.Log(rand);
        float cumulative = 0f;

        for (int i = 0; i < Define.tombProbability.Length; i++)
        {
            cumulative += Define.tombProbability[i];

            if (rand < cumulative)
                return i;
        }

        // 예외처리
        return 0;
    }

}
