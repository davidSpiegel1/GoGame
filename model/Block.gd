# Hopefully will be the block class
class_name Block extends Node2D

# Add properties

var fuel = 0.0
var speed = 0.0

# Override virtual methods
# I guess this is the constructor
func _ready():
	
	add_fuel(17.3)

func _process(delta):
	if fuel > 0.0:
		speed += delta
		fuel -= delta
		print(speed, "km/h")

# Add a new method
func add_fuel(litres):
	fuel += litres
