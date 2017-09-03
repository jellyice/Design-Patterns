using UnityEngine;

public class RedPotion : Potion {
	public override void prepare() {
		Debug.Log("準備紅色藥草");
	}

	public override void brew() {
		Debug.Log("煉製紅色藥水");
	}

	public override void bottle() {
		Debug.Log("裝瓶紅色藥水");
	}
}
