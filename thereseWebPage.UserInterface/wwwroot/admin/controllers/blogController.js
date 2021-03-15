let blogComitments = model.pagesContent.blogPage;

async function addBlog() {
    //const blogComitment = model.pagesContent.blogPage.content;
    //var blogDate = new Date();
    //let blogComitments = model.pagesContent.blogPage;
    const blogObj = {

        headLine: model.pagesContent.blogInput.headLine,
        blogContent: model.pagesContent.blogInput.content,
        picture: model.pagesContent.blogInput.picture,
        publishedDate: model.pagesContent.blogInput.date,

    };
    const response = await axios.post('/api/blog', blogObj);
    blogComitments = response.data;
    console.log(blogComitments);
    await getBlogData();

    addBlogCommitment();
   
}
async function getBlogData() {
    
    const response = await axios.get('/api/blog');
    blogComitments = response.data;
    console.table(blogComitments);
    //blogPage(); //til hovedsiden
    addBlogCommitment(); //til admin siden

}