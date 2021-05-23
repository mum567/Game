
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blueControl : MonoBehaviour
{
    public GameObject bluePrefab;
    public GameObject chickenHeart;

    float span = 2.2f;
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
            GameObject gogo = Instantiate(chickenHeart) as GameObject;

            //GameObject go = Instantiate(chickenHeart) as GameObject;
            float px = Random.Range(-8.5f,8.7f);
            float chickenx = Random.Range(-8.0f, 8.0f);
            go.transform.position = new Vector3 (px, 5.5f, 0);
            gogo.transform.position = new Vector3(chickenx, 5.5f, 0);
         }
    }
}
