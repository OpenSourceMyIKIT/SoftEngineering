// Продемонстрировать несколько способов создания объектов, несколько способов доступа к их свойствам(на чтение и запись).

var comp = {
  type: "laptop",
  firm: "Lenovo",
  HDD: 1024,
  description: function() {
    return this.type + " " + this.firm + " " + this.HDD.toString();
  }
};

var person = new Object();
person.name = "Igor";
person.surname = "Krutoy";
person.sayHi = function() {
  return "Hi, I am " + this.name + " " + this.surname;
};

// Создать конструктор для собственного объекта, добавить в него несколько свойств и методов, продемонстрировать работу с этими объектами.

function Tshirt(type, size, color) {
  this.type = type;
  this.size = size;
  this.color = color;
};

Tshirt.prototype.howLooks = function() {
  if (this.type === "Tight" && this.color === "Red")
      return "Looks terrible!";
    else if (this.type === "Longsleeve" && this.color === "Yellow")
      return "Pretty good!";
    else
      return "Hmm, not bad...";
};

var myTshirt = new Tshirt("Longsleeve", "XL", "Blue");

// Расширить встроенный тип (например Array или Date) функцией, оперирующей данными расширяемого объекта (например вывод среднего арифметического для массива, или подсчет количества секунд со дня вашего рождения для даты).

Array.prototype.findMax = function() {
  var max = this[0];
  for (var i = 0; i < this.length; ++i) {
    if (this[i] > max)
      max = this[i];
  }
  return max;
};