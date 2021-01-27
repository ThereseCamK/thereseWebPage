async function addBlog() {
    //const blogComitment = model.pagesContent.blogPage.content;
    //var blogDate = new Date();

    //model.pagesContent.blogPage.push({
    //    content: `${blogComitment}`,
    //    date: `${blogDate}`,
    //})

    //blogPage();
    const blogObj = {

        headLine: model.pagesContent.blogInput.headLine,
        blogContent: model.pagesContent.blogInput.content,
        picture: model.pagesContent.blogInput.picture,
        publisedDate: model.pagesContent.blogInput.date,

    };
    const response = await axios.post('/api/blog',  blogObj );
    console.log(response);
    await getBlogData();
    blogPage();
}

    async function getBlogData() {
  /*  const blogObj = {

        headLine: model.pagesContent.blogPage.headLine,
        content: model.pagesContent.blogPage.content,
        picture: model.pagesContent.blogPage.picture,
        date: model.pagesContent.blogPage.date,

    };*/
    const response = await axios.get('/api/blog');
    const data = response.data;
    console.table(data);

}