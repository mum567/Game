using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanmove : MonoBehaviour
{
    Rigidbody2D humanRD;
    float walkSpeed = 15.0f;
    float maxSpeed = 3.0f;

    private KgGameBehavior gameManager;
    private AudioSource audioeat;

    // Start is called before the first frame update
    void Start()
    {
        humanRD = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("KgController").GetComponent<KgGameBehavior>();
        audioeat = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float speedx = Mathf.Abs(humanRD.velocity.x);

        if(speedx < maxSpeed)
        {
            if(Input.GetKey(KeyCode.LeftArrow) == true)
            {
                humanRD.AddForce(transform.right * -1 * walkSpeed);
                transform.localScale = new Vector3 (-0.5f, 0.5f, 0.5f);
		    }
            if(Input.GetKey(KeyCode.RightArrow) == true)
            {
                humanRD.AddForce(transform.right * walkSpeed);  
                transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		    }
		}
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if(col.gameObject.tag == "health")
        {
            gameManager.Kg  -= 10;
            audioeat.Play();
		}
        if(col.gameObject.tag == "fat")
        {
            gameManager.Kg += 10;  
            audioeat.Play();
		}
	}

    
}
