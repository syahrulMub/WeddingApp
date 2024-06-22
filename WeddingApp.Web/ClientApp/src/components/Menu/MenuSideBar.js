import React, { useState, useCallback } from "react";
import TreeView from "devextreme-react/tree-view";
import TabPanel from "devextreme-react/tab-panel";

export default function MenuSideBar() {
  const [tabPanelIndex, setTabPanelIndex] = useState(0);
  const handleChangeMenu = useCallback(
    (e) => {
      setTabPanelIndex(e.ItemData.Id - 1);
    },
    [tabPanelIndex]
  );
  return (
    <div className="container">
      <div className="left-content">
        <TreeView
          dataSource={menuData}
          selectionMode="single"
          selectByClick={true}
          onItemSelectionChanged={handleChangeMenu}
        />
      </div>
    </div>
  );
}
const menuData = [
  {
    id: 1,
    text: "Dashboard",
  },
  {
    id: 2,
    text: "Calender",
  },
  {
    id: 3,
    text: "Chat",
  },
];
