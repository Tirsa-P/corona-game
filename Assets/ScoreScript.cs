using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreScript : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            Destroy(collision.collider.gameObject);
        }
        else if (collision.collider.CompareTag("capsule"))
        { 
            Destroy(collision.collider.gameObject);
        }
    }
 
}
