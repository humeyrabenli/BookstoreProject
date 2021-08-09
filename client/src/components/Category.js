import React, { useContext } from "react";

import { ListGroup, ListGroupItem } from "reactstrap";
import { BookContext } from "../contexts/BookContext";

const Category = (props) => {
  const { categoryId, categoryName } = props.category;
  const { currentCategory,changeCategory } = useContext(BookContext);
  
 

  return (
    <div>
      <ListGroup>
        <ListGroupItem active={categoryName===currentCategory?true:false}
          onClick={() => changeCategory(props.category)}
          key={categoryId}
        >
          {categoryName}
        </ListGroupItem>
      </ListGroup>
      
    </div>
  );
};

export default Category;
