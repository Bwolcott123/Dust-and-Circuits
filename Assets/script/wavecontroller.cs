using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wavecontroller : MonoBehaviour
{
    public GameObject enemies;
    public int enemiescount;
    public Vector2 spawnValues;
    public float spawnwait;
    public float startwait;
    public float wavewait;
    public int Squadspawn;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startwait);
        while (true)
        {
            for (int i = 0; i < enemiescount; i++)
            {
                Vector2 spawnPosition = new Vector2((Random.Range(-spawnValues.x, spawnValues.x)),spawnValues.y);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(enemies, spawnPosition, spawnRotation);
                for (int s = 0; s < Squadspawn; s++)
                {
                    yield return new WaitForSeconds(.5f);
                    float spawnPositionX = spawnPosition.x;

                    float xSpread = 1.5f + s;
                    Vector2 SquadspawnPosition = new Vector2((spawnPositionX + xSpread), (spawnValues.y + .5f));
                    Instantiate(enemies, SquadspawnPosition, spawnRotation);

                    Vector2 twoSquadspawnPosition = new Vector2((spawnPositionX - xSpread), spawnValues.y);
                    Instantiate(enemies, twoSquadspawnPosition, spawnRotation);

                }
                yield return new WaitForSeconds(spawnwait);
            }
            yield return new WaitForSeconds(wavewait);
        }
    }
}
