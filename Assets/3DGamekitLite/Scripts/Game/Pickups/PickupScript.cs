using UnityEngine;
using Gamekit3D;
using UnityEngine.Events;
public class PickupScript : MonoBehaviour
{
    [SerializeField] GameObject Pickup;
    [SerializeField] private float yAxis;
    public void SpawnPickup()
    {
        Instantiate(Pickup, transform.position+new Vector3(0,yAxis), transform.rotation);
    }
    
}
