// See https://aka.ms/new-console-template for more information

using WizardsandWarriors.Models;

var party = new List<Player>();

var player1 = new Warrior();
var player2 = new Wizard();

player1.EquippedWeapon = new Staff();
player2.EquippedWeapon = new Sword();

party.Add(player1);
party.Add(player2);