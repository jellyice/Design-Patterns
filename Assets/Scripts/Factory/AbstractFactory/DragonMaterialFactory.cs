public class DragonMaterialFactory : MaterialFactory {
	public Material createMaterial() {
		return new DragonMaterial();
	}

	public Product createProduct() {
		return new DragonProduct();
	}
}
