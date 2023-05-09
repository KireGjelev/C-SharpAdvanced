using Task01.Database;
using Task01.Models;

Db<Shape> db = new Db<Shape>();

Circle circle = new Circle(1, 5);
db.AddShape(circle);

Rectangle rectangle = new Rectangle(2, 4, 6);
db.AddShape(rectangle);

db.PrintAreas();
db.PrintPerimeters();

circle.PrintInfo();
rectangle.PrintInfo();