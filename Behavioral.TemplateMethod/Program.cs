using TemplateMethodPattern;
using static System.Net.Mime.MediaTypeNames;

DataProcessor excelFile = new ExcelFile();
excelFile.ReadProcessAndSave();


DataProcessor textFile = new TextFile();
textFile.ReadProcessAndSave();