public class LockSettings {
	static LockSettings instance;

	static object _lock = new object();

	private LockSettings() {
	}

	public static LockSettings getInstance() {
		if (instance == null) {
			lock (_lock) {
				if (instance == null) {
					instance = new LockSettings();
				}
			}
		}
		return instance;
	}

	public float volume = 0.0f;
}
