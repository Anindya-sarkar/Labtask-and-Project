# FOOD SAFETY APPLICATION - USER GUIDE

## Application Flow

### 🏠 HOMEPAGE
**Entry Point:** Shows all main navigation options

**Available Actions:**
1. **Rules & Laws Buttons** - View food safety regulations and compliance information
2. **User Login** - Login as a regular user
3. **Admin Login** - Login as an administrator (must have Admin role)
4. **Sign Up** - Create a new user account

---

## 👤 USER WORKFLOW

### 1. Sign Up (New User)
**Form:** User_SignUp
- Enter First Name
- Enter Username (unique)
- Select Gender (Male/Female/Other)
- Enter Age (13-120)
- Enter Email (must have @ and .)
- Enter Password
- Confirm Password (must match)
- Click "Create Account"
- ✅ Redirects to Homepage after success
- ❌ Error message if validation fails

### 2. User Login
**Form:** Homepage - User Sign In Panel
- Enter Username
- Enter Password
- Click "Sign In"
- ✅ Redirects to User_Page after success
- ❌ Error message if credentials invalid

### 3. User Dashboard (User_Page)
**Available Options:**

**Search**
- Click "Search" button
- Choose category: Food or Additives
- Enter search term
- View formatted results

**Check Food Items**
- View all available food items in database
- See food name, category, and safety status

**Submit Complaint**
- Click "Submit Complaint"
- Opens UserComplaint form
- Fill in:
  - Username (auto-populated)
  - Food Item Name
  - Vendor Name
  - Vendor ID
  - Complaint Details
- Submit to database

**View History**
- See all complaints you've filed
- View complaint status and admin responses

**Dashboard**
- Toggle side panel for additional options

**Logout**
- Click "Logout" to return to Homepage
- Session cleared

---

## 👨‍💼 ADMIN WORKFLOW

### 1. Admin Login
**Form:** Homepage - Admin Sign In Panel
- Enter Admin Username
- Enter Admin Password
- Click "Sign In"
- ✅ Redirects to AdminPage after success
- ❌ Error if not admin or invalid credentials

### 2. Admin Dashboard (AdminPage)
**Available Management Modules:**

#### A. Manage Foods
**Form:** AdminFoodManagement
- Add new food items
  - Enter Food Name
  - Enter Category
  - Select Safety Status (Safe/Unsafe/Pending)
  - Click "Add Food"
- View all foods in list
- Delete selected food (framework available)

#### B. Manage Additives
**Form:** AdminAdditivesManagement
- View all food additives
- See INS numbers and maximum limits
- Review risk information

#### C. Manage Complaints
**Form:** AdminComplaintsManagement
- View all user complaints
- See complaint details:
  - User who filed it
  - Food item involved
  - Vendor information
  - Complaint description
- Update complaint status:
  - Pending
  - In Review
  - Resolved
  - Rejected
- Write admin response
- Save changes to database

#### D. Manage Users
**Form:** AdminUsersManagement
- View all registered users
- Search users by username (case-insensitive)
- See user details:
  - User ID
  - Username
  - First Name
  - Role (User/Admin)
- Refresh user list

#### E. Rules & Laws
- Placeholder for legal framework management

#### F. Logout
- Click "Logout"
- Returns to Homepage
- Session cleared

---

## 🔑 KEY FEATURES

### Session Management
- Current user tracked via `SessionManager.CurrentUser`
- Persists across form transitions
- Automatically cleared on logout

### Data Validation
- All forms validate inputs before submission
- Email format checking
- Age range validation (13-120)
- Password confirmation
- Mandatory field checks

### Error Handling
- User-friendly error messages
- Validation feedback
- Database operation feedback
- Session verification checks

### Database Integration
- All data persisted in SQL Server
- Real-time database updates
- Complaint tracking
- User management
- Food item tracking
- Additive information

---

## 📋 QUICK REFERENCE - NAVIGATION

```
Homepage
├── User Login → User_Page → Submit Complaint → UserComplaint
│              ├── Search → Results
│              ├── Check Foods → Food List
│              ├── History → Complaint History
│              └── Logout → Homepage
│
├── Admin Login → AdminPage
│               ├── Manage Foods → AdminFoodManagement
│               ├── Manage Additives → AdminAdditivesManagement
│               ├── Manage Complaints → AdminComplaintsManagement
│               ├── Manage Users → AdminUsersManagement
│               └── Logout → Homepage
│
├── Sign Up → User_SignUp → Homepage
│
├── Rules → Display Rules Info
├── Laws → Display Laws Info
└── Incidents Archive → IncidentsArchive
```

---

## ⚠️ IMPORTANT NOTES

1. **Admin Account Required:**
   - Admin login requires a user with Role = "Admin"
   - Use database to create admin accounts

2. **Session Persistence:**
   - Session only exists for current application instance
   - Closes when application exits
   - Logs out when "Logout" button clicked

3. **Database Connection:**
   - Ensure SQL Server is running
   - Check connection string in DatabaseHelper.cs
   - Database: FoodSafetyDB
   - Tables: Users, Foods, Complaints, Additives, Incidents

4. **Validation Rules:**
   - Username must be unique (checked by database)
   - Email must contain @ and .
   - Age between 13-120
   - Password minimum length recommended
   - All text fields auto-trimmed

5. **Search Functionality:**
   - Food search uses LIKE query (partial matches)
   - Additives search case-insensitive
   - Empty search returns all items

---

## 🐛 TROUBLESHOOTING

**Issue:** Login fails
- Solution: Verify username/password in database
- Verify user role if logging in as admin

**Issue:** Can't submit complaint
- Solution: Ensure you're logged in
- Check all fields are filled
- Verify database connection

**Issue:** Search returns no results
- Solution: Try different keywords
- Verify data exists in database
- Check food category spelling

**Issue:** Admin features not showing
- Solution: Ensure you have Admin role
- Check database User table for role assignment

---

## 📞 SUPPORT

For technical issues:
1. Check database connection
2. Verify all required fields filled
3. Review error messages carefully
4. Check that data exists in database
5. Ensure SQL Server is running

**Database Backup:** Regularly backup FoodSafetyDB

---

*Application v1.0 - Food Safety Management System*
