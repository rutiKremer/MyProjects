
const codeArray = JSON.parse(localStorage.getItem("currentUser")).arrayWatches;
const container = document.querySelector(".container");

const array = { arr: [] };
$.ajax({
    url: './watch.json',
    success: (data) => {
        array.arr = data;
        setWatches(codeArray);
    }
});
let sum = 0;
const setWatches = (codeArray) => {
    codeArray.forEach((code) => {
        (array.arr.Watch).forEach((watch) => {
            if (watch.code == code) {
                sum += parseInt(watch.price);
                const data = document.createElement("div");
                data.innerHTML = `
                <button type="button" class="delete">✕</button>
                    <h1>שם: <span id="spanName">${watch.name}</span></h1>
                    <h2>מחיר: <span id="spanPrice">${watch.price}</span></h2>
                    <h3>קוד: <span id="spanCode">${watch.code}</span></h3>
                    <img src="./${watch.img}" id="spanImg">
                   `;
                container.append(data);
                data.querySelector('.delete').onclick = () => {
                    container.removeChild(data);
                    sum -= parseInt(watch.price);
                    document.querySelector('#sumSpan').innerHTML = sum;
                    const updatedCodeArray = codeArray.filter(item => item !== watch.code);
                    localStorage.setItem("currentUser", JSON.stringify({ arrayWatches: updatedCodeArray }));
                };
            }
        })
    });
    document.querySelector('#sumSpan').innerHTML = sum;

};
document.querySelector('#sumSpan').innerHTML = sum;