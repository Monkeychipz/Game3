using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorController : MonoBehaviour {
    // class that utilizes the general Player Movement script 
    // set a speed for the player in the Start() 
    public float health;
    public float rage;
    public bool isBasicAttacking;
    public PlayerMovement player_movement;

	// Use this for initialization
	void Start () {
        health = 100f;
        rage = 100f;
        isBasicAttacking = false;
        player_movement.speed = 5f;

		
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(BasicAttack());  
		
	}

    private IEnumerator BasicAttack()
    {
        if (Input.GetAxis("Right Trigger") == 1)
        {
            if (!isBasicAttacking)
            {
                isBasicAttacking = true;
                Debug.Log("basic attack");
                yield return new WaitForSeconds(1f);
                isBasicAttacking = false;

            }
        }
    }
    private void ShieldBash() //mobility skill: that knocks back and stuns if hits a wall
    {

    }
    private void Taunt() // utility skill: AOE taunt around the player
    {

    }
    private void Cleave() // some time of AOE damage around the player
    {

    }
    private void Berserker()// Ultimate skill: cant be CC'd (maybe also attack speed up)
    {

    }
}
