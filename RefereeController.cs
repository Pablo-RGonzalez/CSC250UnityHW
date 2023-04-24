using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RefereeController : MonoBehaviour
{
    public GameObject monsterGo;
    public GameObject PlayerGo;
    public TextMeshPro monsterSB;
    public TextMeshPro PlayerSB;
    private Monster theMonster;
    private DeathMatch theMatch;

    // Start is called before the first frame update
    void Start()
    {

        this.theMonster = new Monster("goblin");
        MasterData.p = new Player("Mike");
        this.monsterSB.text = this.theMonster.getData();
        this.PlayerSB.text = MasterData.p.getData();
        this.theMatch = new DeathMatch(MasterData.p, this.theMonster);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
