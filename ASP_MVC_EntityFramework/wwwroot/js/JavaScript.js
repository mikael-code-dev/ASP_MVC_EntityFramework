var toggleAddLanguageBtn = document.querySelector("#toggle-add-language-button");


function toggleLanguagePanel(id) {
    var toggleElement = document.getElementById(`${id}`);
    var elementInside = toggleElement.parentElement.querySelector("div");

    var theButton = toggleElement.parentElement.querySelector("input");
    theButton.value = theButton.value === "-" ? "+" : "-";

    elementInside.classList.toggle("show-language-panel");
}

const addLanguageButton = (id) => {

    var thePanel = document.getElementById(`${id}`);
    var input = thePanel.querySelector("input");

    $.ajax({
        type: "POST",
        url: `People/AddLanguage?id=${id}&lang=${input.value}`,
        success: function (response) {

        }
    })
}

function deletePerson(id) {

    $.ajax({
        type: "DELETE",
        url: "People/Delete?id=" + id,
        success: function (response) {
            var ele = document.querySelectorAll('tr');

            ele.forEach(elem => {
                if (elem.getAttribute('data-modelid') == id) {
                    elem.remove();
                }
            })
        }
    })
}

var errorMess = document.querySelectorAll(".error-message");

errorMess.forEach((element) => {
    if (element.innerHTML === "") {
        element.classList.add("no-show");
    }
});