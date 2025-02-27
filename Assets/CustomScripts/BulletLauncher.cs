using UnityEngine;

public class BulletLauncher : MonoBehaviour
{
    [Tooltip("the bullet that will be spawned")]
    public GameObject prefab = null;

    [Tooltip("the transform where the bullet is spawned")]
    public Transform spawnTransform = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Spawn(){
        // create bubble 
        GameObject bullet = Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
        bullet.transform.rotation = Random.rotation; // random bubble rotation!
        float launchSpeed = 70f;

        // create Vector3 to represent forward movement force 
        Vector3 force = spawnTransform.forward * launchSpeed; // forward vector is pos x axis

        bullet.GetComponent<Rigidbody>().AddForce(force);
        
    }
}


