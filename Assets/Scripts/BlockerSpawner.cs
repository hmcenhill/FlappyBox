using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerSpawner : MonoBehaviour
{
    [SerializeField] private BlockerController blockerPrefab;
    [SerializeField] private float spawnRate = 2f;

    public void StartSpawner()
    {
        Instantiate(blockerPrefab, this.transform);
        StartCoroutine(nameof(SpawnBlocker));
    }

    private IEnumerator SpawnBlocker()
    {
        yield return new WaitForSeconds(spawnRate);
        Instantiate(blockerPrefab, this.transform);
        StartCoroutine(nameof(SpawnBlocker));
    }

    public void GameOver()
    {
        StopCoroutine(nameof(SpawnBlocker));
        foreach(var block in this.GetComponentsInChildren<BlockerController>())
        {
            Destroy(block.gameObject);
        }
    }
}
