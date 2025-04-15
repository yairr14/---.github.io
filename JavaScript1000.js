
function checkGender() {
    var genderMale = document.getElementById("male").checked;
    var genderFemale = document.getElementById("female").checked;
    var genderErr = document.getElementById("err_gender");

    if (!genderMale && !genderFemale) {
        genderErr.style.display = "block"; // מציג את הודעת השגיאה
        return false;
    } else {
        genderErr.style.display = "none"; // מסתיר את הודעת השגיאה
        return true;
    }
}
