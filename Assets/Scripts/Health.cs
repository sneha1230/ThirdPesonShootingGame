using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    int startHealth = 3;
    [SerializeField]
    int currentHealth;
    public bool isPlayerAlive = true;
    public static Health instance;

    //public ParticleSystem particleEffect;
    private void OnEnable()
    {
        currentHealth = startHealth;
    }
    private void Awake()
    {
        instance = this;
    }
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        //particleEffect.Play();
        gameObject.SetActive(false);
        if (gameObject.tag == "Player")
        {
            isPlayerAlive = false;
        }
    }
}
