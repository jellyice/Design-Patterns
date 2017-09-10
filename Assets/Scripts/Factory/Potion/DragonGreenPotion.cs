using UnityEngine;

public class DragonGreenPotion : Potion {
	public override void prepare() {
		Debug.Log("準備綠色藥草與龍血");
	}

	public override void brew() {
		Debug.Log("煉製龍血綠色藥水");
	}

	public override void bottle() {
		Debug.Log("裝瓶龍血綠色藥水");
	}
}
