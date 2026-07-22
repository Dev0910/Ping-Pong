using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public string playerName;
    public EGameMode gameMode { get; private set; } = EGameMode.Easy;
    public static GameManager Instance { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(this);
        }
    }
    public void GameOver(int _score)
    {
        score = _score;
        JsonManager.AddPlayer(GetFilePath(), new Player(playerName, score.ToString()));
        GetComponent<ChangeScene>().NextScene();
    }
    public void SetPlayerName(string _name)
    {
        playerName = _name;
    }
    public void SetGameMode(EGameMode eGameMode)
    {
        gameMode = eGameMode;
    }
    public string GetFilePath()
    {
        return Path.Combine(Application.persistentDataPath, "PlayerData", gameMode + "LeaderBoard.json");
    }
    public string GetFilePath(EGameMode gm)
    {
        switch (gm)
        {
            case EGameMode.Easy:
                return Path.Combine(Application.persistentDataPath, "PlayerData", EGameMode.Easy + "LeaderBoard.json");
            case EGameMode.Medium:
                return Path.Combine(Application.persistentDataPath, "PlayerData", EGameMode.Medium + "LeaderBoard.json");
            case EGameMode.Hard:
                return Path.Combine(Application.persistentDataPath, "PlayerData", EGameMode.Hard + "LeaderBoard.json");
                // case EGameMode.Easy:
                //     return Path.Combine(Application.persistentDataPath, EGameMode.Easy + "LeaderBoard.json");
                // case EGameMode.Medium:
                //     return Path.Combine(Application.persistentDataPath, EGameMode.Medium + "LeaderBoard.json");
                // case EGameMode.Hard:
                //     return Path.Combine(Application.persistentDataPath, EGameMode.Hard + "LeaderBoard.json");
        }
        return null;
    }
}
public enum EGameMode
{
    Easy,
    Medium,
    Hard
}
