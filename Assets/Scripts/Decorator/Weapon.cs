public abstract class Weapon {
	protected string name;

	public virtual string getName() {
		return name;
	}

	public string getDescription() {
		return getName() + ", 攻擊力：" + getAtk() + ", 攻擊速度：" + getAtkInterval() + "秒/每下";
	}

	public abstract int getAtk();
	public abstract float getAtkInterval();
}
