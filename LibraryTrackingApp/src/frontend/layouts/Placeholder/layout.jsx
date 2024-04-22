import React from "react";
import Error401 from "../Error/components/Error401";
import Error403 from "../Error/components/Error403";
import Error404 from "../Error/components/Error404";
import Error500 from "../Error/components/Error500";
import Error501 from "../Error/components/Error501";
import { Children } from "react";

function PlaceholderLayout({ children }) {
  return <>{children}</>;
}

export default PlaceholderLayout;
