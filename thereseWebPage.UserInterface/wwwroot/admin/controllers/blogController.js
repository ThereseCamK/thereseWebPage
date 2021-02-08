async function addBlog() {
    //const blogComitment = model.pagesContent.blogPage.content;
    //var blogDate = new Date();
    let blogComitments = model.pagesContent.blogPage;
    const blogObj = {

        headLine: model.pagesContent.blogInput.headLine,
        blogContent: model.pagesContent.blogInput.content,
        picture: model.pagesContent.blogInput.picture,
        publishedDate: model.pagesContent.blogInput.date,

    };
    const response = await axios.post('/api/blog', blogObj);
    data = response.data;
    console.log(data);
    await getBlogData();
   
}
async function getBlogData() {
    let blogComitments = model.pagesContent.blogPage;
    const response = await axios.get('/api/blog');
    data = response.data;
    console.table(data);
    //blogPage(); //til hovedsiden
    addBlogCommitment(); //tin admin siden

}