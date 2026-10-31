using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeBetweenWaves = 5f;
    public GameObject EnemyPrefab;
    private int waveIndex = 0;
    private float countDown = 2f;

    void Update()
    {
        if (countDown <= 0)
        {
            StartCoroutine(SpawnWave());
            countDown = timeBetweenWaves;
        } 
        countDown-=Time.deltaTime;
    }

    public IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(EnemyPrefab,transform.position,transform.rotation);
    }
}
