using UnityEngine;
using Gamekit3D;

public class HungerManager : MonoBehaviour
{
    [SerializeField] private float hungerTime=10f;
    private float timer = 0f;
    Damageable damageable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       damageable=gameObject.GetComponent<Damageable>();


    }



    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= hungerTime)
        {
            DealDamage();
            timer = 0f; 
            
        }
        

    }

    void DealDamage()
    {
        Damageable.DamageMessage hunger = new Damageable.DamageMessage()
        {
            amount = 1,
            damager = this,
            direction = Vector3.zero,
            damageSource = Vector3.zero,
            throwing = false,
            stopCamera = false,  
            
        };
        damageable.ApplyDamage(hunger);
    }


}
