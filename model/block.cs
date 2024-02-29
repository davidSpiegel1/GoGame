using Godot;
using System;

class Block{

	public string Key = "";
	public string Description = "";
	public Block(string key){
		if (String.Equals(key,"G")){
			
			Description = "Grass. No Practical use";
		}
		else if (String.Equals(key,".")){
			Description = "Dirt. No Practical use";
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

