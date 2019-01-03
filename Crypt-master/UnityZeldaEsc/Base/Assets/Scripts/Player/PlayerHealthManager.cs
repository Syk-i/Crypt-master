using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour {
    public int PlayerMaxHealth;
    public int playerCurrentHealth;
	// Use this for initialization
	void Start () {
        playerCurrentHealth = PlayerMaxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
