// DataGridComponent.js
import "devextreme/dist/css/dx.light.css";
import React, { useState } from "react";
import { Button } from "devextreme-react/button";
import DataGrid, {
  Column,
  Editing,
  Popup,
  Paging,
  Lookup,
  Form,
} from "devextreme-react/data-grid";
import "devextreme-react/text-area";
import { Item } from "devextreme-react/form";
import DataSource from "devextreme/data/data_source";
import { sendingRequest } from "./Api";

const DataGridComponent = () => {
  const URL = "itemtype"; // Ganti dengan endpoint API Anda

    let updateRow = function(e){
        e.newData = { ...e.oldData, ...e.newData }
    } 
    const myStore = new DataSource({
        key: "id",
        load: () => sendingRequest(`${URL}`, "GET"),
        insert: (values) => sendingRequest(`${URL}/Save`, "POST", values),
        update: (key, values) => sendingRequest(`${URL}/Save`, "POST", values),
        remove: (key) => sendingRequest(`${URL}/Delete/${key}`, "DELETE",  key ),
        onRowUpdating: function (options) {
            options.newData = { ...options.oldData, ...options.newData }
        }
  });

    return (
        <DataGrid dataSource={myStore} key="id" showBorders={true} onRowUpdating={updateRow}>
      <Paging enabled={true} />
      <Editing
        mode="popup"
        allowUpdating={true}
        allowAdding={true}
        allowDeleting={true}
        useIcons={true}
      >
        <Popup
          title="Item Type"
          showTitle={true}
          width={720}
          height={480}
          showCloseButton={true}
          closeOnOutsideClick={true}
        />
        <Form itemType="Group" colCount={1} colSpan={1}>
          <Item dataField="name" />
          <Item dataField="description" isRequired={true} />
        </Form>
      </Editing>
      <Column dataField="id" visible={false} />
      <Column dataField="name" />
      <Column dataField="description" caption="Description" />
    </DataGrid>
  );
};

export default DataGridComponent;
