public class Axe : Weapon {
	public Axe() {
		name = "斧";
	}

	public override int getAtk() {
		return 15;
	}

	public override float getAtkInterval() {
		return 2.0f;
	}
}
