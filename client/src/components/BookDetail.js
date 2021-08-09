import React, { useState, useEffect } from "react";
import { useParams, Link } from "react-router-dom";

const BookDetail = () => {
  const [book, setBook] = useState({});

  const { bookId } = useParams();

  useEffect(() => {
    const getBook = () => {
      fetch(`https://localhost:44389/api/books/getbyid/${bookId}`)
        .then((response) => response.json())
        .then((data) => setBook(data.data));
    };
    console.log(getBook());
  }, [bookId]);

  return (
    
    <div className="jumbotron jumbotron-fluid" style={{marginTop:"18px"}}>
      <div className="container">
             <div className="row">
                <div className="col-4">
                  <div className="card" style={{width:"16rem"}}>
                    <img className="card-img-top" src={book.imageName} alt="Card Image cap"/>
                    <div className="card-body">
                       
                    </div>
                   </div> <br></br>
                   <Link className="btn btn-outline-secondary" to="/">Ana Sayfa</Link>
             </div>
             <div className="col-8">
                 <h4 style={{color:"burlywood"}}>{book.bookName}</h4>
                 <h5>{book.authorName} {book.authorLastName}</h5> <br/>
                 <h5>Yayınevi: {book.publisherName}</h5> <br></br>
                 <h5>Kitap Açıklaması</h5>
                 <p>{book.description}</p>
                 <div className="row">
                   <div className="col-8">
                 <h5>Sayfa sayısı: {book.numberOfPage}</h5>
                 <h5>Kapak: {book.cover}</h5>
                 </div>
                  <div className="col-4">
                    <h3 style={{color:"darkcyan"}}>Fiyat: {book.unitPrice}₺</h3>
                  </div>
                 </div>
             </div>
             </div>
         
          </div>
  
      </div>
    
  );
};

export default BookDetail;
