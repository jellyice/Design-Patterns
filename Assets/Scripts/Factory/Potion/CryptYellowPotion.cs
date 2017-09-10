using UnityEngine;

public class CryptYellowPotion : Potion {
	public override void prepare() {
		Debug.Log("準備黃色藥草與螢光苔");
	}

	public override void brew() {
		Debug.Log("煉製地穴黃色藥水");
	}

	public override void bottle() {
		Debug.Log("裝瓶地穴黃色藥水");
	}
}
