using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CandySpawner : MonoBehaviour
{
    //list for candy objects
    [SerializeField]private List<GameObject> _candies = new List<GameObject>();
    //the chosen candy to spawn
    private GameObject _chosenCandy;
    //time for spawndelay
    private int _spawnDelayTime;
    //minimum spawn time
    private int _minSpawnTime = 5;
    //maximum spawn time
    private int _maxSpawnTime = 30;

	// Use this for initialization
	void Start ()
    {
        SpawnCandy();
	}
    //spawn a candy
    void SpawnCandy()
    {
        if(transform.childCount == 0)
        {
            _chosenCandy = _candies[Random.Range(0, _candies.Count)];
            GameObject candy = Instantiate(_chosenCandy, transform.position, Quaternion.identity) as GameObject;
            candy.transform.parent = this.transform;
            StartCoroutine(SpawnDelay());
        }
    }

    //delay for spawning the candy
    IEnumerator SpawnDelay()
    {
        _spawnDelayTime = Random.Range(_minSpawnTime, _maxSpawnTime);
        yield return new WaitForSeconds(_spawnDelayTime);
        SpawnCandy();
    }
}
