public abstract class AbstractPotionStore {
	public Potion orderPotion(PotionType type) {
		Potion potion = createPotion(type);
		potion.prepare();
		potion.brew();
		potion.bottle();
		return potion;
	}

	protected abstract Potion createPotion(PotionType type);
}
