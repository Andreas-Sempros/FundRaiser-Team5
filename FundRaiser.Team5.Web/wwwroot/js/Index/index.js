﻿
const uri = 'index';

document.querySelector('#login_bg').addEventListener("click", function () {
    document.querySelector('#login_session').classList.add("d-none");

    document.querySelector('#Email').nodeValue = "";
    document.querySelector('#Password').nodeValue = "";

    console.log("Hide");


});

let login = document.querySelector('#nav-login');
if (login != null) {
    login.addEventListener("click", function () {
        document.querySelector('#login_session').classList.remove("d-none");

        document.querySelector('#Email').nodeValue = "";
        document.querySelector('#Password').nodeValue = "";
        console.log("show");
    });
}

getProjects();


function getProjects() {
    fetch(`Home/Get`)
        .then(response => response.json())
        .then(data => _displayProjects(data))
        .catch(error => console.error('Unable to get Projects.', error));
}

function _displayProjects(data) {
    console.log(data);
    const rowProject = document.querySelector('#project_list_template').firstChild;
    let projectList = document.querySelector('#project_list');
    projectList.innerHTML = "";
    data.projects.forEach(item => {
        let newProjectRow = rowProject.cloneNode(false);

        newProjectRow.querySelector(".ProjectTitle").innerText = item.ProjectTitle;
        newProjectRow.querySelector(".ProjectDescription").innerText = item.ProjectDescription;
        newProjectRow.querySelector(".ProjectCategory").innerText = item.ProjectCategory;
        newProjectRow.querySelector(".ProjectProgress").innerText = item.ProjectProgress;
        newProjectRow.querySelector(".ProjectDeadline").innerText = item.ProjectDeadline;
        newProjectRow.querySelector(".ProjectCreatorFullName").innerText = item.ProjectCreatorFullName;

        let btnProject = newProjectRow.querySelector(".projectById")

        btnProject.setAttribute('onclick', `Project/(${item.ProjectId})`);
        btnProject.setAttribute('href', 'javascript:void(0)');

        projectList.appendChild(newProjectRow);

    });
}

document.querySelector('#loginbtn').addEventListener("click", function () {

    let form = document.querySelector('#loginform');
    $.ajax(
        {
            url: "/login",
            dataType: 'POST',
            data: form.serialize(),
            success: function (data) {
                alert("FormOK"); // show response from the php script.
            }
        }

    );
});

