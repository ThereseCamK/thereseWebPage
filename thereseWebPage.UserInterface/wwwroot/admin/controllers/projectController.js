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
        links: model.pagesContent.projectInput.linkToPage,

    };
    const response = await axios.post('/api/projects',  projectObject );
    console.log(response);
    await getProjectData();

}

async function getProjectData() {
  
    const response = await axios.get('/api/projects');
    const data = response.data;
    console.table(data);
    //projectView(); //er til den hoved siden
    addProjects(); //er til admin siden
}