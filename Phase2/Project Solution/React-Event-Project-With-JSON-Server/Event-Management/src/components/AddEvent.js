import React from "react";

class AddEvent extends React.Component {
  state = {
    id: "",
    title: "",
    domain: "",
    price: "",
    location: "",
    startDate: "",
    endDate: "",
    photoPath: "",
    description: "",
    organizerName: "",
  };

  add = (e) => {
    e.preventDefault();
    if (this.state.title === "" || this.state.domain === "" ||
      this.state.price === "" || this.state.location === "" ||
      this.state.startDate === "" || this.state.endDate === "" ||
      this.state.photoPath === "" || this.state.description === "" ||
      this.state.organizerName === "") {
      alert("All the fields are mandatory!");
      return;
    }
    this.props.addEventHandler(this.state);
    this.setState({
      title: "", domain: "", price: "", location: "",
      startDate: "", endDate: "", photoPath: "", description: "",
      organizerName: ""
    });
    this.props.history.push("/");
  };
  render() {
    return (
      <div className="ui main">
        <h2>Add Event</h2>
        <form className="ui form" onSubmit={this.add}>
          <div className="field">
            <label>Title</label>
            <input
              type="text"
              name="title"
              placeholder="title"
              value={this.state.title}
              onChange={(e) => this.setState({ title: e.target.value })}
            />
          </div>
          <div className="field">
            <label>Domain</label>
            <input
              type="text"
              name="domain"
              placeholder="Domain"
              value={this.state.domain}
              onChange={(e) => this.setState({ domain: e.target.value })}
            />
          </div>
          <div className="field">
            <label>Price</label>
            <input
              type="text"
              name="price"
              placeholder="Price"
              value={this.state.price}
              onChange={(e) => this.setState({ price: e.target.value })}
            />
          </div>
          <div className="field">
            <label>Location</label>
            <input
              type="text"
              name="location"
              placeholder="Location"
              value={this.state.location}
              onChange={(e) => this.setState({ location: e.target.value })}
            />
          </div>
          <div className="field">
            <label>Start Date</label>
            <input
              type="text"
              name="startDate"
              placeholder="Start Date"
              value={this.state.startDate}
              onChange={(e) => this.setState({ startDate: e.target.value })}
            />
          </div>
          <div className="field">
            <label>End Date</label>
            <input
              type="text"
              name="endDate"
              placeholder="End Date"
              value={this.state.endDate}
              onChange={(e) => this.setState({ endDate: e.target.value })}
            />
          </div>
          <div className="field">
            <label>Photo Path</label>
            <input
              type="text"
              name="photoPath"
              placeholder="Photo Path"
              value={this.state.photoPath}
              onChange={(e) => this.setState({ photoPath: e.target.value })}
            />
          </div>
          <div className="field">
            <label>Description</label>
            <input
              type="text"
              name="description"
              placeholder="Description"
              value={this.state.description}
              onChange={(e) => this.setState({ description: e.target.value })}
            />
          </div>
          <div className="field">
            <label>Organizer Name</label>
            <input
              type="text"
              name="organizerName"
              placeholder="Organizer Name"
              value={this.state.organizerName}
              onChange={(e) => this.setState({ organizerName: e.target.value })}
            />
          </div>
          <button className="ui button blue">Add</button>
        </form>
      </div>
    );
  }
}

export default AddEvent;
