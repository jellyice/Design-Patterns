using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyMain : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Character role = new King();
		role.fight();
		role.setWeapon(new AxeBehavior());
		role.fight();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
