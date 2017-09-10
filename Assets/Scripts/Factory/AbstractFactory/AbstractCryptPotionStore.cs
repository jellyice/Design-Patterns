public class AbstractCryptPotionStore : AbstractPotionStore {
	protected override Potion createPotion(PotionType type) {
		MaterialFactory factory = new CryptMaterialFactory();

		switch (type) {
			case PotionType.PT_RedPotion:
				return new AbstractRedPotion(factory);
			case PotionType.PT_GreenPotion:
				return new AbstractGreenPotion(factory);
			case PotionType.PT_YellowPotion:
				return new AbstractYellowPotion(factory);
		}
		return null;
	}
}
