async function addProjectToPage() {
    //const projectTitle = model.pagesContent.projectPage.title;
    //const projectDescription = model.pagesContent.projectPage.description;
    //const projectLink = model.pagesContent.projectPage.linkToPage;

    //model.pagesContent.projectPage.push({
    //    title: `${projectTitle}`,
    //    description: `${projectDescription}`,
    //    linkToPage: `${projectLink}`
    //})
    const projectObject = {
        title: model.pagesContent.projectInput.title,
        description: model.pagesContent.projectInput.description,
        linkToPage: model.pagesContent.projectInput.linkToPage,

    };
    const response = await axios.post('/api/projects',  projectObject );
    console.log(response);
    await getProjectData();

}

async function getProjectData() {
    const projectObject = {
        title: model.pagesContent.projectPage.title,
        description: model.pagesContent.projectPage.description,
        linkToPage: model.pagesContent.projectPage.linkToPage,

    };
    const response = await axios.get('/api/projects', { projectObject });
    const data = response.data;
    console.table(data);
    projectView();
}