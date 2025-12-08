
# 🚀 CoolPals Portfolio Setup & Collaboration Guide

This project is a modular WinForms + SQL portfolio system. You’ll be designing forms (drag-and-drop), wiring up backend logic, and committing your changes to a shared GitHub repo.

---

## 🔗 Repository Access

1. Go to: https://github.com/quijadaclark05-lab/CoolPalsPortfolioLoginTry  
2. Click the green **Code** button  
3. Copy the HTTPS link (looks like `https://github.com/...`)  

---

## 🧬 Clone the Project (First Time Setup)

1. Open **GitHub Desktop**  
2. Click **File → Clone Repository → URL tab**  
3. Paste the link you copied  
4. Choose a local folder and click **Clone**  
5. Open the folder → double-click `CoolPalsPortfolioLoginTry.sln` to launch in **Visual Studio 2022**

---

## 🎨 Start with Drag-and-Drop Design

1. In **Solution Explorer**, open any form (e.g., `WelcomeForm.cs`)  
2. Double-click to open the **[Design]** view  
3. Use the **Toolbox** to drag buttons, labels, textboxes, etc.  
4. Click a control → use the **Properties** panel to rename, style, or set default text  
5. Double-click a button to auto-generate a `Click` event in the `.cs` file

---

## 🧠 Add Backend Logic

Inside the button’s `Click` event, you can open other forms like this:

```csharp
private void loginButton_Click(object sender, EventArgs e)
{
    LoginForm loginForm = new LoginForm();
    loginForm.Show();
    this.Hide();
}
```

Use this pattern to connect `WelcomeForm → LoginForm → SelectProfile → Portfolio1`.

---

## 🗃️ Set Up the Database

1. Open **SQL Server Management Studio (SSMS)**  
2. Go to the `Database/` folder in the project  
3. Run the `.sql` file to create **CoolPalsDB**  
4. Confirm the database appears in SSMS

---

## 🔧 Update the Connection String

In `App.config`, replace `YOUR_MACHINE_NAME` with your actual SQL Server name:

```xml
Data Source=YOUR_MACHINE_NAME;Initial Catalog=CoolPalsDB;Integrated Security=True
```

## ▶️ Run the App

- Press **F5** in Visual Studio  
- The app launches at `WelcomeForm`  
- Click through the flow to test transitions



## 🤝 Collaborate & Commit Changes

1. After making changes (design or code), open **GitHub Desktop**  
2. You’ll see modified files listed  
3. Write a short commit message (e.g., `Added SignupForm layout`)  
4. Click **Commit to main**  
5. Click **Push origin** to upload your changes to GitHub



## 🔄 Pull Updates from Others

Before working each day:

1. Open GitHub Desktop  
2. Click **Fetch origin** → then **Pull origin**  
3. This downloads the latest changes from teammates



## ✅ Tips

- Only change your **SQL Server name** — don’t rename the database  
- Use `Show()` and `Hide()` for form transitions  
- Keep forms modular — each one should work independently  
- Always **pull before you push** to avoid conflicts

