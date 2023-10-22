function create_element(tag, parent_div){
    const element = document.createElement(tag)
    parent_div.appendChild(element)
    return element
}


function create_link(label, link_text, url, parent_div) {
    const url_label = create_element("p", parent_div)
    url_label.innerText = label

    const link = create_element("a", url_label)
    link.href = url
    link.innerText = link_text
}


function create_heading(project, parent_div) {
    const div = create_element("div", parent_div)
    div.className = "background_div"

    const image = create_element("img", div)
    image.src = `./images/${project.name}.png`
    image.id = "main_project_image"
    const title = create_element("h3", div)
    title.innerText = project.name

    const child_div = create_element("div", div)
    child_div.id = "child_div"
    
    create_link("GitHub Repo: ", "project url", project.code_url, child_div)
    create_link("Download: ", "download url", project.download_url, child_div)
}

const xhttp = new XMLHttpRequest()

xhttp.onload = function() {
    const projects = document.getElementById("projects")

    create_heading(JSON.parse(this.responseText)[0], projects)

    const small_projects = create_element("div", projects)
    small_projects.id = "small_projects"

    for (let index = 1; index < 5; index++){
        create_heading(JSON.parse(this.responseText)[index], small_projects)
    }
}

xhttp.open("GET", "./projects.json")
xhttp.send()