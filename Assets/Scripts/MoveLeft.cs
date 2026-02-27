using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;

    GameObject playerGameObject;
    PlayerController player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find player by Tag
        playerGameObject = GameObject.FindGameObjectWithTag("Player");
        player = playerGameObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check IsGameOver
        if (player.IsGameOver)
        {
            return;
        }

        transform.Translate(speed * Vector3.left * Time.deltaTime);
    }
}
