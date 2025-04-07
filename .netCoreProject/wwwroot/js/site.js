const uriPhone = "/Phone";
const uriUsers = "/Users";

let Phones = [];
userName = document.getElementById('userName');

const checkToken = () => {

    fetch(uriPhone,{
        method:'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        },
    })
    .then(response => response.json())
    .then(getItems())
    .catch(error =>{
        sessionStorage.setItem("check", error)
        console.log(error);
        location.href = "./login.html"
    })
}

const getItems = () => {
    fetch(uriPhone,{
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        },
    })
    .then(response => response.json())
    .then(data =>  _displayItems(data))
    .catch(error => console.log(error))
}

const addItem = () => {
    const addNameTextbox = document.getElementById('add-name');
    const addNameTextbox2 = document.getElementById('add-price');
    const item = {
        isDone: false,
        name: addNameTextbox.value.trim(),
        price:addNameTextbox2.value.trim()
    };
    fetch(uriPhone, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addNameTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

const deleteItem = (id) => {
    fetch(`${uriPhone}/${id}`, {
        method: 'DELETE',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        },
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

const displayEditForm = (id) => {
    const item = Phones.find(item => item.id === id);
    document.getElementById('edit-name').value = item.name;
    document.getElementById('edit-price').value = item.price;
    document.getElementById('editForm').style.display = 'block';
    document.getElementById('edit-id').value=item.id
}

const updateItem = () =>{
    console.log("aaa");
    const itemId = document.getElementById('edit-id').value;
    console.log(itemId);
    const item = {
        id: parseInt(itemId),  
        name: document.getElementById('edit-name').value.trim(),
        price: document.getElementById('edit-price').value.trim(),
        userId:2
    };
console.log(item.id);
    fetch(`${uriPhone}/${item.id}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));
    closeInput('editForm');
    return false;
}

const closeInput = (formToClose) =>{
    document.getElementById(formToClose).style.display = 'none';
}

const _displayCount = (itemCount)=> {
    const name = (itemCount === 1) ? 'phone' : 'phone kinds';
    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

const _displayItems = (data) =>{
    const tBody = document.getElementById('phones');
    tBody.innerHTML = '';
    _displayCount(data.length);
    const button = document.createElement('button');
    data.forEach(item => {

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tBody.insertRow();

        // let td1 = tr.insertCell(0);
        // td1.appendChild(isDonePhoneCheckbox);

        let td2 = tr.insertCell(0);
        let textNode = document.createTextNode(item.name);
        td2.appendChild(textNode);

        let td5 = tr.insertCell(1);
        let textNode2 = document.createTextNode(item.price);
        td5.appendChild(textNode2);

        let td3 = tr.insertCell(2);
        td3.appendChild(editButton);

        let td4 = tr.insertCell(3);
        td4.appendChild(deleteButton);
    });

    Phones = data;
}

if (localStorage.getItem("token") == null) {
    console.log("login");
    sessionStorage.setItem("not", "not exist token")

    location.href = "./login.html"

}
const createLink = () => {
    if (localStorage.getItem("link") == "true") {

        let link = document.createElement("a");
        link.href = "./userList.html";
        link.innerHTML = "users";
        console.log(sessionStorage.getItem("link"));
        document.body.appendChild(link);
    }
}
console.log(localStorage.getItem("token"));


const editUser = () =>{

    document.getElementById('edit-name-user').value = user.name
    document.getElementById('edit-id-user').value = user.id;
    document.getElementById('edit-password-user').value = user.password;
    document.getElementById('editUserForm').style.display = 'block';
    console.log(document.getElementById('edit-id-user').value);
}

const updateUser = () =>{
    const newUser = {
        id: user.id,
        name: document.getElementById('edit-name-user').value.trim(),
        password: document.getElementById('edit-password-user').value.trim()
    };
    fetch(`${uriUsers}/${user.id}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        },
        body: JSON.stringify(newUser)
    })
        .then(() =>{
            user=newUser;
            userName.innerHTML=user.name;
        }
        )
        .catch(error => console.error('Unable to update item.', error));

closeInput('editUserForm')
    return false;
}
const createUser = (response)=> {
    user = response;
    userName.innerHTML = user.name;

}

const getUser = ()=> {
    const userId = localStorage.getItem("userId");
    fetch(`${uriUsers}/${userId}`, {
        method: 'GET',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${localStorage.getItem("token")}`
        },
    })
        .then(response => response.json())
        .then(response => createUser(response))
        .catch(error =>
            console.log(error));

}
let user;
getUser();
getItems();
createLink()


