using Godot;
using System;

class Parse{

	public string Key = "";
	public string Description = "";
	public Node newNode;
	public Parse(string key, string nameObject){
		if (String.Equals(key,"G")){
			//RectangleShape2D shape = RectangleShape2D.new();
 			//get_node("StaticBody2D").add_shape(shape);
 			///shape.set_extents(Vector2(70,70));
		}
	
		Key = key;
	}
	
	public string getKey(){
		return Key;
		
	}	
	public string getDescription(){
		
		return Description;
	}
	
	
	
}

