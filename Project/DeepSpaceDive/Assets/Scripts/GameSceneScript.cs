using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 
/// Manage the game cycle when player click "play"
/// including spawning enemies , spawning buffs and counting score
/// 
/// When the game starts, initial a new player
/// Get the data, stats and GameObject from the MainScene/GameManager/MainGameScript
/// Destroy this clone when the game end
/// 
/// </summary>
public class GameSceneScript : MonoBehaviour {

    public GameObject Player;
    MainGameScript _MainGameScript;
    Scene scene;
    public int Lv;
	// Use this for initialization
	void Start ()
    {
        _MainGameScript = GameObject.Find("MainGameManager").GetComponent<MainGameScript>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReturnToMain()
    {
        MainGameScript.Loot loot = new MainGameScript.Loot();
        loot.Gold = 1;
        loot.Money = 2;
        _MainGameScript.EndGameDataInsert(loot);
        SceneManager.LoadSceneAsync("MainScene", LoadSceneMode.Single);
    }
}
