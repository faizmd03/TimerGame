using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPos : MonoBehaviour
{
    float x, y, z;
    public GameObject enemy;
    public int enemyCount;
   
    // Start is called before the first frame update
    void Start()
    {
      
        StartCoroutine(EnemyDrop());


    }
    IEnumerator EnemyDrop()
    {
        while(enemyCount < 9)
        {
            x = Random.Range(-62.3f, 27.2f);
            y = 0.52f;
            z = Random.Range(-19.7f, -109.4f);
            Instantiate(enemy, new Vector3(x, y, z), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
            Debug.Log("Spawn");
        }
    }
  
}
