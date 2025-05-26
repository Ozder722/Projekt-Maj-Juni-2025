using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Spawn : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform spawnPos;
    



    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 2, 2);
    }
    void SpawnEnemy()
    {
        WaveSystem tempWave = new WaveSystem(spawnPrefab, spawnPos.position);

    }
}
