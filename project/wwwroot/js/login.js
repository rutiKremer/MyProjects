const uri = "/login";

const dom = {
    Name: document.getElementById("name"),
    Password: document.getElementById("password"),
    submitBtn: document.getElementById("submit"),
}

dom.submitBtn.onclick = (event) => {

    event.preventDefault();
    const item = {
        Name: dom.Name.value,
        Password: dom.Password.value
    }

    fetch(uri, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(item)
        })
        .then((response) =>
            response.json()
        )
        .then((res) => {
            if (res.status == 401)
                alert("The userName or Password you entered is incorrect");
            else {
                if (dom.Name.value === "David" && dom.Password.value === "3443")
                    localStorage.setItem("link", true);
                else
                    localStorage.setItem("link", false);
                localStorage.setItem("token", res.token);
                localStorage.setItem("userId", res.id);
                location.href = "../index.html";
            }
        })
        .catch((error) => console.error('Unable to add item.', error));

}