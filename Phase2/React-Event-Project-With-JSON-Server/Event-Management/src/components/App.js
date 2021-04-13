import React, { useState, useEffect } from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import { uuid } from "uuidv4";
import api from "../api/events";
import "./App.css";
import Header from "./Header";
import AddEvent from "./AddEvent";
import EventList from "./EventList";
import EventDetail from "./EventDetail";
import EditEvent from "./EditEvent";

function App() {
  const LOCAL_STORAGE_KEY = "events";
  const [events, setEvents] = useState([]);

  const retrieveEvents = async () => {
    const response = await api.get("/events");
    return response.data;
  };

  const addEventHandler = async (event) => {
    console.log(event);
    const request = {
      id: uuid(),
      ...event,
    };

    const response = await api.post("/events", request);
    console.log(response);
    setEvents([...events, response.data]);
  };

  const updateEventHandler = async (event) => {
    const response = await api.put(`/events/${event.id}`, event);
    const { id, title, domain, price, location, startDate, endDate, photoPath, description, organizerName } = response.data;
    setEvents(
      events.map((event) => {
        return event.id === id ? { ...response.data } : event;
      })
    );
  };

  const removeEventHandler = async (id) => {
    await api.delete(`/events/${id}`);
    const newEventList = events.filter((event) => {
      return event.id !== id;
    });
    setEvents(newEventList);
  };

  useEffect(() => {
    // const retriveContacts = JSON.parse(localStorage.getItem(LOCAL_STORAGE_KEY));
    // if (retriveContacts) setContacts(retriveContacts);
    const getAllEvents = async () => {
      const allEvents = await retrieveEvents();
      if (allEvents) setEvents(allEvents);
    };
    getAllEvents();
  }, []);

  useEffect(() => {
    //localStorage.setItem(LOCAL_STORAGE_KEY, JSON.stringify(contacts));
  }, [events]);

  return (
    <div className="ui container">
      <Router>
        <Header />
        <Switch>
          <Route
            path="/"
            exact
            render={(props) => (
              <EventList
                {...props}
                events={events}
                getEventId={removeEventHandler}
              />
            )}
          />
          <Route
            path="/add"
            render={(props) => (
              <AddEvent {...props} addEventHandler={addEventHandler} />
            )}
          />

          <Route
            path="/edit"
            render={(props) => (
              <EditEvent
                {...props}
                updateEventHandler={updateEventHandler}
              />
            )}
          />

          <Route path="/event/:id" component={EventDetail} />
        </Switch>
      </Router>
    </div>
  );
}

export default App;
