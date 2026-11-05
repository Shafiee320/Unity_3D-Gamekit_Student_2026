using UnityEngine;
using Gamekit3D;
public class HealthPickup : MonoBehaviour
{
    Damageable damageable;
    HungerManager hungerManager;
    BoxCollider healthCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageable=GameObject.Find("Ellen").GetComponent<Damageable>();
        hungerManager=GameObject.Find("Ellen").GetComponent<HungerManager>();
        healthCollider=gameObject.GetComponent<BoxCollider>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            damageable.ResetDamage();
            hungerManager.ResetTimer();
            Destroy((gameObject));
            
        }
    }
    
}
