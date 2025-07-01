using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;

public class ZombieInfo : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject Textholder;
    public int Health;
    private bool BattleOngoing;

    void Start()
    {
        //Set the player in a battle
        BattleOngoing = true;

        //Set Health
        Health = 5;

        //Don't show Text
        Textholder.SetActive(false);
    }

    void Update()
    {
        //Allow the Zombie to take damage
        if (Input.GetKeyDown("space"))
        {
            Health -= 1;
            Debug.Log("-1 Health");
        }

        //Destroy the Zombie after health hits 0
        if (Health <= 0)
        {
            //End battle
            BattleOngoing = false;

            //Destroy the mf zombie
            Object.Destroy(Zombie, 0);
        }

        //When the battle ends, show a text box of rewards and give the player a choice
        if (BattleOngoing == false)
        {
            Textholder.SetActive(true);
        }
    }
}

