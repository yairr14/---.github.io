function validateForm() {
    let isValid = true; // משתנה לבדוק אם הטופס תקין

    // ניקוי הודעות שגיאה קודמות
    document.querySelectorAll('.error').forEach(el => el.textContent = '');

    // בדיקת תקינות שם משתמש
    // בדיקת שם משתמש
    const username = document.getElementById('username');
    if (!/^[A-Z][A-Za-z0-9]{4,8}[0-9].*[0-9]$/.test(username.value)) {
        // שם המשתמש חייב להתחיל באות גדולה, להכיל לפחות 2 אותיות, 
        // לכלול לפחות 2 מספרים, ולהיות בין 6 ל-10 תווים.
        document.getElementById('usernameError').textContent = 'שם המשתמש חייב להתחיל באות גדולה, להכיל לפחות 2 אותיות, לכלול לפחות 2 מספרים ולהיות בין 6 ל-10 תווים.';
        isValid = false;
    }

    // בדיקת סיסמה
    const password = document.getElementById('password');
    if (!/^[A-Za-z](?=(.*[a-z]))(?=(.*[A-Z]))(?=(.*\d)).{7,}$/.test(password.value)) {
        // הסיסמה לא יכולה להתחיל בספרה או בתו מיוחד, חייבת לכלול לפחות 8 תווים, 
        // לפחות אות קטנה אחת, לפחות אות גדולה אחת ולפחות ספרה אחת.
        document.getElementById('passwordError').textContent = 'הסיסמה חייבת להיות לפחות 8 תווים, לכלול לפחות אות גדולה אחת, אות קטנה אחת וספרה אחת, ולא יכולה להתחיל בספרה או בתו מיוחד.';
        isValid = false;
    }


    // אם הטופס תקין, נשלח אותו, אחרת מונעים שליחה
    return isValid;  // אם כל הבדיקות עברו בהצלחה, נשלח את הטופס
}