import React from "react";
import { Link } from "react-router-dom";
import user from "../images/user.png";

const EventCard = (props) => {
  const { id, title, domain } = props.event;
  return (
    <div className="item">
      <img className="ui avatar image" src={user} alt="user" />
      <div className="content">
        <Link
          to={{ pathname: `/event/${id}`, state: { event: props.event } }}
        >
          <div className="header">{title}</div>
          <div>{domain}</div>
        </Link>
      </div>
      <i
        className="trash alternate outline icon"
        style={{ color: "red", marginTop: "7px", marginLeft: "10px" }}
        onClick={() => props.clickHander(id)}
      ></i>
      <Link to={{ pathname: `/edit`, state: { event: props.event } }}>
        <i
          className="edit alternate outline icon"
          style={{ color: "blue", marginTop: "7px" }}
        ></i>
      </Link>
    </div>
  );
};

export default EventCard;
