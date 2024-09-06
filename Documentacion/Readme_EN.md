# Binary Tree in C#

### Description

A Binary Tree is a hierarchical data structure in which each node has at most two children: a left node and a right node. This structure is fundamental in computing due to its ability to represent hierarchical relationships and organize data in a way that makes search, insertion, and deletion operations highly efficient. 

This project develops a Binary Tree that supports multiple functionalities, allowing the user to perform various operations on the tree. The Binary Tree can be used in various applications, such as creating expression trees in compilers, organizing hierarchical data, implementing data structures for search algorithms such as Binary Search Tree (BST), and performing systematic walks over ordered data sets.

The code is designed in a modular way, with a class `Node` that defines the nodes of the tree and a class `BinaryTree` that encapsulates all the logic of the possible operations on the tree. These classes work together to provide a simple but powerful interface for handling binary trees, allowing developers to use the project as a basis for academic study, experimentation, or more advanced software development.

## Characteristics
1. **Insert Node:** Allows you to insert a node into the tree following the rules of binary trees, ensuring that the smallest values ​​are placed on the left and the largest ones on the right.
   
2. **Search Node:** Allows you to check if a specific value is present in the tree, returning true if it is found and false otherwise.
   
3. **Get Level of a Node:** Calculates the level at which a specific node is located within the tree, allowing you to understand the depth of the data.

4. **Travel General Path:** Shows all possible paths from the root to the leaves of the tree, which is useful for visualizing the entire structure of the tree.

5. **Traverse Path of a Node:** Shows the path from the root to a specific node, making it easier to identify routes within the tree.

6. **Calculate Total Weight:** Calculates the total number of nodes present in the tree, providing a measure of the size of the tree.

7. **Count Leaf Nodes:** Counts how many leaf nodes the tree has, that is, those nodes that do not have children.


## Requirements
- .NET 5.0 or higher.
- An IDE compatible with C# (such as Visual Studio or Visual Studio Code).
> [!Important]
> It is important to ensure that all requirements are installed and configured correctly before running this project to avoid problems and ensure optimal performance.

## Facility
1. Clone the repository or download the files.
   ```bash
   git clone https://github.com/Miguel-Antonio-Martinez-Jimenez/Arbol.Binario
2. Open the project in your favorite IDE.
3. Make sure you have .NET 5.0 installed and configured.

## Use
1. Run the project from the IDE or from the terminal using
   ```bash
   dotnet run
2. The program will insert nodes into the tree and demonstrate implemented functionality such as searching for nodes, obtaining the level of a node, and traversing tree paths.

## Project Structure
- `ArbolBinario.cs`: Main class that implements the binary tree functions.
- `Nodo.cs`: Class that defines the structure of a node with its value and references to the child nodes (left and right).
- `Program.cs`: Entry point of the program that executes examples of use of the binary tree functionalities.

## Example of Use
    ```csharp
    ArbolBinario arbol = new ArbolBinario();
    arbol.InsertarNodo(20);
    arbol.InsertarNodo(10);
    arbol.InsertarNodo(32);
    Console.WriteLine("Search 10:" + arbol.BuscarNodo(10)); // Returns true if the node exists
    Console.WriteLine("Level 32: " + arbol.NivelNodo(32)); // Returns the node level
    arbol.RecorrerCaminoGeneral(); // Shows all paths from root to leaves

## Project Status
**Current Status:** `Finished.`
> [!Note]
> This project is in **Completed** status, which means that all planned functionalities have been satisfactorily implemented and tested. The code is available for use and study, and contributions are welcome for improvements or new features.
<!--### Possible Project States
- **Beginnings:** The project is in its initial stages of planning and development. Requirements are just being defined and basic implementation is beginning.
- **In Development:** The project is in the full development phase, with features being added and testing in progress. It may contain errors or be subject to important changes.
- **Finished:** The project has achieved its initial objectives, with all functionalities implemented and tested. May receive maintenance or minor improvements.
- **Maintenance:** The project is complete, but is still receiving minor updates, bug fixes, or documentation and performance improvements.
- **Abandoned:** Development has been stopped and no future updates or maintenance are planned. -->

## Contributions
> [!Tip]
> If you want to contribute to the project, report bugs or propose improvements, we invite you to open a pull request or issue in the repository. You can also contact me directly to share your ideas or suggestions through my email miguelantoniomartinezjimenez00@gmail.com. All collaboration is welcome!

# License
This project is licensed under the MIT License. See the LICENSE file for more details.