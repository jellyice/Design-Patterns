public class Knife : Weapon {
	public Knife() {
		name = "匕首";
	}

	public override int getAtk() {
		return 5;
	}

	public override float getAtkInterval() {
		return 0.5f;
	}
}
