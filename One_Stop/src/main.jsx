import React from "react";
import ReactDOM from "react-dom/client";
import App from "./App.jsx";
//import "./output.css";
import SignIn from "./components/user/signIn.jsx";
import Navbar from "./components/nav/navbar.jsx";
import faLogo from "./assets/img/falogo.png";
import "../public/css/main.css";
import AddShoppingCart from "@material-ui/icons/AddShoppingCart";
import ProductDash from "./components/products/productDash.jsx";
import AddProduct from "./components/products/addProduct.jsx";

ReactDOM.createRoot(document.getElementById("root")).render(
  <React.StrictMode>
    <div className="Main">
      <div className="Nav">
        <div>
          <nav className="nav-1">
            <a href="">
              <img src={faLogo} alt="" />
            </a>
            <div>
              <input type="text" />
            </div>
            <a href="">
              <div>
                <h5>Offers</h5>
                <p>Latest Offers</p>
              </div>
            </a>
            <a href="">
              <div>
                <h5>Flash Sale</h5>
                <p>Special Deals</p>
              </div>
            </a>
            <a href="">
              <div>
                <h5>Account</h5>
                <p>Login or Register</p>
              </div>
            </a>
          </nav>
        </div>
        <div className="nav-2"></div>
      </div>
      <div className="content-body">
        <AddProduct />
      </div>
    </div>
  </React.StrictMode>
);
