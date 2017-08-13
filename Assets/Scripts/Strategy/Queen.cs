public class Queen : Character {
	public Queen() {
		weapon = new KnifeBehavior();
	}

	public override void fight() {
		weapon.useWeapon();
	}
}
