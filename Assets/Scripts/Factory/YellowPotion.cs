using UnityEngine;

public class YellowPotion : Potion {
	public override void prepare() {
		Debug.Log("準備黃色藥草");
	}

	public override void brew() {
		Debug.Log("煉製黃色藥水");
	}

	public override void bottle() {
		Debug.Log("裝瓶黃色藥水");
	}
}
