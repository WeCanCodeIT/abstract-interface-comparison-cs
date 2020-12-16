# Base, Abstract, and Interface Comparison

The project is a fictional data access example in which mock implementation is provided as an example of loading connection strings, loading data, and saving data from SQL and SQLite back end databases.

The branches show a comparision between the use of base, abstract classes, and interfaces.  Starting with the base-class-example, checkout a branch and review the code and comments.  Continue with abstract-class-example and interface-example.

This repository contains 3 branches, each with the same classes, but different setup:
- base-class-example
- abstract-class-example
- interface-example

Projects contains some or all of the following files:
- DataAccess.cs: The base class and data connection layer.  Includes LoadConnectionString() and LoadData() methods.  It may or may not contain a SaveData() method.
- IDataAccess.cs: An interface for the data connection layer.  Incluces LoadConnectionString(), LoadData(), and SaveData() methods.
- SqlDataAccess.cs: A derived class of DataAccess.  Includes a unique SaveData() method.
- SqliteDataAccess.cs: A derived class of DataAccess.  Includes an override for LoadData() and a unique SaveData() method.
- Program.cs: Instantiates DataAccess, SqliteDataAccess, and SqlDataAccess objects.  Creates a list of example databases of DataAccess type and displays the results of calling various methods on each object.

---

## base-class-example

### DataAccess.cs

- DataAccess is the base class.  Objects can be instantiated from it or any of its derived classes.
- LoadConnectionString() is a method of the base class.  It is inherited by the derived class.
- LoadData() is a virtual method of the base class.  It can be overridden by the derived class.

### SqlDataAccess.cs

- SqlDataAccess is a derived class of the DataAccess base class
- It inherits LoadConnectionString() and LoadData() methods from the DataAccess class
- SaveData() is a method that is defined only in the derived class
- LoadData() is an overridden method.  What happens to our result if we don't override the virtual method?

### SqliteDataAccess.cs

- SqliteDataAccess is a derived class of the DataAccess base class
- It inherits LoadConnectionString() and LoadData() methods from the DataAccess class
- LoadData() can be overridden in the derived class
- SaveData() is a method that is defined only in the derived class

### Program.cs

- Instantiates all objects
- Creates a list of database objects of type DataAccess
- What is the result when LoadConnectionString() and LoadData() are called upon each of the database objects?
- Can SaveData() be run on the list of database objects?  Why or why not?

--- 

## abstract-class-example

The "abstract" keyword is a modifier for classes, methods, properties, etc.  It indicates that there is missing or incomplete implementation.

### DataAccess.cs

- DataAccess is an abstract class.  It will not allow an object to be directly instantiated from it.  Objects can be instantiated from any of its derived classes.
- Methods in an abstract class can be abstract or concrete.  Derived classes have access to concrete classes of the base class.  Derived classes must override and provide implementation for abstract methods.
- LoadConnectionString() is a method of the abstract class.  It is not abstract or virtual.  Therefore, it can not be overridden in the derived classes.
- LoadData() and SaveData() are abstract methods.  They do not have a code body, and therefore they do not have any direct implementation in this class. To implement these methods you must override them in a derived class.
- LoadData() and SaveData() will produce different results for Sql and Sqlite.

### SqlDataAccess.cs and SqliteDataAccess.cs

- SqlDataAccess and SqliteDataAccess both inherit from the DataAccess abstract class.  It is a blend of an Interface and a Base class.
- The LoadConnectionString() method is not abstract or virtual in the base class and therefore cannot be overridden in the derived class.  It is implemented directly from the DataAccess class.
- When implementing an abstract method the override keyword must be used.  LoadData() and SaveData() are overridden methods. 
- Notice that LoadData() and SaveData() have slightly different implementations in the derived classes. 
- What happens to our result if we don't override the abstract methods?

### Program.cs

- Instantiates all objects, but not the DataAccess class, which cannot be instantiated
- What happens when we try to instantiate a DataAccess object?
- Creates a list of database objects of type DataAccess
- What is the result when LoadConnectionString(), LoadData(), and SaveData() are called upon each of the database objects?
- Where does the implementation for LoadConnectionString() exist?  Is it the same for SqlDataAccess and SqliteDataAccess objects?
- Where does the implementation for LoadData() and SaveData() exist?

---

## interface-example

An interface creates a "contract" that its derived classes satisfy by providing implementation for the methods in the interface.  The interface defines "what" and those that implement the interface provide the answer to "how".

### IDataAccess.cs

- This is an interface, notice the keyword "interface" in place of "class".  Naming convention for interfaces starts with "I" followed by a Pascal case descriptive name.
- An interface contains only abstract methods, and therefore there is no implementation in the interface.  Methods in an interface have no body.  In an interface, methods are defined by their return type, name, and parameter list only.
- Interface methods are public by default.  

### SqlDataAccess.cs and SqliteDataAccess.cs

- SqlDataAccess and SqliteDataAccess both implement the IDataAccess interface
- When implementing a method from an interface, the override keyword is not needed
- Notice that LoadConnectionString(), LoadData(), and SaveData() have slightly different implementations in the derived classes 
- What happens to our result if we don't implement one of the methods from the interface?

### Program.cs

- Instantiates all objects, but not the IDataAccess class, which cannot be instantiated
- What happens when we try to instantiate a IDataAccess object?
- Creates a list of database objects of type IDataAccess
- What is the result when LoadConnectionString(), LoadData(), and SaveData() are called upon each of the database objects?  Where does the implementation for these methods exist?  