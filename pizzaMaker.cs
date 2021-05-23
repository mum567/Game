using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pizzaMaker : MonoBehaviour
{
    public GameObject pizzaPrefab;

    float span = 4.1f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(pizzaPrefab) as GameObject;

            float gox = Random.Range(-7.3f, 7.1f);
            go.transform.position = new Vector3 (gox, 5.5f, 0);
		}
    }
}
