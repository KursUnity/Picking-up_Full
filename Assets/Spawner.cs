using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Cat CatPrefab;
    public float xAxis_1, xAxis_2;

    private void Awake()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var time = new WaitForSeconds(5);

        while (true)
        {
            Instantiate(CatPrefab, new Vector3(Random.Range(xAxis_1, xAxis_2), -1f, 0), Quaternion.identity);

            yield return time;
        }
    }
}