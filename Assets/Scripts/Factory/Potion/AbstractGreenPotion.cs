using UnityEngine;

public class AbstractGreenPotion : Potion {
	MaterialFactory factory;

	public AbstractGreenPotion(MaterialFactory factory) {
		this.factory = factory;
	}

	public override void prepare() {
		Debug.LogFormat("準備綠色藥草{0}", factory.createMaterial().ToString());
	}

	public override void brew() {
		Debug.LogFormat("煉製{0}綠色藥水", factory.createProduct().ToString());
	}

	public override void bottle() {
		Debug.LogFormat("裝瓶{0}綠色藥水", factory.createProduct().ToString());
	}
}
