import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { ItemTypeMaster } from "./components/ItemTypeMaster";
import { Training } from "./components/Training";

const AppRoutes = [
  {
    index: true,
    element: <Home />,
  },
  {
    path: "/counter",
    element: <Counter />,
  },
  {
    path: "/fetch-data",
    element: <FetchData />,
  },
  {
    path: "/item-type",
    element: <ItemTypeMaster />,
  },
  {
    path: "/training",
    element: <Training />,
  },
  // {
  //   path: "/form",
  //   element: <Form />,
  // },
];

export default AppRoutes;
