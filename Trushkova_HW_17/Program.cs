// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, Teacher!");

string melody = "987 876 765 654 543 432 111 8";
int oktava = 1;
int length = 1000;
Note[] notes = MelodyParser.ParseMelody(melody, length, oktava);
Player.Play(notes);
