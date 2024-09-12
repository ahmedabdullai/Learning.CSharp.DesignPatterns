using FactoryPattern;

Divide divide = new Divide();
Add add = new Add();
Subtract subtract = new Subtract();

divide.Calculate(10, 5);
add.Calculate(10, 5);
subtract.Calculate(10, 5);



CalculateFactory.GetCalculation("multiply").Calculate(10, 5);