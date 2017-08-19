public class RedGem : GemDecorator {
	private Weapon weapon;

	public RedGem(Weapon w) {
		weapon = w;
	}

	public override string getName() {
		return weapon.getName() + " + 紅寶石";
	}

	public override int getAtk() {
		return weapon.getAtk() + 10;
	}

	public override float getAtkInterval() {
		return weapon.getAtkInterval();
	}
}
