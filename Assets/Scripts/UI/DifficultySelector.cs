using UnityEngine;

public class DifficultySelector : MonoBehaviour
{
    public void Easy()
    {
        GameManager.Instance.SetGameMode(EGameMode.Easy);
    }
    public void Medium()
    {
        GameManager.Instance.SetGameMode(EGameMode.Medium);
    }
    public void Hard()
    {
        GameManager.Instance.SetGameMode(EGameMode.Hard);
    }
}
