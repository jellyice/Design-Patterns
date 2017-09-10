public class EagerlySettings {
	static EagerlySettings instance = new EagerlySettings();

	private EagerlySettings() {
	}

	public static EagerlySettings getInstance() {
		return instance;
	}

	public float volume = 0.0f;
}
