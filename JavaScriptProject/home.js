const span = document.getElementById('span');
const user = JSON.parse(localStorage.getItem('users'));
span.innerHTML = user[user.length - 1].firstName;

//טיימר
let hasShownPopUp = false; // משתנה בוליאני לבדוק אם הפופ-אפ הוצג
const popAp = () => {
    if (hasShownPopUp) return; // אם הפופ-אפ כבר הוצג, יוצאים מהפונקציה
    hasShownPopUp = true; // מעדכנים שהפופ-אפ הוצג
    const popUpElement = document.querySelector("#popAp");
    popUpElement.style.display = "block";
    popUpElement.style.backgroundColor = "white";
    popUpElement.style.boxShadow = "0 8px 20px rgba(0, 0, 0, 0.2)";
};

const closePopUp = () => {
    const popUpElement = document.querySelector("#popAp");
    popUpElement.style.display = "none";
};

document.querySelector("#closeBtn").addEventListener("click", closePopUp);

// הפעלת טיימר כדי להציג את הפופ-אפ
setTimeout(popAp, 5000);