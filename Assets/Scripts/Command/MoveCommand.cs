using UnityEngine;

public class MoveCommand : Command {
	Role mover;
	Point oldPoint;
	Point newPoint;

	public MoveCommand(Role mover, Point target) {
		this.mover = mover;
		newPoint = target;
	}

	public void execute() {
		Debug.Log("===Move===");
		oldPoint = mover.getPos();
		mover.setPos(newPoint);
	}

	public void undo() {
		Debug.Log("===undo Move===");
		mover.setPos(oldPoint);
	}
}
