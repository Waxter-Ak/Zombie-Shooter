using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject swarmPrefab;
    [SerializeField] float interval;

    private IEnumerable spawnenemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
    }
}
