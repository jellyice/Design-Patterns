using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandMain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameController gc = new GameController();

		Player player = new Player();
		Npc npc = new Npc();
		HealPotion healPotion = new HealPotion();
		Fireball fireball = new Fireball();
		Point point = new Point(10, 10);

		MoveCommand moveCommand = new MoveCommand(player, point);
		AttackCommand attackCommand = new AttackCommand(player, npc);
		SkillCastCommand skillCastCommand = new SkillCastCommand(player, npc, fireball);
		ItemUseCommand itemUseCommand = new ItemUseCommand(player, healPotion);
		Command[] commands = { moveCommand, attackCommand, skillCastCommand, itemUseCommand };
		MacroCommand macroCommand = new MacroCommand(commands);

		gc.setCommand(0, macroCommand);
		Debug.Log(gc.ToString());
		gc.onButtonWasPushed(0);
		gc.onUndoButtonWasPushed(0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
