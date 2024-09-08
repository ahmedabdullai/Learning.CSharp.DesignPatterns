//using MementoDesignPattern;

//Editor editor = new Editor();

//History history = new History();


//editor.Content = "a";
//history.Push(editor.CreateState());

//editor.Content = "b";
//history.Push(editor.CreateState());

//editor.Content = "c";
//editor.Restore(history.Pop());


//Console.WriteLine(editor.Content);



// Client code.
using MementoDesignPattern.RefactoringGuru;

Originator originator = new Originator("Super-duper-super-puper-super.");
Caretaker caretaker = new Caretaker(originator);

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("\nClient: Now, let's rollback!\n");
caretaker.Undo();

Console.WriteLine("\n\nClient: Once more!\n");
caretaker.Undo();

Console.WriteLine();