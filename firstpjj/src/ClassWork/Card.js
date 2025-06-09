import './Card.css'

export function Book()
{
    const book={
        name: "ClR Via",
        author: "Jefry Ritcher",
        pages:900,
        image: '/1.jpg'
    }
    return(
        <div id='divBook'>
            
            <p>Book</p>
            <img src={book.image} alt=''></img>
            <p>{book.name}</p>
            <p>{book.author}</p>
            <p>{book.pages}</p>
        </div>
    );
}