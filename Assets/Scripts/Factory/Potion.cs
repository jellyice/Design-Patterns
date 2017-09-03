public abstract class Potion {
	public abstract void prepare();
	public abstract void brew();
	public abstract void bottle();
}

public enum PotionType {
	PT_RedPotion,
	PT_GreenPotion,
	PT_YellowPotion
}
