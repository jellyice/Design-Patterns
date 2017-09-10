using UnityEngine;

public class AbstractRedPotion : Potion {
	MaterialFactory factory;

	public AbstractRedPotion(MaterialFactory factory) {
		this.factory = factory;
	}

	public override void prepare() {
		Debug.LogFormat("準備紅色藥草{0}", factory.createMaterial().toString());
	}

	public override void brew() {
		Debug.LogFormat("煉製{0}紅色藥水", factory.createProduct().toString());
	}

	public override void bottle() {
		Debug.LogFormat("裝瓶{0}紅色藥水", factory.createProduct().toString());
	}
}
