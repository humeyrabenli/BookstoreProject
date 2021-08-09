import React, {createContext, useState, useEffect} from 'react'

export const BookContext = createContext()

export const BookProvider = (props) => {

    const [books, setBooks] = useState([])
    const [categories, setCategories] = useState([])
    const [authors, setAuthors] = useState([])
    
    const [publishers, setPublishers] = useState([])
   
    const [currentCategory, setCurrentCategory]=useState("")
    const [loading, setLoading] = useState(false)
  
    useEffect(()=> {
      getBooks();
      getCategories();
      getAuthors();
      getPublishers();
  
      
    }, [])
  
  
    const getBooks = (categoryId) => {
      setLoading(true)
      let url="https://localhost:44389/api/books/";
      if(categoryId) {
        url+="getallbycategoryid/" + categoryId;
      }
      fetch(url)
      .then(response => response.json())
      .then(data => {
        //this.setState({movies: data.results, loading: false})
        setBooks(data.data)
        setLoading(false)
      }
        )
    }

    

    const getCategories= () => {
      setLoading(true)
      fetch('https://localhost:44389/api/category/')
      .then(response => response.json())
      .then(data => {
        //this.setState({movies: data.results, loading: false})
        setCategories(data.data)
        setLoading(false)
      }
        )
    }

    const getAuthors= () => {
      setLoading(true)
      fetch('https://localhost:44389/api/authors/')
      .then(response => response.json())
      .then(data => {
        //this.setState({movies: data.results, loading: false})
        setAuthors(data.data)
        setLoading(false)
      }
        )
    }

  

    const getPublishers= () => {
      setLoading(true)
      fetch('https://localhost:44389/api/publishers/')
      .then(response => response.json())
      .then(data => {
        //this.setState({movies: data.results, loading: false})
        setPublishers(data.data)
        setLoading(false)
      }
        )
    }
  
    const searchBook = (term) => {
      fetch(`https://localhost:44389/api/books/getbybookname/${term}`)
      .then(response => response.json())
      .then(data => setBooks(data.data))
    }

    const changeCategory=(category) => {
          setCurrentCategory(category.categoryName)
          console.log(category)
          getBooks(category.categoryId); 
    };

   

    

    

    return (
        <BookContext.Provider value={{
            books,
            searchBook,
            categories,
            getCategories,
            loading,
            getBooks,
            changeCategory,
            currentCategory,
            getAuthors,
            authors,
            getPublishers,
            publishers,
            
           
           
        }}>
            {props.children}
        </BookContext.Provider>
    )
}