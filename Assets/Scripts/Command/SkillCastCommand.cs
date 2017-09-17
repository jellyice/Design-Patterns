using UnityEngine;

public class SkillCastCommand : Command {
	Role caster;
	Role defender;
	Fireball fireball;

	public SkillCastCommand(Role caster, Role defender, Fireball fireball) {
		this.caster = caster;
		this.defender = defender;
		this.fireball = fireball;
	}

	public void execute() {
		Debug.Log("===Skill Cast===");
		caster.decrMp(fireball.getMpNeed());
		defender.decrHp(fireball.getEffect());
	}

	public void undo() {
		Debug.Log("===undo Skill Cast===");
		caster.incrMp(fireball.getMpNeed());
		defender.incrHp(fireball.getEffect());
	}
}
