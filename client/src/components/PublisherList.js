import React, { useContext } from "react";
import { BookContext } from "../contexts/BookContext";
import Publisher from "./Publisher";

const PublisherList = () => {
    
  const { publishers } = useContext(BookContext);

  return (
    <div className="row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3" style={{marginTop:"20px"}}>

    {
        publishers.map(function (publisher) {
            return (
            <div className="col" key={publisher.publisherId}>
                <Publisher publisher={publisher}/>
            </div>
            )
        })
    }


</div>
  );
};

export default PublisherList;
