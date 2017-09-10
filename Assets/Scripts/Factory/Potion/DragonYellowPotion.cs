using UnityEngine;

public class DragonYellowPotion : Potion {
	public override void prepare() {
		Debug.Log("準備黃色藥草與龍血");
	}

	public override void brew() {
		Debug.Log("煉製龍血黃色藥水");
	}

	public override void bottle() {
		Debug.Log("裝瓶龍血黃色藥水");
	}
}
