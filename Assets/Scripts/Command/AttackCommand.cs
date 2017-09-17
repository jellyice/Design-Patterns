using UnityEngine;

public class AttackCommand : Command {
	Role attacker;
	Role defender;
	int damage;

	public AttackCommand(Role attacker, Role defender) {
		this.attacker = attacker;
		this.defender = defender;
		damage = 0;
	}

	public void execute() {
		Debug.Log("===Attack===");
		damage = attacker.getDamage();
		defender.decrHp(damage);
	}

	public void undo() {
		Debug.Log("===undo Attack===");
		defender.incrHp(damage);
	}
}
