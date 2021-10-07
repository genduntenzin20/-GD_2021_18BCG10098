using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public float interval = 7f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
