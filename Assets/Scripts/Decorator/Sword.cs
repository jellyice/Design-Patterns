public class Sword : Weapon {
	public Sword() {
		name = "劍";
	}

	public override int getAtk() {
		return 10;
	}

	public override float getAtkInterval() {
		return 1.0f;
	}
}
