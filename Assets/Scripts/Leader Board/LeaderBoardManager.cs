using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LeaderBoardManager : MonoBehaviour
{
    public LeaderBoard easyLeaderBoardList;
    public LeaderBoard mediumLeaderBoardList;
    public LeaderBoard hardLeaderBoardList;

    void Start()
    {
        switch (GameManager.Instance.gameMode)
        {
            case EGameMode.Easy:
                easyLeaderBoardList.gameObject.SetActive(true);
                mediumLeaderBoardList.gameObject.SetActive(false);
                hardLeaderBoardList.gameObject.SetActive(false);
                break;
            case EGameMode.Medium:
                easyLeaderBoardList.gameObject.SetActive(false);
                mediumLeaderBoardList.gameObject.SetActive(true);
                hardLeaderBoardList.gameObject.SetActive(false);
                break;
            case EGameMode.Hard:
                easyLeaderBoardList.gameObject.SetActive(false);
                mediumLeaderBoardList.gameObject.SetActive(false);
                hardLeaderBoardList.gameObject.SetActive(true);
                break;
        }
    }
}

[System.Serializable]
public class PlayerData
{
    public List<Player> playerData = new List<Player>();
}

[System.Serializable]
public class Player
{
    public string PlayerName;
    public string score;

    public Player(string name, string _score)
    {
        PlayerName = name;
        score = _score;
    }
}
