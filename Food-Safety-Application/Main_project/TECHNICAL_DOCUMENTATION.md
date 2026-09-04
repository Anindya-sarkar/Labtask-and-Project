# TECHNICAL IMPLEMENTATION NOTES

## Architecture Overview

### Session Management Pattern
```csharp
public static class SessionManager
{
    public static User CurrentUser { get; set; }
    public static bool IsUserLoggedIn => CurrentUser != null;
    public static void Login(User user) { CurrentUser = user; }
    public static void Logout() { CurrentUser = null; }
}
```
- Centralized user context
- Stateless forms (no form instance variables for users)
- Automatic session clearing on logout

### Form Transitions
All forms follow this pattern:
```csharp
// Opening new form and hiding current
NewForm newForm = new NewForm();
newForm.Show();
this.Hide();  // or this.Close() if not returning

// Closing form and returning to previous
PreviousForm prevForm = new PreviousForm();
prevForm.Show();
this.Close();
```

---

## Modified Files

### 1. SessionManager.cs (NEW)
**Purpose:** Centralized session tracking
**Key Methods:**
- `Login(User user)` - Store user in session
- `Logout()` - Clear session
- `IsUserLoggedIn` - Check if user logged in

**Usage Pattern:**
```csharp
// After successful authentication
User loggedInUser = DatabaseHelper.AuthenticateUser(username, password);
if (loggedInUser != null) {
    SessionManager.Login(loggedInUser);
}

// Use in other forms
if (SessionManager.IsUserLoggedIn) {
    int userId = SessionManager.CurrentUser.ID;
}

// On logout
SessionManager.Logout();
```

### 2. Homepage.cs (MODIFIED)
**Changes:**
- `HP_usersignin_pnl_signInBt_Click()` - Now authenticates via database
- `Hp_adminPnlSigninBt_Click()` - Now checks admin role
- `HPageFSafety_RulesBt1_Click()` - Displays comprehensive rules
- `HP_LawsBt_Click()` - Displays comprehensive laws
- `HP_LogoutBt1_Click()` - Clears session

**New Logic:**
```csharp
User loggedInUser = DatabaseHelper.AuthenticateUser(username, password);
if (loggedInUser != null) {
    SessionManager.Login(loggedInUser);
    // Navigate to appropriate form
}
```

### 3. User_SignUp.cs (MODIFIED)
**Changes:**
- `SignUp_pageCreateAccBT_Click()` - Now calls DatabaseHelper.RegisterUser()

**New Logic:**
```csharp
User newUser = new User(0, firstName, username, gender, age, email, password, "User");
if (DatabaseHelper.RegisterUser(newUser)) {
    // Success - navigate to homepage
} else {
    // Failure - show error
}
```

**Validation Added:**
- Email format check (@ and . required)
- Age range validation (13-120)
- Password confirmation
- Gender selection required
- All fields required check

### 4. User_Page.cs (MODIFIED)
**Changes:**
- `U_Page_Searchbt_Click()` - Now uses actual database search
- `U_Page_CheckFoodItemsBt_Click()` - Displays all foods
- `U_Page_SubmitComplaintBt_Click()` - Opens complaint form
- `U_Page_HistoryBt_Click()` - Shows complaint history
- `UP_searchpnl_searchBt_Click()` - Implements dual-mode search
- `U_Page_LogOutBt_Click()` - Clears session

**Search Implementation:**
```csharp
if (category == "Food") {
    List<Food> results = DatabaseHelper.SearchFoods(query);
} else if (category == "Additives") {
    List<Additive> allAdditives = DatabaseHelper.GetAllAdditives();
    // Client-side filter by query
}
```

### 5. UserComplaint.cs (MODIFIED)
**Changes:**
- `ComplaintPage_submitBt_Click()` - Now submits to database

**Implementation:**
```csharp
Complaint complaint = new Complaint(
    0,
    SessionManager.CurrentUser.ID,
    SessionManager.CurrentUser.Username,
    foodItem, vendorName, vendorID, details,
    "Pending", ""
);
if (DatabaseHelper.SubmitComplaint(complaint)) {
    // Success
}
```

### 6. AdminPage.cs (MODIFIED)
**Changes:**
- All manage buttons now open appropriate forms
- `A_Page_LogOutBt_Click()` - Clears session
- Simplified Back/Next navigation

**New Pattern:**
```csharp
AdminFoodManagement foodMgmt = new AdminFoodManagement();
foodMgmt.Show();
this.Hide();  // Not closed so can return
```

---

## New Forms Created

### 1. AdminFoodManagement.cs
**UI Components (Programmatic Creation):**
- Labels: Food Name, Category, Safety Status
- TextBoxes: Food Name, Category
- ComboBox: Safety Status (Safe/Unsafe/Pending)
- ListBox: Display all foods
- Buttons: Add Food, Delete Selected, Back

**Key Methods:**
- `AddBtn_Click()` - Calls DatabaseHelper.AddFood()
- `RefreshFoodsList()` - Reloads from database
- `DeleteBtn_Click()` - Framework for deletion

### 2. AdminComplaintsManagement.cs
**UI Components (Programmatic Creation):**
- ListBox: All complaints
- ComboBox: Status filter (Pending/In Review/Resolved/Rejected)
- TextBox: Admin response (multi-line)
- Buttons: Update, Back

