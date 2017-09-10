public class DragonPotionStore : MethodPotionStore {
	protected override Potion createPotion(PotionType type) {
		switch (type) {
			case PotionType.PT_RedPotion:
				return new DragonRedPotion();
			case PotionType.PT_GreenPotion:
				return new DragonGreenPotion();
			case PotionType.PT_YellowPotion:
				return new DragonYellowPotion();
		}
		return null;
	}
}
