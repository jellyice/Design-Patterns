public interface Subject {
	void addObserver(Observer o);
	void removeObserver(Observer o);
	void notifyObservers();
	void setChanged();
	void clearChanged();
	bool hasChanged();
}
