public class GreenGem : GemDecorator {
	private Weapon weapon;

	public GreenGem(Weapon w) {
		weapon = w;
	}

	public override string getName() {
		return weapon.getName() + " + 綠寶石";
	}

	public override int getAtk() {
		return weapon.getAtk();
	}

	public override float getAtkInterval() {
		return weapon.getAtkInterval() * 0.8f;
	}
}
