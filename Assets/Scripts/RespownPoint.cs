using UnityEngine;

public class RespownPoint : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        SpawnPivot();
    }

    /// <summary>
    /// Spawns a PlayerPrefab at the current transform position, with an offset of 0.3f on the y-axis.
    /// </summary>
    public void Spawn()
    {
        Vector3 spawnPointTransform = transform.position;
        spawnPointTransform.y += 0.3f;

        Instantiate(gameManager.PlayerPrefab, spawnPointTransform, Quaternion.identity);
    }

    /// <summary>
    /// Spawns a pivot at a given position.
    /// </summary>
    public void SpawnPivot()
    {
        Vector3 spawnPointTransform = transform.position;

        float x = spawnPointTransform.x + 2.3f;
        float y = spawnPointTransform.y + 1.5f;
        float z = spawnPointTransform.z + 1.5f;

        // Set needed values
        spawnPointTransform = new Vector3(x, y, z);

        Instantiate(gameManager.PivotPrefab, spawnPointTransform, Quaternion.identity);
    }
}
