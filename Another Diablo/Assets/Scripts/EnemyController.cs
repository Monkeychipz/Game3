using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public float maxHealth;
    public float currentHealth;

	// Use this for initialization
	void Start () {
        maxHealth = 10f;
        currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        Death();
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "BasicAttack")
        {
            HurtEnemy(collision.gameObject.GetComponentInParent<WarriorController>().strength);
        }
    }

    public void HurtEnemy(float damage)
    {
        currentHealth -= damage;
    }

    public void Death()
    {
        if(currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
