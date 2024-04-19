
import React from "react";
import Error401 from "./components/Error401";
import Error403 from "./components/Error403";
import Error404 from "./components/Error404";
import Error500 from "./components/Error500";
import Error501 from "./components/Error501";


function ErrorLayout({ statusCode }) {
  let ErrorComponent;

  switch (statusCode) {
    case 401:
      ErrorComponent = Error401;
      break;
    case 403:
      ErrorComponent = Error403;
      break;
    case 404:
      ErrorComponent = Error404;
      break;
    case 500:
      ErrorComponent = Error500;
      break;
    case 501:
      ErrorComponent = Error501;
      break;
    default:
      ErrorComponent = Error404;
      break;
  }

  return <ErrorComponent />;
}

export default ErrorLayout;
