using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(delegate { GameObject.Find("MainGameManager").GetComponent<MainGameScript>().GameStart(); });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
