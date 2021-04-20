import React from "react";
import { Link } from "react-router-dom";
import EventCard from "./EventCard";

const EventList = (props) => {
  console.log(props);

  const deleteEventHandler = (id) => {
    props.getEventId(id);
  };

  const renderEventList = props.events.map((event) => {
    return (
      <EventCard
        event={event}
        clickHander={deleteEventHandler}
        key={event.id}
      />
    );
  });
  return (
    <div className="main">
      <h2>
        Event List
        <Link to="/add">
          <button className="ui button blue right">Add Event</button>
        </Link>
      </h2>
      <div className="ui celled list">{renderEventList}</div>
    </div>
  );
};

export default EventList;
