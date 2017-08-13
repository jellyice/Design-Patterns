public class Troll : Character {
	public Troll() {
		weapon = new AxeBehavior();
	}

	public override void fight() {
		weapon.useWeapon();
	}
}
