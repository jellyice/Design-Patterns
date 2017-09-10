public class Settings {
	static Settings instance;

	private Settings() {
	}

	public static Settings getInstance() {
		if (instance == null) {
			instance = new Settings();
		}
		return instance;
	}

	public float volume = 0.0f;
}
