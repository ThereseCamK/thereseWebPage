function blogPage() {

    let blogComitments = model.pagesContent.blogPage;

    const blogs = blogComitments.map(com => `<hr><div>${com.headLine} <br>${com.content} <br> Dato:${com.date} `).join('');
    let html = ` <h1>Blog Innlegg</h1>
            
    ${blogs}
    `;
    console.log(blogs, 'viser denne noe?');
    document.getElementById('mainContent').innerHTML = html;
}