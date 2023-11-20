function create_element(tag, parent_div){
    const element = document.createElement(tag)
    parent_div.appendChild(element)
    return element
}


function create_link(label, link_text, url, parent_div, class_name, image) {
    //const url_label = create_element("p", parent_div)
    //url_label.innerText = label

    const link = create_element("a", parent_div)
    link.href = url
    link.innerText = link_text
    link.className = class_name;
    const github_image = document.createElement("img")
    github_image.src = image
    link.prepend(github_image)
    return link;
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
    
    const github_link = create_link("GitHub Repo: ", "GitHub", project.code_url, child_div, "github", `./images/github.png`)
    create_link("Download: ", "Download", project.download_url, child_div, "download", `./images/icons8-download-24.png`)
    if (project.type == "website") {
        create_link("Download: ", "Open", project.web_page_url, child_div, "open", `./images/icons8-open-64.png`)
    }
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