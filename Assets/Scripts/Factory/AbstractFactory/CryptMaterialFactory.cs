public class CryptMaterialFactory : MaterialFactory {
	public Material createMaterial() {
		return new CryptMaterial();
	}

	public Product createProduct() {
		return new CryptProduct();
	}
}
