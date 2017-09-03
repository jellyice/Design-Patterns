using UnityEngine;

public class GreenPotion : Potion {
	public override void prepare() {
		Debug.Log("準備綠色藥草");
	}

	public override void brew() {
		Debug.Log("煉製綠色藥水");
	}

	public override void bottle() {
		Debug.Log("裝瓶綠色藥水");
	}
}
