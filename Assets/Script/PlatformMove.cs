using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -3) * Time.deltaTime;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }
}
