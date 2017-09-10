using UnityEngine;

public class AbstractYellowPotion : Potion {
	MaterialFactory factory;

	public AbstractYellowPotion(MaterialFactory factory) {
		this.factory = factory;
	}

	public override void prepare() {
		Debug.LogFormat("準備黃色藥草{0}", factory.createMaterial().toString());
	}

	public override void brew() {
		Debug.LogFormat("煉製{0}黃色藥水", factory.createProduct().toString());
	}

	public override void bottle() {
		Debug.LogFormat("裝瓶{0}黃色藥水", factory.createProduct().toString());
	}
}
