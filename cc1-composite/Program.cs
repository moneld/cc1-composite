
using cc1_composite;
using File = cc1_composite.File;

Folder root = new Folder("Root");
Folder f1 = new Folder("Dossier 1");
Folder f2 = new Folder("Dossier 2");
Folder f3 = new Folder("Dossier 3");
Folder f4 = new Folder("Dossier 4");

root.addComponent(f1);
root.addComponent(f2);
root.addComponent(f3);
root.addComponent(f4);

f1.addComponent(new File("Fichier 1-1"));
f1.addComponent(new File("Fichier 1-2"));
f1.addComponent(new File("Fichier 1-3"));

f2.addComponent(new File("Fichier 2-1"));
f2.addComponent(new File("Fichier 2-2"));
f2.addComponent(new File("Fichier 2-3"));

f3.addComponent(new File("Fichier 3-1"));

Folder f5 = (Folder) f4.addComponent(new Folder("Dossier 5"));

f5.addComponent(new File("Fichier 5-1"));

root.view();