using System;
using UnityEngine;
using System.Collections.Generic;
using System.Text;
using System.IO;

public  enum Quadrant{ TopRight, Top, TopLeft, MiddleRight, Middle, MiddleLeft, BottomRight, Bottom, BottomLeft};

public class Move {
	public 	List<Quadrant> points;

	public Move(){
		points = new List<Quadrant> ();
	}
	public void Add(Quadrant point){
		points.Add (point);
	}
}

public class Level {
	public List<Move> moves;
	public int difficulty;
	public Level(int difficlulty){
		moves = new List<Move> ();
		this.difficulty = difficlulty;
	}
	public void Add (Move move){
		moves.Add (move);
	}
}

public class GameController : MonoBehaviour {
	public GameObject[] quadrants;
	public float setTime;
	float timer;

	private Level CreateLevel (string filename, int diff){
		Level level = new Level (diff);
		try{
			string line;
			StreamReader theReader = new StreamReader(filename, Encoding.Default);
			using (theReader){
				do{
					line = theReader.ReadLine();
					if(line != null){
						string[] entry = line.Split (',');
						if(entry.Length > 1){
							if(Convert.ToInt32(entry[0]) == level.difficulty){
								Move move = new Move();
								for (int i = 1; i < entry.Length; i++){
									Quadrant q =(Quadrant) Enum.Parse (typeof(Quadrant),entry[i]);
									move.Add(q);
								}
								level.Add (move);
							}
						}
					}
				}
				while(line != null);
				theReader.Close ();
			}
			return level;
		}
		catch (Exception e)
		{
			Console.WriteLine("{0}\n", e.Message);
			return null;
		}
	}
	// Use this for initialization
	void Start () {
		Level level = CreateLevel ("Resources/movelist.txt", 1);
		timer = setTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 0) {
			timer -= 1;
		}
		if (timer <= 0){
			timer = setTime;
			foreach (GameObject go in quadrants){
				QuadrantActivate qa = (QuadrantActivate) go.GetComponent<QuadrantActivate>();
				qa.Deactivate();
			}
		}
	}
}
