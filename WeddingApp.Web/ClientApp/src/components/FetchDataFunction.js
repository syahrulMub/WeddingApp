import React, { useEffect, useState, useCallback } from "react";
import "devextreme/dist/css/dx.light.css";
import DataGrid, {
  Column,
  DataGridTypes,
  Grouping,
  Pager,
  Paging,
  SearchPanel,
  Search,
} from "devextreme-react/cjs/data-grid";

export default function FetchDataGrid() {
  const [forecasts, setForecasts] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    populateWeatherData();
  }, []);

  const [collapsed, setCollapsed] = useState(true);

  const onContentReady = useCallback(
    (e) => {
      if (collapsed) {
        e.component.expandRow(["EnviroCare"]);
        setCollapsed(false);
      }
    },
    [collapsed]
  );

  async function populateWeatherData() {
    const response = await fetch("weatherforecast", {
      method: "GET",
    });
    const data = await response.json();
    setForecasts(data);
    setLoading(false);
  }
  return (
    <div>
      <h1 id="tableLabel">Weather APP</h1>
      <p>This component demonstrates fetching data from the server.</p>
      {/* {loading ? 
            <p><em>loading ...</em></p>
            : */}

      <DataGrid
        dataSource={forecasts}
        allowColumnReordering={true}
        rowAlternationEnabled={true}
        showBorders={true}
        width="100%"
        onContentReady={onContentReady}
      ></DataGrid>
    </div>
  );
}
