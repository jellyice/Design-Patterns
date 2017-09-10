using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("=======================簡易工廠=======================");
		SimplePotionStore simpleStore = new SimplePotionStore(new SimplePotionFactory());
		simpleStore.orderPotion(PotionType.PT_RedPotion);
		simpleStore.orderPotion(PotionType.PT_GreenPotion);
		simpleStore.orderPotion(PotionType.PT_YellowPotion);

		Debug.Log("=======================靜態工廠=======================");
		StaticPotionStore staticStore = new StaticPotionStore();
		staticStore.orderPotion(PotionType.PT_RedPotion);
		staticStore.orderPotion(PotionType.PT_GreenPotion);
		staticStore.orderPotion(PotionType.PT_YellowPotion);

		Debug.Log("=======================工廠方法=======================");
		MethodPotionStore methodStore = new DragonPotionStore();
		methodStore.orderPotion(PotionType.PT_RedPotion);
		methodStore.orderPotion(PotionType.PT_GreenPotion);
		methodStore.orderPotion(PotionType.PT_YellowPotion);
		methodStore = new CryptPotionStore();
		methodStore.orderPotion(PotionType.PT_RedPotion);
		methodStore.orderPotion(PotionType.PT_GreenPotion);
		methodStore.orderPotion(PotionType.PT_YellowPotion);

		Debug.Log("=======================抽象工廠=======================");
		AbstractPotionStore abstractStore = new AbstractDragonPotionStore();
		abstractStore.orderPotion(PotionType.PT_RedPotion);
		abstractStore.orderPotion(PotionType.PT_GreenPotion);
		abstractStore.orderPotion(PotionType.PT_YellowPotion);
		abstractStore = new AbstractCryptPotionStore();
		abstractStore.orderPotion(PotionType.PT_RedPotion);
		abstractStore.orderPotion(PotionType.PT_GreenPotion);
		abstractStore.orderPotion(PotionType.PT_YellowPotion);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
