// DataGridComponent.js
import React, { useState } from "react";
import DataGrid, {
  Column,
  FormItem,
  Editing,
  Paging,
  Lookup,
} from "devextreme-react/data-grid";
import CustomStore from "devextreme/data/custom_store";
import DataSource from "devextreme/data/data_source";
import "devextreme/dist/css/dx.light.css";
import { sendingRequest } from "./Api";

const DataGridComponent = () => {
  const URL = "itemtype"; // Ganti dengan endpoint API Anda

  const myStore = new DataSource({
    keyExpr: "Id",
    load: () => sendingRequest(`${URL}`, "GET"),
    insert: (values) => sendingRequest(`${URL}/Add`, "POST", { values }),
    update: (key, values) =>
      sendingRequest(`${URL}/Update`, "PUT", { key, values }),
    remove: (key) => sendingRequest(`${URL}/Delete/${key}`, "DELETE", key),
  });

  return (
    <DataGrid
      dataSource={myStore}
      key="Id"
      showBorders={true}
      allowAdding={true}
    >
      <Editing
        mode="form"
        allowUpdating={true}
        allowAdding={true}
        allowDeleting={true}
      ></Editing>
    </DataGrid>
  );
};

export default DataGridComponent;
