using UnityEngine;

public class BuildPage : Observer, DisplayInterface {
	private int _people;
	private int _money;
	private int _wood;
	private int _iron;
	private int _peopleNeed = 1000;
	private int _moneyNeed = 2000;
	private int _woodNeed = 3000;
	private int _ironNeed = 4000;
	private Subject _subject;

	public BuildPage(Subject subject) {
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
		string output = "";

		if (_peopleNeed > _people)
			output += "People isn't enough(Need " + _peopleNeed + ").";
		else
			output += "People is enough.";

		if (_moneyNeed > _money)
			output += "\tMoney isn't enough(Need " + _moneyNeed + ").";
		else
			output += "\tMoney is enough.";

		if (_woodNeed > _wood)
			output += "\nWood isn't enough(Need " + _woodNeed + ").";
		else
			output += "\nWood is enough.";

		if (_ironNeed > _iron)
			output += "\tIron isn't enough(Need " + _ironNeed + ").";
		else
			output += "\tIron is enough.";
		
		Debug.Log(output);
	}
}
