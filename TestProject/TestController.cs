using CalculateArea;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject
{
    public class TestController
    {

        [Fact]
        public void TestCircle()
        {
            var circle = new Circle(5);
            Assert.Equal(78.5,circle.GetArea());
        }
        [Fact]
        public void TestRectangle()
        {
            var triangle = new Triangle(15,14,13);
            Assert.Equal(84, triangle.GetArea());
        }
        [Fact]
        public void TestRectangleGetInformation()
        {
            var triangle = new Triangle(25, 20, 15);
            Assert.True(triangle.GetInfoTriangleRectangular());
        }
    }
    /*
    SELECT PC.Id,CA.CategoryName, PR.ProductName  
    FROM ProductsCategories AS PC 
    JOIN Categories AS CA ON PC.CategoryId=CA.Id
    RIGHT JOIN Products AS PR  ON  PC.ProductId=PR.Id;

    CREATE TABLE Categories (
    Id int NOT NULL PRIMARY KEY,
    CategoryName nvarchar(250) NOT NULL);

    CREATE TABLE Products (
    Id int NOT NULL PRIMARY KEY,
    ProductName nvarchar(250) NOT NULL);

    CREATE TABLE ProductsCategories(
    Id int NOT NULL PRIMARY KEY,
    CategoryId int FOREIGN KEY REFERENCES Categories(Id),
    ProductId int FOREIGN KEY REFERENCES Products(Id)
    );

   */


}
