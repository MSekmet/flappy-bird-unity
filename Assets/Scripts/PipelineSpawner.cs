using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipelineSpawner : MonoBehaviour
{
    public BirdMovement BirdScript;
    public GameObject Pipeline;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while(BirdScript.isAlive)
        {
            Instantiate(Pipeline, new Vector3(2, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
