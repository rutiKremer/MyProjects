const form = document.querySelector('form');
form.onsubmit = (e) => {

    e.preventDefault();
    const currentUser = {
        firstName: e.target['firstName'].value,
        lastName: e.target['lastName'].value,
        password: e.target['password'].value
    }
    if (currentUser.password.length != 8) {
        alert("הכנס סיסמה בת 8 תווים");
        return;
    }
    //בדיקת המשתמש האם קיים והצגת הודעה מתאימה
    let count = 0;
    oldUsers = JSON.parse(localStorage.getItem("users")) ? JSON.parse(localStorage.getItem('users')) : [];
    const length = oldUsers.length;
    oldUsers.forEach((element) => {
        if (!(element.firstName === currentUser.firstName &&
            element.lastName === currentUser.lastName &&
            element.password === currentUser.password)) {
            count++;
        }
    });
    //הכנסת המשתמש הנוכחי למערך של כל המשתמשים
    currentUser.arrayWatches=[];
    localStorage.setItem("currentUser", JSON.stringify(currentUser));
    oldUsers.push(currentUser);
    localStorage.setItem("users", JSON.stringify(oldUsers));
    if (count === length) {
        alert("נרשמת בהצלחה");
    }
    location.href = './home.html';
}