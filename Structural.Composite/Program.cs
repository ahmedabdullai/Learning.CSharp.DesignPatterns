// Create files
using Composite;
using File = Composite.File;

IFileSystemItem file1 = new File("File1.txt", 500);
IFileSystemItem file2 = new File("File2.txt", 1500);
IFileSystemItem file3 = new File("File3.txt", 2000);

// Create folders and add files to them
Folder folder1 = new Folder("Folder1");
folder1.Add(file1);

Folder folder2 = new Folder("Folder2");
folder2.Add(file2);
folder2.Add(file3);

// Create the root folder and add other folders and files
Folder rootFolder = new Folder("Root");
rootFolder.Add(folder1);
rootFolder.Add(folder2);

// Calculate the total size of all items in the root folder
Console.WriteLine($"Total size: {rootFolder.GetSize()} bytes");