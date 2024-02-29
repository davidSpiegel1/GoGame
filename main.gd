extends Node

func _ready() -> void:
	var label = "res://levelEleven.txt"
	var file = FileAccess.open(label,FileAccess.READ)
	var text = file.get_as_text()
	print("What text is: ",text)


func _on_quit_pressed():
	get_tree().quit()

func _on_start_game_pressed():
		get_tree().change_scene_to_file("res://world.tscn")
