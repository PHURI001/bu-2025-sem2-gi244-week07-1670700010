using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject obstaclePrefab;
    //public PlayerController Player;

    void Start()
    {
        InvokeRepeating(nameof(Spawn), 0f, 2f);
    }

    void Spawn()
    {
        //if (Player.IsGameOver)
        //{
        //    return;
        //}

        GameObject playerGameObject = GameObject.Find("Player");
        PlayerController player = playerGameObject.GetComponent<PlayerController>();
        if (player.IsGameOver)
        {
            return;
        }

        Instantiate(
            obstaclePrefab,
            spawnPoint.position,
            obstaclePrefab.transform.rotation
        );
    }
}
