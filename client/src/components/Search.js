import React, { useState, useContext } from "react";
import { BookContext } from "../contexts/BookContext";

const Search = () => {
  const { searchBook } = useContext(BookContext);

  const [term, setTerm] = useState("");

  const handleOnSubmit = (event) => {
    event.preventDefault();
    searchBook(term);
  };

  const handleOnChange = (event) => {
    //this.setState({term: event.target.value})
    setTerm(event.target.value);
  };

  return (
    <form onSubmit={handleOnSubmit} className="row g-3 mb-5" style={{paddingLeft:"12px"}}>
      <div className="col-8">
        <input
          onChange={handleOnChange}
          type="text"
          className="form-control"
          placeholder="kitap ara.."
          value={term}
        />
      </div>
      <div className="col-4">
        <input
          type="submit"
          value="Ara"
          className="form-control btn-block btn btn-danger text-white"
          disabled={!(term.length > 1)}
        />
      </div>
    </form>
  );
};

export default Search;
