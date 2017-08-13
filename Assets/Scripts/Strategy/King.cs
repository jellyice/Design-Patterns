public class King : Character {
	public King() {
		weapon = new SwordBehavior();
	}

	public override void fight() {
		weapon.useWeapon();
	}
}
