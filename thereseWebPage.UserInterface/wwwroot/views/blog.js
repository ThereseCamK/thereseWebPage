function blogPage() {

    let blogComitments = model.pagesContent.blogPage;

    const blogs = blogComitments.map(com => `<hr><div>${com.HeadLine} <br>${com.BlogContent} <br> Dato:${com.PublishedDate} `).join('');
    let html = ` <h1>Blog Innlegg</h1>
            
    ${blogs}
    `;
    console.log(blogComitments, 'viser denne noe?');


    document.getElementById('mainContent').innerHTML = html;


}