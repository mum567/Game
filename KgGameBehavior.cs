using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KgGameBehavior : MonoBehaviour
{
    private int MinsooWeight = 110;

    public int Kg
    {
        get{return MinsooWeight; }
        set
        {
              MinsooWeight = value;
              Debug.LogFormat("kg : {0}", MinsooWeight);

              if( MinsooWeight <= 60)
              {
                    SceneManager.LoadScene("winScene");     
			  }
              if(MinsooWeight >= 170)
              {
                    SceneManager.LoadScene("loseScene");     
			  }
		}
	}

    void OnGUI()
    {
        GUI.Box(new Rect(30,30,180,30), "Minsoo Weight : " + MinsooWeight);
        //GUI.Label(new Rect(Screen.width / 2 -100, Screen.height - 50, 300, 50), labelText)
	}
}
