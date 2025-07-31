using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager;
    public static GameManager Instance
    {
        get
        {
            if(gameManager == null)
                SetupGameManager();

            return gameManager;
        }
    }

    private void Awake()
    {
        if (gameManager == null)
        { 
            gameManager = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(gameObject);
    }

    private static void SetupGameManager()
    {
        gameManager = FindAnyObjectByType<GameManager>();

        if (gameManager == null)
        {
            GameObject gameObj = new GameObject();
            gameObj.name = "GameManager";
            gameManager = gameObj.AddComponent<GameManager>();
            DontDestroyOnLoad(gameObj);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
