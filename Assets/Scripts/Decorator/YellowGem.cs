public class YellowGem : GemDecorator {
	private Weapon weapon;

	public YellowGem(Weapon w) {
		weapon = w;
	}

	public override string getName() {
		return weapon.getName() + " + 黃寶石";
	}

	public override int getAtk() {
		return weapon.getAtk() + 5;
	}

	public override float getAtkInterval() {
		return weapon.getAtkInterval() * 0.9f;
	}
}
