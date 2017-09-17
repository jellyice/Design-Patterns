using UnityEngine;

public class Role {
	Point point;

	public Point getPos() {
		return point;
	}

	public void setPos(Point point) {
		this.point = point;
		Debug.LogFormat("{0} go to {1}", GetType().Name, point);
	}

	public int getDamage() {
		return Random.Range(5, 11);
	}

	public void incrHp(int value) {
		Debug.LogFormat("{0} Hp + {1}", GetType().Name, value);
	}

	public void decrHp(int value) {
		Debug.LogFormat("{0} Hp - {1}", GetType().Name, value);
	}

	public void incrMp(int value) {
		Debug.LogFormat("{0} Mp + {1}", GetType().Name, value);
	}

	public void decrMp(int value) {
		Debug.LogFormat("{0} Mp - {1}", GetType().Name, value);
	}
}
