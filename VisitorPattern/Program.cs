using VisitorPattern;

List<IEmployee> employees = new List<IEmployee>
        {
            new Engineer("Alice", 70000),
            new Manager("Bob", 90000)
        };

BonusCalculator bonusCalculator = new BonusCalculator();
ReportPrinter reportPrinter = new ReportPrinter();

foreach (var employee in employees)
{
    employee.Accept(bonusCalculator);
    employee.Accept(reportPrinter);
}