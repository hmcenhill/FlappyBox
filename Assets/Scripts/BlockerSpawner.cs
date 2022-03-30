using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerSpawner : MonoBehaviour
{
    [SerializeField] private BlockerController blockerPrefab;
    [SerializeField] private float spawnRate = 2f;

    public void StartSpawner() => StartCoroutine(nameof(SpawnBlocker));

    private IEnumerator SpawnBlocker()
    {
        yield return new WaitForSeconds(spawnRate);
        Instantiate(blockerPrefab, this.transform).SetValues();
        StartCoroutine(nameof(SpawnBlocker));
    }
}
