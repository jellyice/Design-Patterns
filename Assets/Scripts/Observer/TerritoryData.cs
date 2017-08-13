using System.Collections.Generic;

public class TerritoryData : Subject {
	private List<Observer> observerList = new List<Observer>();
	private bool isChanged = false;

	private int _people = 10000;
	private int _money = 10000;
	private int _wood = 10000;
	private int _iron = 10000;

	public int people { 
		get {
			return _people;
		}
	}
	public int money { 
		get {
			return _money;
		}
	}
	public int wood { 
		get {
			return _wood;
		}
	}
	public int iron { 
		get {
			return _iron;
		}
	}

	public void setData(int people, int money, int wood, int iron) {
		_people = people;
		_money = money;
		_wood = wood;
		_iron = iron;
		setChanged();
		notifyObservers();
	}

	public void addObserver(Observer o) {
		observerList.Add(o);
	}

	public void removeObserver(Observer o) {
		observerList.Remove(o);
	}

	public void notifyObservers() {
		if (isChanged) {
			foreach (Observer o in observerList) {
				o.update();
			}
		}
	}

	public void setChanged() {
		isChanged = true;
	}

	public void clearChanged() {
		isChanged = false;
	}

	public bool hasChanged() {
		return isChanged;
	}
}
