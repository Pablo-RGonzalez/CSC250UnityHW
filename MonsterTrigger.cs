using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterTrigger : MonoBehaviour
{
    public bool enableFights = true;
    public float chanceToGetIntoFight = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.enableFights)
        {
            int changeToFight = Random.Range(1, 100);

            if (changeToFight <= this.chanceToGetIntoFight)
            {
                SceneManager.LoadScene("FightScene");
            }
            else
            {
                print("No Monsters Found");
            }
        }
    }
}
