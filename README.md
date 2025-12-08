
# 🚀 CoolPals Portfolio Setup Guide

## 1. 📥 Clone the Repository
- Go to: `https://github.com/quijadaclark05-lab/CoolPalsPortfolioLoginTry`
- Click the green **Code** button → Copy the HTTPS link
- Open **GitHub Desktop**
  - Click **File → Clone Repository**
  - Paste the link and choose a local folder
  - Click **Clone**


## 2. 🧠 Open the Project in Visual Studio
- Go to the folder you just cloned
- Double-click `CoolPalsPortfolioLoginTry.sln` to open the solution in **Visual Studio 2022**
- Wait for it to load and restore dependencies


## 3. 🗃️ Set Up the Database
- Open **SQL Server Management Studio (SSMS)**
- Go to the `Database/` folder in the project
- Open the `.sql` file and run it to create the database: `CoolPalsDB`
- Confirm that `CoolPalsDB` appears in your SSMS Object Explorer


## 4. 🔧 Update the Connection String
- In Visual Studio, open `App.config`
- Find the line that starts with `Data Source=`
- Replace `YOUR_MACHINE_NAME` with your actual SQL Server name (usually your computer name)
  ```xml
  Data Source=YOUR_MACHINE_NAME;Initial Catalog=CoolPalsDB;Integrated Security=True
  ```

## 5. ▶️ Run the App
- Press **F5** or click **Start** in Visual Studio
- The app should launch at `WelcomeForm`

## 6. 🔄 Navigation Flow
- `WelcomeForm` → choose **Login** or **Sign Up**
- `LoginForm` / `SignupForm` → leads to `SelectProfile`
- `SelectProfile` → opens `Portfolio1`

## ✅ Important Reminders
- Always **pull the latest changes** in GitHub Desktop before editing
- Use `Show()` and `Hide()` to switch between forms
- Only update your **SQL Server name** in the connection string — don’t change the database name
