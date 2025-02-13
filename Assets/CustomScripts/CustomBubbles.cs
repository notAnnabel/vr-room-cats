using UnityEngine;

public class CustomBubbles : MonoBehaviour
{
    [Tooltip("the object that will be spawned")]
    public GameObject prefab = null;

    [Tooltip("the transform where the object is spawned")]
    public Transform spawnTransform = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Spawn(){
        // create bubble 
        GameObject bubble = Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
        bubble.transform.rotation = Random.rotation; // random bubble rotation!
        float launchSpeed = Random.Range(0.5f, 1.5f);

        // create Vector3 to represent forward movement force 
        Vector3 force = spawnTransform.forward * launchSpeed; // forward vector is pos x axis

        bubble.GetComponent<Rigidbody>().AddForce(force);
        bubble.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-1f, 1f),Random.Range(-1f, 1f),Random.Range(-1f, 1f))); // spinning force

    }
}
