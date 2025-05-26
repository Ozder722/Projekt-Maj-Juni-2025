using UnityEngine;

public class WaveSystem
{
    public WaveSystem(GameObject enemyPrefab, Vector3 pos)
    {
        GameObject Enemy = GameObject.Instantiate(enemyPrefab, pos, Quaternion.identity);

    }
}
