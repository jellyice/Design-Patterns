public class CryptPotionStore : MethodPotionStore {
	protected override Potion createPotion(PotionType type) {
		switch (type) {
			case PotionType.PT_RedPotion:
				return new CryptRedPotion();
			case PotionType.PT_GreenPotion:
				return new CryptGreenPotion();
			case PotionType.PT_YellowPotion:
				return new CryptYellowPotion();
		}
		return null;
	}
}
