using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prezent : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string PlayerTag;
    void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == PlayerTag)
        {
            Destroy(gameObject);


        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
