async function addBlog() {
    //const blogComitment = model.pagesContent.blogPage.content;
    //var blogDate = new Date();

    const blogObj = {

        headLine: model.pagesContent.blogInput.headLine,
        blogContent: model.pagesContent.blogInput.content,
        picture: model.pagesContent.blogInput.picture,
        publishedDate: model.pagesContent.blogInput.date,

    };
    const response = await axios.post('/api/blog', blogObj );
    console.log(response);
    await getBlogData();
   
}
async function getBlogData() {

    const response = await axios.get('/api/blog');
    const data = response.data;
    console.table(data);
   // addBlogCommitment();

}