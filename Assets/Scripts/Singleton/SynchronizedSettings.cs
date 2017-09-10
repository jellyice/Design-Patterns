using System.Runtime.CompilerServices;

public class SynchronizedSettings {
	static SynchronizedSettings instance;

	private SynchronizedSettings() {
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static SynchronizedSettings getInstance() {
		if (instance == null) {
			instance = new SynchronizedSettings();
		}
		return instance;
	}

	public float volume = 0.0f;
}
