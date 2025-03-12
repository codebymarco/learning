# SOP for Creating a Basic Angular Application

## Project Setup Phase

1. **Create new Angular project**
   - Run: `ng new my-angular-app --routing=true --style=scss`
   - Say yes to Angular routing when prompted

2. **Install necessary dependencies**
   - Run: `npm install @ngrx/store @ngrx/effects @ngrx/store-devtools`
   - These packages will help implement the store functionality

## Layout Structure Phase

1. **Create layout components**
   - Generate Main Layout: `ng generate component layouts/main-layout`
   - Generate User Layout: `ng generate component layouts/user-layout`

2. **Create shared components**
   - Main Navbar: `ng generate component shared/main-navbar`
   - Main Footer: `ng generate component shared/main-footer`
   - User Navbar: `ng generate component shared/user-navbar`
   - User Footer: `ng generate component shared/user-footer`

3. **Set up layout structure**
   - Edit main-layout.component.html to include router-outlet between navbar and footer
   - Edit user-layout.component.html to include router-outlet between navbar and footer

## Page Components Phase

1. **Create authentication pages**
   - Login Page: `ng generate component pages/login`
   - Signup Page: `ng generate component pages/signup`

2. **Create user pages**
   - Home Page: `ng generate component pages/home`
   - Dashboard Page: `ng generate component pages/dashboard`
   - Settings Page: `ng generate component pages/settings`

## Authentication Service Phase

1. **Create authentication service**
   - Run: `ng generate service services/auth`
   - Implement mock login/signup functionality using localStorage

2. **Create authentication guard**
   - Run: `ng generate guard guards/auth`
   - Implement logic to prevent unauthorized access to user pages

## State Management Phase

1. **Set up NgRx store structure**
   - Create model interfaces: `ng generate interface models/user`
   - Create store folder structure:
     - store/actions
     - store/reducers
     - store/effects
     - store/selectors

2. **Create auth state**
   - Create auth actions (login, signup, logout)
   - Create auth reducer (handle auth state changes)
   - Create auth effects (handle side effects like local storage)
   - Create auth selectors (retrieve user state)

## Routing Configuration Phase

1. **Configure main routes in app-routing.module.ts**
   - Set up main layout routes (login, signup, home)
   - Set up user layout routes (dashboard, settings)
   - Add route guards to protected routes

2. **Set up nested routing for layouts**
   - Configure child routes for main-layout
   - Configure child routes for user-layout

## Feature Implementation Phase

1. **Implement login/signup functionality**
   - Connect forms to auth service
   - Dispatch login/signup actions to store
   - Implement redirects to dashboard on success

2. **Implement dashboard functionality**
   - Display user information from store
   - Create mock dashboard content

3. **Implement settings functionality**
   - Create account deletion option
   - Implement logout functionality
   - Connect to store actions

## Testing Phase

1. **Test all routes and navigation**
   - Verify routes are working correctly
   - Test protected routes with and without authentication

2. **Test authentication flow**
   - Test login with valid/invalid credentials
   - Test signup process
   - Test logout functionality

3. **Test store functionality**
   - Verify state is maintained correctly
   - Test persistence after page refresh

## Final Review Phase

1. **Code organization review**
   - Check component organization
   - Ensure services are properly implemented

2. **Authentication review**
   - Verify all authenticated routes are protected
   - Test login persistence

3. **Final application test**
   - Test complete user journey from login to logout

By following this SOP, you'll create a well-structured Angular application with proper authentication flow and state management using NgRx store, all while maintaining clean separation of concerns between layouts, pages, and shared components.
