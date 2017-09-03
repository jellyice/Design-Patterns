public class StaticPotionStore {
	public Potion orderPotion(PotionType type) {
		Potion potion = StaticPotionFactory.createPotion(type);
		potion.prepare();
		potion.brew();
		potion.bottle();
		return potion;
	}
}
