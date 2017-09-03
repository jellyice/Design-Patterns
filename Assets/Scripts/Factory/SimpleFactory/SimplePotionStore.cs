public class SimplePotionStore {
	SimplePotionFactory factory;

	public SimplePotionStore(SimplePotionFactory factory) {
		this.factory = factory;
	}

	public Potion orderPotion(PotionType type) {
		Potion potion = factory.createPotion(type);
		potion.prepare();
		potion.brew();
		potion.bottle();
		return potion;
	}
}
