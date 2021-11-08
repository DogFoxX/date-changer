
# Date Changer
<a  href="https://github.com/DogFoxX/date-changer/releases/latest"><img  src="https://img.shields.io/github/v/release/DogFoxX/date-changer?label=Download%20Latest&style=for-the-badge"></a>
<a  href="https://github.com/DogFoxX/date-changer/releases"><img  src="https://img.shields.io/github/downloads/DogFoxX/date-changer/total?label=Downloads&logo=Github&logoColor=green&style=for-the-badge"></a>
<a  href="https://github.com/DogFoxX/date-changer/issues"><img  src="https://img.shields.io/github/issues/DogFoxX/date-changer?label=Issues&logo=Github&logoColor=green&style=for-the-badge"></a>
<a  href="./LICENSE"><img  src="https://img.shields.io/github/license/dogfoxx/date-changer?logo=Github&logoColor=green&style=for-the-badge"></a>

### A Windows .NET4.7.2 App to change system date and execute Games/Programs.<br>Use case: Star Wars Jedi: Fallen Order

# Screenshots

![alt text](https://raw.githubusercontent.com/DogFoxX/date-changer/main/main_window.JPG)

# Using Date Changer

### How to:
• **NOTE: Requires Admin Rights to run.**

• Browse for .exe file.

• Change the date.

• Start the process


### All the controls:
- **Select a save:**
  - All your saved settings will appear here. Select one to load it.

- **Default (Button):**
  - Sets the selected save to load when Date Changer opens.

- **Delete (Button):**
  - Delete the selected save file.

- **File Location:**
  - Manually enter the location of the .exe to load.

- **Browse (Button):**
  - Browse for an .exe to load.

- **Set preferred date:**
  - Change to the preferred date. Format is MM - dd - yyyy.

- **Auto Reset (Checkbox):**
  - Auto reset date after Game/Program is closed.

- **Friendly name:**
  - Gives your save, or Desktop Shortcut a name.

- **Save (Button):**
  - Saves all parameters entered to an .xml file, and adds a selection to "Select a save" dropdown.

- **Desktop Shortcut (Button)**
  - Creates a desktop shortcut with all parameters.

- **Start (Button):**
  - Start the process.

### Console Log:
- Displays all needed info about the process.

- **Copy Log (Button):**
  - Copy the log to clipboard.

- **Clear Log (Button):**
  - Clears the log.

# Command Line
### Parameters

`date-changer -"path to .exe" -date (mm-dd-yyyy)`

ex. `date-changer -"C:\exampleApp.exe" -10-01-2021`

### NOTE
Path to .exe needs to be within double quotes.

**Date Changer automatically saves Desktop Shortcuts with these command line parameters based on what is entered.**

# About
### Xml Save Files
This application creates .xml files in the root of application.
Everytime the application loads, it will look for any .xml files and load them.
Make sure to save the application in a safe directory; ie. Desktop not recommended. If using multiple saves, it might bloat your Desktop unnecessarily.
Editing the .xml files is not recommened.

### Why create this app?
I created it with the issue of **Star Wars Jedi: Fallen Order** in mind.
The game may sometimes CTD if the system date weren't changed to either October, November or December.
Instead of using CMD or batch files to change the date and run the games, Date Changer does this all automatically.
Who knows? This application might be applicable with other Games/Programs.

# Report an issue
### For issue reporting, open a new issue.
### Copy the log for reference.
