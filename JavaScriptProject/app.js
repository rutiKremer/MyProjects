const searchBtn = document.querySelector('#searchButton');
const searchText = document.querySelector('#searchInput');
const watchForMan = document.querySelector("#watchForMan");
const watchForWoman = document.querySelector("#watchForWoman");

const store = { watches: [] };
const displayConfig = { searchBy: '', sortBy: '' };

$.ajax({
    url: './watch.json',
    success: (data) => {
        const { Watch } = data;
        store.watches = Watch;
        console.log(store.watches);
        setWatch(store.watches);
    },
    error: (xhr, status, error) => {
        console.error("Error loading data: ", error);
    }
});
// הוספת אירוע input לשדה החיפוש
searchText.addEventListener('input', (e) => {
    const valueSearch = e.target.value;
    displayConfig.searchBy = valueSearch;
    const filteredWatches = filterWatch(store.watches, displayConfig.searchBy);
    setWatch(filteredWatches);
});
//חיפוש של שעוני גברים
watchForMan.onclick = (e) => {
    e.preventDefault();
    displayConfig.sortBy = "גבר";
    const filteredWatches = filterWatchSort(store.watches, displayConfig.sortBy);
    if (filteredWatches.length === 0) {
        setWatch([]);
        alert("לא נמצאו שעונים לגברים.");
    } else {
        setWatch(filteredWatches);
    }
}

//חיפוש של שעוני נשים
watchForWoman.onclick = (e) => {
    e.preventDefault();
    displayConfig.sortBy = "אישה";
    const filteredWatches = filterWatchSort(store.watches, displayConfig.sortBy);
    if (filteredWatches.length === 0) {
        setWatch([]); // מציגים רשימה ריקה אם לא נמצאו שעונים
        alert("לא נמצאו שעונים לנשים.");
    } else {
        setWatch(filteredWatches);
    }
}

// פונקציה לסינון שעונים
const filterWatch = (watches, searchText) => {
    return watches.filter((watch) => {
        return (watch.name.toLowerCase().includes(searchText.toLowerCase()));
    });
};

// פונקציה לסינון שעונים
const filterWatchSort = (watches, sortText) => {
    return watches.filter(watch => {
        const isManWatch = watch.gender && watch.gender.toLowerCase() === "גבר";
        const isWomanWatch = watch.gender && watch.gender.toLowerCase() === "אישה";
        const isSortForMen = sortText.toLowerCase() === "גבר";
        const isSortForWomen = sortText.toLowerCase() === "אישה";
        return (
            (isManWatch && isSortForMen) ||
            (isWomanWatch && isSortForWomen) ||
            (sortText === '')
        );
    });
};

// פונקציה להצגת השעונים
const setWatch = (arrayWatches) => {
        if (arrayWatches.length == 0) {
            alert("לא נמצאו פריטים תואמים לחיפוש");
        }
        const allWatch = document.querySelector('#allWatch');
        allWatch.innerHTML = '';
        arrayWatches.forEach((watch) => {
            const eachWatch = document.createElement('div');
            eachWatch.innerHTML = `<a href = "./Watch.html?productCode=${watch.code}">
                <img src="./${watch.img}" alt="${watch.name}" />
                <h3>${watch.name}</h3>
                <p>מחיר: ${watch.price} ש"ח</p></a>
            `;
            const btnAdd = document.createElement('button');
            btnAdd.type = 'button';
            btnAdd.innerHTML = 'ADD TO CART'
            btnAdd.addEventListener('click', () => addToCart(watch.code));
            btnAdd.onclick = () => {
                location.href = './cart.html'
            }
            eachWatch.append(btnAdd);
            allWatch.append(eachWatch);
        });   
};

const addToCart = (code = null) => {
    if (code == null) {
        const searchCode = new URLSearchParams(window.location.search);
        code = searchCode.get("productCode");
    }
    const user = JSON.parse(localStorage.getItem("currentUser"));
    user.arrayWatches.push(code);
    localStorage.setItem("currentUser", JSON.stringify(user));
    localStorage.getItem("cart");
    localStorage.setItem("codeWatch", code);
}

