
function addProjects() {
    html = `
            <button onclick="adminView()"> tilbake </button>

            <input type="text" placeholder="tittel" oninput="model.pagesContent.projectInput.title = this.value"></input>
            <input type="text" placeholder="beskrivelse" oninput="model.pagesContent.projectInput.description = this.value"></input>
            <input type="text" placeholder="link" oninput="model.pagesContent.projectInput.linkToPage = this.value"></input>

            <button onclick="addProjectToPage()">Lagre</button>
            `;
    document.getElementById('adminContent').innerHTML = html;
}