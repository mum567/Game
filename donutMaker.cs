using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donutMaker : MonoBehaviour
{
    public GameObject donutPrefab;

    float span = 3.5f;
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
            GameObject go = Instantiate(donutPrefab) as GameObject;

            float gox = Random.Range(-7.2f, 7.3f);
            go.transform.position = new Vector3 (gox, 5.5f, 0);
		}
    }
}