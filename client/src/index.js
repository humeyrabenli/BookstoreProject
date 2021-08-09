import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import 'bootstrap/dist/css/bootstrap.min.css'
import { BookProvider } from './contexts/BookContext'

ReactDOM.render(
  <React.StrictMode>
    <BookProvider>
      <App />
     
      
    </BookProvider>
  </React.StrictMode>,
  document.getElementById('root')
);