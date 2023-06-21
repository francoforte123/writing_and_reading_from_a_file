Console.Write("insert the path for reading the file= ");
String pathFile= Console.ReadLine();

String contentFile= File.ReadAllText(pathFile);

Console.WriteLine("\nthe content the file is:");
Console.WriteLine(contentFile);

/*
    è possibile leggere il contenuto del file di testo (per leggere il contenuto del testo, va messo tutto il percorso del file, e non 
    questa espressione ./nomeDelFile.txt)
 */
//non riesco ad inserire un file PowerPoint





