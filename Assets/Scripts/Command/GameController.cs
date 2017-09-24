using UnityEngine;

public class GameController {
	Command[] commands;

	public GameController() {
		commands = new Command[5];

		Command noCommand = new NoCommand();
		for (int i = 0; i < commands.Length; ++i) {
			commands[i] = noCommand;
		}
	}

	public void setCommand(int slot, Command command) {
		if (slot >= commands.Length)
			return;
		
		commands[slot] = command;
	}

	public void onButtonWasPushed(int slot) {
		commands[slot].execute();
	}

	public void onUndoButtonWasPushed(int slot) {
		commands[slot].undo();
	}

	public override string ToString() {
		string content = "======Game Controller======\n";
		for (int i = 0; i < commands.Length; ++i) {
			content += "[slot " + i + "] " + commands[i].GetType().Name + "\n";
		}
		return content;
	}
}

public struct Point {
	public int x;
	public int y;

	public Point(int x, int y) {
		this.x = x;
		this.y = y;
	}

	public override string ToString() {
		return "(" + x + ", " + y + ")";
	}
}
