using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		TerritoryData subject = new TerritoryData();
		subject.addObserver(new BuildPage(subject));
		subject.addObserver(new StatisticPage(subject));
		subject.setData(2000, 1000, 3000, 4000);
		subject.setData(12000, 1000, 13000, 4000);
		subject.setData(2000, 11000, 3000, 14000);
		subject.setData(1000, 1000, 1000, 1000);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
