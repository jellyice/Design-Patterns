using UnityEngine;

public class CryptGreenPotion : Potion {
	public override void prepare() {
		Debug.Log("準備綠色藥草與螢光苔");
	}

	public override void brew() {
		Debug.Log("煉製地穴綠色藥水");
	}

	public override void bottle() {
		Debug.Log("裝瓶地穴綠色藥水");
	}
}
