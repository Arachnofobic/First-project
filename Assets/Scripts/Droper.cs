using UnityEngine;

public class Droper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rb;
    [SerializeField] float delay = 3f;
    
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled=false;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;

    }

    
    void Update()
    {
        if (Time.time > delay)
        {
            renderer.enabled = true;
            rb.useGravity = true;
        }
    }
    
    
}

