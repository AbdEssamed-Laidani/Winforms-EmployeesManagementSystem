# WinForms Employees Management System

A simple **C# WinForms** desktop application for managing employee records in memory.

## Features

- Add employees with:
  - Full name
  - Phone
  - Email
  - Date of birth (must be 18+)
  - Gender
- Validate common input formats (name, email, phone).
- Prevent duplicate employees by phone/email.
- Display employees in a `ListView` with multiple view modes.
- Show selected employee details in a dedicated card.
- Modify and remove existing employees.

## Tech Stack

- .NET Framework 4.8
- Windows Forms (WinForms)
- C#

## Project Structure

- `/EmployeesManagment.sln` — solution file.
- `/EmployeesManagment.csproj` — WinForms project file.
- `/Program.cs` — application entry point.
- `/Form1.cs` — main form logic (add/list/remove/modify flow).
- `/frmModifyEmployeeInfo.cs` — employee edit dialog logic.
- `/clsEmployee.cs` — employee model.
- `/Resources/` — UI icons and images.

## Prerequisites

- Windows OS
- Visual Studio 2019/2022 with **.NET desktop development** workload
- .NET Framework 4.8 Developer Pack

## Build and Run

1. Open `EmployeesManagment.sln` in Visual Studio.
2. Select `Debug` or `Release`.
3. Build the solution (`Build > Build Solution`).
4. Run the app (`F5` or `Ctrl + F5`).

## Usage

1. Enter employee details in **Employee Information**.
2. Click **Add** to insert the employee.
3. Select an employee from the list to view details.
4. Use **Modify** to edit the selected employee.
5. Use **Remove** to delete selected employee(s).
6. Change list presentation from the **View** dropdown.

## Notes

- Employee data is stored in memory only (no database/persistence).
- IDs are generated randomly when adding a new employee.