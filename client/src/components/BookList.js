import React, {useContext} from 'react'
import Book from './Book'
import { BookContext } from '../contexts/BookContext'


const BookList = () =>{

    const  { books } = useContext(BookContext)
    

        return (
            <div className="row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3">

                {
                    books.map(function (book) {
                        return (
                        <div className="col" key={book.bookId}>
                            <Book book={book}/>
                        </div>
                        )
                    })
                }


            </div>
        )
    }

export default BookList