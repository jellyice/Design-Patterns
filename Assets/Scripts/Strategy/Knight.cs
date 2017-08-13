public class Knight : Character {
	public Knight() {
		weapon = new BowAndArrowBehavior();
	}

	public override void fight() {
		weapon.useWeapon();
	}
}
