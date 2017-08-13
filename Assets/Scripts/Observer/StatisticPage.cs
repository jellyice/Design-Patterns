using UnityEngine;

public class StatisticPage : Observer, DisplayInterface {
	private int _people;
	private int _money;
	private int _wood;
	private int _iron;
	private Subject _subject;

	public StatisticPage(Subject subject) {
		_subject = subject;
	}

	public void update() {
		if (_subject is TerritoryData) {
			TerritoryData td = _subject as TerritoryData;
			_people = td.people;
			_money = td.money;
			_wood = td.wood;
			_iron = td.iron;
			display();
		}
	}

	public void display() {
		Debug.Log("People:" + _people + "\tMoney:" + _money + "\nWood:" + _wood + "\tIron:" + _iron);
	}
}
