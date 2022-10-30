using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnHealth : MonoBehaviour
{
    //public HealthBar healthBar;
    public int maxHealth = 100;
    public int currentHealth;
    //public Animator DeathAnim;

    // Start is called before the first frame update
    void Start()
    {
        //healthBar.SetMaxHealth(maxHealth);
        currentHealth = maxHealth;
    }

    public void TakeDamage2(int damage2)
    {
        // Play sound here

        currentHealth -= damage2;
        //healthBar.SetHealth(maxHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Heal(int amount)
    {
        // Play sound here

        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

}
////public HealthBar healthBar;
//public int health = 100;


//	//public GameObject deathEffect;

//	void Start()
//	{
//		//healthBar.SetMaxHealth(health);
//	}

//	public void TakeDamage(int damage)
//	{
//		health -= damage;
//		//healthBar.SetHealth(health);
//		if (health <= 0)
//		{
//			Die();
//		}
//	}

//	void Die()
//	{
//		//Instantiate(deathEffect, transform.position, Quaternion.identity);
//		Destroy(gameObject);
//	}

//}
//    public HealthBar healthBar;
//    public int maxHealth = 100;
//    public int currentHealth;
//    public Animator DeathAnim;

//    // Start is called before the first frame update
//    void Start()
//    {
//        healthBar.SetMaxHealth(maxHealth);
//        currentHealth = maxHealth;
//    }

//    public void TakeDamage(int damage)
//    {
//        // Play sound here

//        currentHealth -= damage;
//        healthBar.SetHealth(maxHealth);

//        if (currentHealth <= 0)
//        {
//            // were death
//            // play death animation
//            DeathAnim.SetBool("Dead", true);
//            // show gameover screen
//        }
//    }

//    public void Heal(int amount)
//    {
//        // Play sound here

//        currentHealth += amount;

//        if (currentHealth > maxHealth)
//        {
//            currentHealth = maxHealth;
//        }
//    }

//}

