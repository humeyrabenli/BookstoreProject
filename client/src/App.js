import React, { useContext } from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import Navbar from "./components/Navbar";
import Search from "./components/Search";
import BookList from "./components/BookList";
import Footer from "./components/Footer";
import AuthorList from "./components/AuthorList";
import BookDetail from "./components/BookDetail";
import { BookContext } from "./contexts/BookContext";
import CategoryList from "./components/CategoryList";
import PublisherList from "./components/PublisherList";

const App = () => {
  const { loading } = useContext(BookContext);

  return (
    <Router>
      <>
        <Navbar />

        <Switch>
          <Route exact path="/">
            <main>
              
                <div className="container">
                  <div className="row">
                    <Search />
                  </div>
                  <div className="row">
                    <div className="col-3">
                      <CategoryList />
                    </div>
                    <div className="col-9">
                      {loading ? (
                        <div className="spinner-border" role="status">
                          <span className="visually-hidden">Loading...</span>
                        </div>
                      ) : (
                        <BookList />
                      )}
                    </div>
                  </div>
                </div>
              
            </main>
          </Route>

          <Route path="/authorList" component={AuthorList} />
          <Route path="/publisherList" component={PublisherList} />
          <Route path="/books/:bookId" component={BookDetail} />
        </Switch>

        <Footer />
      </>
    </Router>
  );
};

export default App;
