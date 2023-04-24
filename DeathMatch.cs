using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeathMatch
{
    private Inhabitant dude1;
    private Inhabitant dude2;
    private GameObject dude1GO;
    private GameObject dude2GO;



    public DeathMatch(Inhabitant dude1, Inhabitant dude2, GameObject dude1GO, GameObject dude2GO)
    {
        this.dude1 = dude1;
        this.dude2 = dude2;
        this.dude1GO = dude1GO;
        this.dude2GO = dude2GO;
    }


    public void fight()
    {

        Random r = new Random();
        int coin = r.Next(0, 1);
         

        while (Inhabitant.dude1.hp.getData() > 0 && Inhabitant.dude2.hp.getData() > 0)
        {
            if (coin == 1)
            {
                dude1GO = true;
                tryAttack();

            }
            else
            {
                dude2GO = true;
                tryAttack();
            }
        }

        // goes back and forth having our Inhabitant "try" to attack each other
        // a successful attack means that a D20 is at least as high as the targets AC
        // upon successful attack, the targets HP reduce by the attackers attack
        // an unsuccessful attack results in no change in hp
        // go back and forth liek this unitl an inhabitant dies

    }

    static void tryAttack(dude1, dude2)
    {
        int attackRoll = Inhabitant.damage;
        if (attackRoll >= Inhabitant.ac)
        {
            int damage = attackRoll;
            Inhabitant.hp = Inhabitant.hp - damage;
            console.WriteLine(Inhabitant.name + "Hits" + Inhabitant.name + "for" + attackRoll);
            if (Inhabitant.hp <= 0)
            {
                console.WriteLine(Inhabitant.name + "Wins");
            }

        }

    }
}
