
    $.ajax({
        url: './watch.json',
        success: (data) => {
            debugger
            const { Watch } = data;
            codeSearch(Watch);
        }
    });
    const codeSearch = (watches) => {
        const searchCode = new URLSearchParams(window.location.search);
        const code = searchCode.get("productCode");
        const watch = watches.find(watch => watch.code == code);

        if (watch) {
            document.querySelector("#spanImg").src = `./${watch.img}`;
            document.querySelector("#spanName").innerHTML = watch.name;
            document.querySelector("#spanPrice").innerHTML = `${watch.price} ש"ח`;
            document.querySelector("#spanCode").innerHTML = watch.code;
            document.querySelector("#spanGender").innerHTML = ` ${watch.gender}`;
            document.querySelector("#spanStrip").innerHTML = ` ${watch.description.strip}`;
            document.querySelector("#boardColor").innerHTML = ` ${watch.description.boardColor}`;
            document.querySelector("#waterResistance").innerHTML = ` ${watch.description.waterResistance}`;
            document.querySelector("#yearsOfWarranty").innerHTML = ` ${watch.description.yearsOfWarranty}`;

        } else {
            location.href = "./";
        }
    }


