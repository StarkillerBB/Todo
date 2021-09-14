# Todo Project
##### Author: Benjamin Lank
#### Description:
##### A project page made with razor pages to keep track of different assignments. 

#### Navigation menu:
ChangeLog:  
- [Version 0.5](#Version-0.5).  
- [Version 0.4](#Version-0.4).  
- [Version 0.3](#Version-0.3).  
- [Version 0.2](#Version-0.2).  
- [Version 0.1](#Version-0.1).


## Console menu.
### Short description of the menu and each method associated with it.

	1. OnPostEdit.
		* Updates a specific Todo with the information inserted into the modal
	2. OnPostDelete.
		* Deletes a specific Todo from the list.
	3. OnPostCreate.
		* Creates a Todo with the description inserted into the field, rest of information is pre-defined
	4. OnGetJsonObj.
		* Get's called from a script.
		* Searches for a specific todo by Guid. If able to find it returns the result to the script inside the Index.cshtml

## ChangeLog.
### All changes will be added to this section.

###### 9/14/21
#### Version 0.5

###### Functionality to buttons in table.

##### Added.

	* User able to update the description in specific Todo.
	* 

##### Changed.

##### Removed.

---
###### 9/13/21
#### Version 0.4

###### Functionality to buttons in table.

##### Added.

	* User able to create new Todos with description.
	* User able to delete a Todo from the list.

##### Changed.

	* Table styling.

##### Removed.

---
###### 9/10/21
#### Version 0.3

###### front-end

##### Added.

	* Table that displays the whole list.
	* Buttons to table.

##### Changed.

##### Removed.

---
###### 9/7/21
#### Version 0.2

###### Methods into Repository

##### Added.
	
	* CreateTodo method.
	* GetItemById method, to find the specific Todos.
	* DeleteTodo method.
	* GetTodo method, returns the lists of Todos.
	* UpdateTodo method, finds the specific Todo.

##### Changed.

##### Removed.

---

###### 9/6/21
#### Version 0.1

###### Folders, classes, interfaces and properties, basic setup.

#### Added.

	* Folders.
	* Interface for TodoRepository.
	* TodoRepository file.
	* Model
	* ReadMe

##### Changed.

##### Removed.

	



