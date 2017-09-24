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

		Point npcPoint = new Point(0, 1);
		MoveCommand npcMoveCommand = new MoveCommand(npc, npcPoint);
		gc.setCommand(0, npcMoveCommand);
		AttackCommand npcAttackCommand = new AttackCommand(npc, player);
		gc.setCommand(1, npcAttackCommand);
		SkillCastCommand npcSkillCastCommand = new SkillCastCommand(npc, player, fireball);
		gc.setCommand(2, npcSkillCastCommand);
		ItemUseCommand npcItemUseCommand = new ItemUseCommand(npc, healPotion);
		gc.setCommand(3, npcItemUseCommand);

		Point playerPoint = new Point(1, 1);
		MoveCommand moveCommand = new MoveCommand(player, playerPoint);
		AttackCommand attackCommand = new AttackCommand(player, npc);
		SkillCastCommand skillCastCommand = new SkillCastCommand(player, npc, fireball);
		ItemUseCommand itemUseCommand = new ItemUseCommand(player, healPotion);
		Command[] commands = { moveCommand, attackCommand, skillCastCommand, itemUseCommand };
		MacroCommand macroCommand = new MacroCommand(commands);
		gc.setCommand(4, macroCommand);

		Debug.Log(gc.ToString());
		gc.onButtonWasPushed(0);
		gc.onButtonWasPushed(1);
		gc.onButtonWasPushed(2);
		gc.onButtonWasPushed(3);
		gc.onButtonWasPushed(4);
		gc.onUndoButtonWasPushed(4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
