function blogPage() {
    const blogConmitments = model.pagesContent.blogPage;
    const blogs = blogConmitments.map(com => `<div>${com.content} <br> Dato:${com.date} `).join('');
    html = ` blog Innlegg
    ${blogs}
    `;

    document.getElementById('mainContent').innerHTML = html;
}