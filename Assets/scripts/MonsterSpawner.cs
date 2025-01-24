using UnityEngine;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;

    [SerializeField]
    private Transform leftPos,rightPos;

    private int randomIndex;
    private int randomSide;

    void Start()
    {
        StartCoroutine(SpawnedMonsters());
    }

    IEnumerator SpawnedMonsters(){
        // while loop runs forever
        // While loop during excution for more monster to be respawned
        // yield return statement makes it wait a few seconds before the rest of the code is excuted
        while(true) {
          
            yield return  new WaitForSeconds(Random.Range(1,5));
            randomIndex = Random.Range(0,monsterReference.Length);
            randomSide = Random.Range(0,2);

            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            // left
            if(randomSide == 0){
                spawnedMonster.transform.position = leftPos.position;
                spawnedMonster.GetComponent<Monster>().speed = Random.Range(4,10);

            }
            // Right
            else{
                spawnedMonster.transform.position = rightPos.position;
                // Use negative number for range to move monster from right to left.
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4,10);
                // Fix direction for monster
                spawnedMonster.transform.localScale = new Vector3(-1f,1f,1f);

            }

        }
    }
}
