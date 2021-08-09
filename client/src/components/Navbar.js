import React from "react";
import { Link } from "react-router-dom";


const Navbar = (props) => {

  return (
    <header>
      <div className="navbar navbar-dark bg-dark shadow-sm">
        <div className="container">
          <Link to="/" className="navbar-brand d-flex align-items-center">
            <strong>Bookstore</strong>
          </Link>

          <ul className="nav ms-auto">
            <li className="nav-item">
              <Link className="nav-link text-white" to="/authorList">
                Yazarlar
              </Link>
            </li>
            <li className="nav-item">
              <Link className="nav-link text-white" to="/publisherList">
                Yayınevleri
              </Link>
            </li>
          </ul>
        </div>
      </div>
    </header>
  );
};

export default Navbar;
