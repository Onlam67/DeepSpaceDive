using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 
/// This is the main game script which handles all the data of the game
/// Including player's stats, weapons, crafting materials
/// In charge on whole game cycle
/// 
/// </summary>
public class MainGameScript : MonoBehaviour
{
    #region Declaration
    enum Weapon
    {
        M123, M234, M345, M345_X, M2313_X, _WeaponMax
    }
    public struct Blueprint
    {
        Weapon _Weapon;
        int PartNumber;
    }
    public struct Loot
    {
        int _Money, _Steel, _Iron, _Gold;
        List<Blueprint> _BPList;
        public int Money { get { return _Money; } set { _Money = value; } }
        public int Steel { get { return _Steel; } set { _Steel = value; } }
        public int Iron { get { return _Iron; } set { _Iron = value; } }
        public int Gold { get { return _Gold; } set { _Gold = value; } }
        List<Blueprint> BPList { get { return _BPList; } set { _BPList = value; } }
    }
    #endregion

    #region Player Stats
    [Header("Player Stats")]
    public int MoneyGold;
    public int Gem;
    #region Materials
    [Header("Materials")]
    public int Steel_Count;
    public int Iron_Count;
    public int Gold_Count;
    #endregion
    #endregion

    #region Weapons and Jets
    [Header("Weapons and Jets")]
    public GameObject Weapon1;
    public GameObject Weapon2;
    public GameObject Heavy;
    public GameObject Jet;

    public GameObject CurrentWeapon;
    public GameObject CurrentHeavyWeapon;
    #endregion

    public static MainGameScript instance = null;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);

        // Code as Start() below
        GetData();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameStart()
    {
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Single);
    }

    void SwitchToGameScene()
    {
        SceneManager.LoadSceneAsync("GameScene", LoadSceneMode.Additive);
    }

    /// <summary>
    /// Get the data from the memory
    /// </summary>
    void GetData()
    {

    }

    /// <summary>
    /// When the game is finish, add the loots to the storage
    /// </summary>
    public void EndGameDataInsert(Loot loot)
    {
        MoneyGold += loot.Money;
        Steel_Count += loot.Steel;
        Iron_Count += loot.Iron;
        Gold_Count += loot.Gold;
        /// TODO
        /// Think how the blueprint works
        
    }

    /// <summary>
    /// Save the data to the memory
    /// </summary>
    void SaveData()
    {

    }
}
