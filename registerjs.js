function validateForm() {
    let isValid = true; // משתנה לבדוק אם הטופס תקין

    // ניקוי הודעות שגיאה קודמות
    document.querySelectorAll('.error').forEach(el => el.textContent = '');

    // בדיקת תקינות שם פרטי
    const firstName = document.getElementById('firstName');
    if (!/^[A-Za-z֐-׿]{2,}$/.test(firstName.value)) {
        document.getElementById('firstNameError').textContent = 'השם הפרטי חייב להכיל לפחות 2 אותיות ורק אותיות.';
        isValid = false;
    }

    // בדיקת תקינות שם משפחה
    const lastName = document.getElementById('lastName');
    if (!/^[A-Za-z֐-׿]{2,}$/.test(lastName.value)) {
        document.getElementById('lastNameError').textContent = 'השם המשפחה חייב להכיל לפחות 2 אותיות ורק אותיות.';
        isValid = false;
    }

    const username = document.getElementById('username');
    if (!/^[A-Z][A-Za-z0-9]{4,8}[0-9].*[0-9]$/.test(username.value)) {
        // שם המשתמש חייב להתחיל באות גדולה, להכיל לפחות 2 אותיות, 
        // לכלול לפחות 2 מספרים, ולהיות בין 6 ל-10 תווים.
        document.getElementById('usernameError').textContent = 'שם המשתמש חייב להתחיל באות גדולה, להכיל לפחות 2 אותיות, לכלול לפחות 2 מספרים ולהיות בין 6 ל-10 תווים.';
        isValid = false;
    }

    // בדיקת תקינות אימייל
    const email = document.getElementById('email');
    if (!/^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email.value)) {
        document.getElementById('emailError').textContent = 'כתובת האימייל אינה תקינה.';
        isValid = false;
    }

    // בדיקת תקינות מספר טלפון
    const phone = document.getElementById('phone');
    if (!/^05\d{8}$/.test(phone.value)) {
        document.getElementById('phoneError').textContent = 'מספר הטלפון חייב להתחיל ב-05 ולהכיל 10 ספרות.';
        isValid = false;
    }

    // בדיקת תקינות סיסמה
    const password = document.getElementById('password');
    if (!/^[A-Za-z](?=(.*[a-z]))(?=(.*[A-Z]))(?=(.*\d)).{7,}$/.test(password.value)) {
        // הסיסמה לא יכולה להתחיל בספרה או בתו מיוחד, חייבת לכלול לפחות 8 תווים, 
        // לפחות אות קטנה אחת, לפחות אות גדולה אחת ולפחות ספרה אחת.
        document.getElementById('passwordError').textContent = 'הסיסמה חייבת להיות לפחות 8 תווים, לכלול לפחות אות גדולה אחת, אות קטנה אחת וספרה אחת, ולא יכולה להתחיל בספרה או בתו מיוחד.';
        isValid = false;
    }

    // אם הטופס תקין, נשלח אותו, אחרת מונעים שליחה
    if (isValid) {
        return true;  // נשלח את הטופס
    } else {
        return false; // מונעים שליחה
    }
}
