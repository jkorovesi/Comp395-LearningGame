using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public GameObject[] items;
    int index;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnWaves());

        // If you store all your items that you want to load in the same folder (Assets/Resources/MyItemsToLoad).     
        //items = Resources.LoadAll("MyItemsToLoad") as GameObject[];

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait); while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                index = Random.Range(0, items.Length);
                Instantiate(items[index], spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}