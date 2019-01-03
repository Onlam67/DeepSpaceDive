using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffScript : MonoBehaviour {
    enum Types
    {
        Attack, HP, BluePrint, Material
    };
    Types BuffType;
    float timer;

	// Use this for initialization
	void Start ()
    {
        /// TODO
        /// Get the current level

        //BuffType = (Types)Random.Range((int)Types.Attack,(int)Types.Material);    //Dont do in this way, otherwise the chance will be equal


    }

    // Update is called once per frame
    void Update ()
    {
		/// TODO
        /// Bounce the buff within the map
        /// If it is not blueprint, kill the buff after certain second
        /// Else, keep bouncing in the map
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name=="Player")
        {
            switch (BuffType)
            {
                case Types.Attack:
                    collision.gameObject.GetComponent<PlayerScript>().AttackBuff();
                    break;
                case Types.HP:
                    collision.gameObject.GetComponent<PlayerScript>().HPBuff();
                    break;
                case Types.BluePrint:
                    /// TODO
                    /// Get the current lv
                    /// then randomly drop blueprint based on lv
                    break;
                case Types.Material:
                    /// TODO
                    /// Same as Blueprint
                    break;
                default:
                    break;
            }
        }
    }
}
