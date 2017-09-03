using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		SimplePotionStore simpleStore = new SimplePotionStore(new SimplePotionFactory());
		simpleStore.orderPotion(PotionType.PT_RedPotion);
		simpleStore.orderPotion(PotionType.PT_GreenPotion);
		simpleStore.orderPotion(PotionType.PT_YellowPotion);

		StaticPotionStore staticStore = new StaticPotionStore();
		staticStore.orderPotion(PotionType.PT_RedPotion);
		staticStore.orderPotion(PotionType.PT_GreenPotion);
		staticStore.orderPotion(PotionType.PT_YellowPotion);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
