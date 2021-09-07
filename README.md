# Introduction
This is a project with a list of names...

# Shortcuts
*  **Change Log Updates**
	- [Version 0.3.0](#Version-0.3.0)
	- [Version 0.2.0](#Version-0.2.0)
	- [Version 0.1.0](#Version-0.1.0)
* Infomation
	* [Key Commands](#Key-Commands)
	* [Method Used](#Methods-Used)
		* [Main Window](#Main-Window)
		* [Option's Window](#Option's-Window)

# Key Commands
* Press Enter on Names textbox to run add name method
* While item from List box selected press Delete to run remove name method

# Methods Used
## Main Window
### Name_Click()
* On click check how many names are already in list box, if over given parameter clear list.
* If given name is already in list clear textbox.

### btnDelete_Click()
* Try if selected item is null show error message please select name,
else remove selected item from list box

### DeleteAllbtn_Click()
* Clear listbox on click..

### lstNames_MouseLeftButtonDown()
* If click on list box clear listbox...

### btnSaveList_Click()
* parameter saveFile from SaveFileDialog class is used to write list box items to a file

### btnLoadList_Click()
* Parameter openFile from OpenFileDialog class is used to read items in file.
* Foreach item in openFile's string array add back to list box items.

## Option's Window
### IsTextAllowed()
* Checks if given text is equal to int if soo no problem if not error message saying must be integer.
# Change log
# [Unreleased]
## Version 0.3.0 03-09-2021
### Added
- [x] Add topic textbox that changes title & label
- [x] Add btn save list
- [x] Add method for saving list as file
- [x] Add btn load list
- [x] Add method for loading file to list box
### Change
- [x]  Change title with topic textbox
## Version 0.2.0 02-09-2021
### Added
- [x] Add a check box for if list should clear if over 6 members
- [x] Text box to type how many names are allowed in list before clear
### Changed 
- [x] Instead of closing on close hide to save data and keep options window initialized
- [X] Styling with Windows/Grid resources 
- [X] Changed start up url for main
## Version 0.1.0 01-09-2021
### Added
- [x] Add label/Title Names
- [x] Added add name btn
- [x] Add name textbox
- [x] Add TextList box
- [x] Add btn for deleting selected name from list
- [x] Add btn to clear entire list
