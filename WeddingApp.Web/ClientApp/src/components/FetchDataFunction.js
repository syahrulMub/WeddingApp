import React, { useEffect, useState } from "react";
import 'devextreme/dist/css/dx.darkviolet.css';
import DataGrid, {
    Column,
    DataGridTypes,
    Grouping,
    Pager,
    Paging,
    SearchPanel,
    Search
} from "devextreme-react/cjs/data-grid";

export default function FetchDataGrid() {
    const [forecasts, setForecasts] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() =>{
        populateWeatherData();
    },[])

    async function populateWeatherData(){
        const response = await fetch('weatherforecast',{
            method: 'GET'
        });
        const data = await response.json();
        setForecasts(data);
        setLoading(false);
    }
    return (
        <div>
            <h1 id="tableLabel">Weather APP</h1>
            <p>This component demonstrates fetching data from the server.</p>
            {loading ? 
            <p><em>loading ...</em></p>
            :
            (
                <DataGrid
                    dataSource={forecasts}
                >
                </DataGrid>
            )}
        </div>
    );
}