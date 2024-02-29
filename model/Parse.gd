extends Node2D

#@onready var ball_path = preload("res://Objects/boc.tscn")
@onready var ball_path = preload("res://Objects/Circle.tscn")
# Called when the node enters the scene tree for the first time.
func _ready():
	#parseMe("G","Panel")
	
	var level = "res://levelEleven.txt"
	
	#var array = parse(level)
	var ball = ball_path.instantiate()
	add_child(ball)
	#print(array)

func parse(level):
	"""var shape = RectangleShape2D.new()
	shape.set_extents(Vector2(70,70))
	
	var collision = RigidBody2D.new()
	collision.set_shape(shape)
	add_child(collision)"""
	var file = FileAccess.open(level,FileAccess.READ)
	var text = file.get_as_text()
	var arr = []
	var posi = 0
	for i in text:
		if i == "G":
			var ball = ball_path.instantiate()
			#ball.position = 
			ball.position.x = 5
			# = Vector2(5+len(i),5+len(i))
			posi = posi+1
			add_child(ball)
			#((Button)ball.get_child(0)).Disabled = false
		arr.append(i)
	return arr
	
	

	

