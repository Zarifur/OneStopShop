import React from "react";
import ReactDOM from "react-dom/client";
import faLogo from "./assets/img/falogo.png";

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
        <div className="filters"></div>
        <div className="prod_cont">
          <div className="top_bar">
            <p>Iphones</p>
          </div>
          {[...Array(10).keys()].map(() => (
            <div className="wrapper">
              <div>
                <img
                  src="https://adminapi.applegadgetsbd.com/storage/media/large/iPhone-15-Plus-(2)-(1)-6945.jpg"
                  alt=""
                />
              </div>
              <div className="card-contant">
                <div className="card-contant-details">
                  <h1>
                    <b>Iphone 15</b>
                  </h1>
                  <p>£250</p>
                </div>
              </div>
            </div>
          ))}
        </div>
      </div>
    </div>
  </React.StrictMode>
);
