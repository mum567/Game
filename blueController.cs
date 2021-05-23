using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.FindWithTag("human");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.01f, 0);

        if(transform.position.y < -5.5f)
        {
            Destroy(gameObject);  
		}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "human")
        {
            Destroy(gameObject);
		}
        
	}
}
