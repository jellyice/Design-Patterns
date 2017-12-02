using UnityEngine;

public class Sheep {
	public void stroll(Point pt) {
		Debug.LogFormat("羊漫步到座標：{0}", pt);
	}

	public void baa() {
		Debug.Log("咩~~");
	}
}
