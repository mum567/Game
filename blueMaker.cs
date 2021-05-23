using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueMaker : MonoBehaviour
{
    public GameObject bluePrefab;

    float span = 2.1f;
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
            GameObject go = Instantiate(bluePrefab) as GameObject;

            float gox = Random.Range(-7.8f, 7.8f);
            go.transform.position = new Vector3 (gox, 5.5f, 0);
		}
    }
}
