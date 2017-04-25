using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject[] enemys;
    public Transform[] spots;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("GenerateEnemy", 0, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void GenerateEnemy()
    {
        int spotRandomIndex = Random.Range(0, spots.Length);
        int enemyRandomIndex = Random.Range(0, enemys.Length);
        GameObject enemyClone = Instantiate(enemys[enemyRandomIndex], spots[spotRandomIndex].position, Quaternion.identity);
        enemyClone.GetComponent<EnemyPlane>().transform.Rotate(new Vector3(0, 180, 0));
    }
}
