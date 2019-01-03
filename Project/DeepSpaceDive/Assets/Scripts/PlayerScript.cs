using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// Handle player data and control when the player is alive
/// 
/// </summary>
public class PlayerScript : MonoBehaviour
{
    public float HP;
    public float MaxHP;
    public uint Level;
    public GameObject Weapon;
    public GameObject HeavyWeapon;
    public bool IsImmune;
    public bool IsAttackBuffing;
    public bool IsAlive = true;
    public bool IsMobile;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsAlive)
        {
            PlayerControl();
        }
        else
        {
            Endgame();
        }

    }

    void PlayerControl()
    {

    }

    void Endgame()
    {

    }

    public void HPBuff()
    {

    }

    public void AttackBuff()
    {

    }
}
