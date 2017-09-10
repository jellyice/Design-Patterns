using UnityEngine;

public class CryptRedPotion : Potion {
	public override void prepare() {
		Debug.Log("準備紅色藥草與螢光苔");
	}

	public override void brew() {
		Debug.Log("煉製地穴紅色藥水");
	}

	public override void bottle() {
		Debug.Log("裝瓶地穴紅色藥水");
	}
}
