import React, { Component } from "react";
import FetchDataGrid from "./FetchDataFunction";
import ODataStore from "devextreme/data/odata/store";
import DataGridComponent from "./ItemType";

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };
  }

  componentDidMount() {
    this.populateWeatherData();
  }

  static renderForecastsTable(forecasts) {
    return (
      <table className="table table-striped" aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map((forecast) => (
            <tr key={forecast.date}>
              <td>{forecast.date}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          ))}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading ? (
      <p>
        <em>Loading...</em>
      </p>
    ) : (
      FetchData.renderForecastsTable(this.state.forecasts)
    );

    return (
      <div>
        <h1 id="tableLabel">Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
        <div>
          <FetchDataGrid></FetchDataGrid>
        </div>
        <div>
          <DataGridComponent></DataGridComponent>
        </div>
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch("weatherforecast");
    const data = await response.json();
    console.log(data);
    this.setState({ forecasts: data, loading: false });
  }
}
