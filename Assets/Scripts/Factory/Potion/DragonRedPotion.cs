using UnityEngine;

public class DragonRedPotion : Potion {
	public override void prepare() {
		Debug.Log("準備紅色藥草與龍血");
	}

	public override void brew() {
		Debug.Log("煉製龍血紅色藥水");
	}

	public override void bottle() {
		Debug.Log("裝瓶龍血紅色藥水");
	}
}
