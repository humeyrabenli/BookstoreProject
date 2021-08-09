import React, {useContext} from "react";
import { Link } from "react-router-dom";
import { Button } from "reactstrap";
import { BookContext } from "../contexts/BookContext";

const Book = (props) => {
  const {
    bookName,
    authorName,
    authorLastName,
    unitPrice,
    imageName,
    bookId,
    publisherName,
    description,
    numberOfPage,
    cover,
  } = props.book;



  return (
    <div className="card shadow-sm">
      <img alt={bookName} src={imageName} />

      <div className="card-body">
        <h5 className="card-title">{bookName}</h5>
        <p className="card-text">
          {authorName} {authorLastName}
        </p>
        <div className="d-flex justify-content-between align-items-center">
          <div className="btn-group">
            <Link
              to={`/books/${bookId}`}
              className="btn btn-sm btn-outline-secondary"
            >
              Detay
            </Link>
          </div>
          <h4 className="text-muted">{unitPrice}₺</h4>
          
        </div>
      </div>
    </div>
  );
};

export default Book;
