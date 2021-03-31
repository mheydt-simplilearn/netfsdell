class Rectangle {
    constructor(height, width) {
      this.height = height;
      this.width = width;
    }
    // Getter
    get area() {
      return this.calcArea();
    }
    // Method
    calcArea() {
      return this.height * this.width;
    }
  }
  
  const square = new Rectangle(10, 10);
  
  console.log(square.area); // 100


  class Polygon {
    constructor(...sides) {
      this.sides = sides;
    }
    // Method
    *getSides() {
      for(const side of this.sides){
        yield side;
      }
    }
  }
  
  const pentagon = new Polygon(1,2,3,4,5);
  
  console.log([...pentagon.getSides()]); // [1,2,3,4,5]
  