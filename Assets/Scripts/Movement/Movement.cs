using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private GameObject ball;
    [SerializeField] private bool isAI;
    [SerializeField] GameMode[] gameMode;

    private float moveSpeed;
    private Rigidbody2D rb;
    private Vector2 playerMove;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        foreach (GameMode gm in gameMode)
        {
            if (gm.gameMode == GameManager.Instance.gameMode)
            {
                moveSpeed = gm.moveSpeed;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isAI)
        {
            AIControl();
        }

        else
        {
            PlayerControl();
        }
    }

    void PlayerControl()
    {
        playerMove = new Vector2(0, Input.GetAxisRaw("Vertical"));
    }

    void AIControl()
    {
        if (ball.transform.position.y > transform.position.y + 0.5f)
        {
            playerMove = new Vector2(0, 1);
        }
        else if (ball.transform.position.y < transform.position.y - 0.5f)
        {
            playerMove = new Vector2(0, -1);
        }
        else
        {
            playerMove = new Vector2(0, 0);
        }
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = playerMove * moveSpeed;
    }
    [System.Serializable]
    class GameMode
    {
        public EGameMode gameMode;
        public float moveSpeed;
    }
}
