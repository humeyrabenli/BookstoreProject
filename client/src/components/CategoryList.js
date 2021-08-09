import React, { useContext } from "react";
import { BookContext } from "../contexts/BookContext";
import Category from "./Category";

const CategoryList = () => {
    
  const { categories } = useContext(BookContext);

  return (
    <div>

    {
        categories.map(function (category) {
            return (
            <div className="col" key={category.categoryId}>
                <Category category={category}/>
            </div>
            )
        })
    }


</div>
  );
};

export default CategoryList;