**Key Methods:**
- `RefreshComplaintsList()` - Gets all complaints
- `ComplaintsListBox_SelectedIndexChanged()` - Shows details
- `UpdateBtn_Click()` - Calls UpdateComplaintStatus()

### 3. AdminAdditivesManagement.cs
**UI Components (Programmatic Creation):**
- ListBox: All additives with INS numbers
- Back button

**Key Methods:**
- `AdminAdditivesManagement_Load()` - Loads additives via GetAllAdditives()

### 4. AdminUsersManagement.cs
**UI Components (Programmatic Creation):**
- ListBox: All users
- TextBox: Search term
- Buttons: Search, Refresh, Back

**Key Methods:**
- `RefreshUsersList()` - Gets all users
- `SearchBtn_Click()` - Filters by username

### 5. IncidentsArchive.cs
**UI Components (Programmatic Creation):**
- ListBox: All incidents
- ComboBox: Status filter (All/Resolved/Pending/Investigating)
- Back button

**Key Methods:**
- `RefreshIncidentsList()` - Gets incidents, applies filter

---

## Database Integration Points

### Authentication Flow
```
Homepage Login → DatabaseHelper.AuthenticateUser()
    ↓
Returns User object or null
    ↓
SessionManager.Login(user) or show error
```

### Registration Flow
```
User_SignUp → Create User object
    ↓
DatabaseHelper.RegisterUser(user)
    ↓
On success → Navigate to Homepage
On failure → Show error message
```

### Complaint Flow
```
UserComplaint → Create Complaint object with SessionManager.CurrentUser
    ↓
DatabaseHelper.SubmitComplaint(complaint)
    ↓
On success → Navigate to User_Page
```

### Search Flow
```
User_Page Search → DatabaseHelper.SearchFoods(query)
                 or GetAllAdditives() + client filter
    ↓
Display results in MessageBox
```

---

## Validation Strategy

### Input Validation (Client-Side)
1. **Empty/Null Checks**
   ```csharp
   if (string.IsNullOrEmpty(username))
   ```

2. **Format Validation**
   ```csharp
   if (!email.Contains("@") || !email.Contains("."))
   ```

3. **Range Validation**
   ```csharp
   if (age < 13 || age > 120)
   ```

4. **Match Validation**
   ```csharp
   if (password != confirmPassword)
   ```

5. **String Trimming**
   ```csharp
   string input = textBox.Text.Trim();
   ```

### Session Validation
```csharp
if (!SessionManager.IsUserLoggedIn) {
    MessageBox.Show("You must be logged in...");
    return;
}
```

---

## Error Handling Pattern

### Try-Catch in Database Methods
```csharp
catch (SqlException ex) {
    Console.WriteLine("Error: " + ex.Message);
    return false;  // or null
}
```

### User Feedback in UI
```csharp
if (DatabaseHelper.SubmitComplaint(complaint)) {
    MessageBox.Show("Success message", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
} else {
    MessageBox.Show("Error message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
```

---

## Form Naming Conventions

**Partial Classes (Designer):**
- `FormName.Designer.cs` - Auto-generated UI code
- DO NOT EDIT manually

**Code-Behind:**
- `FormName.cs` - All event handlers and logic
- Edit this file for functionality

**File Naming:**
- PascalCase for all form names
- Match exact class name used in InitializeComponent()

---

## Testing Checklist

- [ ] Database connection verified
- [ ] User registration with various inputs
- [ ] User login with valid/invalid credentials
- [ ] Admin login with admin/non-admin accounts
- [ ] Food search functionality
- [ ] Complaint submission and retrieval
- [ ] Admin complaint management
- [ ] Admin user viewing
- [ ] Admin food management
- [ ] Logout from all forms
- [ ] Session persistence across forms
- [ ] Error messages display correctly
- [ ] All forms close and open correctly
- [ ] No data loss on navigation
- [ ] All validations working

---

## Deployment Steps

1. **Prepare Database:**
   - Create FoodSafetyDB in SQL Server
   - Create all tables (Users, Foods, Complaints, Additives, Incidents)
   - Add at least one Admin user

2. **Configure Connection String:**
   - Update DatabaseHelper.cs connection string if needed
   - Test with VerifyConnection()

3. **Build Project:**
   - Compile in Visual Studio
   - Resolve any missing dependencies

4. **Test Application:**
   - Run each workflow
   - Verify database operations
   - Test error scenarios

5. **Deploy:**
   - Distribute compiled .exe
   - Ensure SQL Server accessible from client machines
   - Test on target systems

---

## Performance Considerations

1. **Database Queries:**
   - SearchFoods uses LIKE (could be slow with large datasets)
   - Consider adding indexes on frequently queried columns
   - GetAllUsers/GetAllComplaints loads everything (consider pagination)

2. **UI Responsiveness:**
   - Large datasets may cause UI lag in ListBoxes
   - Consider DataGridView for better performance
   - Consider async operations for long-running queries

3. **Session Memory:**
   - CurrentUser object stored in static variable
   - Minimal memory impact
   - Automatically garbage collected on logout

---

## Future Enhancements

1. Add pagination to admin views
2. Implement DataGridView for better data display
3. Add async database operations
4. Add export to Excel/PDF functionality
5. Add email notifications for complaints
6. Add dashboard with statistics
7. Add user role permissions
8. Add audit logging
9. Add password hashing (currently plain text)
10. Add database encryption for sensitive data

---

*This technical documentation last updated with all 16 features implemented.*
