using UnityEngine;
using Gamekit3D;
public class HealthPickup : MonoBehaviour
{
    Damageable damageable;
    BoxCollider healthCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damageable=GameObject.Find("Ellen").GetComponent<Damageable>();
        healthCollider=gameObject.GetComponent<BoxCollider>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            damageable.ResetDamage();
            Destroy((gameObject));
            
        }
    }
    
}
