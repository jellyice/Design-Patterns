using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratorMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Weapon myWeapon = new RedGem(new Sword());
		Debug.Log(myWeapon.getDescription());
		myWeapon = new YellowGem(new Axe());
		Debug.Log(myWeapon.getDescription());
		myWeapon = new GreenGem(new Knife());
		Debug.Log(myWeapon.getDescription());
		myWeapon = new RedGem(new GreenGem(new YellowGem(new Sword())));
		Debug.Log(myWeapon.getDescription());
		myWeapon = new YellowGem(new GreenGem(new RedGem(new Sword())));
		Debug.Log(myWeapon.getDescription());
		myWeapon = new RedGem(new RedGem(new RedGem(new Axe())));
		Debug.Log(myWeapon.getDescription());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
