import React, { useContext } from "react";
import { BookContext } from "../contexts/BookContext";
import Author from "./Author";

const CategoryList = () => {
  const { authors } = useContext(BookContext);

  return (
    <div
      className="row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3"
      style={{ marginTop: "20px" }}
    >
      {authors.map(function (author) {
        return (
          <div className="col" key={author.authorId}>
            <Author author={author} />
          </div>
        );
      })}
    </div>
  );
};

export default CategoryList;
