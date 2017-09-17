using UnityEngine;

public class ItemUseCommand : Command {
	Role user;
	HealPotion potion;
	int effect;

	public ItemUseCommand(Role user, HealPotion potion) {
		this.user = user;
		this.potion = potion;
		effect = 0;
	}

	public void execute() {
		Debug.Log("===Item Use===");
		effect = potion.getEffect();
		user.incrHp(effect);
	}

	public void undo() {
		Debug.Log("===undo Item Use===");
		user.decrHp(effect);
	}
}
