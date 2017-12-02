using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SheepAdapter sheepHero = new SheepAdapter(new Sheep());
		sheepHero.attack(null);
		sheepHero.moveTo(new Point(3, 3));
		sheepHero.speak("嗨");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
