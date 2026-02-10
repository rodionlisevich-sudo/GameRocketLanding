using UnityEngine;

public class LandingPlatformRandomTransform : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(Random.Range(-50f, 50f), 0, 0);
    }
    void Update()
    {
        
    }
}
