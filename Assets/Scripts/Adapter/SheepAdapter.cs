using UnityEngine;

public class SheepAdapter : Hero {
	Sheep sheep;

	public SheepAdapter(Sheep sheep) {
		this.sheep = sheep;
	}

	public void attack(object o) {
		Debug.Log("羊無法攻擊");
	}

	public void moveTo(Point pt) {
		sheep.stroll(pt);
	}

	public void speak(string words) {
		sheep.baa();
	}
}
