
function addBlogCommitment(blog) {
    let blogComitments = model.pagesContent.blogPage;
    var listOfPosts = listOfBlogs(blog);
    //const blogs = blogComitments.map(com => `<hr><div onclick="editBlog()">${com.HeadLine} <br>${com.BlogContent} <br> Picture:${com.Picture} `).join('');
    html = `
            <button onclick="adminView()"> tilbake </button><br>
            <input type="text" placeholder="Overskrift" oninput="model.pagesContent.blogInput.headLine = this.value"></input><br>
            <textarea type="text" placeholder="legg inn ett bloggInlegg" oninput="model.pagesContent.blogInput.content = this.value"></textarea><br>
            <input type="media" placeholder="bilde" oninput="model.pagesContent.blogInput.picture = this.value"></input><br>
            <input type="date" placeholder="dato" oninput="model.pagesContent.blogInput.date = this.value"></input><br>
            <button onclick="addNewBlog()">Lagre blogg</button>
            
            ${listOfPosts}

    `;
  console.log(blog)
    document.getElementById('adminContent').innerHTML = html;
    
}

function listOfBlogs(blog) {
    html = "";
    for (let b of blog) {
        html += b.HeadLine
    }
    return html;
}