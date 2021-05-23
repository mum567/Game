using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenMaker : MonoBehaviour
{
    public GameObject ChickenPrefab;

    float span = 2.5f;
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
            GameObject go = Instantiate(ChickenPrefab) as GameObject;

            float gox = Random.Range(-7.0f, 7.5f);
            go.transform.position = new Vector3 (gox, 5.5f, 0);
		}
    }
}