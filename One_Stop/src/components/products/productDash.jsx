import React from "react";

export default function ProductDash() {
  return (
    <>
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
    </>
  );
}
