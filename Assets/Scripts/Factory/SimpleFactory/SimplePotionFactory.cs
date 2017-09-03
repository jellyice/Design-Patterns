public class SimplePotionFactory {
	public Potion createPotion(PotionType type) {
		switch (type) {
			case PotionType.PT_RedPotion:
				return new RedPotion();
			case PotionType.PT_GreenPotion:
				return new GreenPotion();
			case PotionType.PT_YellowPotion:
				return new YellowPotion();
		}
		return null;
	}
}
