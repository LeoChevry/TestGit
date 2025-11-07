using System;
using UnityEngine;
using UnityEngine.Events;

public interface IDamageable
{
    event UnityAction<int> OnDamage;
    
    void TakeDamage(int amount);
}


public interface IKillable
{
    event UnityAction OnDeath;

    void Die();
}

public class HealthComponent : MonoBehaviour, IKillable, IDamageable
{
    public int CurrentHealth = 100;
    public int MaxHealth = 100;
    
    public event UnityAction<int> OnDamage;
    public event UnityAction OnDeath;
    
    private void Awake()
    {
        CurrentHealth = MaxHealth;
    }


    public void Die()
    {
        Debug.Log("I died");
        OnDeath?.Invoke();
    }


    public void TakeDamage(int amount)
    {
        CurrentHealth -= amount;
        
        Debug.Log("Took damage");
        
        OnDamage?.Invoke(amount);
        
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }
}
